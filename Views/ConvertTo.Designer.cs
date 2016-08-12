namespace Views
{
    partial class ConvertTo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelArchivoFormato = new System.Windows.Forms.Button();
            this.btnSelArchivoBase = new System.Windows.Forms.Button();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.txtArchivoFormato = new System.Windows.Forms.TextBox();
            this.txtArchivoBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progreso2 = new System.Windows.Forms.ProgressBar();
            this.progreso1 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkaislado = new System.Windows.Forms.CheckBox();
            this.chknoaislado = new System.Windows.Forms.CheckBox();
            this.txtTipoSuelo = new System.Windows.Forms.NumericUpDown();
            this.txtDelta = new System.Windows.Forms.NumericUpDown();
            this.txtZonaZ = new System.Windows.Forms.NumericUpDown();
            this.lblSismoVertical = new System.Windows.Forms.Label();
            this.txtaislado = new System.Windows.Forms.TextBox();
            this.txtnoaislado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelDestino = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArchivoDestino = new System.Windows.Forms.TextBox();
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoSuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZonaZ)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.19897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.74677F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelArchivoFormato);
            this.groupBox1.Controls.Add(this.btnSelArchivoBase);
            this.groupBox1.Controls.Add(this.BtnProcesar);
            this.groupBox1.Controls.Add(this.txtArchivoFormato);
            this.groupBox1.Controls.Add(this.txtArchivoBase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas de Archivos";
            // 
            // btnSelArchivoFormato
            // 
            this.btnSelArchivoFormato.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelArchivoFormato.Location = new System.Drawing.Point(143, 68);
            this.btnSelArchivoFormato.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelArchivoFormato.Name = "btnSelArchivoFormato";
            this.btnSelArchivoFormato.Size = new System.Drawing.Size(29, 24);
            this.btnSelArchivoFormato.TabIndex = 6;
            this.btnSelArchivoFormato.Text = "...";
            this.btnSelArchivoFormato.UseVisualStyleBackColor = true;
            this.btnSelArchivoFormato.Click += new System.EventHandler(this.btnSelArchivoFormato_Click);
            // 
            // btnSelArchivoBase
            // 
            this.btnSelArchivoBase.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelArchivoBase.Location = new System.Drawing.Point(143, 25);
            this.btnSelArchivoBase.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelArchivoBase.Name = "btnSelArchivoBase";
            this.btnSelArchivoBase.Size = new System.Drawing.Size(29, 24);
            this.btnSelArchivoBase.TabIndex = 6;
            this.btnSelArchivoBase.Text = "...";
            this.btnSelArchivoBase.UseVisualStyleBackColor = true;
            this.btnSelArchivoBase.Click += new System.EventHandler(this.btnSelArchivoBase_Click);
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Location = new System.Drawing.Point(557, 19);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(75, 23);
            this.BtnProcesar.TabIndex = 5;
            this.BtnProcesar.Text = "Procesar";
            this.BtnProcesar.UseVisualStyleBackColor = true;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // txtArchivoFormato
            // 
            this.txtArchivoFormato.Enabled = false;
            this.txtArchivoFormato.Location = new System.Drawing.Point(189, 72);
            this.txtArchivoFormato.Name = "txtArchivoFormato";
            this.txtArchivoFormato.Size = new System.Drawing.Size(329, 20);
            this.txtArchivoFormato.TabIndex = 3;
            this.txtArchivoFormato.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtArchivoBase
            // 
            this.txtArchivoBase.Enabled = false;
            this.txtArchivoBase.Location = new System.Drawing.Point(189, 29);
            this.txtArchivoBase.Name = "txtArchivoBase";
            this.txtArchivoBase.Size = new System.Drawing.Size(329, 20);
            this.txtArchivoBase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formato ( *.xlsx | *.txt )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo ( *.e2k | *.std )";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 213);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 194);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progreso2);
            this.groupBox4.Controls.Add(this.progreso1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(319, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 188);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // progreso2
            // 
            this.progreso2.Location = new System.Drawing.Point(6, 55);
            this.progreso2.Name = "progreso2";
            this.progreso2.Size = new System.Drawing.Size(298, 17);
            this.progreso2.TabIndex = 1;
            // 
            // progreso1
            // 
            this.progreso1.Location = new System.Drawing.Point(6, 28);
            this.progreso1.Name = "progreso1";
            this.progreso1.Size = new System.Drawing.Size(298, 13);
            this.progreso1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkaislado);
            this.groupBox5.Controls.Add(this.chknoaislado);
            this.groupBox5.Controls.Add(this.txtTipoSuelo);
            this.groupBox5.Controls.Add(this.txtDelta);
            this.groupBox5.Controls.Add(this.txtZonaZ);
            this.groupBox5.Controls.Add(this.lblSismoVertical);
            this.groupBox5.Controls.Add(this.txtaislado);
            this.groupBox5.Controls.Add(this.txtnoaislado);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 188);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // chkaislado
            // 
            this.chkaislado.AutoSize = true;
            this.chkaislado.Location = new System.Drawing.Point(277, 162);
            this.chkaislado.Name = "chkaislado";
            this.chkaislado.Size = new System.Drawing.Size(15, 14);
            this.chkaislado.TabIndex = 4;
            this.chkaislado.Tag = "aislado";
            this.chkaislado.UseVisualStyleBackColor = true;
            this.chkaislado.CheckedChanged += new System.EventHandler(this.chkaislado_CheckedChanged);
            // 
            // chknoaislado
            // 
            this.chknoaislado.AutoSize = true;
            this.chknoaislado.Location = new System.Drawing.Point(277, 135);
            this.chknoaislado.Name = "chknoaislado";
            this.chknoaislado.Size = new System.Drawing.Size(15, 14);
            this.chknoaislado.TabIndex = 4;
            this.chknoaislado.Tag = "noaislado";
            this.chknoaislado.UseVisualStyleBackColor = true;
            this.chknoaislado.CheckedChanged += new System.EventHandler(this.chknoaislado_CheckedChanged);
            // 
            // txtTipoSuelo
            // 
            this.txtTipoSuelo.DecimalPlaces = 2;
            this.txtTipoSuelo.Location = new System.Drawing.Point(137, 79);
            this.txtTipoSuelo.Name = "txtTipoSuelo";
            this.txtTipoSuelo.Size = new System.Drawing.Size(155, 20);
            this.txtTipoSuelo.TabIndex = 3;
            this.txtTipoSuelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipoSuelo.Value = new decimal(new int[] {
            115,
            0,
            0,
            131072});
            this.txtTipoSuelo.ValueChanged += new System.EventHandler(this.txtTipoSuelo_ValueChanged);
            // 
            // txtDelta
            // 
            this.txtDelta.DecimalPlaces = 2;
            this.txtDelta.Location = new System.Drawing.Point(137, 19);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(155, 20);
            this.txtDelta.TabIndex = 3;
            this.txtDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDelta.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            this.txtDelta.ValueChanged += new System.EventHandler(this.txtDelta_ValueChanged);
            // 
            // txtZonaZ
            // 
            this.txtZonaZ.DecimalPlaces = 2;
            this.txtZonaZ.Location = new System.Drawing.Point(137, 48);
            this.txtZonaZ.Name = "txtZonaZ";
            this.txtZonaZ.Size = new System.Drawing.Size(155, 20);
            this.txtZonaZ.TabIndex = 3;
            this.txtZonaZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZonaZ.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            this.txtZonaZ.ValueChanged += new System.EventHandler(this.txtZonaZ_ValueChanged);
            // 
            // lblSismoVertical
            // 
            this.lblSismoVertical.AutoSize = true;
            this.lblSismoVertical.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSismoVertical.Location = new System.Drawing.Point(239, 112);
            this.lblSismoVertical.Name = "lblSismoVertical";
            this.lblSismoVertical.Size = new System.Drawing.Size(54, 16);
            this.lblSismoVertical.TabIndex = 2;
            this.lblSismoVertical.Text = "label10";
            // 
            // txtaislado
            // 
            this.txtaislado.Location = new System.Drawing.Point(137, 159);
            this.txtaislado.Name = "txtaislado";
            this.txtaislado.Size = new System.Drawing.Size(128, 20);
            this.txtaislado.TabIndex = 1;
            this.txtaislado.Text = "Base";
            this.txtaislado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtaislado.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtnoaislado
            // 
            this.txtnoaislado.Location = new System.Drawing.Point(137, 133);
            this.txtnoaislado.Name = "txtnoaislado";
            this.txtnoaislado.Size = new System.Drawing.Size(128, 20);
            this.txtnoaislado.TabIndex = 1;
            this.txtnoaislado.Text = "Story1";
            this.txtnoaislado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "NIVEL AISLADO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "NIVEL NO AISLADO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Participación CM (Sismo Vertical 0.2(ZxSx2.5))";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "S (Tipo de Suelo)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Z (Factor de Zona)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DELTA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelDestino);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtArchivoDestino);
            this.groupBox3.Location = new System.Drawing.Point(3, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 55);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnSelDestino
            // 
            this.btnSelDestino.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelDestino.Location = new System.Drawing.Point(143, 20);
            this.btnSelDestino.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelDestino.Name = "btnSelDestino";
            this.btnSelDestino.Size = new System.Drawing.Size(29, 24);
            this.btnSelDestino.TabIndex = 6;
            this.btnSelDestino.Text = "...";
            this.btnSelDestino.UseVisualStyleBackColor = true;
            this.btnSelDestino.Click += new System.EventHandler(this.btnSelDestino_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Exportar en";
            // 
            // txtArchivoDestino
            // 
            this.txtArchivoDestino.Enabled = false;
            this.txtArchivoDestino.Location = new System.Drawing.Point(189, 23);
            this.txtArchivoDestino.Name = "txtArchivoDestino";
            this.txtArchivoDestino.Size = new System.Drawing.Size(329, 20);
            this.txtArchivoDestino.TabIndex = 4;
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // ConvertTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConvertTo";
            this.Text = "ConvertTo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoSuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZonaZ)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.TextBox txtArchivoDestino;
        private System.Windows.Forms.TextBox txtArchivoFormato;
        private System.Windows.Forms.TextBox txtArchivoBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progreso2;
        private System.Windows.Forms.ProgressBar progreso1;
        private System.Windows.Forms.Button btnSelArchivoBase;
        private System.Windows.Forms.Button btnSelDestino;
        private System.Windows.Forms.Button btnSelArchivoFormato;
        private System.Windows.Forms.FolderBrowserDialog fBD;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSismoVertical;
        private System.Windows.Forms.TextBox txtaislado;
        private System.Windows.Forms.TextBox txtnoaislado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTipoSuelo;
        private System.Windows.Forms.NumericUpDown txtDelta;
        private System.Windows.Forms.NumericUpDown txtZonaZ;
        private System.Windows.Forms.CheckBox chkaislado;
        private System.Windows.Forms.CheckBox chknoaislado;
    }
}