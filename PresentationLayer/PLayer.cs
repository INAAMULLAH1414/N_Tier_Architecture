using System;
using BusinessObject;
using System.Collections.Generic;
namespace PresentationLayer
{
    public class PLayer
    {
        public void output(List<ElectricitySourse> obj)
        {

            foreach (var v in obj)
            {
                Console.WriteLine(v.damName + "," + v.totalCapacity + "," + v.output + "," + v.type);
            }
 }
    }
}
