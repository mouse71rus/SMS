namespace SMS
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MatrixOfState = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.Button();
            this.CountStep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfExperiments = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfState)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.MatrixOfState.Location = new System.Drawing.Point(12, 27);
            this.MatrixOfState.MultiSelect = false;
            this.MatrixOfState.Name = "MatrixOfState";
            this.MatrixOfState.Size = new System.Drawing.Size(776, 268);
            this.MatrixOfState.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(675, 303);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(113, 33);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CountStep
            // 
            this.CountStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountStep.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountStep.Location = new System.Drawing.Point(597, 304);
            this.CountStep.Name = "CountStep";
            this.CountStep.Size = new System.Drawing.Size(72, 29);
            this.CountStep.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(542, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шаг";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число экспериментов";
            // 
            // NumberOfExperiments
            // 
            this.NumberOfExperiments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfExperiments.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfExperiments.Location = new System.Drawing.Point(219, 303);
            this.NumberOfExperiments.Name = "NumberOfExperiments";
            this.NumberOfExperiments.Size = new System.Drawing.Size(113, 29);
            this.NumberOfExperiments.TabIndex = 4;
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Run.Location = new System.Drawing.Point(338, 303);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(123, 29);
            this.Run.TabIndex = 6;
            this.Run.Text = "Моделировать";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfExperiments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountStep);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.MatrixOfState);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "СМО";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfState)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixOfState;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox CountStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberOfExperiments;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

