// StatesForm.cs
// Using a ComboBox and a ListBox.
using System;
using System.Windows.Forms;

namespace States
{
   public partial class StatesForm : Form
   {
      // constructor
      public StatesForm()
      {
         // this call is required by the Windows Form Designer
         InitializeComponent();

         // Add any initialization after the InitializeComponent() call
         string[] states = { "New Jersey", "Idaho", "Illinois",
         "Indiana", "Iowa", "Kansas", "Kentucky", "Maryland",
         "Massachusetts", "Michigan", "Wisconsin", "Wyoming",
         "Oregon", "Pennsylvania", "Rhode Island" };

         statesComboBox.Items.AddRange( states );
      } // end constructor

      // handles statesComboBox's SelectedIndexChanged event
      private void statesComboBox_SelectedIndexChanged(
         object sender, EventArgs e )
      {
         // add the selected item to the ListBox
         statesListBox.Items.Add( statesComboBox.SelectedItem );

         // remove the selected item from the ComboBox.
         statesComboBox.Items.RemoveAt( statesComboBox.SelectedIndex );

         // check if ComboBox is now empty
         if ( statesComboBox.Items.Count == 0 )
         {
            MessageBox.Show( "There are no more states in the " +
               "ComboBox.", "Empty", MessageBoxButtons.OK,
               MessageBoxIcon.Information );

            // terminate program execution
            Application.Exit();
         } // end if
      } // end method statesComboBox_SelectedIndexChanged
   } // end class StatesForm
} // end namespace States