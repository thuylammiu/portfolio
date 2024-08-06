import { Component, Input, input } from '@angular/core';
import { EducationDto, PortfolioViewModel } from '../../portfolio.model';

@Component({
  selector: 'app-education',
  templateUrl: './education.component.html',
  styleUrl: './education.component.css'
})
export class EducationComponent {
@Input() model?: PortfolioViewModel;
}
