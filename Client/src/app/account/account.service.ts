import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Users } from '../shared/module/Users';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class accountService {
  baseUrl = "http://localhost:5202/api/";
  constructor(private http : HttpClient, private route : Router) { }

  login(values:any){
    return this.http.post<Users>(this.baseUrl + 'account/login', values).pipe(
        map(users => {
          localStorage.setItem('username',users.displayName);
      })
    )
  }

  logout(){
    localStorage.removeItem('username');
    this.route.navigateByUrl('/');
  }
}
