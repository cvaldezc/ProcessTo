using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controller;

namespace Views
{
    public partial class ConvertTo : Form
    {
        public ConvertTo()
        {
            InitializeComponent();
            sismoVertical();
            chckText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            String path = this.txtArchivoFormato.Text;
            ReadFileExcel read = new ReadFileExcel(path);
            read.selectSheet("Hoja1");
            read.readETabs(this.chkaislado.Checked ? txtaislado.Text : "");
            read.calcFormulas(Convert.ToDouble(txtDelta.Value), Convert.ToDouble(lblSismoVertical.Text), this.chknoaislado.Checked ? txtnoaislado.Text : "");
            // read.test();
            read.close();
            // escritura de archivos
            WriteEtabs wa = new WriteEtabs();
            wa.path = this.txtArchivoBase.Text;
            wa.destino = this.txtArchivoDestino.Text;
            wa.processe2kAislado(this.chkaislado.Checked ? txtaislado.Text : "Base", Convert.ToDouble(this.lblSismoVertical.Text));
            wa.processe2kNoAislado(this.chknoaislado.Checked ? this.txtnoaislado.Text : "story1", Convert.ToDouble(this.lblSismoVertical.Text));
        }

        private void btnSelArchivoBase_Click(object sender, EventArgs e)
        {
            this.oFD = new OpenFileDialog();
            this.oFD.Filter = "Importados (*.e2k, *.std) | *.e2k; *.std";
            if (this.oFD.ShowDialog() == DialogResult.OK)
            {
                this.txtArchivoBase.Text = this.oFD.FileName;
            }
        }

        private void btnSelArchivoFormato_Click(object sender, EventArgs e)
        {
            this.oFD = new OpenFileDialog();
            this.oFD.Filter = "Formato (*.xlxs) | *.xlsx";
            if (this.oFD.ShowDialog() == DialogResult.OK)
            {
                this.txtArchivoFormato.Text = this.oFD.FileName;
            }
        }

        private void btnSelDestino_Click(object sender, EventArgs e)
        {
            this.fBD = new FolderBrowserDialog();
            if (this.fBD.ShowDialog() == DialogResult.OK)
            {
                this.txtArchivoDestino.Text = this.fBD.SelectedPath.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        
        }

        /// <summaty>
        /// block functions
        /// </summary>

        private void sismoVertical()
        {
            // Double delta = Convert.ToDouble(this.txtDelta.Value != null ? this.txtDelta.Value : 0);
            Double facZona = Convert.ToDouble(this.txtZonaZ.Value != null ? this.txtZonaZ.Value : 0);
            Double tipoSuelo = Convert.ToDouble(this.txtTipoSuelo.Value != null ? this.txtTipoSuelo.Value : 0);
            Double calc = (facZona * tipoSuelo * 0.2 * 2.5);
            this.lblSismoVertical.Text = Math.Round(calc, 2).ToString();
        }

        private void txtZonaZ_ValueChanged(object sender, EventArgs e)
        {
            sismoVertical();
        }

        private void txtTipoSuelo_ValueChanged(object sender, EventArgs e)
        {
            sismoVertical();
        }

        private void chckText()
        {
            foreach (Control item in this.groupBox5.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cp = (CheckBox)item;
                    if (cp.Checked)
                    {
                        if ((string)cp.Tag == "aislado")
                        {
                            txtaislado.Enabled = true;
                        }
                        else
                        {
                            txtnoaislado.Enabled = true;
                        }
                    }
                    else
                    {
                        if ((string)cp.Tag == "aislado")
                        {
                            txtaislado.Enabled = false;
                        }
                        else
                        {
                            txtnoaislado.Enabled = false;
                        }
                    }
                }
            }
        }

        private void chknoaislado_CheckedChanged(object sender, EventArgs e)
        {
            chckText();
        }

        private void chkaislado_CheckedChanged(object sender, EventArgs e)
        {
            chckText();
        }
    }
}
