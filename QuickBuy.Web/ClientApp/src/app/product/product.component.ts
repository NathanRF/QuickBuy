import { Component } from '@angular/core';

@Component({
  selector: 'product',
  template: '<html><body>{{ getName() }}</body></html>'
})
export class ProductComponent {
  public name: string;
  public clearedForSale: boolean;

  public getName(): string {
    return this.name;
  }
}
