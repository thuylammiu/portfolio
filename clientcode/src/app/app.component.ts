import { Component, OnInit } from '@angular/core';
import { PortfolioViewModel } from './portfolio.model';
import { PortfolioService } from './portfolio.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  model?:PortfolioViewModel;

  constructor(private service: PortfolioService)
  {

  }

  ngOnInit(): void {
    this.getData();
    console.log(this.model);
  }

  getData()
  {
    this.service.getData().subscribe({
      next:(response)=> {
        this.model=response;
      }
    })
  }
  
}
