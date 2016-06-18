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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.txtArchivoDestino = new System.Windows.Forms.TextBox();
            this.txtArchivoFormato = new System.Windows.Forms.TextBox();
            this.txtArchivoBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progreso2 = new System.Windows.Forms.ProgressBar();
            this.progreso1 = new System.Windows.Forms.ProgressBar();
            this.btnSelArchivoBase = new System.Windows.Forms.Button();
            this.btnSelArchivoFormato = new System.Windows.Forms.Button();
            this.btnSelDestino = new System.Windows.Forms.Button();
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.98777F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.01223F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 251);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelDestino);
            this.groupBox1.Controls.Add(this.btnSelArchivoFormato);
            this.groupBox1.Controls.Add(this.btnSelArchivoBase);
            this.groupBox1.Controls.Add(this.BtnProcesar);
            this.groupBox1.Controls.Add(this.txtArchivoDestino);
            this.groupBox1.Controls.Add(this.txtArchivoFormato);
            this.groupBox1.Controls.Add(this.txtArchivoBase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(958, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas y Salidas";
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Location = new System.Drawing.Point(838, 206);
            this.BtnProcesar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(112, 35);
            this.BtnProcesar.TabIndex = 5;
            this.BtnProcesar.Text = "Processar";
            this.BtnProcesar.UseVisualStyleBackColor = true;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // txtArchivoDestino
            // 
            this.txtArchivoDestino.Enabled = false;
            this.txtArchivoDestino.Location = new System.Drawing.Point(283, 194);
            this.txtArchivoDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArchivoDestino.Name = "txtArchivoDestino";
            this.txtArchivoDestino.Size = new System.Drawing.Size(492, 26);
            this.txtArchivoDestino.TabIndex = 4;
            // 
            // txtArchivoFormato
            // 
            this.txtArchivoFormato.Enabled = false;
            this.txtArchivoFormato.Location = new System.Drawing.Point(283, 111);
            this.txtArchivoFormato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArchivoFormato.Name = "txtArchivoFormato";
            this.txtArchivoFormato.Size = new System.Drawing.Size(492, 26);
            this.txtArchivoFormato.TabIndex = 3;
            this.txtArchivoFormato.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtArchivoBase
            // 
            this.txtArchivoBase.Enabled = false;
            this.txtArchivoBase.Location = new System.Drawing.Point(283, 45);
            this.txtArchivoBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArchivoBase.Name = "txtArchivoBase";
            this.txtArchivoBase.Size = new System.Drawing.Size(492, 26);
            this.txtArchivoBase.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salida de Archivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formato Exel ( *.xlsx )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo ( *.e2k | *.std )";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 232);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progreso2);
            this.groupBox2.Controls.Add(this.progreso1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(958, 232);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // progreso2
            // 
            this.progreso2.Location = new System.Drawing.Point(48, 123);
            this.progreso2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progreso2.Name = "progreso2";
            this.progreso2.Size = new System.Drawing.Size(838, 17);
            this.progreso2.TabIndex = 1;
            // 
            // progreso1
            // 
            this.progreso1.Location = new System.Drawing.Point(48, 74);
            this.progreso1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progreso1.Name = "progreso1";
            this.progreso1.Size = new System.Drawing.Size(838, 18);
            this.progreso1.TabIndex = 0;
            // 
            // btnSelArchivoBase
            // 
            this.btnSelArchivoBase.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelArchivoBase.Location = new System.Drawing.Point(215, 39);
            this.btnSelArchivoBase.Name = "btnSelArchivoBase";
            this.btnSelArchivoBase.Size = new System.Drawing.Size(43, 37);
            this.btnSelArchivoBase.TabIndex = 6;
            this.btnSelArchivoBase.Text = "...";
            this.btnSelArchivoBase.UseVisualStyleBackColor = true;
            this.btnSelArchivoBase.Click += new System.EventHandler(this.btnSelArchivoBase_Click);
            // 
            // btnSelArchivoFormato
            // 
            this.btnSelArchivoFormato.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelArchivoFormato.Location = new System.Drawing.Point(215, 105);
            this.btnSelArchivoFormato.Name = "btnSelArchivoFormato";
            this.btnSelArchivoFormato.Size = new System.Drawing.Size(43, 37);
            this.btnSelArchivoFormato.TabIndex = 6;
            this.btnSelArchivoFormato.Text = "...";
            this.btnSelArchivoFormato.UseVisualStyleBackColor = true;
            this.btnSelArchivoFormato.Click += new System.EventHandler(this.btnSelArchivoFormato_Click);
            // 
            // btnSelDestino
            // 
            this.btnSelDestino.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelDestino.Location = new System.Drawing.Point(215, 187);
            this.btnSelDestino.Name = "btnSelDestino";
            this.btnSelDestino.Size = new System.Drawing.Size(43, 37);
            this.btnSelDestino.TabIndex = 6;
            this.btnSelDestino.Text = "...";
            this.btnSelDestino.UseVisualStyleBackColor = true;
            this.btnSelDestino.Click += new System.EventHandler(this.btnSelDestino_Click);
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            // 
            // ConvertTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConvertTo";
            this.Text = "ConvertTo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
    }
}