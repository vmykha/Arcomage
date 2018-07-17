import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Castle } from '../models/castle';
import { tap } from 'rxjs/operators/tap';
import { catchError } from 'rxjs/operators/catchError';

@Injectable()

export class CastleService{
    private castleUrl = 'https://localhost:44347/api/game/';
    constructor(private http: HttpClient){

    }

    getCastles(): Observable<Castle[]>{
        return this.http.get<Castle[]>(this.castleUrl + 'castles').pipe(
          tap(data => console.log('All: ' + JSON.stringify(data))),
            catchError(this.handleError)
          );             
      }

    private handleError(err: HttpErrorResponse) {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        let errorMessage = ``;
        if (err.error instanceof Error) {
          // A client-side or network error occurred. Handle it accordingly.
          errorMessage = `An error occurred: ${err.error.message}`;
        } else {
          // The backend returned an unsuccessful response code.
          // The response body may contain clues as to what went wrong,
          errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
        }
        console.error(errorMessage);
        return Observable.throw(errorMessage);
      }
}