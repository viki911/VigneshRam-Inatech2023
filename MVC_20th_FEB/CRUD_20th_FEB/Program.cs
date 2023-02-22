using CoreEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEM
{
    internal class Program
    {
        public static void Create()
        {
            using (var dbconnect = new LeagueContext()) 
            {
                League tmt = new League();
                tmt.Teams = "PBKS";
                dbconnect.Add(tmt);
                tmt = new League();
                tmt.Teams = "SRH";
                dbconnect.Add(tmt);
                tmt = new League();
                tmt.Teams = "RR";
                dbconnect.Add(tmt);
                tmt = new League();
                tmt.Teams = "DC";
                dbconnect.Add(tmt);
                dbconnect.SaveChanges();
            }
            return;
        }

        public static void Update()
        {
            using(var dbconnect = new LeagueContext()) 
            {
                League? l = dbconnect.League.Find(6);
                l.Teams = "LSP";
                dbconnect.SaveChanges() ;
            }
        }

        public static void Read()
        {
            using(var dbconnect = new LeagueContext()) 
            {
                foreach(var le in dbconnect.League) { Console.WriteLine(le.Id +" "+le.Teams); }
            }
        }

        public static void Del()
        {
            using(var dbconnect = new LeagueContext()) 
            {
                League ?l = dbconnect.League.Find(7);
                dbconnect.League.Remove(l);
                dbconnect.SaveChanges();
            }
        }
        public static void Main(string[] args) 
        {
            Create();
            Update();
            Del();
            Read();
        }
    }
}
