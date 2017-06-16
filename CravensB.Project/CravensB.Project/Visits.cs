using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CravensB.Project
{
    public class Visits
    {
        string pId;

        public string PId
        {
            get { return pId; }
            set { pId = value; }
        }

        string visitId;

        public string VisitId
        {
            get { return visitId; }
            set { visitId = value; }
        }

        
        string visitDate;

        public string VisitDate
        {
            get { return visitDate; }
            set { visitDate = value; }
        }
        string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        string physician;

        public string Physician
        {
            get { return physician; }
            set { physician = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Visits()
        { }

        public Visits(string id)
        {
            visitId = id;
        }

        public Visits(string Patient, string id, string date, string hospital, string doctor, string desc)
        {
            pId = Patient;
            visitId = id;
            visitDate = date;
            location = hospital;
            physician = doctor;
            description = desc;
        }

        public override bool Equals(object obj)
        {
            Visits v = (Visits)obj;
            if (this.visitId == v.visitId)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "Patient ID: " + pId + "Visit ID: " + visitId + "Date: " + visitDate + "Location: " + location +
                "Physician: " + physician + "Description: " + description;
            
         }
    }
}
