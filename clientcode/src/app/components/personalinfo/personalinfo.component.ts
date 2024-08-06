import { Component, Input } from '@angular/core';
import { PersonalInformationDto } from '../../portfolio.model';

@Component({
  selector: 'app-personalinfo',
  templateUrl: './personalinfo.component.html',
  styleUrl: './personalinfo.component.css'
})
export class PersonalinfoComponent {
  @Input() infor?: PersonalInformationDto;
}
