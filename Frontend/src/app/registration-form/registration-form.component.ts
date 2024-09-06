import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { take } from 'rxjs';


@Component({
  standalone: true,
  selector: 'app-registration-form',
  templateUrl: './registration-form.component.html',
  styleUrl: './registration-form.component.scss',
  imports: [FormsModule, ReactiveFormsModule, MatFormFieldModule, MatInputModule, MatButtonModule]
})
export class RegistrationFormComponent {
  registrationForm = new FormGroup({
    userName: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required]),
  })

  constructor(private http: HttpClient ){}

  sendForm() {
    console.warn(this.registrationForm.value);
    let formData = {
      userName: this.registrationForm.value.userName,
      email: this.registrationForm.value.email,
      password: this.registrationForm.value.password,
    }

    this.http.post('http://localhost:5228/api/account/register', formData)
      .pipe(take(1))
      .subscribe();
  }
    
}
