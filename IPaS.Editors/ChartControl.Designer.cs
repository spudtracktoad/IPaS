namespace IPaS.Editors
{
    partial class ChartControl
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
            IPaS.Shared.ChartHeaderInfo chartHeaderInfo1 = new IPaS.Shared.ChartHeaderInfo();
            this.ChartBasePanel = new System.Windows.Forms.Panel();
            this.chart1 = new IPaS.Editors.Chart();
            this.ChartBasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartBasePanel
            // 
            this.ChartBasePanel.AutoScroll = true;
            this.ChartBasePanel.Controls.Add(this.chart1);
            this.ChartBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartBasePanel.Location = new System.Drawing.Point(0, 0);
            this.ChartBasePanel.Name = "ChartBasePanel";
            this.ChartBasePanel.Size = new System.Drawing.Size(646, 279);
            this.ChartBasePanel.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.AutoScroll = true;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            chartHeaderInfo1.CurrentDateTime = new System.DateTime(2018, 2, 26, 21, 9, 6, 265);
            chartHeaderInfo1.ViewDateTime = new System.DateTime(2018, 2, 27, 0, 3, 44, 158);
            chartHeaderInfo1.ViewWindow = new System.Drawing.Rectangle(0, 0, 646, 279);
            this.chart1.HeaderInfo = chartHeaderInfo1;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(646, 279);
            this.chart1.TabIndex = 0;
            this.chart1.Load += new System.EventHandler(this.chart1_Load);
            // 
            // ChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 279);
            this.Controls.Add(this.ChartBasePanel);
            this.Name = "ChartControl";
            this.Text = "Form1";
            this.ChartBasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChartBasePanel;
        private Chart chart1;
    }
}

