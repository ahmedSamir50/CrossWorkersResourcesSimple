import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AppConstants } from "../constants";
import { BookingBase, NewBookingModel } from "../models/newbooking.model";
import { ResourceAvailability } from "../models/ResourceAvailability";
import { mergeMap, Observable,of } from "rxjs";
import { ToastrService } from "ngx-toastr";

@Injectable({
    providedIn: "root"
})
export class BookingFormService {
    constructor(private client: HttpClient , private toastr: ToastrService) { }
    formData: NewBookingModel = new NewBookingModel();
    validated: ResourceAvailability | null = null;
    // adding new Booking of resource
    public postNewBooking = () => {
       return this.validateDatesAndQtyForResource().pipe(
            mergeMap((val:any,idx)=>{
                if(val){
                    const available = val as ResourceAvailability;
                    if(available.availability&&available.availableQtyInDates>=this.formData.bookedQuantity){
                        this.toastr.success(`Resource: {${this.formData.resIdNum ?? ""}} {${this.formData.bookedQuantity}} booked untill ${this.formData.dateTo}`, "booked")
                        return this.postNewBookingForResourceRequest(val);
                    }
                    else {
                        if (available.availableInDates)
                            this.toastr.error(`Resource: {${this.formData.resIdNum ?? ""}} Only {${val.availableQtyInDates}} are available `, "Warning");
                        else
                            this.toastr.error(`Resource: {${this.formData.resIdNum ?? ""}} is not available for the selected dates `, "Warning");
                    }
                }
                else
                    this.toastr.error(`Resource: {${this.formData.resIdNum ?? ""}} is not available for the selected dates `, "Warning");
                return of(null)
            }) )
    }

    private postNewBookingForResourceRequest = (x:any): Observable<any> => {
        debugger;
        this.adjustDatesToUTC();
        return this.client.post(AppConstants.baseUrl, {...this.formData as NewBookingModel})
    }

    public validateDatesAndQtyForResource = (): Observable<any> => {
        debugger;
        // temp solution for isuue with prim ng calender plug in 
        this.adjustDatesToUTC();
        return this.client.post(AppConstants.baseUrl + AppConstants.validateBooking,{...this.formData as BookingBase})
    }
    // the prime ng sending the dates in the local machine time zone 
    // whitch shifting -1 day on back end 
    // mutating dates to adjust them on sending temporary 
     // temp solution for isuue with prim ng calender plug in  TODO
    adjustDatesToUTC() {
        this.formData.dateFrom ? this.formData.dateFrom = this.asUTCDate(this.formData.dateFrom) : "";
        this.formData.dateTo ? this.formData.dateTo = this.asUTCDate(this.formData.dateTo) : "";
    }
    asUTCDate(calenderDateValue:Date):Date{
       return new Date(Date.UTC(calenderDateValue.getFullYear()
            , calenderDateValue.getMonth()
            , calenderDateValue.getDate()
            , 0, 0, 0))
    }
}