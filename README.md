# INFO2300-Assignment-3
## Name:Tara Ramnaraine-Singh
## INFO2300 Assignment 3 
## Description
This project is about a reservation Systems developed for an Airline with small aeroplanes.
Their internal reservation saff can used the application to make the booking for the passengers


A reservation system for an airline flight seating.The airplane has 5 rows (1 to 5) with 4 seats (A to D) in each row. 
1.	Allow the user to add themselves to the flight or to a waiting list (if the flight is full):
a.	Request the passenger’s name.
b.	Display a list of all seats in the airplane when the user clicks the “All Seats” button.  One line per seat, format: seat number & passenger name (if booked): 

1A – 
1B – 
1C – Russell Crowe
1D – Shania Twain


2.	If seats are available, let the passenger select a seat by using the row/seat list boxes and clicking “book”.  Add the passenger to the seating chart.
a.	If no seats are available, “Book” and “Add to waiting list” buttons will add the person to the waiting list. 
b.	The waiting list has a maximum of 10 people. If full, just show a message to that effect.
c.	seats are available, “add to waiting list” button will not do anything, except show the message “Seats are available”.
d.	pressing “Status” button, the status of the selected seat will be shown.
3.	Remove a passenger from the flight
a.	Choose the row & seat to cancel.
b.	Click “Cancel” to delete the passenger’s booking
c.	If the waiting list is not empty, remove the first person from the list and give her/him the newly vacated seat.
4.	You are to use a multi-dimensional array to record seat bookings (ie: person’s name at row/column intersection), and a single-dimensional array for the waiting list.
a.	You are not to store bookings or the waiting list in the form controls
b.	Use a loop, not nested if-else statements, to generate a string from the arrays when “show all” and “show waiting list” are clicked.  Then, display the string in the RichTextBoxes, one line per seat.
5.	Show a message when
a.	“Book” is pressed but either the passenger name, row or seat is not selected.
b.	“Book” is pressed when the chosen seat is already taken
c.	“Add to Waiting List” is pressed when there are seats available.
d.	“Cancel” is pressed without specifying the row/seat.
e.	“Cancel” is pressed but the seat is not booked
f.	After a successful booking, including one from the waiting list
g.	After successfully cancelling a seat.
h.	After successfully adding to the waiting list.
6.	Add a “Fill All” button. Clicking this button will fill all 20 seats. You may use the same passenger name for all seats.
7.	Don’t restrict the length of the passenger name. For example, I should be able to book a person with name “a”.  


###### Contributer
- Tara Ramnaraine-Singh <nramnarainesing5897@conestogac.on.ca>

## License & Copyright
© Tara Ramnaraine-Singh, Conestoga College INFO2300 Project Development
Licenced under the [GNU License]_(LICENSE).
