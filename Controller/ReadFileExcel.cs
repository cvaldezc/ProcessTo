using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Controller.Interfaces;
using Model;

namespace Controller
{
    public class ReadFileExcel : IReadFileExcelable
    {
        private Excel.Application app;
        private Excel.Workbook book;
        private Excel.Worksheet sheet;

        public ReadFileExcel(string path)
        {
            try
            {
                app = new Excel.Application();
                if (app == null)
                {
                    MessageBox.Show(null, "Se ha producido un error al iniciar la aplicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                book = app.Workbooks.Open(@path,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch(System.IO.IOException ex){
                MessageBox.Show(null, ex.Message.ToString(), "Error path IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message.ToString(), "Error GENERAl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region IReadFileExcelable Members
        
        public void selectSheet(String Name)
        {
            sheet = (Excel.Worksheet)book.Sheets[Name];
        }

        public void readETabs(String story)
        {
            //try
            //{
                // validando columnas y nombre de hoja
                // Selecciona hoja global
                //this.selectSheet("GLOBAL INPUT");
                if (sheet.Columns.Count >= 10)
                {
                    Model.Model.init();
                    // recoremos las filas que contenga la hoja de excel
                    #region ""Recorrido de la hoja de excel"
                    for (int i = 3; i < sheet.Rows.Count; i++)
                    {
                        if (sheet.Cells[i, 2].Value2 == null)
                        {
                            break;
                        }
                        string join = String.Format("joint='{0}'", sheet.Cells[i, 2].Value);
                        DataRow[] drs = Model.Model.dtGlobal.Select(join);
                        // drs = ds.Tables["GLOBAL"].Select(join);
                        if (drs.Length > 0)
                        {
                            List<object[]> lst = rowData(i);
                            foreach (object[] item in lst)
                            {
                                drs[0][item[0].ToString()] = Math.Abs(Convert.ToDouble(item[1]));
                            }
                            Model.Model.dtGlobal.AcceptChanges();
                        }
                        else
                        {
                            DataRow dr = Model.Model.dtGlobal.NewRow();
                            dr["story"] = story != "" ? story : sheet.Cells[i, 1].Value;
                            dr["joint"] = sheet.Cells[i, 2].Value;
                            List<object[]> lst = rowData(i);
                            foreach (object[] item in lst)
                            {
                                dr[item[0].ToString()] = Math.Abs(Convert.ToDouble(item[1]));
                            }

                            Model.Model.dtGlobal.Rows.Add(dr);
                        }
                    }
                    #endregion
                    // ds.Tables.Add(dtg);
                }
                else
                {
                    MessageBox.Show(null, "La hoja GLOBAL no cumple con el formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //    MessageBox.Show(null, ex.Message.ToString(), "Error Lectura", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }

        private List<object[]> rowData(int row)
        {
            List<object[]> lst = new List<object[]>();
            try
            {
                String name = sheet.Cells[row, 4].Value;
                object[] obj;
                obj = new object[2];
                obj[0] = name.ToLower();
                switch (name)
                {
                    case "Dead":
                        obj[1] = sheet.Cells[row, 7].Value;
                        break;
                    case "Live":
                        obj[1] = sheet.Cells[row, 7].Value;
                        break;
                    case "SX":
                        obj[0] = "fzx";
                        obj[1] = sheet.Cells[row, 7].Value;
                        break;
                    case "SY":
                        obj[0] = "fzy";
                        obj[1] = sheet.Cells[row, 7].Value;
                        break;
                    default:
                        break;
                }
                lst.Add(obj);
                obj = new object[2];
                switch (name)
                {
                    case "SX":
                        obj[0] = "fx";
                        obj[1] = sheet.Cells[row, 5].Value;
                        lst.Add(obj);
                        break;
                    case "SY":
                        obj[0] = "fy";
                        obj[1] = sheet.Cells[row, 6].Value;
                        lst.Add(obj);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR " + ex.Message);
            }
            return lst;
        }

        public void calcFormulas(double delta, double cm, String story)
        {
            try
            {
                foreach (DataRow row in Model.Model.dtGlobal.Rows)
                {
                    double dead = Convert.ToDouble(row["dead"]);
                    double live = Convert.ToDouble(row["live"]);
                    double fzx = Convert.ToDouble(row["fzx"]);
                    double fzy = Convert.ToDouble(row["fzy"]);
                    row["sv"] = Math.Round(dead * cm, 2);
                    // dead + 0.5 * live + FZX + SV * DELTA / 2
                    double sv = Convert.ToDouble(row["sv"]);
                    row["pdsx"] = Math.Round((((dead + (0.5 * live) + fzx + sv) * delta) / 2), 2);
                    row["pdsy"] = Math.Round((((dead + (0.5 * live) + fzy + sv) * delta) / 2), 2);
                }
                inputSXSY(story);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void inputSXSY(String story)
        {
            try
            {
                // Realizar el ingreso en la tabla SX
                foreach (DataRow row in Model.Model.dtGlobal.Rows)
                {
                    // Aqui se ingresa los datos a la tabla sx
                    DataRow dr = Model.Model.dtSX.NewRow();
                    dr["story"] = story != "" ? story : row["story"];
                    dr["joint"] = row["joint"];
                    dr["combo"] = "SX";
                    dr["fz"] = row["fzx"];
                    dr["my"] = row["pdsx"];
                    dr["fx"] = row["fx"];
                    Model.Model.dtSX.Rows.Add(dr);

                    // Aqui se ingresa los datos a la tabla sy
                    DataRow d = Model.Model.dtSY.NewRow();
                    d["story"] = story != "" ? story : row["story"];
                    d["joint"] = row["joint"];
                    d["combo"] = "SY";
                    d["fz"] = row["fzy"];
                    d["mx"] = row["pdsy"];
                    d["fy"] = row["fy"];
                    Model.Model.dtSY.Rows.Add(d);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        
        public void close()
        {
            this.book.Close();
            this.app.Quit();
        }

        public void test()
        {
            for (int i = 0; i < Model.Model.dtGlobal.Rows.Count; i++)
            {
                for (int j = 0; j < Model.Model.dtGlobal.Columns.Count; j++)
                {
                    Console.Write(Model.Model.dtGlobal.Rows[i][j].ToString());
                    Console.Write(", ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < Model.Model.dtSX.Rows.Count; i++)
            {
                for (int j = 0; j < Model.Model.dtSX.Columns.Count; j++)
                {
                    Console.Write(Model.Model.dtSX.Rows[i][j].ToString());
                    Console.Write(", ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("======================================================");
            for (int i = 0; i < Model.Model.dtSY.Rows.Count; i++)
            {
                for (int j = 0; j < Model.Model.dtSY.Columns.Count; j++)
                {
                    Console.Write(Model.Model.dtSY.Rows[i][j].ToString());
                    Console.Write(", ");
                }
                Console.WriteLine("");
            }
        }

        #endregion
    }
}
