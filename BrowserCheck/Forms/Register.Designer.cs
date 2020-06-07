namespace BrowserCheck.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.saveUser = new System.Windows.Forms.Button();
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.CancelProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password : ";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(95, 8);
            this.nameText.MaxLength = 255;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(237, 20);
            this.nameText.TabIndex = 4;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(95, 48);
            this.surnameText.MaxLength = 255;
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(237, 20);
            this.surnameText.TabIndex = 5;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(95, 87);
            this.emailText.MaxLength = 255;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(237, 20);
            this.emailText.TabIndex = 6;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(95, 127);
            this.passwordText.MaxLength = 255;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(237, 20);
            this.passwordText.TabIndex = 7;
            // 
            // saveUser
            // 
            this.saveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.saveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveUser.ImageIndex = 0;
            this.saveUser.ImageList = this.imageListButton;
            this.saveUser.Location = new System.Drawing.Point(139, 172);
            this.saveUser.Name = "saveUser";
            this.saveUser.Size = new System.Drawing.Size(82, 34);
            this.saveUser.TabIndex = 8;
            this.saveUser.Text = "Save";
            this.saveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveUser.UseVisualStyleBackColor = false;
            this.saveUser.Click += new System.EventHandler(this.saveUser_Click);
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "register.png");
            this.imageListButton.Images.SetKeyName(1, "close.png");
            // 
            // CancelProcess
            // 
            this.CancelProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CancelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelProcess.ImageIndex = 1;
            this.CancelProcess.ImageList = this.imageListButton;
            this.CancelProcess.Location = new System.Drawing.Point(131, 212);
            this.CancelProcess.Name = "CancelProcess";
            this.CancelProcess.Size = new System.Drawing.Size(100, 34);
            this.CancelProcess.TabIndex = 9;
            this.CancelProcess.Text = "Cancel";
            this.CancelProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelProcess.UseVisualStyleBackColor = false;
            this.CancelProcess.Click += new System.EventHandler(this.CancelProcess_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BrowserCheck.Properties.Resources.registertrans1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(339, 283);
            this.ControlBox = false;
            this.Controls.Add(this.CancelProcess);
            this.Controls.Add(this.saveUser);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button saveUser;
        private System.Windows.Forms.Button CancelProcess;
        private System.Windows.Forms.ImageList imageListButton;
    }
}