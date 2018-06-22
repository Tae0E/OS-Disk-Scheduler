namespace Disk_IO
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbQueueList = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbDebugText = new System.Windows.Forms.Label();
 //           this.lbDebugText2 = new System.Windows.Forms.Label();
            this.tbInital = new System.Windows.Forms.TextBox();
            this.chtSchedule = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQueueList
            // 
            this.tbQueueList.Location = new System.Drawing.Point(133, 17);
            this.tbQueueList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQueueList.Name = "tbQueueList";
            this.tbQueueList.Size = new System.Drawing.Size(280, 21);
            this.tbQueueList.TabIndex = 0;
            this.tbQueueList.Text = "98,183,37,122,14,124,65,67";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(496, 15);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(76, 24);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbDebugText
            // 
            this.lbDebugText.AutoSize = true;
            this.lbDebugText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDebugText.Location = new System.Drawing.Point(580, 10);
            this.lbDebugText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDebugText.Name = "lbDebugText";
            this.lbDebugText.Size = new System.Drawing.Size(76, 12);
            this.lbDebugText.TabIndex = 2;
            this.lbDebugText.Text = "lbDebugText";
            // 
            // lbDebugText2
            // 
/*            this.lbDebugText2.AutoSize = true;
            this.lbDebugText2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDebugText2.Location = new System.Drawing.Point(594, 20);
            this.lbDebugText2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDebugText2.Name = "lbDebugText2";
            this.lbDebugText2.Size = new System.Drawing.Size(76, 12);
            this.lbDebugText2.TabIndex = 2;
            this.lbDebugText2.Text = "lbDebugText2";
  */          // 
            
            // tbInital
            // 
            this.tbInital.Location = new System.Drawing.Point(76, 17);
            this.tbInital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInital.Name = "tbInital";
            this.tbInital.Size = new System.Drawing.Size(56, 21);
            this.tbInital.TabIndex = 3;
            this.tbInital.Text = "53";
            // 
            // chtSchedule
            // 
            chartArea4.Area3DStyle.Inclination = 0;
            chartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea4.Area3DStyle.Rotation = 23;
            chartArea4.Area3DStyle.WallWidth = 0;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX2.IsReversed = true;
            chartArea4.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsReversed = true;
            chartArea4.AxisY2.IsReversed = true;
            chartArea4.Name = "ChartArea1";
            this.chtSchedule.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtSchedule.Legends.Add(legend4);
            this.chtSchedule.Location = new System.Drawing.Point(6, 38);
            this.chtSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtSchedule.Name = "chtSchedule";
            this.chtSchedule.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.CustomProperties = "IsXAxisQuantitative=False, EmptyPointValue=Zero";
            series7.Font = new System.Drawing.Font("Consolas", 9F);
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "chartData";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "ChartCustom";
            this.chtSchedule.Series.Add(series7);
            this.chtSchedule.Series.Add(series8);
            this.chtSchedule.Size = new System.Drawing.Size(566, 352);
            this.chtSchedule.TabIndex = 4;
            this.chtSchedule.Text = "chart1";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(414, 15);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(79, 24);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Generate";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Policy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "초기 위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "디스크 큐";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.position,
            this.distance,
            this.accum});
            this.listView1.Location = new System.Drawing.Point(576, 38);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 354);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "번호";
            // 
            // position
            // 
            this.position.Text = "위치";
            this.position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // distance
            // 
            this.distance.Text = "거리";
            this.distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.distance.Width = 90;
            // 
            // accum
            // 
            this.accum.Text = "누적";
            this.accum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accum.Width = 100;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 396);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.chtSchedule);
            this.Controls.Add(this.tbInital);
            this.Controls.Add(this.lbDebugText);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbQueueList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chtSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQueueList;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lbDebugText;
        private System.Windows.Forms.TextBox tbInital;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSchedule;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ColumnHeader distance;
        private System.Windows.Forms.ColumnHeader accum;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

