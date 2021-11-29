namespace Apka2
{
    partial class Okno1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tDx = new System.Windows.Forms.TextBox();
            this.tXmax = new System.Windows.Forms.TextBox();
            this.tXmin = new System.Windows.Forms.TextBox();
            this.bGenerujCosinus = new System.Windows.Forms.Button();
            this.bGenerujSinus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tDx);
            this.groupBox1.Controls.Add(this.tXmax);
            this.groupBox1.Controls.Add(this.tXmin);
            this.groupBox1.Controls.Add(this.bGenerujCosinus);
            this.groupBox1.Controls.Add(this.bGenerujSinus);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia generowanych funkcji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Krok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Koniec zakresu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Początek zakresu";
            // 
            // tDx
            // 
            this.tDx.Location = new System.Drawing.Point(137, 71);
            this.tDx.Name = "tDx";
            this.tDx.Size = new System.Drawing.Size(100, 20);
            this.tDx.TabIndex = 4;
            this.tDx.Text = "0.1";
            this.tDx.TextChanged += new System.EventHandler(this.tDx_TextChanged);
            // 
            // tXmax
            // 
            this.tXmax.Location = new System.Drawing.Point(137, 45);
            this.tXmax.Name = "tXmax";
            this.tXmax.Size = new System.Drawing.Size(100, 20);
            this.tXmax.TabIndex = 3;
            this.tXmax.Text = "6.2";
            this.tXmax.TextChanged += new System.EventHandler(this.tXmax_TextChanged);
            // 
            // tXmin
            // 
            this.tXmin.Location = new System.Drawing.Point(137, 19);
            this.tXmin.Name = "tXmin";
            this.tXmin.Size = new System.Drawing.Size(100, 20);
            this.tXmin.TabIndex = 2;
            this.tXmin.Text = "-6.2";
            this.tXmin.TextChanged += new System.EventHandler(this.tXmin_TextChanged);
            // 
            // bGenerujCosinus
            // 
            this.bGenerujCosinus.Location = new System.Drawing.Point(137, 97);
            this.bGenerujCosinus.Name = "bGenerujCosinus";
            this.bGenerujCosinus.Size = new System.Drawing.Size(100, 23);
            this.bGenerujCosinus.TabIndex = 1;
            this.bGenerujCosinus.Text = "Generuj Cosinus";
            this.bGenerujCosinus.UseVisualStyleBackColor = true;
            this.bGenerujCosinus.Click += new System.EventHandler(this.bGenerujCosinus_Click);
            // 
            // bGenerujSinus
            // 
            this.bGenerujSinus.Location = new System.Drawing.Point(50, 97);
            this.bGenerujSinus.Name = "bGenerujSinus";
            this.bGenerujSinus.Size = new System.Drawing.Size(81, 23);
            this.bGenerujSinus.TabIndex = 0;
            this.bGenerujSinus.Text = "Generuj Sinus";
            this.bGenerujSinus.UseVisualStyleBackColor = true;
            this.bGenerujSinus.Click += new System.EventHandler(this.bGenerujSinus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bClear);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Location = new System.Drawing.Point(262, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zapis serii do pliku tekstowego";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(6, 17);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(145, 45);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Wyczyść wygenerowane dane";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(157, 17);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(130, 45);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Zapisz dane";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Location = new System.Drawing.Point(13, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 401);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prezentacja danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wykres funkcji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wygenerowane dane";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(584, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(168, 363);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 32);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Sinus Fresnela";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Cosinus Fresnela";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(572, 363);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Okno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Okno1";
            this.Text = "Generator Całek Fresnela";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tDx;
        private System.Windows.Forms.TextBox tXmax;
        private System.Windows.Forms.TextBox tXmin;
        private System.Windows.Forms.Button bGenerujCosinus;
        private System.Windows.Forms.Button bGenerujSinus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bClear;
    }
}

