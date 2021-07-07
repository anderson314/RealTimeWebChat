import { stringify } from '@angular/compiler/src/util';
import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog'


@Component({
  selector: 'app-name-dialog',
  templateUrl: './name-dialog.component.html',
  styleUrls: ['./name-dialog.component.scss']
})
export class NameDialogComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA)
              public name: string,
              public dialogRef: MatDialogRef<NameDialogComponent>
              ) 
  { 

  }

  ngOnInit(): void {
  }

}
