export class BookingBase{
    resIdNum:number;
    dateFrom:Date ;
    dateTo:Date ;
}
export class NewBookingModel extends BookingBase{
    bookedQuantity:number=0;
}
