using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CravensB.Project
{
    public partial class VisitForm : Form
    {
        string CurrentPatientID = string.Empty;
        PatientCollection pc;
        VisitCollection vc;
        Visits vis;
        List<int> assignVisit = new List<int>();
        int CurrentVisit = -1;
        
        public VisitForm()
        {
            InitializeComponent();
        }

        public VisitForm(string patientId)
        {
            InitializeComponent();

            CurrentPatientID = patientId; 
        }


        private void VisitForm_Load(object sender, EventArgs e)
        {
            txtVisitPatientId.Text = CurrentPatientID;
            LoadPatientVisits();

        }

        public VisitCollection VisitCol
        {
            get { return vc; }
            set { vc = value; }
        }

        public string PatientId
        {
            set { CurrentPatientID = value; }
        }

        private void LoadPatientVisits()
        {
            foreach (Visits v in vc.VisitList)
            {
                if (v.PId.Equals(CurrentPatientID))
                {
                    cboVisitDates.Items.Add(v.VisitDate);
                }
            }
                

        }

        private bool VisitInfoEntered()
        {
            bool allEntered = false;

            if (txtVisitId.Text.Length > 0 &&
                txtVisitDate.Text.Length > 0 &&
                txtPhysician.Text.Length > 0 &&
                txtLocation.Text.Length > 0 &&
                txtVisitPatientId.Text.Length > 0)
            {
                allEntered = true;
            }

            return allEntered;
        }

        private void ClearVisitFields()
        {
            txtDescription.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtPhysician.Text = string.Empty;
            txtVisitDate.Text = string.Empty;
            txtVisitId.Text = string.Empty;
            txtVisitPatientId.Text = string.Empty;
        }

        private void cboVisitDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVisitDates.SelectedIndex > -1)
            {
                foreach (Visits v in vc.VisitList)
                { 
                    if(v.PId.Equals(CurrentPatientID))
                    {
                       if (v.VisitDate.Equals(cboVisitDates.SelectedItem))
                       {
                        CurrentVisit = vc.VisitList.IndexOf(v);
                        txtDescription.Text = v.Description;
                        txtLocation.Text = v.Location;
                        txtPhysician.Text = v.Physician;
                        txtVisitDate.Text = v.VisitDate;
                        txtVisitId.Text = v.VisitId;
                        txtVisitPatientId.Text = v.PId;
                       }
                  }
              }
          }                        
      }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VisitInfoEntered())
            {
                vc.AddVisit(CurrentPatientID, txtVisitId.Text,
                    txtVisitDate.Text, txtLocation.Text, txtPhysician.Text, txtDescription.Text);

                cboVisitDates.Items.Add(txtVisitDate.Text);

                MessageBox.Show("Visit Added!");
            }
            else
            {
                MessageBox.Show("Not all information entered. Visit cannot be added!!");
            }
        }
            

        private void btnRemoveVisit_Click(object sender, EventArgs e)
        {
            if (txtVisitId.Text.Length > 0)
            {
                vc.RemoveVisit(txtVisitId.Text);

                ClearVisitFields();

                MessageBox.Show("Visit has been removed!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtVisitDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhysician_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVisitId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void txtVisitPatientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClearVisit_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();    
            txtLocation.Clear(); 
            txtPhysician.Clear();
            txtVisitDate.Clear(); 
            txtVisitId.Clear();
            txtVisitPatientId.Clear();

        }

        
    }
}
