#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project imports
using PersonListe.BL;
using PersonListe.DAL;

#endregion

namespace PersonListe.GUI
{
    public partial class PersonListeForm : Form
    {
        #region Class Variables

        PersonDAO personDAO = new PersonDAO();

        #endregion

        #region Class Methods

        public PersonListeForm()
        {
            InitializeComponent();         

            RefreshList();

            MessageBox.Show("constructor...");
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void RefreshList()
        {
            dgvPersons.DataSource = personDAO.RetrieveObjectsFromDB();            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Person GetSelectedPersonFromDataGridView()
        {
            Person selectedPerson = null;

            if (dgvPersons.SelectedRows.Count > 0)
            {
                selectedPerson = new Person();

                selectedPerson.RecID = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["recID"].Value);
                selectedPerson.FirstName = dgvPersons.SelectedRows[0].Cells["firstName"].Value.ToString();
                selectedPerson.LastName = dgvPersons.SelectedRows[0].Cells["lastName"].Value.ToString();
                selectedPerson.Position = dgvPersons.SelectedRows[0].Cells["position"].Value.ToString();
                selectedPerson.Age = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["age"].Value.ToString());
            }

            return selectedPerson;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string position = txtPosition.Text;
            int age = Convert.ToInt32(txtAge.Text);

            Person newPerson = new Person(firstName, lastName, position, age);

            try
            {
                personDAO.CreateObjectInDB(newPerson);
                RefreshList();
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }

            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {           

            Person selectedPerson = GetSelectedPersonFromDataGridView();

            //check that the user input is a valid
            int age = 0;
            bool convertSucceeded = int.TryParse(txtAge.Text, out age);

            if (convertSucceeded)
            {
                if (selectedPerson != null)
                {
                    selectedPerson.Age = age;
                    selectedPerson.FirstName = txtFirstName.Text;
                    selectedPerson.LastName = txtLastName.Text;
                    selectedPerson.Position = txtPosition.Text;

                    personDAO.UpdateObjectInDB(selectedPerson);
                    RefreshList();
                }
            }
            else
                MessageBox.Show("Invalid input. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPersonListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = GetSelectedPersonFromDataGridView();
            
            if (selectedPerson != null)
            {
                txtAge.Text = Convert.ToString(selectedPerson.Age);
                txtFirstName.Text = selectedPerson.FirstName;
                txtLastName.Text = selectedPerson.LastName;
                txtPosition.Text = selectedPerson.Position;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person selectedPerson = GetSelectedPersonFromDataGridView();

            if (selectedPerson != null)            
            {
                personDAO.DeleteObjectFromDB(selectedPerson);
                RefreshList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPersons_SelectionChanged(object sender, EventArgs e)
        {
            Person selectedPerson = GetSelectedPersonFromDataGridView();

            if (selectedPerson != null)
            {
                txtFirstName.Text = selectedPerson.FirstName;
                txtLastName.Text = selectedPerson.LastName;
                txtPosition.Text = selectedPerson.Position;
                txtAge.Text = selectedPerson.Age.ToString();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get search text from textbox
            string searchText = txtSearch.Text;

            //search for employee
            personDAO.CacheTable.DefaultView.RowFilter = "firstName LIKE '%" + searchText + "%' OR lastName LIKE '%" + searchText + "%' OR position LIKE '%" + searchText + "%'";

            //ask datagridview to display
            dgvPersons.DataSource = personDAO.CacheTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dgvPersons.ClearSelection();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPosition.Text = "";
            txtAge.Text = "";
        }
        
        /// <summary>
        /// Make sure that the user can only enter numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion                
    }
}
