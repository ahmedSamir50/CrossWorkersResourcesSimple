import { Component, OnInit } from "@angular/core";

import { Resource } from "../../shared/models/resource.model";
import { ResourceService } from "src/app/shared/services/resource.service";
import { FormGroup } from "@angular/forms";



@Component({
    selector: "resources-component",
    templateUrl: "./resources.template.html",
    styles: [`
    :host ::ng-deep .p-dialog .product-image {
        width: 150px;
        margin: 0 auto 2rem auto;
        display: block;
    }
    .ui-calendar .ui-datepicker {
        height: 200px!important;
    }
`],
    styleUrls: ["./resources.component.style.scss"]
})
export class ResourcesComponent implements OnInit {
    selectedResourceForBooking:Resource|null = null;
    dispalyNewBooking:boolean=false;
    displayedColumns: string[] = ['id', 'name', 'quantity','booknow'];
    resources:Array<Resource> = [] ;
    newBookingForm:FormGroup;
    resouceBookings:Array<any>=[];

    constructor(private service:ResourceService) { 
    }
    

    ngOnInit(): void {
       this.service.GetAllResources().subscribe((resources:any)=>{
           this.resources = (resources as Array<Resource>);
       });
    }


   

    // opening the modal to add new booking
    open(resource:Resource) {
        this.selectedResourceForBooking = resource;
        this.dispalyNewBooking = true;
    }

    // dismissing curren modal 
    dismiss(modalDissmissed:boolean){
        if(modalDissmissed){
            this.dispalyNewBooking = false;
            this.selectedResourceForBooking = null;
        }
    }

    // for expandeble row 
     getBookings(expanded:boolean,resource:Resource)
     {
         // TODO expanding not functioning right 
         if (!expanded)
             this.service.GetResourceBookings(resource.id).subscribe((v: any) => {
                 this.resouceBookings = (v && v.bookings) ? v.bookings : [];
             });
     }
   
}