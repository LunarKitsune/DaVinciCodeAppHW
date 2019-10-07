namespace DavinciCollegeV2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpResidence = new System.Windows.Forms.GroupBox();
            this.radOffCampus = new System.Windows.Forms.RadioButton();
            this.radOnCampus = new System.Windows.Forms.RadioButton();
            this.grpHousing = new System.Windows.Forms.GroupBox();
            this.radLondon = new System.Windows.Forms.RadioButton();
            this.radRome = new System.Windows.Forms.RadioButton();
            this.radParis = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbFeeOutput = new System.Windows.Forms.RichTextBox();
            this.txtSNameInput = new System.Windows.Forms.TextBox();
            this.txtSCreditInput = new System.Windows.Forms.TextBox();
            this.txtSIDInput = new System.Windows.Forms.TextBox();
            this.btnFeeCalculation = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkAutomobile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpResidence.SuspendLayout();
            this.grpHousing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Credits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(273, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tuition Fee";
            // 
            // grpResidence
            // 
            this.grpResidence.Controls.Add(this.radOffCampus);
            this.grpResidence.Controls.Add(this.radOnCampus);
            this.grpResidence.Location = new System.Drawing.Point(23, 201);
            this.grpResidence.Name = "grpResidence";
            this.grpResidence.Size = new System.Drawing.Size(122, 72);
            this.grpResidence.TabIndex = 5;
            this.grpResidence.TabStop = false;
            this.grpResidence.Text = "Residence";
            // 
            // radOffCampus
            // 
            this.radOffCampus.AutoSize = true;
            this.radOffCampus.Location = new System.Drawing.Point(7, 43);
            this.radOffCampus.Name = "radOffCampus";
            this.radOffCampus.Size = new System.Drawing.Size(80, 17);
            this.radOffCampus.TabIndex = 1;
            this.radOffCampus.TabStop = true;
            this.radOffCampus.Text = "Off-Campus";
            this.radOffCampus.UseVisualStyleBackColor = true;
            this.radOffCampus.CheckedChanged += new System.EventHandler(this.radOffCampus_CheckChanged);
            // 
            // radOnCampus
            // 
            this.radOnCampus.AutoSize = true;
            this.radOnCampus.Location = new System.Drawing.Point(7, 20);
            this.radOnCampus.Name = "radOnCampus";
            this.radOnCampus.Size = new System.Drawing.Size(80, 17);
            this.radOnCampus.TabIndex = 0;
            this.radOnCampus.TabStop = true;
            this.radOnCampus.Text = "On-Campus";
            this.radOnCampus.UseVisualStyleBackColor = true;
            this.radOnCampus.CheckedChanged += new System.EventHandler(this.radCampus_CheckedChanged);
            // 
            // grpHousing
            // 
            this.grpHousing.Controls.Add(this.radLondon);
            this.grpHousing.Controls.Add(this.radRome);
            this.grpHousing.Controls.Add(this.radParis);
            this.grpHousing.Location = new System.Drawing.Point(23, 279);
            this.grpHousing.Name = "grpHousing";
            this.grpHousing.Size = new System.Drawing.Size(122, 110);
            this.grpHousing.TabIndex = 6;
            this.grpHousing.TabStop = false;
            this.grpHousing.Text = "Housing";
            // 
            // radLondon
            // 
            this.radLondon.AutoSize = true;
            this.radLondon.Location = new System.Drawing.Point(7, 74);
            this.radLondon.Name = "radLondon";
            this.radLondon.Size = new System.Drawing.Size(89, 17);
            this.radLondon.TabIndex = 4;
            this.radLondon.TabStop = true;
            this.radLondon.Text = "London Dorm";
            this.radLondon.UseVisualStyleBackColor = true;
            // 
            // radRome
            // 
            this.radRome.AutoSize = true;
            this.radRome.Location = new System.Drawing.Point(7, 51);
            this.radRome.Name = "radRome";
            this.radRome.Size = new System.Drawing.Size(81, 17);
            this.radRome.TabIndex = 3;
            this.radRome.TabStop = true;
            this.radRome.Text = "Rome Dorm";
            this.radRome.UseVisualStyleBackColor = true;
            // 
            // radParis
            // 
            this.radParis.AutoSize = true;
            this.radParis.Location = new System.Drawing.Point(7, 28);
            this.radParis.Name = "radParis";
            this.radParis.Size = new System.Drawing.Size(76, 17);
            this.radParis.TabIndex = 2;
            this.radParis.TabStop = true;
            this.radParis.Text = "Paris Dorm";
            this.radParis.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(273, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "DaVinci College";
            // 
            // rtbFeeOutput
            // 
            this.rtbFeeOutput.Location = new System.Drawing.Point(223, 220);
            this.rtbFeeOutput.Name = "rtbFeeOutput";
            this.rtbFeeOutput.Size = new System.Drawing.Size(195, 169);
            this.rtbFeeOutput.TabIndex = 8;
            this.rtbFeeOutput.Text = "";
            // 
            // txtSNameInput
            // 
            this.txtSNameInput.Location = new System.Drawing.Point(318, 61);
            this.txtSNameInput.Name = "txtSNameInput";
            this.txtSNameInput.Size = new System.Drawing.Size(100, 20);
            this.txtSNameInput.TabIndex = 0;
            // 
            // txtSCreditInput
            // 
            this.txtSCreditInput.Location = new System.Drawing.Point(318, 151);
            this.txtSCreditInput.Name = "txtSCreditInput";
            this.txtSCreditInput.Size = new System.Drawing.Size(100, 20);
            this.txtSCreditInput.TabIndex = 2;
            // 
            // txtSIDInput
            // 
            this.txtSIDInput.Location = new System.Drawing.Point(318, 107);
            this.txtSIDInput.Name = "txtSIDInput";
            this.txtSIDInput.Size = new System.Drawing.Size(100, 20);
            this.txtSIDInput.TabIndex = 1;
            // 
            // btnFeeCalculation
            // 
            this.btnFeeCalculation.Location = new System.Drawing.Point(221, 395);
            this.btnFeeCalculation.Name = "btnFeeCalculation";
            this.btnFeeCalculation.Size = new System.Drawing.Size(92, 43);
            this.btnFeeCalculation.TabIndex = 3;
            this.btnFeeCalculation.Text = "Calculate Fee";
            this.btnFeeCalculation.UseVisualStyleBackColor = true;
            this.btnFeeCalculation.Click += new System.EventHandler(this.btnFeeCalculation_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(328, 395);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(88, 43);
            this.btnExitApp.TabIndex = 4;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // chkAutomobile
            // 
            this.chkAutomobile.AutoSize = true;
            this.chkAutomobile.Location = new System.Drawing.Point(23, 395);
            this.chkAutomobile.Name = "chkAutomobile";
            this.chkAutomobile.Size = new System.Drawing.Size(78, 17);
            this.chkAutomobile.TabIndex = 14;
            this.chkAutomobile.Text = "Automobile";
            this.chkAutomobile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.chkAutomobile);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnFeeCalculation);
            this.Controls.Add(this.txtSIDInput);
            this.Controls.Add(this.txtSCreditInput);
            this.Controls.Add(this.txtSNameInput);
            this.Controls.Add(this.rtbFeeOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpHousing);
            this.Controls.Add(this.grpResidence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "DaVinci College";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpResidence.ResumeLayout(false);
            this.grpResidence.PerformLayout();
            this.grpHousing.ResumeLayout(false);
            this.grpHousing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpResidence;
        private System.Windows.Forms.RadioButton radOffCampus;
        private System.Windows.Forms.RadioButton radOnCampus;
        private System.Windows.Forms.GroupBox grpHousing;
        private System.Windows.Forms.RadioButton radLondon;
        private System.Windows.Forms.RadioButton radRome;
        private System.Windows.Forms.RadioButton radParis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbFeeOutput;
        private System.Windows.Forms.TextBox txtSNameInput;
        private System.Windows.Forms.TextBox txtSCreditInput;
        private System.Windows.Forms.TextBox txtSIDInput;
        private System.Windows.Forms.Button btnFeeCalculation;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.CheckBox chkAutomobile;
    }
}

