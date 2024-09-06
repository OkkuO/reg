import { Routes } from '@angular/router';
import { RegistrationFormComponent } from './registration-form/registration-form.component';
import { MainPageComponent } from './main-page/main-page.component';

export const routes: Routes = [
    {
        path: 'registration',
        component: RegistrationFormComponent
    },
    {
        path: '',
        component: MainPageComponent
    },
    {
        path: '**',
        redirectTo: '',
        pathMatch: 'full'
    }
];
