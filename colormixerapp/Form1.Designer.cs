namespace colormixerapp
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
            this.RedBulb = new System.Windows.Forms.PictureBox();
            this.GreenBulb = new System.Windows.Forms.PictureBox();
            this.BlueBulb = new System.Windows.Forms.PictureBox();
            this.SetColorsButton = new System.Windows.Forms.Button();
            this.RedValue = new System.Windows.Forms.TextBox();
            this.GreenValue = new System.Windows.Forms.TextBox();
            this.BlueValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedBulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBulb)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBulb
            // 
            this.RedBulb.Location = new System.Drawing.Point(12, 120);
            this.RedBulb.Name = "RedBulb";
            this.RedBulb.Size = new System.Drawing.Size(140, 140);
            this.RedBulb.TabIndex = 0;
            this.RedBulb.TabStop = false;
            // 
            // GreenBulb
            // 
            this.GreenBulb.Location = new System.Drawing.Point(171, 120);
            this.GreenBulb.Name = "GreenBulb";
            this.GreenBulb.Size = new System.Drawing.Size(140, 140);
            this.GreenBulb.TabIndex = 1;
            this.GreenBulb.TabStop = false;
            // 
            // BlueBulb
            // 
            this.BlueBulb.Location = new System.Drawing.Point(326, 120);
            this.BlueBulb.Name = "BlueBulb";
            this.BlueBulb.Size = new System.Drawing.Size(140, 140);
            this.BlueBulb.TabIndex = 2;
            this.BlueBulb.TabStop = false;
            // 
            // SetColorsButton
            // 
            this.SetColorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SetColorsButton.Location = new System.Drawing.Point(61, 266);
            this.SetColorsButton.Name = "SetColorsButton";
            this.SetColorsButton.Size = new System.Drawing.Size(357, 76);
            this.SetColorsButton.TabIndex = 3;
            this.SetColorsButton.Text = "Set Colors";
            this.SetColorsButton.UseVisualStyleBackColor = true;
            this.SetColorsButton.Click += new System.EventHandler(this.SetColorsButton_Click);
            // 
            // RedValue
            // 
            this.RedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RedValue.Location = new System.Drawing.Point(34, 68);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(100, 31);
            this.RedValue.TabIndex = 5;
            this.RedValue.Text = "255";
            this.RedValue.TextChanged += new System.EventHandler(this.RedValue_TextChanged);
            // 
            // GreenValue
            // 
            this.GreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.GreenValue.Location = new System.Drawing.Point(187, 68);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(100, 31);
            this.GreenValue.TabIndex = 6;
            this.GreenValue.Text = "255";
            // 
            // BlueValue
            // 
            this.BlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BlueValue.Location = new System.Drawing.Point(342, 68);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(100, 31);
            this.BlueValue.TabIndex = 7;
            this.BlueValue.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 412);
            this.Controls.Add(this.BlueValue);
            this.Controls.Add(this.GreenValue);
            this.Controls.Add(this.RedValue);
            this.Controls.Add(this.SetColorsButton);
            this.Controls.Add(this.BlueBulb);
            this.Controls.Add(this.GreenBulb);
            this.Controls.Add(this.RedBulb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedBulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedBulb;
        private System.Windows.Forms.PictureBox GreenBulb;
        private System.Windows.Forms.PictureBox BlueBulb;
        private System.Windows.Forms.Button SetColorsButton;
        private System.Windows.Forms.TextBox RedValue;
        private System.Windows.Forms.TextBox GreenValue;
        private System.Windows.Forms.TextBox BlueValue;
    }
}

