namespace Priprema
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
            this.ReceiveContainer = new System.Windows.Forms.TextBox();
            this.StartListeningAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiveContainer
            // 
            this.ReceiveContainer.Location = new System.Drawing.Point(12, 12);
            this.ReceiveContainer.Multiline = true;
            this.ReceiveContainer.Name = "ReceiveContainer";
            this.ReceiveContainer.Size = new System.Drawing.Size(260, 174);
            this.ReceiveContainer.TabIndex = 0;
            // 
            // StartListeningAction
            // 
            this.StartListeningAction.Location = new System.Drawing.Point(12, 206);
            this.StartListeningAction.Name = "StartListeningAction";
            this.StartListeningAction.Size = new System.Drawing.Size(146, 34);
            this.StartListeningAction.TabIndex = 1;
            this.StartListeningAction.Text = "Start Listening";
            this.StartListeningAction.UseVisualStyleBackColor = true;
            this.StartListeningAction.Click += new System.EventHandler(this.StartListeningAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.StartListeningAction);
            this.Controls.Add(this.ReceiveContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiveContainer;
        private System.Windows.Forms.Button StartListeningAction;
    }
}

