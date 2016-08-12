using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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


        #region IWriteStaadPROable Members

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
            try
            {
                // verify if file exists
                if (File.Exists(this.path))
                {
                    #region "Si el archivo existe"
                    // comenzamos a leer en archivo base
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    String line = "";
                    StringBuilder text = new StringBuilder();
                    StringBuilder loadcm, loadcv, loadcsx, loadcsz, loadcsxv, loadcszv, pdsx, pdsz;
                    // recorremos el archivo
                    #region "While file"
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();
                        // get text
                        text.AppendLine(line);
                        line = line.Trim();
                        // validLoads(line);
                    }
                    // Validar exisistencia de 
                    // insert load cases
                    
                    #endregion
                    #endregion
                }
                else
                {
                    Console.WriteLine("El archivo no se existe en la ubicación.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        #endregion

        private void validLoads(String line)
        {
            try
            {
                switch (line)
                {
                    case "LOAD 1 CM":
                        loads[line] = true;
                        break;
                    case "LOAD 2 CV":
                        loads[line] = true;
                        break;
                    case "LOAD 3 CSX":
                        loads[line] = true;
                        break;
                    case "LOAD 4 CSZ":
                        loads[line] = true;
                        break;
                    case "LOAD 5 CSXV":
                        loads[line] = true;
                        break;
                    case "LOAD 6 CSZV":
                        loads[line] = true;
                        break;
                    case "LOAD 7 PDSX":
                        loads[line] = true;
                        break;
                    case "LOAD 8 PDSZ":
                        loads[line] = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
