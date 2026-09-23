namespace Assignment1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.Lblsemister = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemister = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(143, 18);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(367, 51);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter The Student Name";
            // 
            // lblstudentID
            // 
            this.lblstudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentID.Location = new System.Drawing.Point(143, 90);
            this.lblstudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(367, 77);
            this.lblstudentID.TabIndex = 1;
            this.lblstudentID.Text = "Enter The Student ID";
            // 
            // Lblsemister
            // 
            this.Lblsemister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsemister.Location = new System.Drawing.Point(143, 229);
            this.Lblsemister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblsemister.Name = "Lblsemister";
            this.Lblsemister.Size = new System.Drawing.Size(367, 77);
            this.Lblsemister.TabIndex = 2;
            this.Lblsemister.Text = "Enter The Semister";
            // 
            // lbldepartment
            // 
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(143, 153);
            this.lbldepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(367, 41);
            this.lbldepartment.TabIndex = 3;
            this.lbldepartment.Text = "Enter The Department";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(453, 16);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(405, 43);
            this.txtname.TabIndex = 4;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(453, 88);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(405, 43);
            this.txtstudentid.TabIndex = 7;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(453, 151);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(405, 43);
            this.txtdepartment.TabIndex = 8;
            // 
            // txtsemister
            // 
            this.txtsemister.Location = new System.Drawing.Point(453, 217);
            this.txtsemister.Multiline = true;
            this.txtsemister.Name = "txtsemister";
            this.txtsemister.Size = new System.Drawing.Size(405, 43);
            this.txtsemister.TabIndex = 9;
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(164, 306);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(615, 104);
            this.lbloutput.TabIndex = 10;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(191, 449);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(235, 78);
            this.btnshowinfo.TabIndex = 11;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(505, 449);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(235, 78);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 578);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtsemister);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.Lblsemister);
            this.Controls.Add(this.lblstudentID);
            this.Controls.Add(this.lblname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Assignment1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentID;
        private System.Windows.Forms.Label Lblsemister;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemister;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
    }
}

