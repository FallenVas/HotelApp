
namespace application_de_hotele.forms
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_FRM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.TextBox();
            this.BOX_pass = new System.Windows.Forms.TextBox();
            this.BTN_COX = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(6)))));
            this.panel1.Controls.Add(this.BTN_FRM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 23);
            this.panel1.TabIndex = 0;
            // 
            // BTN_FRM
            // 
            this.BTN_FRM.BackColor = System.Drawing.Color.Transparent;
            this.BTN_FRM.FlatAppearance.BorderSize = 0;
            this.BTN_FRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FRM.Image = global::application_de_hotele.Properties.Resources.close;
            this.BTN_FRM.Location = new System.Drawing.Point(448, -1);
            this.BTN_FRM.Name = "BTN_FRM";
            this.BTN_FRM.Size = new System.Drawing.Size(24, 25);
            this.BTN_FRM.TabIndex = 10;
            this.BTN_FRM.UseVisualStyleBackColor = false;
            this.BTN_FRM.Click += new System.EventHandler(this.BTN_FRM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.box_name.Location = new System.Drawing.Point(143, 175);
            this.box_name.Multiline = true;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(257, 35);
            this.box_name.TabIndex = 8;
            this.box_name.Text = "User Name";
            this.box_name.Enter += new System.EventHandler(this.box_name_Enter);
            this.box_name.Leave += new System.EventHandler(this.box_name_Leave);
            // 
            // BOX_pass
            // 
            this.BOX_pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BOX_pass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BOX_pass.Location = new System.Drawing.Point(143, 251);
            this.BOX_pass.Multiline = true;
            this.BOX_pass.Name = "BOX_pass";
            this.BOX_pass.Size = new System.Drawing.Size(257, 35);
            this.BOX_pass.TabIndex = 9;
            this.BOX_pass.Text = "Password";
            this.BOX_pass.Enter += new System.EventHandler(this.BOX_pass_Enter);
            this.BOX_pass.Leave += new System.EventHandler(this.BOX_pass_Leave);
            // 
            // BTN_COX
            // 
            this.BTN_COX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(6)))));
            this.BTN_COX.FlatAppearance.BorderSize = 0;
            this.BTN_COX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_COX.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COX.ForeColor = System.Drawing.Color.White;
            this.BTN_COX.Location = new System.Drawing.Point(198, 298);
            this.BTN_COX.Name = "BTN_COX";
            this.BTN_COX.Size = new System.Drawing.Size(108, 28);
            this.BTN_COX.TabIndex = 10;
            this.BTN_COX.Text = "Se Connecter";
            this.BTN_COX.UseVisualStyleBackColor = false;
            this.BTN_COX.Click += new System.EventHandler(this.BTN_COX_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::application_de_hotele.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(80, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::application_de_hotele.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(80, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::application_de_hotele.Properties.Resources.LogoTrans;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::application_de_hotele.Properties.Resources.LogoTrans;
            this.pictureBox1.InitialImage = global::application_de_hotele.Properties.Resources.LogoTrans;
            this.pictureBox1.Location = new System.Drawing.Point(143, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 140);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(475, 371);
            this.Controls.Add(this.BTN_COX);
            this.Controls.Add(this.BOX_pass);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.TextBox BOX_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_FRM;
        private System.Windows.Forms.Button BTN_COX;
    }
}