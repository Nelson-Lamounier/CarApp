namespace CarApp
{
    partial class CarClass
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
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.txtCarY = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(175, 46);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(100, 31);
            this.txtCarMake.TabIndex = 0;
            // 
            // txtCarY
            // 
            this.txtCarY.Location = new System.Drawing.Point(175, 106);
            this.txtCarY.Name = "txtCarY";
            this.txtCarY.Size = new System.Drawing.Size(100, 31);
            this.txtCarY.TabIndex = 1;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(175, 160);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 31);
            this.txtSpeed.TabIndex = 2;
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMake.Location = new System.Drawing.Point(56, 49);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(90, 24);
            this.labelMake.TabIndex = 3;
            this.labelMake.Text = "Car Make";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(56, 112);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(83, 24);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Car Year";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(18, 166);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(133, 24);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Current Speed";
            this.labelSpeed.Click += new System.EventHandler(this.labelSpeed_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreak.Location = new System.Drawing.Point(200, 216);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(75, 35);
            this.btnBreak.TabIndex = 6;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Location = new System.Drawing.Point(108, 216);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(75, 35);
            this.btnAcc.TabIndex = 8;
            this.btnAcc.Text = "Accelerate";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // CarClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(335, 277);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtCarY);
            this.Controls.Add(this.txtCarMake);
            this.Name = "CarClass";
            this.Text = "Car Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.TextBox txtCarY;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAcc;
    }
}

