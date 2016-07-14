namespace ContactManager
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContacts = new System.Windows.Forms.Label();
            this.listboxContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "EMail Address";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Location = new System.Drawing.Point(23, 128);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(49, 13);
            this.lblContacts.TabIndex = 5;
            this.lblContacts.Text = "Contacts";
            // 
            // listboxContacts
            // 
            this.listboxContacts.FormattingEnabled = true;
            this.listboxContacts.Location = new System.Drawing.Point(26, 154);
            this.listboxContacts.Name = "listboxContacts";
            this.listboxContacts.Size = new System.Drawing.Size(234, 160);
            this.listboxContacts.TabIndex = 6;
            this.listboxContacts.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 342);
            this.Controls.Add(this.listboxContacts);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "EMail Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.ListBox listboxContacts;
    }
}

