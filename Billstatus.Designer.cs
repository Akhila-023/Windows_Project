namespace Bill_Status
{
    partial class Billstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billstatus));
            this.labelbillstatus = new System.Windows.Forms.Label();
            this.comboBoxwing = new System.Windows.Forms.ComboBox();
            this.labelwing = new System.Windows.Forms.Label();
            this.labelflatnumber = new System.Windows.Forms.Label();
            this.txtflatnumber = new System.Windows.Forms.TextBox();
            this.labelbillnumber = new System.Windows.Forms.Label();
            this.txtbillnumber = new System.Windows.Forms.TextBox();
            this.dataGridViewdetails = new System.Windows.Forms.DataGridView();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.labeldetails = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelbillstatus
            // 
            this.labelbillstatus.AutoSize = true;
            this.labelbillstatus.BackColor = System.Drawing.Color.Transparent;
            this.labelbillstatus.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbillstatus.ForeColor = System.Drawing.Color.Black;
            this.labelbillstatus.Location = new System.Drawing.Point(394, 73);
            this.labelbillstatus.Name = "labelbillstatus";
            this.labelbillstatus.Size = new System.Drawing.Size(174, 45);
            this.labelbillstatus.TabIndex = 0;
            this.labelbillstatus.Text = "Bill Status";
            // 
            // comboBoxwing
            // 
            this.comboBoxwing.DropDownHeight = 120;
            this.comboBoxwing.DropDownWidth = 130;
            this.comboBoxwing.FormattingEnabled = true;
            this.comboBoxwing.IntegralHeight = false;
            this.comboBoxwing.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBoxwing.Location = new System.Drawing.Point(267, 243);
            this.comboBoxwing.Name = "comboBoxwing";
            this.comboBoxwing.Size = new System.Drawing.Size(121, 21);
            this.comboBoxwing.TabIndex = 1;
            this.comboBoxwing.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelwing
            // 
            this.labelwing.AutoSize = true;
            this.labelwing.BackColor = System.Drawing.Color.Transparent;
            this.labelwing.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwing.ForeColor = System.Drawing.Color.Black;
            this.labelwing.Location = new System.Drawing.Point(84, 239);
            this.labelwing.Name = "labelwing";
            this.labelwing.Size = new System.Drawing.Size(63, 25);
            this.labelwing.TabIndex = 2;
            this.labelwing.Text = "Wing";
            this.labelwing.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelflatnumber
            // 
            this.labelflatnumber.AutoSize = true;
            this.labelflatnumber.BackColor = System.Drawing.Color.Transparent;
            this.labelflatnumber.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelflatnumber.ForeColor = System.Drawing.Color.Black;
            this.labelflatnumber.Location = new System.Drawing.Point(84, 163);
            this.labelflatnumber.Name = "labelflatnumber";
            this.labelflatnumber.Size = new System.Drawing.Size(133, 25);
            this.labelflatnumber.TabIndex = 3;
            this.labelflatnumber.Text = "Flat Number";
            this.labelflatnumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtflatnumber
            // 
            this.txtflatnumber.Location = new System.Drawing.Point(267, 169);
            this.txtflatnumber.Name = "txtflatnumber";
            this.txtflatnumber.Size = new System.Drawing.Size(137, 20);
            this.txtflatnumber.TabIndex = 4;
            this.txtflatnumber.TextChanged += new System.EventHandler(this.txtflatnumber_TextChanged);
            // 
            // labelbillnumber
            // 
            this.labelbillnumber.AutoSize = true;
            this.labelbillnumber.BackColor = System.Drawing.Color.Transparent;
            this.labelbillnumber.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbillnumber.ForeColor = System.Drawing.Color.Black;
            this.labelbillnumber.Location = new System.Drawing.Point(84, 323);
            this.labelbillnumber.Name = "labelbillnumber";
            this.labelbillnumber.Size = new System.Drawing.Size(129, 25);
            this.labelbillnumber.TabIndex = 5;
            this.labelbillnumber.Text = "Bill Number";
            this.labelbillnumber.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbillnumber
            // 
            this.txtbillnumber.Location = new System.Drawing.Point(267, 316);
            this.txtbillnumber.Multiline = true;
            this.txtbillnumber.Name = "txtbillnumber";
            this.txtbillnumber.Size = new System.Drawing.Size(125, 32);
            this.txtbillnumber.TabIndex = 6;
            // 
            // dataGridViewdetails
            // 
            this.dataGridViewdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdetails.Location = new System.Drawing.Point(553, 297);
            this.dataGridViewdetails.Name = "dataGridViewdetails";
            this.dataGridViewdetails.Size = new System.Drawing.Size(458, 176);
            this.dataGridViewdetails.TabIndex = 7;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsubmit.BackgroundImage")));
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsubmit.Location = new System.Drawing.Point(183, 427);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(121, 46);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeldetails
            // 
            this.labeldetails.AutoSize = true;
            this.labeldetails.BackColor = System.Drawing.Color.Transparent;
            this.labeldetails.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldetails.ForeColor = System.Drawing.Color.White;
            this.labeldetails.Location = new System.Drawing.Point(713, 256);
            this.labeldetails.Name = "labeldetails";
            this.labeldetails.Size = new System.Drawing.Size(90, 28);
            this.labeldetails.TabIndex = 9;
            this.labeldetails.Text = "Details";
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefresh.BackgroundImage")));
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Location = new System.Drawing.Point(728, 513);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(140, 39);
            this.btnrefresh.TabIndex = 10;
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // Billstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 622);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.labeldetails);
            this.Controls.Add(this.dataGridViewdetails);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.labelbillstatus);
            this.Controls.Add(this.comboBoxwing);
            this.Controls.Add(this.labelwing);
            this.Controls.Add(this.txtbillnumber);
            this.Controls.Add(this.labelflatnumber);
            this.Controls.Add(this.labelbillnumber);
            this.Controls.Add(this.txtflatnumber);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Billstatus";
            this.Text = "Bill Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbillstatus;
        private System.Windows.Forms.ComboBox comboBoxwing;
        private System.Windows.Forms.Label labelwing;
        private System.Windows.Forms.Label labelflatnumber;
        private System.Windows.Forms.TextBox txtflatnumber;
        private System.Windows.Forms.Label labelbillnumber;
        private System.Windows.Forms.TextBox txtbillnumber;
        private System.Windows.Forms.DataGridView dataGridViewdetails;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label labeldetails;
        private System.Windows.Forms.Button btnrefresh;

    }
}

