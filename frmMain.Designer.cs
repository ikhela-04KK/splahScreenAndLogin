namespace splahScreen_and_Login
{
    partial class frmMain
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gretting = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.TxtPasswordTwo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BnCheckAgree = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.TxtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseLoginTag = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.borderRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.Gretting);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(429, 662);
            this.panelLeft.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("JetBrains Mono ExtraLight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "easy to use , easy to share";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL", 6F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "version 1.0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "A powerful yes easy to use application for managing venue geospatial data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gretting
            // 
            this.Gretting.AutoSize = true;
            this.Gretting.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gretting.ForeColor = System.Drawing.Color.White;
            this.Gretting.Location = new System.Drawing.Point(127, 184);
            this.Gretting.Name = "Gretting";
            this.Gretting.Size = new System.Drawing.Size(159, 44);
            this.Gretting.TabIndex = 0;
            this.Gretting.Text = "IKHELA.";
            this.Gretting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.CloseLoginTag);
            this.panelRight.Controls.Add(this.TxtPasswordTwo);
            this.panelRight.Controls.Add(this.BnCheckAgree);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.SignUp);
            this.panelRight.Controls.Add(this.TxtMail);
            this.panelRight.Controls.Add(this.TxtPassword);
            this.panelRight.Controls.Add(this.TxtUser);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(429, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(406, 662);
            this.panelRight.TabIndex = 1;
            // 
            // TxtPasswordTwo
            // 
            this.TxtPasswordTwo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPasswordTwo.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswordTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPasswordTwo.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPasswordTwo.HintText = "password";
            this.TxtPasswordTwo.isPassword = true;
            this.TxtPasswordTwo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPasswordTwo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPasswordTwo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPasswordTwo.LineThickness = 3;
            this.TxtPasswordTwo.Location = new System.Drawing.Point(48, 338);
            this.TxtPasswordTwo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPasswordTwo.Name = "TxtPasswordTwo";
            this.TxtPasswordTwo.Size = new System.Drawing.Size(326, 52);
            this.TxtPasswordTwo.TabIndex = 4;
            this.TxtPasswordTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BnCheckAgree
            // 
            this.BnCheckAgree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.BnCheckAgree.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.BnCheckAgree.Checked = true;
            this.BnCheckAgree.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.BnCheckAgree.ForeColor = System.Drawing.Color.White;
            this.BnCheckAgree.Location = new System.Drawing.Point(48, 516);
            this.BnCheckAgree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BnCheckAgree.Name = "BnCheckAgree";
            this.BnCheckAgree.Size = new System.Drawing.Size(20, 20);
            this.BnCheckAgree.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono NL", 6F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(75, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "I agree Terms And Conditions";
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.SignUp.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.White;
            this.SignUp.Location = new System.Drawing.Point(48, 556);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(326, 46);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMail.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtMail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtMail.HintText = "Email";
            this.TxtMail.isPassword = false;
            this.TxtMail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtMail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtMail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtMail.LineThickness = 3;
            this.TxtMail.Location = new System.Drawing.Point(48, 426);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(326, 52);
            this.TxtMail.TabIndex = 1;
            this.TxtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPassword.HintText = "Password";
            this.TxtPassword.isPassword = true;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtPassword.LineThickness = 3;
            this.TxtPassword.Location = new System.Drawing.Point(48, 253);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(326, 52);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtUser
            // 
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.Font = new System.Drawing.Font("JetBrains Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtUser.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUser.HintText = "Full Name";
            this.TxtUser.isPassword = false;
            this.TxtUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtUser.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.TxtUser.LineThickness = 3;
            this.TxtUser.Location = new System.Drawing.Point(48, 176);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(326, 52);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(132, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sign Up";
            // 
            // CloseLoginTag
            // 
            this.CloseLoginTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLoginTag.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLoginTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(78)))));
            this.CloseLoginTag.Location = new System.Drawing.Point(355, 9);
            this.CloseLoginTag.Name = "CloseLoginTag";
            this.CloseLoginTag.Size = new System.Drawing.Size(39, 43);
            this.CloseLoginTag.TabIndex = 5;
            this.CloseLoginTag.Text = "X";
            this.CloseLoginTag.Click += new System.EventHandler(this.label6_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // borderRadius
            // 
            this.borderRadius.ElipseRadius = 25;
            this.borderRadius.TargetControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 662);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label Gretting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtMail;
        private System.Windows.Forms.Button SignUp;
        private Bunifu.Framework.UI.BunifuCheckbox BnCheckAgree;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPasswordTwo;
        private System.Windows.Forms.Label CloseLoginTag;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse borderRadius;
    }
}