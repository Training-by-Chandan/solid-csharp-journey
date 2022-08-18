import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StListComponent } from './st-list.component';

describe('StListComponent', () => {
  let component: StListComponent;
  let fixture: ComponentFixture<StListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
