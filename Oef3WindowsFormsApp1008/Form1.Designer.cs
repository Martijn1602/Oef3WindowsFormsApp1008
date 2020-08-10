namespace Oef3WindowsFormsApp1008
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
            this.lbLijst = new System.Windows.Forms.ListBox();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.btnKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLijst
            // 
            this.lbLijst.FormattingEnabled = true;
            this.lbLijst.Location = new System.Drawing.Point(43, 37);
            this.lbLijst.Name = "lbLijst";
            this.lbLijst.Size = new System.Drawing.Size(125, 212);
            this.lbLijst.TabIndex = 0;
            this.lbLijst.SelectedIndexChanged += new System.EventHandler(this.lbLijst_SelectedIndexChanged);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(43, 272);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(125, 20);
            this.txtTekst.TabIndex = 1;
            this.txtTekst.TextChanged += new System.EventHandler(this.txtTekst_TextChanged);
            // 
            // btnKnop
            // 
            this.btnKnop.Location = new System.Drawing.Point(43, 316);
            this.btnKnop.Name = "btnKnop";
            this.btnKnop.Size = new System.Drawing.Size(125, 31);
            this.btnKnop.TabIndex = 2;
            this.btnKnop.Text = "Filter";
            this.btnKnop.UseVisualStyleBackColor = true;
            this.btnKnop.Click += new System.EventHandler(this.btnKnop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKnop);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.lbLijst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLijst;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.Button btnKnop;
    }
}

