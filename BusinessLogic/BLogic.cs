using System;
using System.Collections.Generic;

using BusinessObject;
namespace BusinessLogic
{
    public class BLogic
    {
        public bool function(int total,int output)
        {
            try
            {
                double x = (Convert.ToDouble(output) / Convert.ToDouble(total));
                if (x < 0.5)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            return false;
        }

        public List <ElectricitySourse> PowerStations (List<ElectricitySourse> output)
        {
            List< ElectricitySourse> object1 = output;
            List<ElectricitySourse> result = new List<ElectricitySourse>();
            foreach (var v in object1 )
                {
                int x = v.totalCapacity;
                int y = v.output;

                if (function(x, y))
                {
                    result.Add(v);
                }
                
                }
            return result;
        }
    }
}
