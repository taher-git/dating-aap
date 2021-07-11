import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'Dating App';
  users : any = {};

  constructor(private http : HttpClient){

  }
  ngOnInit() {
    this.getUsers();
  }
  getUsers(){
    this.http.get("https://localhost:5001/api/user").subscribe( res =>{
      console.log(res)
      this.users = res
    })
  }
  
}
