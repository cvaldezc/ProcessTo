using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Controller
{
    public class WriteStaadPRO : Interfaces.IWriteStaadPROable
    {
        /// <summary>
        /// Params
        /// path : Address file base where overwrite 
        /// destiny : Address file destiny
        /// </summary>
        /// 
        public String path = "";
        public String destiny = "";
        private Dictionary<string, bool> loads = new Dictionary<string, bool>()
        {
            {"LOAD 1 CM", false},
            {"LOAD 2 CV", false},
            {"LOAD 3 CSX", false},
            {"LOAD 4 CSZ", false},
            {"LOAD 5 CSXV", false},
            {"LOAD 6 CSZV", false},
            {"LOAD 7 PDSX", false},
            {"LOAD 8 PDSZ", false},
        };
        private StringBuilder loadcm = new StringBuilder();
        private StringBuilder loadcv = new StringBuilder();
        private StringBuilder loadcsx = new StringBuilder();
        private StringBuilder loadcsz = new StringBuilder();
        private StringBuilder loadcsxv = new StringBuilder();
        private StringBuilder loadcszv = new StringBuilder();
        private StringBuilder loadpdsx = new StringBuilder();
        private StringBuilder loadpdsz = new StringBuilder();
        private StringBuilder Text = new StringBuilder();
        private StringBuilder combos = new StringBuilder();

        #region IWriteStaadPROable Members

        public StringBuilder readFile()
        {
            StringBuilder block = new StringBuilder();
            if (File.Exists(this.path))
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                try
                {
                    // verify if file exists
                
                        #region "Si el archivo existe"
                        // comenzamos a leer en archivo base
                        String line = "";
                        // recorremos el archivo
                        #region "While file"
                        while (sr.Peek() >= 0)
                        {
                            line = sr.ReadLine();
                            // get text
                            block.AppendLine(line);
                            // validLoads(line);
                        }
                        // Validar exisistencia de 
                        // insert load cases
                        #endregion
                        #endregion
                
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Error : " + ex.Message);
                }
                finally
                {
                    fs.Close();
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("El archivo no se existe en la ubicación.");
            }
            return block;
        }

        public void processAisladoSTD()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        public void processNoAisladoSTD()
        {
            //try
            //{
                // init Text
                this.Text = readFile();
                // load Data
                preload();
                // agregar LOAD CM
                loadcm.AppendLine("LOAD 2 CV");
                Text.Replace("LOAD 2 CV", loadcm.ToString());
                // agregar LOAD CV
                loadcv.AppendLine("LOAD 3 CSX");
                Text.Replace("LOAD 3 CSX", loadcv.ToString());
                // agregar LOAD CSX
                Text.Replace("LOAD 3 CSX", "LOAD 3 CSX\r\n" + loadcsx.ToString());
                // agregar LOAD CSZ
                Text.Replace("LOAD 4 CSZ", "LOAD 4 CSZ\r\n" + loadcsz.ToString());
                // agregar LOAD CSXV
                loadcsxv.AppendLine("PRINT PROBLEM STATISTICS");
                Text.Replace("PRINT PROBLEM STATISTICS", "LOAD 5 CSXV\r\n" + loadcsxv.ToString());
                // agregar LOAD CSZV
                loadcszv.AppendLine("PRINT PROBLEM STATISTICS");
                Text.Replace("PRINT PROBLEM STATISTICS", "LOAD 6 CSZV\r\n" + loadcszv.ToString());
                // agregar LOAD PDSX
                loadpdsx.AppendLine("PRINT PROBLEM STATISTICS");
                Text.Replace("PRINT PROBLEM STATISTICS", "LOAD 7 PDSX\r\n" + loadpdsx.ToString());
                // agregar LOAD PDSZ
                loadpdsz.AppendLine("PRINT PROBLEM STATISTICS");
                Text.Replace("PRINT PROBLEM STATISTICS", "LOAD 8 PDSZ\r\n" + loadpdsz.ToString());
                // agregar combos
                combos.AppendLine("LOAD COMB 9 1.4CM+1.7CV");
                combos.AppendLine("1 1.4 2 1.7 ");
                combos.AppendLine("LOAD COMB 10 1.25CM+1.25CV+CSX+PD");
                combos.AppendLine("1 1.25 2 1.25 3 1.0 5 1.0 7 1.0");
                combos.AppendLine("LOAD COMB 11 1.25CM+1.25CV +CSZ+PD");
                combos.AppendLine("1 1.25 2 1.25 4 1.0 6 1.0 8 1.0");
                combos.AppendLine("LOAD COMB 12 1.25CM+1.25CV-CSX-PD");
                combos.AppendLine("1 1.25 2 1.25 3 1.0 5 -1.0 7 -1.0 ");
                combos.AppendLine("LOAD COMB 13 1.25CM+1.25CV-CSZ-PD");
                combos.AppendLine("1 1.25 2 1.25 4 1.0 6 -1.0 8 -1.0 ");
                combos.AppendLine("LOAD COMB 14 0.9CM-CSX-PD");
                combos.AppendLine("1 0.9 3 -1.0 5 1.0 7 -1.0");
                combos.AppendLine("LOAD COMB 15 0.9CM+CSX+PD");
                combos.AppendLine("1 0.9 3 1.0 5 1.0 7 1.0 ");
                combos.AppendLine("LOAD COMB 16 0.9CM-SZ-PD");
                combos.AppendLine("1 0.9 4 -1.0 6 1.0 8 -1.0");
                combos.AppendLine("LOAD COMB 17 0.9CM+CSZ+PD");
                combos.AppendLine("1 0.9 4 1.0 6 1.0 8 1.0");
                combos.AppendLine("LOAD COMB 18 CM+CV");
                combos.AppendLine("1 1.0 2 1.0");
                combos.AppendLine("PRINT PROBLEM STATISTICS");
                Text.Replace("PRINT PROBLEM STATISTICS", combos.ToString());
                //Escribiendo archivo Aislado
                // obtener nombre de archivo
                string[] par = this.path.Split(new char[] { '\\' });
                String direccion = destiny;
                direccion += String.Format(@"\{0} - NoAislado.std", (par[par.Length - 1].Split(new char[] {'.'}).First()));
                StreamWriter write = new StreamWriter(direccion, false, Encoding.ASCII);
                write.Write(Text.ToString());
                write.Close();
                Console.WriteLine("FINISH WRITE FILE!!!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        #endregion

        //private void validLoads(String line)
        //{
        //    try
        //    {
        //        switch (line)
        //        {
        //            case "LOAD 1 CM":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 2 CV":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 3 CSX":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 4 CSZ":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 5 CSXV":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 6 CSZV":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 7 PDSX":
        //                loads[line] = true;
        //                break;
        //            case "LOAD 8 PDSZ":
        //                loads[line] = true;
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        private void preload()
        {
            //loadcm = new StringBuilder();
            //loadcv = new StringBuilder();
            //loadcsx = new StringBuilder();
            //loadcsz = new StringBuilder();
            //loadcsxv = new StringBuilder();
            //loadcszv = new StringBuilder();
            //loadpdsx = new StringBuilder();
            //loadpdsz = new StringBuilder();
            // llenar los datos
            foreach (DataRow row in Model.MDStaadPRO.dtGlobal.Rows)
            {
                // carga muerta CM
                loadcm.AppendLine(String.Format("{0} FY -{1}", row["nodo"], row["cm"]));
                // carga viva CV
                loadcv.AppendLine(String.Format("{0} FY -{1}", row["nodo"], row["cv"]));
                // carga CSX
                loadcsx.AppendLine(String.Format("{0} FX {1}", row["nodo"], row["csx"]));
                // carga CSZ
                loadcsz.AppendLine(String.Format("{0} FZ {1}", row["nodo"], row["csz"]));
                // carga CSXV
                loadcsxv.AppendLine(String.Format("{0} FY -{1}", row["nodo"], row["csxv"]));
                //carga CSZV
                loadcszv.AppendLine(String.Format("{0} FY -{1}", row["nodo"], row["cszv"]));
                // carga PDSX
                loadpdsx.AppendLine(String.Format("{0} MZ -{1}", row["nodo"], row["pdsx"]));
                // carga PDSZ
                loadpdsz.AppendLine(String.Format("{0} MX {1}", row["nodo"], row["pdsz"]));
            }
        }
    }
}
