
namespace formAddTwoNumber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnAddTwoNumber = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.LightGreen;
            this.txtA.Location = new System.Drawing.Point(15, 15);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(94, 27);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.LightGreen;
            this.txtB.Location = new System.Drawing.Point(15, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(94, 27);
            this.txtB.TabIndex = 1;
            // 
            // btnAddTwoNumber
            // 
            this.btnAddTwoNumber.Location = new System.Drawing.Point(15, 149);
            this.btnAddTwoNumber.Name = "btnAddTwoNumber";
            this.btnAddTwoNumber.Size = new System.Drawing.Size(94, 29);
            this.btnAddTwoNumber.TabIndex = 2;
            this.btnAddTwoNumber.Text = "Add";
            this.btnAddTwoNumber.UseCompatibleTextRendering = true;
            this.btnAddTwoNumber.UseVisualStyleBackColor = true;
            this.btnAddTwoNumber.Click += new System.EventHandler(this.btnAddTwoNumber_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtResult.Location = new System.Drawing.Point(181, 151);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(94, 27);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAddTwoNumber);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnAddTwoNumber;
        private System.Windows.Forms.TextBox txtResult;
    }
}

