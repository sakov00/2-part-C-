namespace Sakov.laba5
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchOfCountApart = new System.Windows.Forms.Button();
            this.SearchOfYears = new System.Windows.Forms.Button();
            this.SearchOfStreet = new System.Windows.Forms.Button();
            this.SeachOfTown = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(458, 256);
            this.textBox1.TabIndex = 0;
            // 
            // SearchOfCountApart
            // 
            this.SearchOfCountApart.Location = new System.Drawing.Point(67, 16);
            this.SearchOfCountApart.Name = "SearchOfCountApart";
            this.SearchOfCountApart.Size = new System.Drawing.Size(110, 23);
            this.SearchOfCountApart.TabIndex = 1;
            this.SearchOfCountApart.Text = "Кол-во квартир";
            this.SearchOfCountApart.UseVisualStyleBackColor = true;
            this.SearchOfCountApart.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchOfYears
            // 
            this.SearchOfYears.Location = new System.Drawing.Point(183, 16);
            this.SearchOfYears.Name = "SearchOfYears";
            this.SearchOfYears.Size = new System.Drawing.Size(110, 23);
            this.SearchOfYears.TabIndex = 2;
            this.SearchOfYears.Text = "Год постройки";
            this.SearchOfYears.UseVisualStyleBackColor = true;
            this.SearchOfYears.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchOfStreet
            // 
            this.SearchOfStreet.Location = new System.Drawing.Point(299, 16);
            this.SearchOfStreet.Name = "SearchOfStreet";
            this.SearchOfStreet.Size = new System.Drawing.Size(110, 23);
            this.SearchOfStreet.TabIndex = 3;
            this.SearchOfStreet.Text = "Улица";
            this.SearchOfStreet.UseVisualStyleBackColor = true;
            this.SearchOfStreet.Click += new System.EventHandler(this.button3_Click);
            // 
            // SeachOfTown
            // 
            this.SeachOfTown.Location = new System.Drawing.Point(415, 16);
            this.SeachOfTown.Name = "SeachOfTown";
            this.SeachOfTown.Size = new System.Drawing.Size(110, 23);
            this.SeachOfTown.TabIndex = 4;
            this.SeachOfTown.Text = "Город";
            this.SeachOfTown.UseVisualStyleBackColor = true;
            this.SeachOfTown.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(415, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(110, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(110, 20);
            this.textBox5.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SeachOfTown);
            this.Controls.Add(this.SearchOfStreet);
            this.Controls.Add(this.SearchOfYears);
            this.Controls.Add(this.SearchOfCountApart);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchOfCountApart;
        private System.Windows.Forms.Button SearchOfYears;
        private System.Windows.Forms.Button SearchOfStreet;
        private System.Windows.Forms.Button SeachOfTown;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
    }
}