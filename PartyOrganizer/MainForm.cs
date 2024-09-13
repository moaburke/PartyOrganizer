//Moa Burke
//13 Sept 2024

using MyPartyOrganizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        //Ref variable declared, object not created
        PartyManager partyManager;

        public MainForm()
        {
            InitializeComponent();
            //Prepare the GUI
            InitializeGUI();
        }

        /// <summary>
        /// Center the window on the screen
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Center form to screen
            CenterToScreen();
        }

        /// <summary>
        /// Initialize the GUI.
        /// </summary>
        private void InitializeGUI()
        {
            //Change the title of the form
            this.Text = this.Text + " by Moa Burke";

            //Call method to clear input controls
            ClearInputControls();
            //Call method to clear output controls
            ClearOutputControls();

            //Enable groupbox for inputting guests invited
            grpInviteGuest.Enabled = false;

            //Enable the groupbox for creating a new party
            grpNewParty.Enabled = true;

        } //end of InitializeGUI method

        /// <summary>
        /// Method to clear all input controls
        /// </summary>
        private void ClearInputControls()
        {
            //Clear input controls
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

        } //end of ClearInputControls method


        /// <summary>
        /// Method to clear all output controls
        /// </summary>
        private void ClearOutputControls()
        {
            //Clear output controls
            lblNumOfGuests.Text = string.Empty;
            lblTotalCost.Text = string.Empty;
            lblTotalFees.Text = string.Empty;
            lblSurplusDeficit.Text = string.Empty;

        } //end of ClearOutputControls method

        /// <summary>
        /// Updates the graphical user interface with guest list informatiom and calculated totals.
        /// </summary>
        private void UpdateGUI()
        {

            //Clear the field for guest's first name
            txtFirstName.Text = "";
            //Clear the field for guest's last name
            txtLastName.Text = "";

            //Clear the list of guests displayed
            lstGuests.Items.Clear();
            //Retrieve the list of guests from the PartyManager
            string[] guestList = partyManager.GetGuestList();

            //Check if guest list is not null
            if(guestList != null)
            {
                //Iterate through the guest list and format the display for each guest
                for(int i = 0; i < guestList.Length; i++)
                {
                    //Formatted string with the guest information
                    string str = $"{i + 1,4} {guestList[i],-2}";
                    //Add the formatted string to the list
                    lstGuests.Items.Add(str);
                }
            }

            //Calculate and display the total costs for the party
            double totalCost = partyManager.CalcTotalCost(); //Calculate the total costs
            lblTotalCost.Text = totalCost.ToString("0.00"); //Display the total costs

            //Calculate and display the total fees for all guests invited
            double totalFees = partyManager.CalcTotalFees(); //Calculate the total fees
            lblTotalFees.Text = totalFees.ToString("0.00"); //Display the total fees

            //Calculate and display the surplus or deficit 
            //A positive value indicated a surplus, and a negative value indicated deficit.
            double totalSurplusDeficit = partyManager.CalcSurplusDeficit(); //Calculate the surplus/deficit
            lblSurplusDeficit.Text = totalSurplusDeficit.ToString("0.00"); //Display the surplus/deficit

            //Count and display the number of guests 
            int numOfGuests = partyManager.NumOfGuests(); //Count the number of guests
            lblNumOfGuests.Text = numOfGuests.ToString(); //Display the number of guests

        } // end of UpdateGUI method

        /// <summary>
        /// Event-handler method that is called when user click btnCreateList button.
        /// Initiating and create a guest list.
        /// </summary>
        /// <param name="sender">The control/object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            ClearInputControls();
            ClearOutputControls();
            lstGuests.Items.Clear();

            //Validate the max guests input
            bool maxNumOK = CreateParty();

            //If the total number of guests has invalid input 
            if (!maxNumOK)
                return; //do no more
            else
                grpInviteGuest.Enabled = true; //groupbox to input invited guests becomes enabled

        } //end of btnCreateList_Click method

        /// <summary>
        /// Event-handler method that is called when the user click the 'Add' button. Validates and adds a new guest to the guest list.
        /// </summary>
        /// <param name="sender">The control/object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check if party has spance for more guests
            bool amountOfGuestsOK = partyManager.ValidateAmountOfGuests();

            //If party has space for more guests
            if (amountOfGuestsOK)
            {
                //Read and validate the guest input
                bool guestOK = ReadGuestInput(ref partyManager);

                //The guest input is valid
                if (guestOK)
                {
                    //Adds the guest
                    bool okAdd = partyManager.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                }
            }
            else //The party does not have space for more guests
            {
                MessageBox.Show("List is full! Guest not added.", "Error"); //Display error message
            }

            //Update the graphical interface
            UpdateGUI();

        } //end of btnAdd_Click method

        /// <summary>
        /// Event-handler method that is called when the user click 'Change' button,
        /// modifying a guest's details in the PartyManager
        /// <param name="sender">The control/object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            //get the selected index from the list
            int index = lstGuests.SelectedIndex;

            //Check if item is selected (index is non -1)
            if (index == -1)
            {
                //Display an error message if no item is selected
                MessageBox.Show("Select an item in the listbox!", "Error");
                return;
            }

            //Get the updated first and last name from the input
            var names = ReadInput();
            //Retrieve the first name
            string firstName = names.firstName;
            //Retrieve the last name
            string lastName = names.lastName;

            //Change the selected guest's details
            partyManager.ChangeAt(index, firstName, lastName);
            //Update te graphical user interface
            UpdateGUI();

        } //end of btnChange_Click method

        /// <summary>
        /// Event-handler method that is called when the user click 'Delete' button.
        /// </summary>
        /// <param name="sender">The control/object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the selected index from the list
            int index = lstGuests.SelectedIndex;

            //Check if item is selected (index is non -1)
            if (index == -1)
            {
                //Display an error message if no item is selected
                MessageBox.Show("Select an item in the listbox!", "Error");
                return;
            }
            //Delete the selected guest from the PartyManager
            partyManager.DeleteAt(index);
            //Update the graphical user interface
            UpdateGUI();

        } //end of btnDelete_Click method

        /// <summary>
        /// Responds to the selection change in the list and displays the selected guest's name.
        /// </summary>
        /// <param name="sender">The control/object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected index from the list
            int index = lstGuests.SelectedIndex;

            //Check for a valid index (0 and above)
            if (index >= 0)
            {
                //Get the names of the selected guest
                var names = partyManager.GetNames(index);
                //Display the selected guest's first name
                txtFirstName.Text = names.firstName;
                //Display the selected guest's last name
                txtLastName.Text = names.lastName;
            }
        } //end of lstGuests_SelectedIndexChanged method

        /// <summary>
        /// Creates a party based on the number of guests inputted by the user, and initializes the Partymanager.
        /// </summary>
        /// <returns>True if the input for the amount of max guests is a valid numver; otherwise false.</returns>
        private bool CreateParty()
        {
            int maxNumber = 0; //Variable to store the max number of guests
            bool ok = true; //Flag to control if input is a valid number

            //Attempt to parse the text from the 'txtMaxNumOfGuests' input into the maxNum variable
            if (int.TryParse(txtMaxNumOfGuests.Text, out maxNumber) && (maxNumber > 0)){
                //Initialize the party manager with the given maxNumber of guests
                partyManager = new PartyManager(maxNumber);

                //Assigning the maximum amount of guests to the party manager
                partyManager.MaxNumOfGuests = maxNumber;

                //Validate the cost per person and fee per person inputs
                bool costOK = ReadCostPerPerson();
                bool feeOK = ReadFeePerPerson();

                //If both cost and fee inputs are valid, show a sucess message
                if (costOK && feeOK)
                {
                    //Display a message indicating the successful creation of the party list
                    MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success");
                }
                else
                {
                    ok = false; //Set the flag to false indicating an unsuccessful creatio
                }
            }
            else
            {
                ok = false; //Set the flag to false indicating the input is not valid

                //Display an error message for an invalid input
                MessageBox.Show("Invalid total number. Please try again!", "Error");

                //Reset text input cursot and handle text section based on the input state
                txtMaxNumOfGuests.SelectionStart = 0; //Set cursor position to the start of the text
                //If there is any text input
                if (txtMaxNumOfGuests.Text.Length > 0)
                    txtMaxNumOfGuests.SelectionLength = txtMaxNumOfGuests.Text.Length; //Select the entite text
                else //The input field is empty
                    txtMaxNumOfGuests.Text = "     "; //Set default text
                //Focus on he text input field for user attention
                txtMaxNumOfGuests.Focus(); 
            }
            //Return true if the input for the amount of max guests is a valid number; otherwise false
            return ok;
        } //end of CreateParty method

        /// <summary>
        /// Reads and validates the cost per person input, assigning it to the party manager.
        /// </summary>
        /// <returns>True if the input for the cost per person is a valid numver; otherwise false.</returns>
        private bool ReadCostPerPerson()
        {
            double costPerPerson = 0.0; //Variable to store the cost per person
            bool ok = false; //Flag to control if input is a valid number

            //Attempt to parse the text from the 'txtCostPerPerson' input into the costPerPerson variable
            if (double.TryParse(txtCostPerPerson.Text, out costPerPerson))
            {
                //Assigning the cost per person to the party manager
                partyManager.CostPerPerson = costPerPerson;
                ok = true; //Set the flag to true indicating valid input
            }
            else
            {
                ok = false; //Set the flag to false indicating the input is not valid

                //Display an error message for an invalid input
                MessageBox.Show($"Invalid cost per person. Please try again!", "Error");

                //Reset text input cursot and handle text section based on the input state
                txtCostPerPerson.SelectionStart = 0;//Set cursor position to the start of the text
                //If there is any text input
                if (txtCostPerPerson.Text.Length > 0)
                    txtCostPerPerson.SelectionLength = txtCostPerPerson.Text.Length; //Select the entite text
                else //The input field is empty
                    txtCostPerPerson.Text = "     "; //Set default text
                //Focus on he text input field for user attention
                txtCostPerPerson.Focus();
            }
            //Return true if the input for the cost per person is a valid number; otherwise false
            return ok;

        } //end of ReadCostPerPerson method

        /// <summary>
        /// Reads and validates the fee per person input, assigning it to the party manager.
        /// </summary>
        /// <returns>True if the input for the cost per person is a valid numver; otherwise false.</returns>
        private bool ReadFeePerPerson()
        {
            double feePerPerson = 0.0;  //Variable to store the fee per person
            bool ok = false; //Flag to control if input is a valid number

            //Attempt to parse the text from the 'txtFeePerPerson' input into the feePerPerson variable
            if (double.TryParse(txtFeePerPerson.Text, out feePerPerson))
            {
                //Assigning the cost per person to the party manager
                partyManager.FeePerPerson = feePerPerson;
                ok = true; //Set the flag to true indicating valid input
            }
            else
            {
                ok = false;//Set the flag to false indicating the input is not valid

                //Display an error message for an invalid input
                MessageBox.Show($"Invalid fee per person. Please try again!", "Error");

                //Reset text input cursot and handle text section based on the input state
                txtFeePerPerson.SelectionStart = 0; //Set cursor position to the start of the text
                //If there is any text input
                if (txtFeePerPerson.Text.Length > 0) 
                    txtFeePerPerson.SelectionLength = txtFeePerPerson.Text.Length;//Select the entite text
                else //The input field is empty
                    txtFeePerPerson.Text = "     "; //Set default text
                //Focus on he text input field for user attention
                txtFeePerPerson.Focus();
            }
            //Return true if the input for the fee per person is a valid number; otherwise false
            return ok;

        } //end of ReadFeePerPerson

        /// <summary>
        /// Reads and validates the geust input
        /// </summary>
        /// <param name="partyManager">The PartyManager object to update.</param>
        /// <returns>True if both first and last names are valid; otherwise false.</returns>
        private bool ReadGuestInput(ref PartyManager partyManager)
        {
            //Validate first name, if false display error message
            bool firstNameOK = ValidateText(txtFirstName.Text, "First name must be given!");
            //Validate last name, if false display error message
            bool lastNameOK = ValidateText(txtLastName.Text, "Last name must be given!");

            //Last name input is not valid
            if (!lastNameOK)
            {
                //Reset text input cursot and handle text section based on the input state
                txtLastName.SelectionStart = 0; //Set cursor position to the start of the text
                                                //If there is any text input
                if (txtLastName.Text.Length > 0)
                    txtLastName.SelectionLength = txtLastName.Text.Length; //Select the entite text
                else //The input field is empty
                    txtLastName.Text = "     "; //Set default text
                                                //Focus on he text input field for user attention
                txtLastName.Focus();
            }

            //First name input is not valid
            if (!firstNameOK)
            {
                //Reset text input cursor and handle text section based on the input state
                txtFirstName.SelectionStart = 0; //Set cursor position to the start of the text
                                                 //If there is any text input
                if (txtFirstName.Text.Length > 0)
                    txtFirstName.SelectionLength = txtFirstName.Text.Length; //Select the entite text
                else //The input field is empty
                    txtFirstName.Text = "     "; //Set default text
                                                 //Focus on he text input field for user attention
                txtFirstName.Focus();
            }

            //Return the first ad last name if both input are valid 
            return firstNameOK && lastNameOK;

        } //end of ReadGuestInput method

        /// <summary>
        /// Validares text input for being non-empty.
        /// </summary>
        /// <param name="text">The text to validate.</param>
        /// <param name="errMessage">The errormessage to display if text is empty.</param>
        /// <returns>True if the text is valid; otherwise false.</returns>
        private bool ValidateText(string text, string errMessage)
        {
            //Trim before and after empty spaces
            text = text.Trim();

            //Check if string is empty
            if(string.IsNullOrEmpty(text))
            {
                //If empty display error message
                MessageBox.Show(errMessage, "Error");
                return false;
            }
            //Return true if text is valid
            return true;

        } //end of ValidateText impit

        /// <summary>
        /// Reads and retrieves the first and last names from the text input fields.
        /// </summary>
        /// <returns>A tuple containing the first and last names obtained from the inpug fields.</returns>
        private (string firstName, string lastName) ReadInput()
        {
            string firstName = ""; //Variable to store the first name
            string lastName = ""; //Variable to store the last name

            //Check if the input field for the first name is empty
            if (!(string.IsNullOrEmpty(txtFirstName.Text)))
            { 
                //Retrieve the first name from the input field and set it in the variable
                firstName = txtFirstName.Text;
            }

            //Check if the input field for the first name is empty
            if (!(string.IsNullOrEmpty(txtLastName.Text)))
            {
                //Retrieve the last name from the input field and set it in the variable
                lastName = txtLastName.Text;
            }
            //Return the first and the last name
            return (firstName, lastName);

        } //end of ReadInput method
    }
}
