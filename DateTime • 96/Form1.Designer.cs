namespace DateTime___96
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
            this.btnMinValue = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinValue
            // 
            this.btnMinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinValue.Location = new System.Drawing.Point(21, 56);
            this.btnMinValue.Name = "btnMinValue";
            this.btnMinValue.Size = new System.Drawing.Size(112, 49);
            this.btnMinValue.TabIndex = 1;
            this.btnMinValue.Text = "MinValue";
            this.btnMinValue.UseVisualStyleBackColor = true;
            this.btnMinValue.Click += new System.EventHandler(this.btnMinValue_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(17, 22);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(27, 20);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "***";
            // 
            // MaxValue
            // 
            this.MaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaxValue.Location = new System.Drawing.Point(139, 56);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(112, 49);
            this.MaxValue.TabIndex = 3;
            this.MaxValue.Text = "MaxValue";
            this.MaxValue.UseVisualStyleBackColor = true;
            this.MaxValue.Click += new System.EventHandler(this.MaxValue_Click);
            // 
            // btnNow
            // 
            this.btnNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNow.Location = new System.Drawing.Point(21, 111);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(112, 49);
            this.btnNow.TabIndex = 4;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToday.Location = new System.Drawing.Point(139, 111);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(112, 49);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(272, 180);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnMinValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinValue;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button MaxValue;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnToday;
    }
}

