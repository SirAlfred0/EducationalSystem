import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-custom-select',
  templateUrl: './custom-select.component.html',
  styleUrls: ['./custom-select.component.css']
})
export class CustomSelectComponent implements OnInit {

  @Input() defaultValue: string = "Select One Of The Options";

  @Input() options: any[] = [];

  @Output() emitter: EventEmitter<any> = new EventEmitter<any>();

  constructor() { }

  ngOnInit(): void {
  }

  Change(id: any)
  {
    this.emitter.emit(id);
  }
}
