using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using Controller.Interfaces;
using Model;


namespace Controller
{
    public class ReadFileStaadPRO : IReadFileStaadProable
    {
        // Parameters
        private FileStream fs;
        private StreamReader read;
        public double participacion;
        public string path;
        public double delta;

        #region IReadFileable Members

        public void ReadStaadPro()
        {
            Model.MDStaadPRO.init();
            fs = new FileStream(@path, FileMode.Open, FileAccess.Read);
            read = new StreamReader(fs, Encoding.UTF8);
            //try
            //{
                String node = "";
                while(read.Peek() >= 0)
                {
                    String cad = read.ReadLine();
                    Console.WriteLine(cad);
                    // Console.WriteLine(cad);
                    string pattern = @"\s+";
                    string[] line = Regex.Split(cad, pattern);
                    if (line.Length == 10 && line[2].ToString() == "1:CM")
                    {
                        // crea nuevo nodo
                        DataRow dr = Model.MDStaadPRO.dtGlobal.NewRow();
                        node = Convert.ToString(line[1]);
                        double dead = Math.Abs(Convert.ToDouble(line[4]));
                        dr["nodo"] = node;
                        dr["cm"] = dead;
                        dr["sv"] = (dead * this.participacion);
                        Model.MDStaadPRO.dtGlobal.Rows.Add(dr);
                    }
                    if (line.Length == 9)
                    {
                        Console.WriteLine("fila leida " + line[1].Split(':')[0].ToString().Trim());
                        if (Convert.ToInt16(line[1].Split(':')[0].ToString().Trim()) > 4)
                            continue;
                        string nodo = String.Format("nodo='{0}'", node);
                        DataRow[] drs = Model.MDStaadPRO.dtGlobal.Select(nodo);
                        if (drs.Length > 0)
                        {
                            List<object[]> lst = rowData(line, line[1].Split(new char[] {':'}).Last().ToString().Trim());
                            foreach (object[] row in lst)
                            {
                                if (row[0].ToString() == "csxv" || row[0].ToString() == "cszv")
                                {
                                    double csv = (Math.Abs(Convert.ToDouble(row[1])) + Convert.ToDouble(drs[0]["sv"]));
                                    drs[0][row[0].ToString()] = csv;
                                    // formula para pdelta
                                    double dead = Convert.ToDouble(drs[0]["cm"]);
                                    double live = Convert.ToDouble(drs[0]["cv"]);
                                    if (row[0].ToString() == "csxv")
                                        //Math.Round((((dead + (0.5 * live) + fzx + sv) * delta) / 2), 2);
                                        drs[0]["pdsx"] = Math.Round((((dead + (0.5 * live) + csv) * delta) / 2), 2);

                                    if (row[0].ToString() == "cszv")
                                        //Math.Round((((dead + (0.5 * live) + fzx + sv) * delta) / 2), 2);
                                        drs[0]["pdsz"] = Math.Round((((dead + (0.5 * live) + csv) * delta) / 2), 2); 
                                }
                                else
                                    drs[0][row[0].ToString()] = Math.Abs(Convert.ToDouble(row[1]));
                            }
                            Model.MDStaadPRO.dtGlobal.AcceptChanges();
                        }
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("ERRORR");
            //    Console.WriteLine( ex.Message.ToString() );
            //}
            //finally
            //{
            //    close();        
            //}
            close();
        }

        private List<object[]> rowData(object[] row, String carga)
        {
            List<object[]> lst = new List<object[]>();
            try
            {
                object[] obj = new object[2];
                switch (carga)
                {
                    case "CV":
                        obj[0] = "cv";
                        obj[1] = Convert.ToDouble(row[3]);
                        break;
                    case "CSX":
                        obj[0] = "csx";
                        obj[1] = Convert.ToDouble(row[2]);
                        break;
                    case "CSZ":
                        obj[0] = "csz";
                        obj[1] = Convert.ToDouble(row[4]);
                        break;
                }
                lst.Add(obj);
                obj = new object[2];
                switch (carga)
                {
                    case "CSX":
                        obj[0] = "csxv";
                        obj[1] = Convert.ToDouble(row[3]);
                        lst.Add(obj);
                        break;
                    case "CSZ":
                        obj[0] = "cszv";
                        obj[1] = Convert.ToDouble(row[3]);
                        lst.Add(obj);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lst;
        }

        public void test()
        {
            for (int i = 0; i < Model.MDStaadPRO.dtGlobal.Rows.Count; i++)
            {
                for (int j = 0; j < Model.MDStaadPRO.dtGlobal.Columns.Count; j++)
                {
                    Console.Write(Model.MDStaadPRO.dtGlobal.Rows[i][j].ToString());
                    Console.Write(", ");
                }
                Console.WriteLine("");
            }
        }

        public void close()
        {
            read.Close();
            fs.Close();
        }

        #endregion
    }
}
