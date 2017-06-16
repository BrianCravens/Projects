using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CravensB.Project
{
    public class Patients
    {
        string patientId;

        public string PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        string dateOfBirth;

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        string race;

        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        string zip;

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        List<int> patientList = new List<int>();

        public List<int> PatientList
        {
            get { return patientList; }
            set { patientList = value; }
        }

        public Patients()
        { }

        public Patients(string id)
        {
            patientId = id;
        }

        public Patients(string id, string first, string middle, string last, string dob,
            string type, string color, string add, string cty, string st, string zipCode,
            string cuntry, string phone)
        {
            patientId = id;
            firstName = first;
            middleName = middle;
            lastName = last;
            dateOfBirth = dob;
            gender = type;
            race = color;
            address = add;
            city = cty;
            state = st;
            zip = zipCode;
            country = cuntry;
            telephone = phone;
         }
        public override string ToString()
        {
            return "ID: " + patientId + " First Name: " + firstName + "Middle Name: " + middleName +
                "Last Name: " + lastName + "DOB: " + dateOfBirth + "Gender: " + gender + "Race: " + race +
                "Address: " + address + "City: " + city + "State: " + state + "Zip: " + zip + "Country: " +
                country + "Telephone: " + telephone;
        }

        public override bool Equals(object obj)
        {
            Patients pa = (Patients)obj;
            if (this.patientId == pa.patientId)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
