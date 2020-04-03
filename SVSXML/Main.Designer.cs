namespace SVSXML
{
    partial class Main
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
            this.archivoText = new System.Windows.Forms.TextBox();
            this.abrirBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.procesarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dvText = new System.Windows.Forms.TextBox();
            this.rutText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.rutaExportText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xmlFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoText
            // 
            this.archivoText.Location = new System.Drawing.Point(12, 35);
            this.archivoText.Name = "archivoText";
            this.archivoText.Size = new System.Drawing.Size(275, 20);
            this.archivoText.TabIndex = 0;
            // 
            // abrirBtn
            // 
            this.abrirBtn.Image = global::SVSXML.Properties.Resources.folder;
            this.abrirBtn.Location = new System.Drawing.Point(293, 33);
            this.abrirBtn.Name = "abrirBtn";
            this.abrirBtn.Size = new System.Drawing.Size(34, 23);
            this.abrirBtn.TabIndex = 1;
            this.abrirBtn.UseVisualStyleBackColor = true;
            this.abrirBtn.Click += new System.EventHandler(this.abrirBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo Base (Excel)";
            // 
            // procesarBtn
            // 
            this.procesarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesarBtn.Location = new System.Drawing.Point(7, 325);
            this.procesarBtn.Name = "procesarBtn";
            this.procesarBtn.Size = new System.Drawing.Size(320, 46);
            this.procesarBtn.TabIndex = 3;
            this.procesarBtn.Text = "Exportar";
            this.procesarBtn.UseVisualStyleBackColor = true;
            this.procesarBtn.Click += new System.EventHandler(this.procesarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dvText);
            this.groupBox1.Controls.Add(this.rutText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // dvText
            // 
            this.dvText.Location = new System.Drawing.Point(196, 85);
            this.dvText.Name = "dvText";
            this.dvText.Size = new System.Drawing.Size(34, 20);
            this.dvText.TabIndex = 8;
            // 
            // rutText
            // 
            this.rutText.Location = new System.Drawing.Point(22, 85);
            this.rutText.Name = "rutText";
            this.rutText.Size = new System.Drawing.Size(151, 20);
            this.rutText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RUT";
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(22, 37);
            this.dateText.Mask = "00/00/0000";
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(208, 20);
            this.dateText.TabIndex = 5;
            this.dateText.ValidatingType = typeof(System.DateTime);
            this.dateText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateText_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Periodo a Informar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ruta Exportación";
            // 
            // exportBtn
            // 
            this.exportBtn.Image = global::SVSXML.Properties.Resources.folder;
            this.exportBtn.Location = new System.Drawing.Point(293, 80);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(34, 23);
            this.exportBtn.TabIndex = 6;
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // rutaExportText
            // 
            this.rutaExportText.Location = new System.Drawing.Point(12, 82);
            this.rutaExportText.Name = "rutaExportText";
            this.rutaExportText.Size = new System.Drawing.Size(275, 20);
            this.rutaExportText.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre Archivo de Salida";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // xmlFileName
            // 
            this.xmlFileName.Location = new System.Drawing.Point(12, 132);
            this.xmlFileName.Name = "xmlFileName";
            this.xmlFileName.Size = new System.Drawing.Size(275, 20);
            this.xmlFileName.TabIndex = 9;
            this.xmlFileName.Text = "svsFile";
            this.xmlFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nota: la extensión del archivo será .xml";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 380);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xmlFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.rutaExportText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.procesarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abrirBtn);
            this.Controls.Add(this.archivoText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "Generador de XML para SVS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox archivoText;
        private System.Windows.Forms.Button abrirBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button procesarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox dateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rutText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dvText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.TextBox rutaExportText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xmlFileName;
        private System.Windows.Forms.Label label7;
    }
}

