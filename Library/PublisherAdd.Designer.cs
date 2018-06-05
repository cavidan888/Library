namespace Library
{
    partial class PublisherAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.PublisherAdress = new System.Windows.Forms.TextBox();
            this.PublisherPhone = new System.Windows.Forms.TextBox();
            this.PublisherEmail = new System.Windows.Forms.TextBox();
            this.PublisherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Publisher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PublisherAdress
            // 
            this.PublisherAdress.Location = new System.Drawing.Point(205, 227);
            this.PublisherAdress.Name = "PublisherAdress";
            this.PublisherAdress.Size = new System.Drawing.Size(100, 20);
            this.PublisherAdress.TabIndex = 22;
            // 
            // PublisherPhone
            // 
            this.PublisherPhone.Location = new System.Drawing.Point(205, 195);
            this.PublisherPhone.Name = "PublisherPhone";
            this.PublisherPhone.Size = new System.Drawing.Size(100, 20);
            this.PublisherPhone.TabIndex = 21;
            // 
            // PublisherEmail
            // 
            this.PublisherEmail.Location = new System.Drawing.Point(205, 162);
            this.PublisherEmail.Name = "PublisherEmail";
            this.PublisherEmail.Size = new System.Drawing.Size(100, 20);
            this.PublisherEmail.TabIndex = 20;
            // 
            // PublisherName
            // 
            this.PublisherName.Location = new System.Drawing.Point(205, 127);
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Size = new System.Drawing.Size(100, 20);
            this.PublisherName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Publisher Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Publisher Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Publisher Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Publisher Name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(496, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 40);
            this.button4.TabIndex = 26;
            this.button4.Text = "Add Book";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PublisherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PublisherAdress);
            this.Controls.Add(this.PublisherPhone);
            this.Controls.Add(this.PublisherEmail);
            this.Controls.Add(this.PublisherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PublisherAdd";
            this.Text = "publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PublisherAdress;
        private System.Windows.Forms.TextBox PublisherPhone;
        private System.Windows.Forms.TextBox PublisherEmail;
        private System.Windows.Forms.TextBox PublisherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}