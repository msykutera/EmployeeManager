import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'add',
    templateUrl: './add.component.html'
})
export class AddComponent {

    public body: any = {};

    private _http: Http;
    private _baseUrl: string;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._http = http;
        this._baseUrl = baseUrl;
    }

    public add() {
        this._http.post(this._baseUrl + 'api/employees', this.body).subscribe(result => {
            this.body = {};
        }, error => console.error(error));
    }
}