namespace Library
{
    partial class AuthorAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.AuthorsName = new System.Windows.Forms.TextBox();
            this.AuthorSurname = new System.Windows.Forms.TextBox();
            this.AuthorEmail = new System.Windows.Forms.TextBox();
            this.AuthorPhone = new System.Windows.Forms.TextBox();
            this.AuthorAbout = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author SurName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author About";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Location = new System.Drawing.Point(95, 196);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(71, 13);
            this.AuthorName.TabIndex = 5;
            this.AuthorName.Text = "Author Books";
            // 
            // AuthorsName
            // 
            this.AuthorsName.Location = new System.Drawing.Point(190, 61);
            this.AuthorsName.Name = "AuthorsName";
            this.AuthorsName.Size = new System.Drawing.Size(100, 20);
            this.AuthorsName.TabIndex = 6;
            // 
            // AuthorSurname
            // 
            this.AuthorSurname.Location = new System.Drawing.Point(190, 96);
            this.AuthorSurname.Name = "AuthorSurname";
            this.AuthorSurname.Size = new System.Drawing.Size(100, 20);
            this.AuthorSurname.TabIndex = 7;
            // 
            // AuthorEmail
            // 
            this.AuthorEmail.Location = new System.Drawing.Point(190, 129);
            this.AuthorEmail.Name = "AuthorEmail";
            this.AuthorEmail.Size = new System.Drawing.Size(100, 20);
            this.AuthorEmail.TabIndex = 8;
            // 
            // AuthorPhone
            // 
            this.AuthorPhone.Location = new System.Drawing.Point(190, 161);
            this.AuthorPhone.Name = "AuthorPhone";
            this.AuthorPhone.Size = new System.Drawing.Size(100, 20);
            this.AuthorPhone.TabIndex = 9;
            // 
            // AuthorAbout
            // 
            this.AuthorAbout.Location = new System.Drawing.Point(191, 226);
            this.AuthorAbout.Name = "AuthorAbout";
            this.AuthorAbout.Size = new System.Drawing.Size(100, 20);
            this.AuthorAbout.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Author";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(478, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 185);
            this.textBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(793, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Publisher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AuthorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AuthorAbout);
            this.Controls.Add(this.AuthorPhone);
            this.Controls.Add(this.AuthorEmail);
            this.Controls.Add(this.AuthorSurname);
            this.Controls.Add(this.AuthorsName);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthorAdd";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.TextBox AuthorsName;
        private System.Windows.Forms.TextBox AuthorSurname;
        private System.Windows.Forms.TextBox AuthorEmail;
        private System.Windows.Forms.TextBox AuthorPhone;
        private System.Windows.Forms.TextBox AuthorAbout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}