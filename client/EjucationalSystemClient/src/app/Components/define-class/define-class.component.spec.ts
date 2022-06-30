import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DefineClassComponent } from './define-class.component';

describe('DefineClassComponent', () => {
  let component: DefineClassComponent;
  let fixture: ComponentFixture<DefineClassComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DefineClassComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DefineClassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
