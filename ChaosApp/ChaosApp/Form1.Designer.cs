namespace ChaosApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphSingleRbtn = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusText = new System.Windows.Forms.Label();
            this.RInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // graphSingleRbtn
            // 
            this.graphSingleRbtn.Location = new System.Drawing.Point(383, 55);
            this.graphSingleRbtn.Name = "graphSingleRbtn";
            this.graphSingleRbtn.Size = new System.Drawing.Size(93, 23);
            this.graphSingleRbtn.TabIndex = 0;
            this.graphSingleRbtn.Text = "Graph formula";
            this.graphSingleRbtn.UseVisualStyleBackColor = true;
            this.graphSingleRbtn.Click += new System.EventHandler(this.graphSingleRbtn_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(99, 94);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(552, 337);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(352, 9);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(35, 13);
            this.statusText.TabIndex = 3;
            this.statusText.Text = "label1";
            this.statusText.Click += new System.EventHandler(this.label1_Click);
            // 
            // RInput
            // 
            this.RInput.Location = new System.Drawing.Point(227, 55);
            this.RInput.Name = "RInput";
            this.RInput.Size = new System.Drawing.Size(100, 20);
            this.RInput.TabIndex = 4;
            this.RInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter R value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RInput);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.graphSingleRbtn);
            this.Name = "Form1";
            this.Text = "Chaos App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button graphSingleRbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.TextBox RInput;
        private System.Windows.Forms.Label label2;
    }
}

