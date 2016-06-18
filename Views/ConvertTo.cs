using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Views
{
    public partial class ConvertTo : Form
    {
        public ConvertTo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {

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
    }
}
