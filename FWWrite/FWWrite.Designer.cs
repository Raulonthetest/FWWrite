namespace WRITE_REGINFO
{
    partial class FWWrite
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
            this.devmtb = new System.Windows.Forms.TextBox();
            this.devctb = new System.Windows.Forms.TextBox();
            this.fbtb = new System.Windows.Forms.TextBox();
            this.fbdatetb = new System.Windows.Forms.TextBox();
            this.writebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.devmlbl = new System.Windows.Forms.Label();
            this.devclbl = new System.Windows.Forms.Label();
            this.fblbl = new System.Windows.Forms.Label();
            this.fwdatelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // devmtb
            // 
            this.devmtb.Location = new System.Drawing.Point(3, 20);
            this.devmtb.Name = "devmtb";
            this.devmtb.Size = new System.Drawing.Size(234, 21);
            this.devmtb.TabIndex = 0;
            // 
            // devctb
            // 
            this.devctb.Location = new System.Drawing.Point(3, 64);
            this.devctb.Name = "devctb";
            this.devctb.Size = new System.Drawing.Size(234, 21);
            this.devctb.TabIndex = 1;
            // 
            // fbtb
            // 
            this.fbtb.Location = new System.Drawing.Point(3, 108);
            this.fbtb.Name = "fbtb";
            this.fbtb.Size = new System.Drawing.Size(234, 21);
            this.fbtb.TabIndex = 2;
            // 
            // fbdatetb
            // 
            this.fbdatetb.Location = new System.Drawing.Point(3, 152);
            this.fbdatetb.Name = "fbdatetb";
            this.fbdatetb.Size = new System.Drawing.Size(234, 21);
            this.fbdatetb.TabIndex = 3;
            // 
            // writebtn
            // 
            this.writebtn.Location = new System.Drawing.Point(3, 179);
            this.writebtn.Name = "writebtn";
            this.writebtn.Size = new System.Drawing.Size(86, 21);
            this.writebtn.TabIndex = 4;
            this.writebtn.Text = "Write";
            this.writebtn.Click += new System.EventHandler(this.writebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(151, 179);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(86, 21);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // devmlbl
            // 
            this.devmlbl.Location = new System.Drawing.Point(3, 0);
            this.devmlbl.Name = "devmlbl";
            this.devmlbl.Size = new System.Drawing.Size(102, 17);
            this.devmlbl.Text = "Device Model";
            // 
            // devclbl
            // 
            this.devclbl.Location = new System.Drawing.Point(3, 44);
            this.devclbl.Name = "devclbl";
            this.devclbl.Size = new System.Drawing.Size(113, 17);
            this.devclbl.Text = "Device Codename";
            // 
            // fblbl
            // 
            this.fblbl.Location = new System.Drawing.Point(3, 88);
            this.fblbl.Name = "fblbl";
            this.fblbl.Size = new System.Drawing.Size(113, 17);
            this.fblbl.Text = "Firmware Build";
            // 
            // fwdatelbl
            // 
            this.fwdatelbl.Location = new System.Drawing.Point(3, 132);
            this.fwdatelbl.Name = "fwdatelbl";
            this.fwdatelbl.Size = new System.Drawing.Size(122, 17);
            this.fwdatelbl.Text = "Firmware Build Date";
            // 
            // FWWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 202);
            this.Controls.Add(this.fwdatelbl);
            this.Controls.Add(this.fblbl);
            this.Controls.Add(this.devclbl);
            this.Controls.Add(this.devmlbl);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.writebtn);
            this.Controls.Add(this.fbdatetb);
            this.Controls.Add(this.fbtb);
            this.Controls.Add(this.devctb);
            this.Controls.Add(this.devmtb);
            this.Name = "FWWrite";
            this.Text = "Write Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox devmtb;
        private System.Windows.Forms.TextBox devctb;
        private System.Windows.Forms.TextBox fbtb;
        private System.Windows.Forms.TextBox fbdatetb;
        private System.Windows.Forms.Button writebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label devmlbl;
        private System.Windows.Forms.Label devclbl;
        private System.Windows.Forms.Label fblbl;
        private System.Windows.Forms.Label fwdatelbl;
    }
}

