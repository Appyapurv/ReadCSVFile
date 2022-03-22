using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadCSVFile
{
    class CSVReadForCrestronDevices
    {
        void Main(string[] args)
        {
            var input = new List<string>();

            var final = new List<string>();
            using (var reader = new StreamReader(@"C:\Users\aupadhyay\Desktop\Device-Request-Details1.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    input.Add(values[0]);
                }
            }

            foreach (var ss in input)
            {
                StringBuilder str = new StringBuilder();
                var s = ss.ToLower();
                var mac = s.Replace(':', '-');
                str.Append(mac + "_-1");


                //while (ss.Length > i)
                //{
                //    if (ss.Length > i)
                //    {
                //        if (i % 2 == 0 && i > 0)
                //        {
                //            //str.AppendLine(".");
                //            //str.AppendLine(ss[i].ToString());
                //            output.Add(".");
                //            output.Add(ss[i].ToString());
                //            i++;
                //        }
                //        else
                //        {
                //            //str.AppendLine(ss[i].ToString());
                //            output.Add(ss[i].ToString());
                //            i++;
                //        }
                //    }
                //}

                //StringBuilder str = new StringBuilder();
                //foreach (var item in output)
                //{
                //    str.Append(item);
                //}
                var opts = str.ToString();
                final.Add(opts);
            }

            using (var file = File.CreateText(@"C:\Users\aupadhyay\Desktop\Apurv\deviceList1.csv"))
            {
                foreach (var arr in final)
                {
                    file.WriteLine(string.Join(",", arr));
                }
            }

        }
    }
}
