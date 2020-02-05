/*
 CISP 405 Summer 2019 Tony Wang SID # 1443145
 
 Assignment 3 Description:
 Create another GUI but with advanced techniques
 such as learn how to create an Event Handler
 method and execute this method to an event from 
 a GUI component (i.e. listbox, combobox, etc.)
 and select the appropriate event for the 
 Event Handler method to perform its intended task.

 States.cs
 The main C# file to house the Windows Form App's code.
 This program fulfills the assignment's purpose:
 Have the user to click select a state from combobox and
 then the selected state transfers itself to listbox after
 selection. Repeat until the last state from the combobox 
 is selected and added last to the listbox, and then a 
 Message Box pops up to notify the user that no states are
 left from the combobox and the program closes itself after
 closing the Message Box.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace States
{
    public partial class States : Form
    {
        // an int counter for keeping track of number of states
        // currently left in comboBox1.
        private int numOfItems;

        // constructor
        public States()
        {
            // Windows Form is initialized.
            InitializeComponent();

           /* Originally put the state names in the comboBox1 collection 
              but I decided to use the string array provided just to prove
              the use of implementation of state names in code.*/
           string[] statesList = { "New Jersey", "Idaho", "Illinois",
         "Indiana", "Iowa", "Kansas", "Kentucky", "Maryland",
         "Massachusetts", "Michigan", "Wisconsin", "Wyoming",
         "Oregon", "Pennsylvania", "Rhode Island" };

            // comboBox1 gets all states from the stateslist string array.
            comboBox1.Items.AddRange(statesList);

            // numOfItems gets the total count of 15 states from the 
            // comboBox1 count of items.
            numOfItems = comboBox1.Items.Count;
        }

        // handles comboBox1's SelectionChangeCommitted event
        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // The selected item from comboBox1 is added to listBox1.
            listBox1.Items.Add(comboBox1.SelectedItem);

            // The selected item from comboBox1 is removed for immediate selection.
            comboBox1.Items.Remove(comboBox1.SelectedItem);

            // int counter for states subtracts by one after the selection.
            numOfItems--;

            // check if the int counter reaches to zero
            if (numOfItems == 0)
            {
                /* that comboBox1 currently holds 0 states and then a
                   Message Box pop-up to let user know that there are no states
                   left to transfer from comboBox1 to listBox1 and the user is 
                   prompted to press OK to continue. */
                MessageBox.Show("There are no more states in the ComboBox.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // App closes itself after clicking OK on the Message Box pop-up.
                Application.Exit();
            }
        }
    }
}

