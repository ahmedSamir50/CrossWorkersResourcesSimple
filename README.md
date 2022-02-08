# CrossWorkersResourcesSimple
CrossWorkers simple booking
Acceptance criteria
- User can book resources.
- Resources can be booked only if the requested quantity is available for the requested period.
- If the user tries to book a resource that is not available, he is presented with error message.
- If the user tries to book a resource that is available, after successful booking the user is
presented with success message.
- The part of the validation that checks for conflicts between existing booking time ranges and
requested booking time range should be designed as reusable in other places.
- At the end of the booking process, an email should be sent to admin@admin.com. For this task
email implementation should ONLY write to console “EMAIL SENT TO admin@admin.com FOR
CREATED BOOKING WITH ID {Id}”. For this task there is no need for real email sending and it is
only mocked with console write.
-- 
Please restore the neugets 
navigate to \CrossWorkersResourcesSimple-master\BookingSampleAPIs\ClientApp\booking-ang\ and npm install 
run the application from visual studio
if it oens the swagger page please remove to the application base url 
