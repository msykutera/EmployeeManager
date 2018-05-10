import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { addComponent } from './components/add/add.component';
import { EditComponent } from './components/edit/edit.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        addComponent,
        FetchDataComponent,
        HomeComponent,
        EditComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'add', component: addComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'edit/:employeeId', component: EditComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
