using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tara_Assignment1
{
    public partial class Reservation : Form
    {
        // creating variables and arrays
        private const byte ROWS = 5;
        private const byte COLUMNS = 4;
        private byte seatsRemaining = 20;
        private byte counter = 0;
        private string[] waitingList = new string[20];
        private string[,] seatingPlan = new string[ROWS, COLUMNS];

        private RadioButton activeRadioButton;
        
        public Reservation()
        {
            InitializeComponent();
            InitializeSeatingPlan();

        }

        private void InitializeSeatingPlan() 
        {
            // Assigning the seats to the Index
            seatingPlan[0, 0] = "1A-";
            seatingPlan[0, 1] = "1B-";
            seatingPlan[0, 2] = "1C-";
            seatingPlan[0, 3] = "1D-";

            seatingPlan[1, 0] = "2A-";
            seatingPlan[1, 1] = "2B-";
            seatingPlan[1, 2] = "2C-";
            seatingPlan[1, 3] = "2D-";

            seatingPlan[2, 0] = "3A-";
            seatingPlan[2, 1] = "3B-";
            seatingPlan[2, 2] = "3C-";
            seatingPlan[2, 3] = "3D-";

            seatingPlan[3, 0] = "4A-";
            seatingPlan[3, 1] = "4B-";
            seatingPlan[3, 2] = "4C-";
            seatingPlan[3, 3] = "4D-";

            seatingPlan[4, 0] = "5A-";
            seatingPlan[4, 1] = "5B-";
            seatingPlan[4, 2] = "5C-";
            seatingPlan[4, 3] = "5D-";

        }

        private void BtnShowAllSeats_Click(object sender, EventArgs e)
        {
            //Using a nested for loop to show all the seats
            var seatList = new StringBuilder();
            
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    seatList.AppendLine(seatingPlan[i, j]);        
                }
            }

            txtShowAllSeats.Text = seatList.ToString();
        }

        private void CheckSeat(object sender, EventArgs e) 
        {


            var radioButton = (RadioButton)sender;
            activeRadioButton = radioButton;

            if (activeRadioButton.BackColor == Color.Red) 
            {
                btnCancel.Enabled = true;
                btnBook.Enabled = false;
                txtSystemMessages.Text = "This seat is reserved." +
                    " You must cancel the reservation " +
                    "to make it available";
            }
            else 
            {
                txtName.Enabled = true;
                txtSystemMessages.ResetText();
                btnBook.Enabled = true;
                btnCancel.Enabled = false;
                activeRadioButton = radioButton;
            }
        }

        private void Book(object sender, EventArgs e) 
        {
            //display error if user submits reservation without passenger name
            if(string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a customer name",
                "Error", MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
            
            //First row bookings
            if (activeRadioButton.Name == "rb0_0" && 
                !string.IsNullOrEmpty(txtName.Text))// edit out later. Redundant
            {
                seatingPlan[0, 0] += txtName.Text;
                rb0_0.BackColor = Color.Red;
                
                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
                
            }
            else if (activeRadioButton.Name == "rb0_1" && 
                !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[0, 1] += txtName.Text;
                rb0_1.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }
            else if (activeRadioButton.Name == "rb0_2" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[0, 2] += txtName.Text;
                rb0_2.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb0_3" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[0, 3] += txtName.Text;
                rb0_3.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }
            //Handle second row bookings
            else if (activeRadioButton.Name == "rb1_0" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[1,0] += txtName.Text;
                rb1_0.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb1_1" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[1, 1] += txtName.Text;
                rb1_1.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb1_2" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[1, 2] += txtName.Text;
                rb1_2.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb1_3" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[1, 3] += txtName.Text;
                rb1_3.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            //Handle third row bookings

            else if (activeRadioButton.Name == "rb2_0" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[2,0] += txtName.Text;
                rb2_0.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb2_1" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[2, 1] += txtName.Text;
                rb2_1.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb2_2" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[2, 2] += txtName.Text;
                rb2_2.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb2_3" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[2, 3] += txtName.Text;
                rb2_3.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }
            //Handle fourth row bookings
            else if (activeRadioButton.Name == "rb3_0" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[3, 0] += txtName.Text;
                rb3_0.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb3_1" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[3, 1] += txtName.Text;
                rb3_1.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb3_2" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[3, 2] += txtName.Text;
                rb3_2.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb3_3" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[3, 3] += txtName.Text;
                rb3_3.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            //Handle fifth row bookings

            else if (activeRadioButton.Name == "rb4_0" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[4, 0] += txtName.Text;
                rb4_0.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb4_1" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[4, 1] += txtName.Text;
                rb4_1.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb4_2" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[4, 2] += txtName.Text;
                rb4_2.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }

            else if (activeRadioButton.Name == "rb4_3" &&
               !string.IsNullOrEmpty(txtName.Text))
            {
                seatingPlan[4, 3] += txtName.Text;
                rb4_3.BackColor = Color.Red;

                txtName.Clear();
                txtSystemMessages.Text = "SUCCESS: Seat booked!";

                seatsRemaining--;
            }


        }
        
        //Populating seats
        private void BtnFillAllSeats_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnlSeatingPlan.Controls.Count; i++)
            {
                pnlSeatingPlan.Controls[i].BackColor = Color.Red;
            }

            seatingPlan[0, 0] += "Tara Singh";
            seatingPlan[0, 1] += "Nirvan Singh";
            seatingPlan[0, 2] += "Aryan Singh";
            seatingPlan[0, 3] += "Singh Singh";

            seatingPlan[1, 0] += "Steve Ray Vaugh";
            seatingPlan[1, 1] += "Christopher Dean";
            seatingPlan[1, 2] += "Joe Satriani";
            seatingPlan[1, 3] += "Jimmy Page";

            seatingPlan[2, 0] += "Shakira Baksh";
            seatingPlan[2, 1] += "Michael Cain";
            seatingPlan[2, 2] += "Clint Eastwood";
            seatingPlan[2, 3] += "Nicholas Cage";

            seatingPlan[3, 0] += "Darth Vader";
            seatingPlan[3, 1] += "Count Dookoo";
            seatingPlan[3, 2] += "Emperor Palpatine";
            seatingPlan[3, 3] += "Yoda";

            seatingPlan[4, 0] += "Yoko Ono";
            seatingPlan[4, 1] += "Miley Cyrus";
            seatingPlan[4, 2] += "Lil' Kim";
            seatingPlan[4, 3] += "Oprah Winfrey";

            seatsRemaining = 0;
            btnBook.Enabled = false;
            btnCancel.Enabled = true;

            var testSeatingPlanDisplay = new StringBuilder();

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    testSeatingPlanDisplay.AppendLine(seatingPlan[i, j]);
                }
            }

            txtShowAllSeats.Text = testSeatingPlanDisplay.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            string cancellationMessage = "Reservation canceled.";
            //Cancel first row bookings
            if (activeRadioButton.Name == "rb0_0")
            {
                seatingPlan[0, 0] = "1A-";
                rb0_0.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;

            }
            else if (activeRadioButton.Name == "rb0_1")
            {
                seatingPlan[0, 1] ="1B-";
                rb0_1.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }
            else if (activeRadioButton.Name == "rb0_2")
            {
                seatingPlan[0, 2] = "1C-";
                rb0_2.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb0_3")
            {
                seatingPlan[0, 3] = "1D-";
                rb0_3.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }
            //Cancel second row bookings
            else if (activeRadioButton.Name == "rb1_0")
            {
                seatingPlan[1, 0] ="2A-";
                rb1_0.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb1_1")
            {
                seatingPlan[1, 1] ="2B-";
                rb1_1.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb1_2")
            {
                seatingPlan[1, 2] ="2C-";
                rb1_2.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb1_3")
            {
                seatingPlan[1, 3] = "2D-";
                rb1_3.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            //Cancel third row bookings

            else if (activeRadioButton.Name == "rb2_0")
            {
                seatingPlan[2, 0] ="3A-";
                rb2_0.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb2_1")
            {
                seatingPlan[2, 1] = "3B-";
                rb2_1.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb2_2")
            {
                seatingPlan[2, 2] = "3C-";
                rb2_2.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb2_3")
            {
                seatingPlan[2, 3] = "3D-";
                rb2_3.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }
            //Cancel fourth row bookings
            else if (activeRadioButton.Name == "rb3_0")
            {
                seatingPlan[3, 0] = "4A-";
                rb3_0.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb3_1")
            {
                seatingPlan[3, 1] = "4B-";
                rb3_1.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb3_2")
            {
                seatingPlan[3, 2] = "4C-";
                rb3_2.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb3_3")
            {
                seatingPlan[3, 3] = "4D-";
                rb3_3.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            //Cancel fifth row bookings

            else if (activeRadioButton.Name == "rb4_0")
            {
                seatingPlan[4, 0] = "5A-";
                rb4_0.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb4_1")
            {
                seatingPlan[4, 1] = "5B-";
                rb4_1.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb4_2")
            {
                seatingPlan[4, 2] = "5C-";
                rb4_2.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }

            else if (activeRadioButton.Name == "rb4_3")
            {
                seatingPlan[4, 3] = "5D-";
                rb4_3.BackColor = DefaultBackColor;

                txtSystemMessages.Text = cancellationMessage;

                seatsRemaining++;
            }
        
        }

        private void btnAddWaitingList_Click(object sender, EventArgs e)
        {
            //count set a counter to manage where customers are dropped on the array
            
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //waitingList set to 20, do not allow more people on waiting list than there are seats
            else if (seatsRemaining == 0)
            {
                try
                {
                    waitingList[counter] = txtName.Text;
                    counter++;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("The waiting list is full","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
                txtSystemMessages.Text = "Customer added to waiting list";
                txtName.ResetText();
            }

            else if (seatsRemaining > 0) 
            {
                txtSystemMessages.Text = "Error: there is seating available.";
            }

            else if (counter == 20)
            {
                MessageBox.Show("The waiting list is full");
            }

        }

        private void BtnWaitingList_Click(object sender, EventArgs e)
        {
            var waitingListDisplay = new StringBuilder();

            for (int i = 0; i < waitingList.Length; i++)
            {
                waitingListDisplay.AppendLine(waitingList[i]);
            }

            txtWaitingList.Text = waitingListDisplay.ToString();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
