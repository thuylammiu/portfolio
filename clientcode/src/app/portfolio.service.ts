import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment';
import { PortfolioViewModel } from './portfolio.model';
import { ContactViewModel } from './contact.model';

@Injectable({
  providedIn: 'root'
})
export class PortfolioService {

  constructor(private http: HttpClient) { }
  
  getData(): Observable<PortfolioViewModel> {
    return this.http.get<PortfolioViewModel>(`${environment.apiBaseUrl}/api/Portfolio/GetAll`);
  }

  sendEmail(model: ContactViewModel): Observable<void>{
     return this.http.post<void>(`${environment.sendEmailLamdaUrl}`, model);
  }
  
}
