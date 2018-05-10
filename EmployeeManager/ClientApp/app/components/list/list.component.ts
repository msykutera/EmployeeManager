import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'list',
    templateUrl: './list.component.html'
})
export class ListComponent {
    public employees: Employee[];

    private _http: Http;
    private _baseUrl: string;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._http = http;
        this._baseUrl = baseUrl;

        this._http.get(this._baseUrl + 'api/employees').subscribe(result => {
            this.employees = result.json() as Employee[];
        }, error => console.error(error));
    }

    remove(employeeId: string) {
        this._http.delete(this._baseUrl + 'api/employees/' + employeeId).subscribe(result => {
            this._http.get(this._baseUrl + 'api/employees').subscribe(result => {
                this.employees = result.json() as Employee[];
            }, error => console.error(error));
        }, error => console.error(error));
    }
}

interface Employee {
    name: string;
    gender: string;
    role: string;
    skills: string[];
}
