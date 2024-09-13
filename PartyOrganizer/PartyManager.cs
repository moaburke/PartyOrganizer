//Moa Burke
//13 Sept 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPartyOrganizer
{
    internal class PartyManager
    {
        private double costPerPerson; //Instance variable to store the cost per participant (expence)
        private double feePerPerson; //Instance variable to store the fee per guest (income)
        private int maxNumOfGuests;
        private string[] guestList; //Declaring an array to store the names of guests invited to the event
        private int numOfElems = 0;

        //Constructor - expect maxNumOfGuests from the caller (MainForm) to set the size of the array
        public PartyManager(int maxNumOfGuests)
        {
            //Create the array
            guestList = new string[maxNumOfGuests];
        }

        /// <summary>
        /// Represents the cost per person that is attenting the party.
        /// </summary>
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set
            {
                //If the value if non-negative, update the cost per person
                //0 value if cost per guest is nothing
                if (value >= 0.0)
                    costPerPerson = value;  //Set the cost per person tot he provided value
            }
        } //end of property CostPerPerson

        /// <summary>
        /// Represents the fee per person for attenting the party.
        /// </summary>
        public double FeePerPerson
        {
            //Getter to retrieve the current fee per person
            get { return feePerPerson; }
            set
            {
                //If the value if non-negative, update the fee per person
                //0 value for free entry
                if (value >= 0.0)
                {
                    feePerPerson = value; //Set the fee per person
                }
            }
        } //end of property FeePerPerson

        /// <summary>
        /// Represents the maximun amount of guests that can attend the party.
        /// </summary>
        public int MaxNumOfGuests
        {
            get { return maxNumOfGuests; }
            set
            {
                if (value >= 0.0)
                {
                    maxNumOfGuests = value;
                }
            }
        } //end of property MaxNumOfGuests

        /// <summary>
        /// Validates if the number of guests is below the maximun capacity.
        /// </summary>
        /// <returns>True if the number of guests is within the allow limit; otherwise false.</returns>
        public bool ValidateAmountOfGuests()
        {
            //Check if the number of guests if below the amount of maximun guests
            if (numOfElems >= maxNumOfGuests)
                //Return false if the number of guests exceeds the limit
                return false;
            else
                //Return true if the number of guests is within the limit
                return true;

        } //end of ValidateAmountOfGuests method

        /// <summary>
        /// Change the name of the guest at the specified index in the guest list.
        /// </summary>
        /// <param name="index">Index of the guest to change.</param>
        /// <param name="FirstName">New first name for the guest.</param>
        /// <param name="LastName">New last name for the guest.</param>
        /// <returns>True if the change was successful; otherwise false.</returns>
        public bool ChangeAt(int index, string FirstName, string LastName)
        {
            bool ok = false; //Flag to control if change was successful

            if (CheckIndex(index))
            {
                //Change the guest name at the specified index
                guestList[index] = FullName(FirstName, LastName);
                //Set the flag to true
                ok = true;
            }

            //Return true if change was successful; otherwise false.
            return ok;

        } //end of ChangeAt method

        /// <summary>
        /// Adds a new guest to the guest list.
        /// </summary>
        /// <param name="firstName">The first name of the guest to be added.</param>
        /// <param name="lastName">The last name of the guest to be added.</param>
        /// <returns>True if guest if successfully added; otherwise false.</returns>
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true; //Flag to control if guest was added successfully

            //Check if there is space avaliblie in the guestlist
            if (numOfElems < guestList.Length)
            {
                //Add the new guest to the next avalible position in the guestList array
                guestList[numOfElems] = FullName(firstName, lastName);
                numOfElems++; //Increment the number of elements (guests) in the guest list
            }
            else
            {
                ok = false; //Set flag to false if guest list is full
            }

            //return status indicating successfull addition or false if unsuccessful
            return ok;
        } //end of AddNewGuest method

        /// <summary>
        /// Combines the first and the last name to creare a formatted full name.
        /// </summary>
        /// <param name="firstName">The first name of the guest.</param>
        /// <param name="lastName">The last name of the guest.</param>
        /// <returns>The formatted full name in the pattern "LASTNAME, firstname".</returns>
        private string FullName(string firstName, string lastName)
        {
            //The formatted full name in the pattern "LASTNAME, Firstname".
            //Last name to uppercase
            //First letter of first name to uppercase
            return lastName.ToUpper() + ", " + (char.ToUpper(firstName[0]) + firstName.Substring(1));

        } //end of FullName method

        /// <summary>
        /// Deleted the entry at the specifies index and adjust the guest list accordingly.
        /// </summary>
        /// <param name="index">The index of the entry to be deleted.</param>
        public void DeleteAt(int index)
        {
            //Check if the index is within the valid range befoee performing the deletion
            if (CheckIndex(index))
            {
                //Clear the entry at the given index
                guestList[index] = string.Empty;
                //Decrement the total counf of elements
                numOfElems--;
                //Move elements one step to the left to tll the emtied space
                MoveElementsOneStepLeft(index);
            }
        } //end of DeleteAt method

        /// <summary>
        /// Moved the elements in the guest list one steo to the left, staring from the provided index.
        /// </summary>
        /// <param name="index">The index from which elements need to be shifted.</param>
        private void MoveElementsOneStepLeft(int index)
        {
            //Shift elements to the left starting from the next position to the given index
            for (int i = index + 1; i < guestList.Length; i++)
            {
                //Move current element one step left
                guestList[i - 1] = guestList[i];
                //Clear the original positio of the moved element
                guestList[i] = string.Empty;
            }
        } //end of MoveElementsOneStepLeft method

        /// <summary>
        /// Retrieves and separeted the first and last names of guest at the given index.
        /// </summary>
        /// <param name="index">Index of the guest to retrieve names.</param>
        /// <returns>Tuple containing the first and last names of the guest.</returns>
        public (string firstName, string lastName) GetNames(int index)
        {
            string name = GetAt(index); //Retrieve the name at the given index
            string[] names = name.Split(','); //Split the names into first and last name
            string firstName = names[1].Trim(); //The firts name should be at index 1 after splitting
            string lastName = names[0].Trim(); //The last name should be at index 0 after splitting

            //Return the first and last names
            return (firstName, lastName);

        } //end of GetNames method

        /// <summary>
        /// Retrieves the guest information at the specifies index from the guest list.
        /// </summary>
        /// <param name="index">The idex of the guest to retrieve.</param>
        /// <returns>The guest informatio at the specified index; null if index it out of range.</returns>
        public string GetAt(int index)
        {
            //Check if the index is within range
            if (CheckIndex(index))
            {
                //Return the guest informatio at the specified index
                return guestList[index];
            }
            //If index is not within range; return null
            return null;

        } //end of GetAt method

        /// <summary>
        /// Retrieves the entire guest list.
        /// </summary>
        /// <returns>An array containing the list of guests invited to the event.</returns>
        public string[] GetGuestList()
        {

            //Get the number of guests and store it in a local variable
            int size = NumOfGuests();

            //if there are no guests, return null
            if (size <= 0)
            {
                return null;
            }
            //Creating an arrat to store the guest names
            string[] guests = new string[size];

            //Iterate through the guest list and populate the 'guests' array with the non-empty names
            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                //Check if the guest at the current index is not empty
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    //Assign the non-empty guest name to the 'guests' array and increment the index
                    guests[j++] = guestList[i];
                }
            }
            //Return the array contining non-empty guest names
            return guests;

        } //end of GetGuestList method

                /// <summary>
        /// Calculates the total costs for all invited guests based on the number of guest added to the guest list.
        /// </summary>
        /// <returns>The total cost for all the guests invited to the party.</returns>
         public double CalcTotalCost()
        {
            double totalCost = 0.0; //Variable for storing the total cost
            int numOfGuests = NumOfGuests(); //Get the number of guests as a local variable

            //Calculates the total cost
            totalCost = numOfGuests * costPerPerson;

            //Return the calulated total cost for all guests invited
            return totalCost;

        } //end of CalcTotalCost method

        /// <summary>
        /// Calculates the total fees for all invited guests based on the number of guest added to the guest list.
        /// </summary>
        /// <returns>The total fees for all the guests invited to the party.</returns>
        public double CalcTotalFees()
        {
            double totalFees = 0.0; //Variable for storing the total fees
            //Call the method to get the number of guests and store it as a local variable
            int numOfGuests = NumOfGuests(); 

            //Calculates the total fees
            totalFees = numOfGuests * feePerPerson;

            //Return the calulated total fees for all guests invited
            return totalFees;

        } //end of CalcTotalFees method

        /// <summary>
        /// Calculated the surplus or deficit by subtracting the totalcost from the total fees collected.
        /// </summary>
        /// <remarks>
        /// This method computes the difference betweeen the total fees received and and the total cost for the event.
        /// A positive value indicated a surplus, and a negative value indicated deficit.
        /// </remarks>
        /// <returns>The calculated surplus (if positive) or deficit (if negative) based on total fees and total cost.</returns>
        public double CalcSurplusDeficit()
        {
            double totalSurplusDeficit = 0.0; //Variable for storing the surplus/deficit
            //Call the method to calculte the total costs and store it as a local variable
            double totalCost = CalcTotalCost();
            //Call the method to calculte the total fees and store it as a local variable
            double totalFees = CalcTotalFees();

            //Calculate the surplus or deficit
            //Surplus if positive, and deficit if negative
            totalSurplusDeficit = totalFees - totalCost;

            //Return the calulated surplus/deficit
            return totalSurplusDeficit;

        } //end of CalcSurplusDeficit method

        /// <summary>
        /// Counts the number of guests on the guest list.
        /// </summary>
        /// <returns>The total count of guests currently invited to the event.</returns>
        public int NumOfGuests()
        {
            int numOfGuests = 0; //Variable for storing the value of number of guests

            //Iterate through the guest list to count the number of guests currently invited
            for(int i = 0; i < guestList.Length; i++)
            {
                //Check if the current guest entry (at index i) is not an empty null or string.
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    //Increment the count of non-empty guest entries
                    numOfGuests++;
                }
            }
            //Return the counted number of guests
            return numOfGuests;

        } //end of NumOfGuests method

        /// <summary>
        /// Checks if the provided index is within the valid range of the hiest list.
        /// </summary>
        /// <param name="index">The index to be checked.</param>
        /// <returns>True if the index is within the valid range; otherwise.</returns>
        public bool CheckIndex(int index)
        {
            //Ensure the index it within the valid range (0 to num of elements -1)
            if ((index >= 0) && (index < guestList.Length))
                return true;
            else 
                return false;

        } //end of CheckIndex method
    }
}
