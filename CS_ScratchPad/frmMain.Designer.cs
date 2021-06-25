namespace CS_ScratchPad
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
            this.btnSayHello = new System.Windows.Forms.Button();
            this.lblSayHello = new System.Windows.Forms.Label();
            this.lblSayName = new System.Windows.Forms.Label();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(173, 48);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(139, 38);
            this.btnSayHello.TabIndex = 1;
            this.btnSayHello.Text = "&Hello!";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // lblSayHello
            // 
            this.lblSayHello.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayHello.Location = new System.Drawing.Point(81, 111);
            this.lblSayHello.Name = "lblSayHello";
            this.lblSayHello.Size = new System.Drawing.Size(322, 32);
            this.lblSayHello.TabIndex = 2;
            this.lblSayHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayName
            // 
            this.lblSayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayName.Location = new System.Drawing.Point(81, 166);
            this.lblSayName.Name = "lblSayName";
            this.lblSayName.Size = new System.Drawing.Size(322, 32);
            this.lblSayName.TabIndex = 2;
            this.lblSayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(173, 227);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(139, 38);
            this.btnGoodbye.TabIndex = 1;
            this.btnGoodbye.Text = "&Goodbye";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.lblSayName);
            this.Controls.Add(this.lblSayHello);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.btnSayHello);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#: Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label lblSayHello;
        private System.Windows.Forms.Label lblSayName;
        private System.Windows.Forms.Button btnGoodbye;
    }
}

