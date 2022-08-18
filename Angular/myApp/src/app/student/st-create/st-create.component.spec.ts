import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StCreateComponent } from './st-create.component';

describe('StCreateComponent', () => {
  let component: StCreateComponent;
  let fixture: ComponentFixture<StCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
