using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CravensB.Project
{
    public class PatientCollection
    {
        List<Patients> patList = new List<Patients>();

        public List<Patients> PatList
        {
            get { return patList; }
            set { patList = value; }
        }

        public void AddPatients(string id, string first, string middle, string last, string dob,
            string type, string color, string add, string cty, string st, string zipCode,
            string cuntry, string phone)
        {
            Patients pa = new Patients(id, first, middle, last, dob, type, color, add, cty, st, zipCode, cuntry, phone);
            patList.Add(pa);
        }

        public void RemovePatients(string id)
        {
            Patients rem = new Patients(id);
            patList.Remove(rem);
        }

        public bool UpdatePatients(string id, string first, string middle, string last, string dob,
            string type, string color, string add, string cty, string st, string zipCode,
            string cuntry, string phone)
        {
            bool success = false;
            Patients upd = new Patients(id);
            for(int i=0; i<patList.Count; i++)
                if (patList[i].Equals(upd))
                {
                    patList[i].FirstName = first;
                    patList[i].MiddleName = middle;
                    patList[i].LastName = last;
                    patList[i].DateOfBirth = dob;
                    patList[i].Gender = type;
                    patList[i].Race = color;
                    patList[i].Address = add;
                    patList[i].City = cty;
                    patList[i].State = st;
                    patList[i].Zip = zipCode;
                    patList[i].Country = cuntry;
                    patList[i].Telephone = phone;
                    success = true;
                }
            return success;


        }

        public Patients Lookup(string id)
        {
            Patients find = new Patients(id);
            for (int i = 0; i < patList.Count; i++)
                if (patList[i].Equals(find))
                    return patList[i];
            return null;
        }

        public int Count
        {
            get { return patList.Count; }
        }

        public Patients this[int i]
        {
            get { return patList[i]; }
            set { patList[i] = value; }
        }

        public void AddToVisitList(string id, int idAdd)
        {
            Patients find = new Patients(id);
            for (int i = 0; i < patList.Count; i++)
                if (patList[i].Equals(find))
                    patList[i].PatientList.Add(idAdd);
        }

        public void RemoveFromVisitList(string id, int idRem)
        {
            Patients find = new Patients(id);
            for (int i = 0; i < patList.Count; i++)
                if (patList[i].Equals(find))
                    patList[i].PatientList.Remove(idRem);
        }







    }
}
