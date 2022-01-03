namespace Тренажер
{
    partial class sessionViewForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea46 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend46 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title46 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea47 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend47 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title47 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea48 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend48 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title48 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea49 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend49 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title49 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea50 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend50 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title50 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.endExaminition = new System.Windows.Forms.Button();
            this.sexBoxInSeesion = new System.Windows.Forms.TextBox();
            this.typeBoxInSeesion = new System.Windows.Forms.TextBox();
            this.dataBoxInSeesion = new System.Windows.Forms.TextBox();
            this.chartPresure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ageBoxInSeesion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patientBoxInSeesion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartCondact = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHumd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCondact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumd)).BeginInit();
            this.SuspendLayout();
            // 
            // endExaminition
            // 
            this.endExaminition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endExaminition.Location = new System.Drawing.Point(480, 28);
            this.endExaminition.Name = "endExaminition";
            this.endExaminition.Size = new System.Drawing.Size(244, 53);
            this.endExaminition.TabIndex = 24;
            this.endExaminition.Text = "Завершить обследование";
            this.endExaminition.UseVisualStyleBackColor = true;
            this.endExaminition.Click += new System.EventHandler(this.endExaminition_Click_1);
            // 
            // sexBoxInSeesion
            // 
            this.sexBoxInSeesion.Location = new System.Drawing.Point(154, 78);
            this.sexBoxInSeesion.Name = "sexBoxInSeesion";
            this.sexBoxInSeesion.ReadOnly = true;
            this.sexBoxInSeesion.Size = new System.Drawing.Size(211, 20);
            this.sexBoxInSeesion.TabIndex = 36;
            // 
            // typeBoxInSeesion
            // 
            this.typeBoxInSeesion.Location = new System.Drawing.Point(154, 131);
            this.typeBoxInSeesion.Name = "typeBoxInSeesion";
            this.typeBoxInSeesion.ReadOnly = true;
            this.typeBoxInSeesion.Size = new System.Drawing.Size(211, 20);
            this.typeBoxInSeesion.TabIndex = 35;
            // 
            // dataBoxInSeesion
            // 
            this.dataBoxInSeesion.Location = new System.Drawing.Point(154, 104);
            this.dataBoxInSeesion.Name = "dataBoxInSeesion";
            this.dataBoxInSeesion.ReadOnly = true;
            this.dataBoxInSeesion.Size = new System.Drawing.Size(211, 20);
            this.dataBoxInSeesion.TabIndex = 34;
            // 
            // chartPresure
            // 
            chartArea46.Name = "ChartArea1";
            this.chartPresure.ChartAreas.Add(chartArea46);
            legend46.Name = "Legend1";
            legend46.Position.Auto = false;
            legend46.Position.Width = 14.37599F;
            legend46.Position.X = 50F;
            legend46.Position.Y = 100F;
            this.chartPresure.Legends.Add(legend46);
            this.chartPresure.Location = new System.Drawing.Point(25, 157);
            this.chartPresure.Name = "chartPresure";
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series46.Color = System.Drawing.Color.Red;
            series46.Legend = "Legend1";
            series46.LegendText = "Минуты";
            series46.MarkerBorderColor = System.Drawing.Color.White;
            series46.Name = "Series1";
            series46.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            this.chartPresure.Series.Add(series46);
            this.chartPresure.Size = new System.Drawing.Size(542, 221);
            this.chartPresure.TabIndex = 25;
            this.chartPresure.Text = "chartPresure";
            title46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title46.Name = "Title1";
            title46.Text = "Измерение кровяного давления";
            this.chartPresure.Titles.Add(title46);
            // 
            // ageBoxInSeesion
            // 
            this.ageBoxInSeesion.Location = new System.Drawing.Point(154, 56);
            this.ageBoxInSeesion.Name = "ageBoxInSeesion";
            this.ageBoxInSeesion.ReadOnly = true;
            this.ageBoxInSeesion.Size = new System.Drawing.Size(211, 20);
            this.ageBoxInSeesion.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Пациент";
            // 
            // patientBoxInSeesion
            // 
            this.patientBoxInSeesion.Location = new System.Drawing.Point(154, 28);
            this.patientBoxInSeesion.Name = "patientBoxInSeesion";
            this.patientBoxInSeesion.ReadOnly = true;
            this.patientBoxInSeesion.Size = new System.Drawing.Size(211, 20);
            this.patientBoxInSeesion.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Тип нагрузки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Дата обследования";
            // 
            // chartTemp
            // 
            chartArea47.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea47);
            legend47.Name = "Legend1";
            legend47.Position.Auto = false;
            legend47.Position.Width = 14.37599F;
            legend47.Position.X = 50F;
            legend47.Position.Y = 100F;
            this.chartTemp.Legends.Add(legend47);
            this.chartTemp.Location = new System.Drawing.Point(573, 157);
            this.chartTemp.Name = "chartTemp";
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series47.Legend = "Legend1";
            series47.LegendText = "Минуты";
            series47.MarkerBorderColor = System.Drawing.Color.White;
            series47.Name = "Series1";
            series47.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            this.chartTemp.Series.Add(series47);
            this.chartTemp.Size = new System.Drawing.Size(586, 221);
            this.chartTemp.TabIndex = 37;
            this.chartTemp.Text = "chart3";
            title47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title47.Name = "Title1";
            title47.Text = "Измерение температуры кожи";
            this.chartTemp.Titles.Add(title47);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartCondact
            // 
            chartArea48.Name = "ChartArea1";
            this.chartCondact.ChartAreas.Add(chartArea48);
            legend48.Name = "Legend1";
            legend48.Position.Auto = false;
            legend48.Position.Width = 14.37599F;
            legend48.Position.X = 50F;
            legend48.Position.Y = 100F;
            this.chartCondact.Legends.Add(legend48);
            this.chartCondact.Location = new System.Drawing.Point(25, 384);
            this.chartCondact.Name = "chartCondact";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series48.Legend = "Legend1";
            series48.LegendText = "Минуты";
            series48.MarkerBorderColor = System.Drawing.Color.White;
            series48.Name = "Series1";
            series48.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            this.chartCondact.Series.Add(series48);
            this.chartCondact.Size = new System.Drawing.Size(542, 221);
            this.chartCondact.TabIndex = 38;
            this.chartCondact.Text = "chartCondact";
            title48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title48.Name = "Title1";
            title48.Text = "Измерение электричесткой проводимости";
            this.chartCondact.Titles.Add(title48);
            // 
            // chartFreq
            // 
            chartArea49.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea49);
            legend49.Name = "Legend1";
            legend49.Position.Auto = false;
            legend49.Position.Width = 14.37599F;
            legend49.Position.X = 50F;
            legend49.Position.Y = 100F;
            this.chartFreq.Legends.Add(legend49);
            this.chartFreq.Location = new System.Drawing.Point(573, 384);
            this.chartFreq.Name = "chartFreq";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Legend = "Legend1";
            series49.LegendText = "Минуты";
            series49.MarkerBorderColor = System.Drawing.Color.White;
            series49.Name = "Series1";
            series49.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            this.chartFreq.Series.Add(series49);
            this.chartFreq.Size = new System.Drawing.Size(586, 221);
            this.chartFreq.TabIndex = 39;
            this.chartFreq.Text = "chart3";
            title49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title49.Name = "Title1";
            title49.Text = "Измерение частоты серцебиения";
            this.chartFreq.Titles.Add(title49);
            // 
            // chartHumd
            // 
            chartArea50.Name = "ChartArea1";
            this.chartHumd.ChartAreas.Add(chartArea50);
            legend50.Name = "Legend1";
            legend50.Position.Auto = false;
            legend50.Position.Width = 14.37599F;
            legend50.Position.X = 50F;
            legend50.Position.Y = 100F;
            this.chartHumd.Legends.Add(legend50);
            this.chartHumd.Location = new System.Drawing.Point(299, 621);
            this.chartHumd.Name = "chartHumd";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Legend = "Legend1";
            series50.LegendText = "Минуты";
            series50.MarkerBorderColor = System.Drawing.Color.White;
            series50.Name = "Series1";
            series50.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            this.chartHumd.Series.Add(series50);
            this.chartHumd.Size = new System.Drawing.Size(586, 215);
            this.chartHumd.TabIndex = 40;
            this.chartHumd.Text = "chart3";
            title50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title50.Name = "Title1";
            title50.Text = "Измерение влажности кожи";
            this.chartHumd.Titles.Add(title50);
            // 
            // sessionViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 655);
            this.Controls.Add(this.chartHumd);
            this.Controls.Add(this.chartFreq);
            this.Controls.Add(this.chartCondact);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.endExaminition);
            this.Controls.Add(this.sexBoxInSeesion);
            this.Controls.Add(this.typeBoxInSeesion);
            this.Controls.Add(this.dataBoxInSeesion);
            this.Controls.Add(this.chartPresure);
            this.Controls.Add(this.ageBoxInSeesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientBoxInSeesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "sessionViewForm";
            this.RightToLeftLayout = true;
            this.Text = "sessionViewForm";
            this.Load += new System.EventHandler(this.sessionViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPresure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCondact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button endExaminition;
        private System.Windows.Forms.TextBox sexBoxInSeesion;
        private System.Windows.Forms.TextBox typeBoxInSeesion;
        private System.Windows.Forms.TextBox dataBoxInSeesion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPresure;
        private System.Windows.Forms.TextBox ageBoxInSeesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientBoxInSeesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCondact;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumd;
    }
}