using System;
using System.IO;
using BusinessObject;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class DataLayer
    {

        public void saveFile(List<ElectricitySourse> l)
        {
            FileStream File = null;
            StreamWriter sw=null;

            try
            {
                File = new FileStream("new.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(File);
                foreach (var Obj in l)
                {
                    sw.WriteLine(Obj.damName + "," + Obj.totalCapacity + "," + Obj.output + "," + Obj.type);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);            }
            finally
            {
                sw.Close();
                File.Close();
            }

            
        }

        public List<ElectricitySourse> ReadFile()
        {
            FileStream File = null;
            StreamReader sr = null;
            List<ElectricitySourse> listofPS = null;

            try
            {
                listofPS= new List<ElectricitySourse>();

                File = new FileStream(@"Data.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(File);
                string strdata = sr.ReadLine();

                while (strdata != null)
                {

                    ElectricitySourse tempEmp = new ElectricitySourse();
                    string[] ary = strdata.Split(',');
                    tempEmp.damName = Convert.ToString(ary[0]);
                    tempEmp.totalCapacity = Convert.ToInt32(ary[1]);
                    tempEmp.output = Convert.ToInt32(ary[2]);
                    tempEmp.type = Convert.ToString(ary[3]);
                    listofPS.Add(tempEmp);

                    strdata = sr.ReadLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {



                sr.Close();
                File.Close();


            }



            return listofPS;

        }

    }
}
