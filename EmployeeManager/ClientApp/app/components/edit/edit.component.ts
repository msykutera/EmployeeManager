import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'edit',
    templateUrl: './edit.component.html'
})
export class EditComponent {

    public body: any = {};
    public oldSkills: string[];

    private _http: Http;
    private _baseUrl: string;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, route: ActivatedRoute) {
        this._http = http;
        this._baseUrl = baseUrl;

        const id = route.snapshot.paramMap.get('employeeId');

        this._http.get(this._baseUrl + 'api/employees/' + id).subscribe(result => {
            this.body = result.json() as Employee;
            this.oldSkills = this.body.skills;
        }, error => console.error(error));
    }

    public edit() {
        this._http.put(this._baseUrl + 'api/employees', this.body).subscribe(result => {
        }, error => console.error(error));
    }
}

interface Employee {
    name: string;
    gender: string;
    role: string;
    skills: string[];
}