# Party Organizer

A Windows Forms application for organizing parties. This application allows you to manage guest lists, calculate costs, and handle party details efficiently.

## Features

- **Create Party**: Set up a new party with a maximum number of guests, cost per person, and fee per person.
- **Add Guest**: Add new guests to the party.
- **Change Guest**: Modify details of an existing guest.
- **Delete Guest**: Remove a guest from the list.
- **View Details**: See a list of guests, total cost, total fees, and surplus or deficit.

## Usage

1. **Create a Party**
   - Enter the maximum number of guests, cost per person, and fee per person.
   - Click the "Create List" button to initialize the party.
   - The system will allow you to invite guests if the setup is valid.

2. **Add Guests**
   - Enter the first and last name of the guest.
   - Click the "Add" button to include the guest in the list.

3. **Change Guest Details**
   - Select the guest from the list.
   - Edit the guest’s first and last names.
   - Click the "Change" button to update the details.

4. **Delete a Guest**
   - Select the guest from the list.
   - Click the "Delete" button to remove them from the party.
  
5. **View summary**
   - The total number of guests, total cost, total fees, and surplus/deficit are displayed.

## Code Structure

- **MainForm.cs**: Contains the main logic for handling user input, performing calculations, and updating the GUI.

- **PartyManager.cs**: Manages party details, guest list, and calculations.
