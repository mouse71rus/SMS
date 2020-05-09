namespace SMS
{
    partial class ResultForm
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
            this.MatrixOfState = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfState)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixOfState
            // 
            this.MatrixOfState.AllowUserToAddRows = false;
            this.MatrixOfState.AllowUserToDeleteRows = false;
            this.MatrixOfState.AllowUserToResizeRows = false;
            this.MatrixOfState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatrixOfState.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.MatrixOfState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixOfState.Location = new System.Drawing.Point(12, 12);
            this.MatrixOfState.MultiSelect = false;
            this.MatrixOfState.Name = "MatrixOfState";
            this.MatrixOfState.Size = new System.Drawing.Size(776, 200);
            this.MatrixOfState.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 218);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "X1 процедур";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Count_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 218);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "X2 процедур";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Count_CheckedChanged);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 247);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.MatrixOfState);
            this.Name = "ResultForm";
            this.Text = "Вероятности переходов";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixOfState;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}