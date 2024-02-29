import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { accountService } from '../account.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  title : string ='Login From';

  loginForm = new FormGroup({
    email : new FormControl('',Validators.required),
    password: new FormControl('',Validators.required)
  })
   constructor(private accountService: accountService, private router: Router){}

  onSubmit(){
    this.accountService.login(this.loginForm.value).subscribe({
      next:()=> this.router.navigateByUrl('/home'),
      error:()=> alert("Please check Credential...!")
    })
  }
}
