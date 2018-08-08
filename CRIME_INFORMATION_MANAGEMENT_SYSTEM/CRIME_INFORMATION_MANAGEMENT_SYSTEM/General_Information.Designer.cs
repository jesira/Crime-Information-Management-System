namespace CRIME_INFORMATION_MANAGEMENT_SYSTEM
{
    partial class General_Information
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.criminalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CRIME_INFORMATION_MANAGEMENT_SYSTEM.Database1DataSet();
            this.criminal_InfoTableAdapter = new CRIME_INFORMATION_MANAGEMENT_SYSTEM.Database1DataSetTableAdapters.Criminal_InfoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.criminalInfoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Gender";
            series1.YValueMembers = "Age";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(761, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // criminalInfoBindingSource
            // 
            this.criminalInfoBindingSource.DataMember = "Criminal_Info";
            this.criminalInfoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // criminal_InfoTableAdapter
            // 
            this.criminal_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENDER VS AGE GRAPH OF CRIMINALS";
            // 
            // General_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "General_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General_Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.General_Information_FormClosed);
            this.Load += new System.EventHandler(this.General_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource criminalInfoBindingSource;
        private Database1DataSetTableAdapters.Criminal_InfoTableAdapter criminal_InfoTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}