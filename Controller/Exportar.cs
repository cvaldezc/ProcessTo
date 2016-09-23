using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Controller.Interfaces;
using Excel = Microsoft.Office.Interop.Excel;

namespace Controller
{
    public class Exportar
    {
        private Excel.Application app;
        private Excel.Workbook wb;
        private Excel.Worksheet ws;
        protected bool status;
        private string path, ext;

        public Exportar(String _path, String _ext)
        {
            try
            {
                status = true;
                app = new Excel.Application();
                this.path = _path;
                this.ext = _ext;
                if (app == null)
                {
                    Console.WriteLine("Excel is not installed!");
                    status = false;
                }
                if (this.path == "")
                {
                    Console.WriteLine("path not found");
                    status = false;
                }
                if (this.ext == "")
                {
                    Console.WriteLine("path not found");
                    status = false;
                }
            }
            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                closeExcel();
            }
            
        }

        public void LlenarDatos()
        {
            try
            {
                object myvalue = System.Reflection.Missing.Value;
                wb = app.Workbooks.Add(myvalue);
                ws = wb.Worksheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
                ws.Name = "REPORTE";
                ws.Columns.AutoFit();
                // TITULOS
                ws.Cells[2, 3] = "FUERZAS";
                ws.Cells[2, 6] = "MOMENTOS";
                ws.Cells[3, 2] = "NODO";
                // FUERZAS
                ws.Cells[3, 3] = "FX";
                ws.Cells[3, 4] = "FY";
                ws.Cells[3, 5] = "FZ";
                // MOMENTOS
                ws.Cells[3, 6] = "MX";
                ws.Cells[3, 7] = "MY";
                ws.Cells[3, 8] = "MZ";
                if (this.ext == "std")
                {
                    // llamos a funcion
                    StaadPro();
                }
                else if (this.ext == "e2k")
                {
                    // llamos a funcion
                    Etabs();
                }
                else
                {
                    closeExcel();
                }
                closeExcel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void Etabs()
        {
            try
            {
                DataRow[] dr = Model.MDEtabs.dtGlobal.Select(null, null, DataViewRowState.CurrentRows);
                int rindex = 4;
                foreach (DataRow row in dr)
                {
                    // Dead
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["joint"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["dead"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = "0";
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = "0";
                    // Live
                    rindex++;
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["joint"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["live"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = "0";
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = "0";
                    // fzx
                    rindex++;
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["joint"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["fzx"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = row["pdsy"];
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = "0";
                    // fzy
                    rindex++;
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["joint"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["fzy"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = "0";
                    ws.Cells[rindex, 7] = row["pdsx"];
                    ws.Cells[rindex, 8] = "0";
                    rindex++;
                }
                ws.get_Range("B2", "H" + rindex).Cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    //.BorderAround2(Excel.XlLineStyle.xlContinuous,
                    //Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic,
                    //Type.Missing, Type.Missing);
                ws.get_Range("C2", "E2").Merge(true);
                ws.get_Range("C2").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.get_Range("C2").Cells.Font.Bold = true;
                ws.get_Range("F2", "H2").Merge(true);
                ws.get_Range("F2").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.get_Range("F2").Cells.Font.Bold = true;
                ws.get_Range("B3", "H3").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.get_Range("B3", "H3").Font.Bold = true;
                ws.get_Range("B3", "B" + rindex).Font.Bold = true;
                ws.get_Range("B3", "B" + rindex).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                object myvalue = System.Reflection.Missing.Value;
                this.path = String.Format(@"{0}\reporte.xlsx", this.path);
                wb.SaveAs(path, Excel.XlFileFormat.xlOpenXMLWorkbook, myvalue,
                myvalue, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                Excel.XlSaveConflictResolution.xlUserResolution, true,
                myvalue, myvalue, myvalue);
                wb.Close(true, myvalue, myvalue);
                app.Quit();
                status = false;
                //releaseObject(ws);
                //releaseObject(wb);
                //releaseObject(app);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void StaadPro()
        {
            try
            {
                DataRow[] dr = Model.MDStaadPRO.dtGlobal.Select(null, null, DataViewRowState.CurrentRows);
                int rindex = 4;
                foreach (DataRow row in dr)
                {
                    // Dead
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["nodo"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["cm"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = "0";
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = "0";
                    // Live
                    rindex++;
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["nodo"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["cv"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = "0";
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = "0";
                    // fzx
                    rindex++;
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["nodo"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["csxv"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = row["pdsz"];
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = "0";
                    // fzy
                    rindex++;
                    // FUERZAS
                    ws.Cells[rindex, 2] = row["nodo"];
                    ws.Cells[rindex, 3] = "0";
                    ws.Cells[rindex, 4] = "0";
                    ws.Cells[rindex, 5] = row["cszv"];
                    // MOMENTOS
                    ws.Cells[rindex, 6] = "0";
                    ws.Cells[rindex, 7] = "0";
                    ws.Cells[rindex, 8] = row["pdsx"];
                    rindex++;
                }
                ws.get_Range("B2", "H" + rindex).Cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //.BorderAround2(Excel.XlLineStyle.xlContinuous,
                //Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic,
                //Type.Missing, Type.Missing);
                ws.get_Range("C2", "E2").Merge(true);
                ws.get_Range("C2").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.get_Range("C2").Cells.Font.Bold = true;
                ws.get_Range("F2", "H2").Merge(true);
                ws.get_Range("F2").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.get_Range("F2").Cells.Font.Bold = true;
                ws.get_Range("B3", "H3").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.get_Range("B3", "H3").Font.Bold = true;
                ws.get_Range("B3", "B" + rindex).Font.Bold = true;
                ws.get_Range("B3", "B" + rindex).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                object myvalue = System.Reflection.Missing.Value;
                this.path = String.Format(@"{0}\reporte.xlsx", this.path);
                wb.SaveAs(path, Excel.XlFileFormat.xlOpenXMLWorkbook, myvalue,
                myvalue, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                Excel.XlSaveConflictResolution.xlUserResolution, true,
                myvalue, myvalue, myvalue);
                wb.Close(true, myvalue, myvalue);
                app.Quit();
                status = false;
                //releaseObject(ws);
                //releaseObject(wb);
                //releaseObject(app);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void closeExcel(){
            if (!status)
            {
                wb.Close();
                app.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(app);
            }
        }

    }
}
