namespace OneTimePad
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.textBoxDesifred = new System.Windows.Forms.TextBox();
            this.textBoxSifred = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonSifre = new System.Windows.Forms.RadioButton();
            this.radioButtonDesifre = new System.Windows.Forms.RadioButton();
            this.buttonSifre = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonDrawKey = new System.Windows.Forms.Button();
            this.buttonDesifre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IfFIleIsChosen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(134, 37);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Eksploruj...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybór pliku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odszyfrowany";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zaszyfrowany";
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(6, 33);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(52, 17);
            this.radioButtonText.TabIndex = 5;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Tekst";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(6, 56);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(42, 17);
            this.radioButtonFile.TabIndex = 6;
            this.radioButtonFile.TabStop = true;
            this.radioButtonFile.Text = "Plik";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            this.radioButtonFile.CheckedChanged += new System.EventHandler(this.radioButtonFile_CheckedChanged);
            // 
            // textBoxDesifred
            // 
            this.textBoxDesifred.Location = new System.Drawing.Point(134, 99);
            this.textBoxDesifred.MaxLength = 100;
            this.textBoxDesifred.Name = "textBoxDesifred";
            this.textBoxDesifred.Size = new System.Drawing.Size(254, 20);
            this.textBoxDesifred.TabIndex = 7;
            // 
            // textBoxSifred
            // 
            this.textBoxSifred.Location = new System.Drawing.Point(134, 155);
            this.textBoxSifred.Name = "textBoxSifred";
            this.textBoxSifred.Size = new System.Drawing.Size(254, 20);
            this.textBoxSifred.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonText);
            this.groupBox1.Controls.Add(this.radioButtonFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybór danych";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonSifre);
            this.groupBox2.Controls.Add(this.radioButtonDesifre);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybór trybu";
            // 
            // radioButtonSifre
            // 
            this.radioButtonSifre.AutoSize = true;
            this.radioButtonSifre.Location = new System.Drawing.Point(6, 33);
            this.radioButtonSifre.Name = "radioButtonSifre";
            this.radioButtonSifre.Size = new System.Drawing.Size(56, 17);
            this.radioButtonSifre.TabIndex = 5;
            this.radioButtonSifre.TabStop = true;
            this.radioButtonSifre.Text = "Szyfruj";
            this.radioButtonSifre.UseVisualStyleBackColor = true;
            this.radioButtonSifre.CheckedChanged += new System.EventHandler(this.radioButtonSifre_CheckedChanged);
            // 
            // radioButtonDesifre
            // 
            this.radioButtonDesifre.AutoSize = true;
            this.radioButtonDesifre.Location = new System.Drawing.Point(6, 56);
            this.radioButtonDesifre.Name = "radioButtonDesifre";
            this.radioButtonDesifre.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDesifre.TabIndex = 6;
            this.radioButtonDesifre.TabStop = true;
            this.radioButtonDesifre.Text = "Deszyfruj";
            this.radioButtonDesifre.UseVisualStyleBackColor = true;
            this.radioButtonDesifre.CheckedChanged += new System.EventHandler(this.radioButtonDesifre_CheckedChanged);
            // 
            // buttonSifre
            // 
            this.buttonSifre.Location = new System.Drawing.Point(394, 99);
            this.buttonSifre.Name = "buttonSifre";
            this.buttonSifre.Size = new System.Drawing.Size(148, 34);
            this.buttonSifre.TabIndex = 11;
            this.buttonSifre.Text = "Szyfruj";
            this.buttonSifre.UseVisualStyleBackColor = true;
            this.buttonSifre.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(131, 210);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(257, 129);
            this.textBoxKey.TabIndex = 13;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(134, 190);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(33, 13);
            this.labelKey.TabIndex = 12;
            this.labelKey.Text = "Klucz";
            // 
            // buttonDrawKey
            // 
            this.buttonDrawKey.Location = new System.Drawing.Point(394, 210);
            this.buttonDrawKey.Name = "buttonDrawKey";
            this.buttonDrawKey.Size = new System.Drawing.Size(148, 129);
            this.buttonDrawKey.TabIndex = 14;
            this.buttonDrawKey.Text = "Losuj nowy klucz";
            this.buttonDrawKey.UseVisualStyleBackColor = true;
            this.buttonDrawKey.Click += new System.EventHandler(this.buttonDrawKey_Click);
            // 
            // buttonDesifre
            // 
            this.buttonDesifre.Location = new System.Drawing.Point(394, 141);
            this.buttonDesifre.Name = "buttonDesifre";
            this.buttonDesifre.Size = new System.Drawing.Size(148, 34);
            this.buttonDesifre.TabIndex = 15;
            this.buttonDesifre.Text = "Deszyfruj";
            this.buttonDesifre.UseVisualStyleBackColor = true;
            this.buttonDesifre.Click += new System.EventHandler(this.buttonDesifre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // IfFIleIsChosen
            // 
            this.IfFIleIsChosen.AutoSize = true;
            this.IfFIleIsChosen.Location = new System.Drawing.Point(250, 37);
            this.IfFIleIsChosen.Name = "IfFIleIsChosen";
            this.IfFIleIsChosen.Size = new System.Drawing.Size(0, 13);
            this.IfFIleIsChosen.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 351);
            this.Controls.Add(this.IfFIleIsChosen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDesifre);
            this.Controls.Add(this.buttonDrawKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.buttonSifre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSifred);
            this.Controls.Add(this.textBoxDesifred);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.TextBox textBoxDesifred;
        private System.Windows.Forms.TextBox textBoxSifred;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSifre;
        private System.Windows.Forms.RadioButton radioButtonDesifre;
        private System.Windows.Forms.Button buttonSifre;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonDrawKey;
        private System.Windows.Forms.Button buttonDesifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IfFIleIsChosen;
    }
}

