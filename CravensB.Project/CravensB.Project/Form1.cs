using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace CravensB.Project
{
    public partial class PatientForm : Form
    {
        VisitCollection vc;
        PatientCollection pc;
        int currRecord = 0;
        string currPatientID = string.Empty;

        bool patientFound = false;

        public PatientForm()
        {
            InitializeComponent();
        }

        public PatientForm(PatientCollection pcPassed)
        {
            pc = pcPassed;
            InitializeComponent();
        }
        private void btnVisits_Click(object sender, EventArgs e)
        {
            int j = -1;
            bool patientFound = false;

            for (int i = 0; i < pc.Count; i++)
            {
                if (pc[i].PatientId == txtPatientID.Text)
                {
                    j = i;
                    patientFound = true;
                }
            }
            if (patientFound)
            {
                VisitForm formc = new VisitForm();
                formc.PatientId = pc[j].PatientId;
                formc.VisitCol = vc;
                formc.ShowDialog();
                // set the visits collection to the updated
                // version on the visits form so it can be saved
                // when exit is clicked

                vc = formc.VisitCol;
            }
            else
            {
                // show message the patient does not match
                MessageBox.Show("Patient must be found or added to edit patient or visit info ");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //save files
            XmlSerializer xsPatients = new XmlSerializer(typeof(PatientCollection));
            TextWriter twPatients = new StreamWriter("patients.xml");
            xsPatients.Serialize(twPatients, pc);
            twPatients.Close();

            XmlSerializer xsVisits = new XmlSerializer(typeof(VisitCollection));
            TextWriter twVisits = new StreamWriter("visits.xml");
            xsVisits.Serialize(twVisits, vc);
            twVisits.Close();

            Application.Exit();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // check and load patients collection from xml
            if (File.Exists("patients.xml"))
            {
                XmlSerializer xsPatients = new XmlSerializer(typeof(PatientCollection));
                TextReader trPatients = new StreamReader("patients.xml");
                pc = (PatientCollection)xsPatients.Deserialize(trPatients);
                trPatients.Close();
            }
            else pc = new PatientCollection();
            // if the file had no patients or the file did not exists, the collection
            // will be null
            if (pc == null)
            {
                pc = new PatientCollection();
            }
            // check and load visits collection from xml
            if (File.Exists("visits.xml"))
            {
                XmlSerializer xsVisits = new XmlSerializer(typeof(VisitCollection));
                TextReader trVisits = new StreamReader("visits.xml");
                vc = (VisitCollection)xsVisits.Deserialize(trVisits);
                trVisits.Close();
            }
            // if the file had no visits or the file did not exists, the collection
            // will be null
            if (vc == null)
            {
                vc = new VisitCollection();
            }
        }

        public void DisplayPatientInfo()
        {
            txtPatientID.Text = pc[currRecord].PatientId;
            txtFirstName.Text = pc[currRecord].FirstName;
            txtMiddleName.Text = pc[currRecord].MiddleName;
            txtLastName.Text = pc[currRecord].LastName;
            txtDateOfBirth.Text = pc[currRecord].DateOfBirth;
            txtGender.Text = pc[currRecord].Gender;
            txtRace.Text = pc[currRecord].Race;
            txtAddress.Text = pc[currRecord].Address;
            txtCity.Text = pc[currRecord].City;
            txtState.Text = pc[currRecord].State;
            txtZipCode.Text = pc[currRecord].Zip;
            txtCountry.Text = pc[currRecord].Country;
            txtTelephone.Text = pc[currRecord].Telephone;
        }

        private bool PatientInfoEntered()
        {
            bool infoEntered = false;

            if (txtPatientID.Text.Length > 0 &&
            txtFirstName.Text.Length > 0 &&
            txtMiddleName.Text.Length > 0 &&
            txtLastName.Text.Length > 0 &&
            txtDateOfBirth.Text.Length > 0 &&
            txtGender.Text.Length > 0 &&
            txtRace.Text.Length > 0 &&
            txtAddress.Text.Length > 0 &&
            txtCity.Text.Length > 0 &&
            txtState.Text.Length > 0 &&
            txtZipCode.Text.Length > 0 &&
            txtCountry.Text.Length > 0)
            {
                infoEntered = true;
            }

            return infoEntered;
        }

        private void ClearPatientFields()
        {
            txtPatientID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtRace.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtTelephone.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (PatientInfoEntered())
            {
                pc.AddPatients(txtPatientID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                    txtDateOfBirth.Text, txtGender.Text, txtRace.Text, txtAddress.Text, txtCity.Text,
                    txtState.Text, txtZipCode.Text, txtCountry.Text, txtTelephone.Text);

                //reset before looking up patient in collection
                //verifying the patient was added
                patientFound = false;
                currRecord = -1;
                currPatientID = string.Empty;

                foreach (Patients p in pc.PatList)
                {
                    if (p.PatientId == txtPatientID.Text)
                    {
                        patientFound = true;
                        currRecord = pc.PatList.IndexOf(p);
                        currPatientID = p.PatientId;
                    }
                }

                if (patientFound)
                {
                    MessageBox.Show("Patient added.");
                }
                else
                {
                    MessageBox.Show("All patient info must be entered  before you can add!!.");
                }
            }
        }
        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pc.RemovePatients(txtPatientID.Text);

            MessageBox.Show("Patient removed.");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            patientFound = false;

            if (pc.Count > 0)
            {
                foreach (Patients p in pc.PatList)
                {
                    if (p.PatientId.Equals(txtPatientID.Text.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        currRecord = pc.PatList.IndexOf(p);
                        patientFound = true;
                        currPatientID = p.PatientId;
                        DisplayPatientInfo();
                    }
                }

                if (!patientFound)
                {
                    MessageBox.Show("Patient ID not found");
                }
            }
            else
            {
                MessageBox.Show("No patients exists");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (patientFound)
            {
                pc.UpdatePatients(txtPatientID.Text,
                                  txtFirstName.Text,
                                  txtMiddleName.Text,
                                  txtLastName.Text,
                                  txtDateOfBirth.Text,
                                  txtGender.Text,
                                  txtRace.Text,
                                  txtAddress.Text,
                                  txtCity.Text,
                                  txtState.Text,
                                  txtZipCode.Text,
                                  txtCountry.Text,
                                  txtTelephone.Text);
            }

            MessageBox.Show("Patient Updated.");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                                  txtPatientID.Clear();
                                  txtFirstName.Clear();
                                  txtMiddleName.Clear();
                                  txtLastName.Clear();
                                  txtDateOfBirth.Clear();
                                  txtGender.Clear();
                                  txtRace.Clear();
                                  txtAddress.Clear();
                                  txtCity.Clear();
                                  txtState.Clear();
                                  txtZipCode.Clear();
                                  txtCountry.Clear();
                                  txtTelephone.Clear();

        }


    }
    
}
