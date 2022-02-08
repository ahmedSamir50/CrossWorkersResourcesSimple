import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { AbstractControl, FormControl, FormGroup } from "@angular/forms";
import { ReactiveFormConfig, RxFormBuilder, RxwebValidators } from "@rxweb/reactive-form-validators";
import { ToastrService } from "ngx-toastr";
import { NewBookingModel } from "src/app/shared/models/newbooking.model";
import { Resource } from "src/app/shared/models/resource.model";
import { BookingFormService } from "src/app/shared/services/bookingFormService";




@Component({
    selector: "newbooking-component",
    templateUrl: "./newbooking.template.html",
    styles: [`
    .ui-calendar .ui-datepicker {
        height: 200px!important;
    }
`],
    styleUrls: ["./newbooking.component.style.scss"]
})
export class NewBookingFormComponent implements OnInit {
    bookingFormGruopElems: FormGroup = null;
    @Input() selectedForBooking: Resource | null;
    @Output() dismissed: EventEmitter<boolean> = new EventEmitter();
    fromDateErr = undefined;
    toDateErr = undefined;
    quantityErr = undefined;
    fromMinDate = new Date();
    toMinDate = new Date();
    constructor(public bookFormServ: BookingFormService, private formBuilder: RxFormBuilder) {
    }
    
    ngOnInit(): void {
        // setting the needed error messages formates
        ReactiveFormConfig.set({
            "validationMessage": {
                "required": "This field is required",
                "minLength": "minimum length is {{0}}",
                "maxLength": "allowed max length is {{0}}",
                "minDate": `minimum allowed date : {{0}}`,
                "minNumber": "minimum quantity is {{1}}",
                "maxNumber":"maxmum quantity of this resource is {{1}}"
            }
        });
        this.initiateFormControles();
    }

    // init ractive form controles 
    private initiateFormControles(): void {
        this.bookFormServ.formData.resIdNum = this.selectedForBooking.id;
        this.bookingFormGruopElems = this.formBuilder.group({
                dateFrom: new FormControl(this.bookFormServ.formData.dateFrom,
                    [RxwebValidators.required()]),
                dateTo: new FormControl(this.bookFormServ.formData.dateTo,
                    [RxwebValidators.required()]),
            quantity: new FormControl(this.bookFormServ.formData.bookedQuantity,
                [RxwebValidators.required(), RxwebValidators.minNumber({ value: 1 }),
                (control: AbstractControl) =>
                    RxwebValidators.maxNumber({ value: this.selectedForBooking?.quantity ?? 1 })(control)
                ]),
                resIdNum: new FormControl(this.selectedForBooking.id, [RxwebValidators.required()] ),
        });
    }
    
    // reserving / booking current form resource 
    reserveResource() {
        this.setValidationMessages()
        if (this.bookingFormGruopElems.valid){

            this.bookFormServ.postNewBooking().subscribe(res => {console.log(res);if(res)this.dismiss();});
        }

    }
    // dismissing current modal / booking form and emit closed to aknowlege parent 
    dismiss(close: boolean = true) {
        if (close) {
            this.modalDismissed();
            this.selectedForBooking = null;
        }
    }
    // aknowlege parent form is closed 
    modalDismissed = () => {
        this.dismissed.emit(true);;
    }
    // setting local variables with error messages warnings for 
    //the form validation to simplify the html template 
    setValidationMessages() {
        let fromhasErr = this.bookingFormGruopElems.controls["dateFrom"]["errors"];
        if (fromhasErr)
            this.fromDateErr = this.bookingFormGruopElems && this.bookingFormGruopElems.invalid
                ? fromhasErr["required"]?.message ?? "" + "\n" 
                + fromhasErr["minDate"]?.message ?? ""
                : "";
        let tohasErr = this.bookingFormGruopElems.controls["dateTo"]["errors"];
        if (tohasErr)
            this.toDateErr = this.bookingFormGruopElems && this.bookingFormGruopElems.invalid
                ? tohasErr["required"]?.message ?? "" + "\n" 
                + tohasErr["minDate"]?.message ?? ""
                : "";
        let qtyhasErr = this.bookingFormGruopElems.controls["quantity"]["errors"];
        if (qtyhasErr)
            this.quantityErr = this.bookingFormGruopElems && this.bookingFormGruopElems.invalid
                ? qtyhasErr["required"]?.message  ?? "" + "\n" 
                + qtyhasErr["minNumber"]?.message ?? ""+  "\n"
                + qtyhasErr['maxNumber']?.message?? ""  
                  : "";

    }

    // change booking to date upon from date change 
    fromMinChanged(newDateInFromInput: Date) {
        this.bookingFormGruopElems.patchValue( { dateTo: null } );
        this.toMinDate = newDateInFromInput;
    }
}