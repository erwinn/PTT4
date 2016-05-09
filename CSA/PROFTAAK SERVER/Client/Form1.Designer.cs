namespace Client
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNrOfCalculations = new System.Windows.Forms.Button();
            this.txtNrOfCalculations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(13, 13);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(257, 22);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(13, 115);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(257, 22);
            this.txtN2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.Location = new System.Drawing.Point(84, 54);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(56, 55);
            this.btnSubstract.TabIndex = 3;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(146, 54);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(56, 55);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(208, 54);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(56, 55);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(119, 140);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 48);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(13, 191);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(257, 22);
            this.txtAnswer.TabIndex = 7;
            // 
            // btnNrOfCalculations
            // 
            this.btnNrOfCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNrOfCalculations.Location = new System.Drawing.Point(13, 220);
            this.btnNrOfCalculations.Name = "btnNrOfCalculations";
            this.btnNrOfCalculations.Size = new System.Drawing.Size(257, 40);
            this.btnNrOfCalculations.TabIndex = 8;
            this.btnNrOfCalculations.Text = "Nr Of Calculations";
            this.btnNrOfCalculations.UseVisualStyleBackColor = true;
            this.btnNrOfCalculations.Click += new System.EventHandler(this.btnNrOfCalculations_Click);
            // 
            // txtNrOfCalculations
            // 
            this.txtNrOfCalculations.Location = new System.Drawing.Point(13, 266);
            this.txtNrOfCalculations.Name = "txtNrOfCalculations";
            this.txtNrOfCalculations.ReadOnly = true;
            this.txtNrOfCalculations.Size = new System.Drawing.Size(257, 22);
            this.txtNrOfCalculations.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 300);
            this.Controls.Add(this.txtNrOfCalculations);
            this.Controls.Add(this.btnNrOfCalculations);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNrOfCalculations;
        private System.Windows.Forms.TextBox txtNrOfCalculations;
    }
}

