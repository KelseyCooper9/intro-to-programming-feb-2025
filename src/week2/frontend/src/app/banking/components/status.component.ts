import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-banking-status',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: ` <p>Your Status Goes Here!</p> `,
  styles: ``,
})
export class StatusComponent {}
