namespace TextFileToUI
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
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearOfBirth = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.specificRoleLabel = new System.Windows.Forms.Label();
            this.specificAttributeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(301, 415);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(75, 23);
            this.browseFileBtn.TabIndex = 0;
            this.browseFileBtn.Text = "Browse file";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Full Name:";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(128, 45);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(239, 20);
            this.fullNameBox.TabIndex = 2;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 90);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(67, 13);
            this.yearLabel.TabIndex = 1;
            this.yearLabel.Text = "Year of birth:";
            // 
            // yearOfBirth
            // 
            this.yearOfBirth.Location = new System.Drawing.Point(128, 90);
            this.yearOfBirth.Name = "yearOfBirth";
            this.yearOfBirth.Size = new System.Drawing.Size(239, 20);
            this.yearOfBirth.TabIndex = 2;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 139);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "City";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(128, 139);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(239, 20);
            this.cityBox.TabIndex = 2;
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Location = new System.Drawing.Point(12, 188);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(41, 13);
            this.facultyLabel.TabIndex = 1;
            this.facultyLabel.Text = "Faculty";
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(128, 185);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(239, 20);
            this.facultyBox.TabIndex = 2;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(12, 237);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(32, 13);
            this.roleLabel.TabIndex = 1;
            this.roleLabel.Text = "Role:";
            // 
            // roleBox
            // 
            this.roleBox.Location = new System.Drawing.Point(128, 234);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(239, 20);
            this.roleBox.TabIndex = 2;
            // 
            // specificRoleLabel
            // 
            this.specificRoleLabel.AutoSize = true;
            this.specificRoleLabel.Location = new System.Drawing.Point(12, 294);
            this.specificRoleLabel.Name = "specificRoleLabel";
            this.specificRoleLabel.Size = new System.Drawing.Size(110, 13);
            this.specificRoleLabel.TabIndex = 1;
            this.specificRoleLabel.Text = "[role specific attribute]";
            // 
            // specificAttributeBox
            // 
            this.specificAttributeBox.Location = new System.Drawing.Point(128, 291);
            this.specificAttributeBox.Name = "specificAttributeBox";
            this.specificAttributeBox.Size = new System.Drawing.Size(239, 20);
            this.specificAttributeBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.specificAttributeBox);
            this.Controls.Add(this.specificRoleLabel);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.yearOfBirth);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.browseFileBtn);
            this.Name = "Form1";
            this.Text = "File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearOfBirth;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox roleBox;
        private System.Windows.Forms.Label specificRoleLabel;
        private System.Windows.Forms.TextBox specificAttributeBox;
    }
}

