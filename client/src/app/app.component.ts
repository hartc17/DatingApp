import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule} from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Short-Term Rental Calculator';
  properties:any;

  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/property').subscribe(response => {
      this.properties = response;
    }, error => {
      console.log(error);
    }

    )
    
  }
}
