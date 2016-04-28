namespace piClient
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
            this.Hello = new System.Windows.Forms.Button();
            this.SendHash = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Validacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(75, 12);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(148, 51);
            this.Hello.TabIndex = 0;
            this.Hello.Text = "Hello";
            this.Hello.UseVisualStyleBackColor = true;
            this.Hello.Click += new System.EventHandler(this.Hello_Click);
            // 
            // SendHash
            // 
            this.SendHash.Location = new System.Drawing.Point(75, 69);
            this.SendHash.Name = "SendHash";
            this.SendHash.Size = new System.Drawing.Size(148, 53);
            this.SendHash.TabIndex = 1;
            this.SendHash.Text = "SendHash";
            this.SendHash.UseVisualStyleBackColor = true;
            this.SendHash.Click += new System.EventHandler(this.SendHash_Click);
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(75, 138);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(148, 20);
            this.Box1.TabIndex = 2;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(75, 164);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(148, 20);
            this.Box2.TabIndex = 3;
            // 
            // Validacija
            // 
            this.Validacija.Location = new System.Drawing.Point(75, 190);
            this.Validacija.Name = "Validacija";
            this.Validacija.Size = new System.Drawing.Size(148, 40);
            this.Validacija.TabIndex = 4;
            this.Validacija.Text = "Validacija";
            this.Validacija.UseVisualStyleBackColor = true;
            this.Validacija.Click += new System.EventHandler(this.Validacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.Validacija);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.SendHash);
            this.Controls.Add(this.Hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hello;
        private System.Windows.Forms.Button SendHash;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.Button Validacija;
    }
}

