namespace WhoWantsToBeAMillionaire
{
    partial class Infile
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
            this.fimdFbutton = new System.Windows.Forms.Button();
            this.browseText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fimdFbutton
            // 
            this.fimdFbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fimdFbutton.Location = new System.Drawing.Point(125, 110);
            this.fimdFbutton.Margin = new System.Windows.Forms.Padding(2);
            this.fimdFbutton.Name = "fimdFbutton";
            this.fimdFbutton.Size = new System.Drawing.Size(110, 49);
            this.fimdFbutton.TabIndex = 0;
            this.fimdFbutton.Text = "Find file ";
            this.fimdFbutton.UseVisualStyleBackColor = true;
            this.fimdFbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // browseText
            // 
            this.browseText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.browseText.Location = new System.Drawing.Point(87, 73);
            this.browseText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.browseText.Name = "browseText";
            this.browseText.Size = new System.Drawing.Size(193, 46);
            this.browseText.TabIndex = 2;
            this.browseText.Text = "      Browse Text Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Infile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseText);
            this.Controls.Add(this.fimdFbutton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Infile";
            this.Text = "WWTBM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fimdFbutton;
        private System.Windows.Forms.Label browseText;
        private System.Windows.Forms.Label label2;
    }
}

