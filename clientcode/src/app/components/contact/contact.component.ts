import { Component } from '@angular/core';
import { ContactViewModel } from '../../contact.model';
import { ToastrService } from 'ngx-toastr';
import { PortfolioService } from '../../portfolio.service';

 
// bootstrap style toast 
// or import a bootstrap 4 alert styled design (SASS ONLY) 
// should be after your bootstrap imports, it uses bs4 variables, mixins, functions 

 
// if you'd like to use it without importing all of bootstrap it requires 


@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent {

  constructor(private toastr: ToastrService, 
              private service: PortfolioService

  ){
    
  }
  contactModel: ContactViewModel = new ContactViewModel();
  errorMsg:string=''

  showMessage() {
    this.toastr.success('Sending Email Successfully','Confirmation' );   
}



  onSubmitClick(event: any) {
    console.log(this.contactModel);
    if (!this.contactModel.body || !this.contactModel.from || !this.contactModel.name
      ||!this.contactModel.subject 
    )
    {
      this.errorMsg="Please input all required fields!";
      return;
    }
    else
    { 
      this.service.sendEmail(this.contactModel).subscribe({
        next: (response) => {
          this.contactModel= new ContactViewModel();
          
          this.showMessage();
          this.errorMsg='';
          return;
        },
        error:(error) => {
          this.toastr.error('Error when sending email','Confirmation' ); 
          console.log(error);
          return;
        }
      })
      
    }
    
  }
  
}
