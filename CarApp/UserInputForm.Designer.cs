namespace CarApp
{
    partial class UserInputForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYearInput = new System.Windows.Forms.Label();
            this.maskedTextBoxCar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(245, 155);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(184, 38);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(174, 31);
            this.textBoxCar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Car Make";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelYearInput
            // 
            this.labelYearInput.AutoSize = true;
            this.labelYearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearInput.Location = new System.Drawing.Point(23, 91);
            this.labelYearInput.Name = "labelYearInput";
            this.labelYearInput.Size = new System.Drawing.Size(133, 24);
            this.labelYearInput.TabIndex = 4;
            this.labelYearInput.Text = "Enter Car Year";
            // 
            // maskedTextBoxCar
            // 
            this.maskedTextBoxCar.Location = new System.Drawing.Point(184, 91);
            this.maskedTextBoxCar.Mask = "0000";
            this.maskedTextBoxCar.Name = "maskedTextBoxCar";
            this.maskedTextBoxCar.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBoxCar.TabIndex = 5;
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(385, 206);
            this.Controls.Add(this.maskedTextBoxCar);
            this.Controls.Add(this.labelYearInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.btnSubmit);
            this.Name = "UserInputForm";
            this.Text = "UserInputForm";
            this.Load += new System.EventHandler(this.UserInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYearInput;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCar;
    }
}