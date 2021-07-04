using System;
using DataAccessLayer;
using BusinessLogic;
using BusinessObject;
using PresentationLayer;
using System.Collections.Generic;
namespace N_Tier
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PLayer presentLayer = new PLayer();
            DataLayer DAL = new DataLayer();
            BLogic bLayer = new BLogic(); 
            List<ElectricitySourse> L1 = new List<ElectricitySourse>();
            List<ElectricitySourse> L2 = new List<ElectricitySourse>();

            L1 = DAL.ReadFile();
            L2= bLayer.PowerStations(L1);
            presentLayer.output(L2);
            DAL.saveFile(L2);


        }
    }
}
