using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CravensB.Project
{
    public class VisitCollection
    {
        List<Visits> visitList = new List<Visits>();

        public List<Visits> VisitList
        {
            get { return visitList; }
            set { visitList = value; }
        }

        public void AddVisit(string pId, string id, string date, string hospital, string doctor, string desc)
        {
            Visits v = new Visits(pId, id, date, hospital, doctor, desc);
            visitList.Add(v);
        }

        public void RemoveVisit(string id)
        {
            Visits rem = new Visits(id);
            visitList.Remove(rem);
        }

        public Visits FindVisit(string id)
        {
            Visits find = new Visits(id);
            for (int i = 0; i < visitList.Count; i++)
                if (visitList[i].Equals(find))
                    return visitList[i];
            return null;
        }

        public int Count
        {
            get { return visitList.Count; }
        }

        public Visits this[int i]
        {
            get { return visitList[i]; }
            set { visitList[i] = value; }
        }

    }
}
