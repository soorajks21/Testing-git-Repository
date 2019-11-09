import { Component, OnInit } from '@angular/core'; 
import { Http } from '@angular/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'app works!';
  test: string[];
  user: string;

  constructor(private http: Http) {

  }
  ngOnInit() {
    this.http.get('/api/values').subscribe(res => { this.test = res.json() as string[] });
    

  }
  post() {
    
    this.http.post(('/api/values'),'sds');
    this.title = 'tony';
  }
}
