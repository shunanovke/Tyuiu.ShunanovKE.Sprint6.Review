
namespace Tyuiu.ShunanovKE.Sprint6.TaskReview.V17
{
    partial class FormMain
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
            this.panelMatrix_SKE = new System.Windows.Forms.Panel();
            this.buttonGetMatrix_SKE = new System.Windows.Forms.Button();
            this.groupBoxInPutMatrix_SKE = new System.Windows.Forms.GroupBox();
            this.labelN1_SKE = new System.Windows.Forms.Label();
            this.labelN2_SKE = new System.Windows.Forms.Label();
            this.labelCols_SKE = new System.Windows.Forms.Label();
            this.labelRows_SKE = new System.Windows.Forms.Label();
            this.textBoxN2_SKE = new System.Windows.Forms.TextBox();
            this.textBoxN1_SKE = new System.Windows.Forms.TextBox();
            this.textBoxM_SKE = new System.Windows.Forms.TextBox();
            this.textBoxN_SKE = new System.Windows.Forms.TextBox();
            this.groupBoxMatrix_SKE = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SKE = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelRight_SKE = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SKE = new System.Windows.Forms.GroupBox();
            this.labelOutPut_SKE = new System.Windows.Forms.Label();
            this.textBoxOutPut_SKE = new System.Windows.Forms.TextBox();
            this.buttonDone_SKE = new System.Windows.Forms.Button();
            this.groupBoxInPut_SKE = new System.Windows.Forms.GroupBox();
            this.labelR_SKE = new System.Windows.Forms.Label();
            this.labelL_SKE = new System.Windows.Forms.Label();
            this.labelK_SKE = new System.Windows.Forms.Label();
            this.textBoxR_SKE = new System.Windows.Forms.TextBox();
            this.textBoxL_SKE = new System.Windows.Forms.TextBox();
            this.textBoxK_SKE = new System.Windows.Forms.TextBox();
            this.panelMatrix_SKE.SuspendLayout();
            this.groupBoxInPutMatrix_SKE.SuspendLayout();
            this.groupBoxMatrix_SKE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SKE)).BeginInit();
            this.panelRight_SKE.SuspendLayout();
            this.groupBoxOutPut_SKE.SuspendLayout();
            this.groupBoxInPut_SKE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMatrix_SKE
            // 
            this.panelMatrix_SKE.Controls.Add(this.buttonGetMatrix_SKE);
            this.panelMatrix_SKE.Controls.Add(this.groupBoxInPutMatrix_SKE);
            this.panelMatrix_SKE.Controls.Add(this.groupBoxMatrix_SKE);
            this.panelMatrix_SKE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMatrix_SKE.Location = new System.Drawing.Point(0, 0);
            this.panelMatrix_SKE.Name = "panelMatrix_SKE";
            this.panelMatrix_SKE.Size = new System.Drawing.Size(382, 362);
            this.panelMatrix_SKE.TabIndex = 0;
            // 
            // buttonGetMatrix_SKE
            // 
            this.buttonGetMatrix_SKE.Location = new System.Drawing.Point(282, 67);
            this.buttonGetMatrix_SKE.Name = "buttonGetMatrix_SKE";
            this.buttonGetMatrix_SKE.Size = new System.Drawing.Size(93, 44);
            this.buttonGetMatrix_SKE.TabIndex = 2;
            this.buttonGetMatrix_SKE.Text = "Сгенерировать матрицу";
            this.buttonGetMatrix_SKE.UseVisualStyleBackColor = true;
            this.buttonGetMatrix_SKE.Click += new System.EventHandler(this.buttonGetMatrix_SKE_Click);
            // 
            // groupBoxInPutMatrix_SKE
            // 
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.labelN1_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.labelN2_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.labelCols_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.labelRows_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.textBoxN2_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.textBoxN1_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.textBoxM_SKE);
            this.groupBoxInPutMatrix_SKE.Controls.Add(this.textBoxN_SKE);
            this.groupBoxInPutMatrix_SKE.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPutMatrix_SKE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutMatrix_SKE.Name = "groupBoxInPutMatrix_SKE";
            this.groupBoxInPutMatrix_SKE.Size = new System.Drawing.Size(276, 117);
            this.groupBoxInPutMatrix_SKE.TabIndex = 1;
            this.groupBoxInPutMatrix_SKE.TabStop = false;
            this.groupBoxInPutMatrix_SKE.Text = "Ввод значений для матрицы";
            // 
            // labelN1_SKE
            // 
            this.labelN1_SKE.AutoSize = true;
            this.labelN1_SKE.Location = new System.Drawing.Point(145, 27);
            this.labelN1_SKE.Name = "labelN1_SKE";
            this.labelN1_SKE.Size = new System.Drawing.Size(19, 13);
            this.labelN1_SKE.TabIndex = 1;
            this.labelN1_SKE.Text = "n1";
            // 
            // labelN2_SKE
            // 
            this.labelN2_SKE.AutoSize = true;
            this.labelN2_SKE.Location = new System.Drawing.Point(145, 75);
            this.labelN2_SKE.Name = "labelN2_SKE";
            this.labelN2_SKE.Size = new System.Drawing.Size(19, 13);
            this.labelN2_SKE.TabIndex = 1;
            this.labelN2_SKE.Text = "n2";
            // 
            // labelCols_SKE
            // 
            this.labelCols_SKE.AutoSize = true;
            this.labelCols_SKE.Location = new System.Drawing.Point(12, 75);
            this.labelCols_SKE.Name = "labelCols_SKE";
            this.labelCols_SKE.Size = new System.Drawing.Size(116, 13);
            this.labelCols_SKE.TabIndex = 1;
            this.labelCols_SKE.Text = "Количество столбцов";
            // 
            // labelRows_SKE
            // 
            this.labelRows_SKE.AutoSize = true;
            this.labelRows_SKE.Location = new System.Drawing.Point(12, 27);
            this.labelRows_SKE.Name = "labelRows_SKE";
            this.labelRows_SKE.Size = new System.Drawing.Size(98, 13);
            this.labelRows_SKE.TabIndex = 1;
            this.labelRows_SKE.Text = "Количество строк";
            // 
            // textBoxN2_SKE
            // 
            this.textBoxN2_SKE.Location = new System.Drawing.Point(148, 91);
            this.textBoxN2_SKE.Name = "textBoxN2_SKE";
            this.textBoxN2_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxN2_SKE.TabIndex = 0;
            // 
            // textBoxN1_SKE
            // 
            this.textBoxN1_SKE.Location = new System.Drawing.Point(148, 43);
            this.textBoxN1_SKE.Name = "textBoxN1_SKE";
            this.textBoxN1_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxN1_SKE.TabIndex = 0;
            // 
            // textBoxM_SKE
            // 
            this.textBoxM_SKE.Location = new System.Drawing.Point(12, 91);
            this.textBoxM_SKE.Name = "textBoxM_SKE";
            this.textBoxM_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxM_SKE.TabIndex = 0;
            // 
            // textBoxN_SKE
            // 
            this.textBoxN_SKE.Location = new System.Drawing.Point(12, 43);
            this.textBoxN_SKE.Name = "textBoxN_SKE";
            this.textBoxN_SKE.Size = new System.Drawing.Size(100, 20);
            this.textBoxN_SKE.TabIndex = 0;
            // 
            // groupBoxMatrix_SKE
            // 
            this.groupBoxMatrix_SKE.Controls.Add(this.dataGridViewMatrix_SKE);
            this.groupBoxMatrix_SKE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMatrix_SKE.Location = new System.Drawing.Point(0, 117);
            this.groupBoxMatrix_SKE.Name = "groupBoxMatrix_SKE";
            this.groupBoxMatrix_SKE.Size = new System.Drawing.Size(382, 245);
            this.groupBoxMatrix_SKE.TabIndex = 0;
            this.groupBoxMatrix_SKE.TabStop = false;
            this.groupBoxMatrix_SKE.Text = "Матрица";
            // 
            // dataGridViewMatrix_SKE
            // 
            this.dataGridViewMatrix_SKE.AllowUserToAddRows = false;
            this.dataGridViewMatrix_SKE.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix_SKE.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix_SKE.AllowUserToResizeRows = false;
            this.dataGridViewMatrix_SKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SKE.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrix_SKE.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMatrix_SKE.Name = "dataGridViewMatrix_SKE";
            this.dataGridViewMatrix_SKE.ReadOnly = true;
            this.dataGridViewMatrix_SKE.RowHeadersVisible = false;
            this.dataGridViewMatrix_SKE.Size = new System.Drawing.Size(376, 226);
            this.dataGridViewMatrix_SKE.TabIndex = 0;
            // 
            // panelRight_SKE
            // 
            this.panelRight_SKE.Controls.Add(this.groupBoxOutPut_SKE);
            this.panelRight_SKE.Controls.Add(this.buttonDone_SKE);
            this.panelRight_SKE.Controls.Add(this.groupBoxInPut_SKE);
            this.panelRight_SKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_SKE.Location = new System.Drawing.Point(382, 0);
            this.panelRight_SKE.Name = "panelRight_SKE";
            this.panelRight_SKE.Size = new System.Drawing.Size(202, 362);
            this.panelRight_SKE.TabIndex = 1;
            // 
            // groupBoxOutPut_SKE
            // 
            this.groupBoxOutPut_SKE.Controls.Add(this.labelOutPut_SKE);
            this.groupBoxOutPut_SKE.Controls.Add(this.textBoxOutPut_SKE);
            this.groupBoxOutPut_SKE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOutPut_SKE.Location = new System.Drawing.Point(0, 196);
            this.groupBoxOutPut_SKE.Name = "groupBoxOutPut_SKE";
            this.groupBoxOutPut_SKE.Size = new System.Drawing.Size(202, 166);
            this.groupBoxOutPut_SKE.TabIndex = 2;
            this.groupBoxOutPut_SKE.TabStop = false;
            this.groupBoxOutPut_SKE.Text = "Вывод данных";
            // 
            // labelOutPut_SKE
            // 
            this.labelOutPut_SKE.AutoSize = true;
            this.labelOutPut_SKE.Location = new System.Drawing.Point(6, 16);
            this.labelOutPut_SKE.Name = "labelOutPut_SKE";
            this.labelOutPut_SKE.Size = new System.Drawing.Size(177, 65);
            this.labelOutPut_SKE.TabIndex = 1;
            this.labelOutPut_SKE.Text = "Произведение значений из его\r\nэлементов с чётными номерами\r\nот K до L (нумерация " +
    "начинается\r\nс нуля) включительно в заданной\r\nстроке R.";
            // 
            // textBoxOutPut_SKE
            // 
            this.textBoxOutPut_SKE.Location = new System.Drawing.Point(9, 101);
            this.textBoxOutPut_SKE.Name = "textBoxOutPut_SKE";
            this.textBoxOutPut_SKE.ReadOnly = true;
            this.textBoxOutPut_SKE.Size = new System.Drawing.Size(155, 20);
            this.textBoxOutPut_SKE.TabIndex = 0;
            // 
            // buttonDone_SKE
            // 
            this.buttonDone_SKE.Enabled = false;
            this.buttonDone_SKE.Location = new System.Drawing.Point(6, 162);
            this.buttonDone_SKE.Name = "buttonDone_SKE";
            this.buttonDone_SKE.Size = new System.Drawing.Size(193, 28);
            this.buttonDone_SKE.TabIndex = 1;
            this.buttonDone_SKE.Text = "Вычислить результат";
            this.buttonDone_SKE.UseVisualStyleBackColor = true;
            this.buttonDone_SKE.Click += new System.EventHandler(this.buttonDone_SKE_Click);
            // 
            // groupBoxInPut_SKE
            // 
            this.groupBoxInPut_SKE.Controls.Add(this.labelR_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.labelL_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.labelK_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.textBoxR_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.textBoxL_SKE);
            this.groupBoxInPut_SKE.Controls.Add(this.textBoxK_SKE);
            this.groupBoxInPut_SKE.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInPut_SKE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_SKE.Name = "groupBoxInPut_SKE";
            this.groupBoxInPut_SKE.Size = new System.Drawing.Size(202, 156);
            this.groupBoxInPut_SKE.TabIndex = 0;
            this.groupBoxInPut_SKE.TabStop = false;
            this.groupBoxInPut_SKE.Text = "Ввод данных";
            // 
            // labelR_SKE
            // 
            this.labelR_SKE.AutoSize = true;
            this.labelR_SKE.Location = new System.Drawing.Point(6, 101);
            this.labelR_SKE.Name = "labelR_SKE";
            this.labelR_SKE.Size = new System.Drawing.Size(90, 13);
            this.labelR_SKE.TabIndex = 1;
            this.labelR_SKE.Text = "Номер строки R";
            // 
            // labelL_SKE
            // 
            this.labelL_SKE.AutoSize = true;
            this.labelL_SKE.Location = new System.Drawing.Point(6, 64);
            this.labelL_SKE.Name = "labelL_SKE";
            this.labelL_SKE.Size = new System.Drawing.Size(64, 13);
            this.labelL_SKE.TabIndex = 1;
            this.labelL_SKE.Text = "Значение L";
            // 
            // labelK_SKE
            // 
            this.labelK_SKE.AutoSize = true;
            this.labelK_SKE.Location = new System.Drawing.Point(6, 27);
            this.labelK_SKE.Name = "labelK_SKE";
            this.labelK_SKE.Size = new System.Drawing.Size(65, 13);
            this.labelK_SKE.TabIndex = 1;
            this.labelK_SKE.Text = "Значение K";
            // 
            // textBoxR_SKE
            // 
            this.textBoxR_SKE.Location = new System.Drawing.Point(6, 117);
            this.textBoxR_SKE.Name = "textBoxR_SKE";
            this.textBoxR_SKE.Size = new System.Drawing.Size(144, 20);
            this.textBoxR_SKE.TabIndex = 0;
            // 
            // textBoxL_SKE
            // 
            this.textBoxL_SKE.Location = new System.Drawing.Point(6, 80);
            this.textBoxL_SKE.Name = "textBoxL_SKE";
            this.textBoxL_SKE.Size = new System.Drawing.Size(144, 20);
            this.textBoxL_SKE.TabIndex = 0;
            // 
            // textBoxK_SKE
            // 
            this.textBoxK_SKE.Location = new System.Drawing.Point(6, 43);
            this.textBoxK_SKE.Name = "textBoxK_SKE";
            this.textBoxK_SKE.Size = new System.Drawing.Size(144, 20);
            this.textBoxK_SKE.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelRight_SKE);
            this.Controls.Add(this.panelMatrix_SKE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Review | Вариант 17 | Шунанов К.Е.";
            this.panelMatrix_SKE.ResumeLayout(false);
            this.groupBoxInPutMatrix_SKE.ResumeLayout(false);
            this.groupBoxInPutMatrix_SKE.PerformLayout();
            this.groupBoxMatrix_SKE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SKE)).EndInit();
            this.panelRight_SKE.ResumeLayout(false);
            this.groupBoxOutPut_SKE.ResumeLayout(false);
            this.groupBoxOutPut_SKE.PerformLayout();
            this.groupBoxInPut_SKE.ResumeLayout(false);
            this.groupBoxInPut_SKE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMatrix_SKE;
        private System.Windows.Forms.GroupBox groupBoxMatrix_SKE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonGetMatrix_SKE;
        private System.Windows.Forms.GroupBox groupBoxInPutMatrix_SKE;
        private System.Windows.Forms.Label labelN1_SKE;
        private System.Windows.Forms.Label labelN2_SKE;
        private System.Windows.Forms.Label labelCols_SKE;
        private System.Windows.Forms.Label labelRows_SKE;
        private System.Windows.Forms.TextBox textBoxN2_SKE;
        private System.Windows.Forms.TextBox textBoxN1_SKE;
        private System.Windows.Forms.TextBox textBoxM_SKE;
        private System.Windows.Forms.TextBox textBoxN_SKE;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SKE;
        private System.Windows.Forms.Panel panelRight_SKE;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SKE;
        private System.Windows.Forms.Label labelOutPut_SKE;
        private System.Windows.Forms.TextBox textBoxOutPut_SKE;
        private System.Windows.Forms.Button buttonDone_SKE;
        private System.Windows.Forms.GroupBox groupBoxInPut_SKE;
        private System.Windows.Forms.Label labelR_SKE;
        private System.Windows.Forms.Label labelL_SKE;
        private System.Windows.Forms.Label labelK_SKE;
        private System.Windows.Forms.TextBox textBoxR_SKE;
        private System.Windows.Forms.TextBox textBoxL_SKE;
        private System.Windows.Forms.TextBox textBoxK_SKE;
    }
}

