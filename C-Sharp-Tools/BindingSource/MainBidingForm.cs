using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSource
{
    public partial class MainBidingForm : Form
    {
        public MainBidingForm()
        {
            InitializeComponent();

            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));

            bindingobj.DataSource = new List<User>();

            AddNew();
            
        }

        /// <summary>
        /// Initialize the Source Binding and creating collections
        /// </summary>
        /// <param name="user"></param>
        private void AddNew()
        {
            bindingobj.AddNew();

            //Clears all the data
            textFirst.DataBindings.Clear();
            textLast.DataBindings.Clear();
            comboBoxGender.DataBindings.Clear();
            textJob.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            labelFullName.DataBindings.Clear();
            buttonSave.DataBindings.Clear();

            //Creating the binding structure
            textFirst.DataBindings.Add("Text", bindingobj, "FirstName");
            textLast.DataBindings.Add("Text", bindingobj, "LastName");
            comboBoxGender.DataBindings.Add("SelectedItem", bindingobj, "Gender");
            textJob.DataBindings.Add("Text", bindingobj, "JobTitle");
            dateTimePicker1.DataBindings.Add("Value", bindingobj, "DateOfBirth");            labelFullName.DataBindings.Add("Text", bindingobj, "FullName");

            buttonSave.DataBindings.Add("Enabled", bindingobj, "IsInputValid");
        }
        


        private void Save()
        {
            User _currentUser = (User)bindingobj.Current;
            if (_currentUser != null)
            {
                if (_currentUser.IsInputValid)
                {
                    if (_currentUser.IsAgeValid)
                    {
                        bindingobj.Add(_currentUser);
                        AddNew();
                    }
                    else
                        MessageBox.Show("Too young :/");
                }
                else
                    MessageBox.Show("You're missing some details");
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void labelFullName_Click(object sender, EventArgs e)
        {

        }
    }
}
