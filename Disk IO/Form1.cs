using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Disk_IO
{
    public partial class Form1 : Form
    {
        Disk disk;

        public Form1()
        {
            this.disk = new Disk();
            InitializeComponent();

            comboBox1.Items.Add("FCFS");
            comboBox1.Items.Add("SSTF");
            comboBox1.Items.Add("SCAN");
            comboBox1.Items.Add("C-SCAN");
            comboBox1.Items.Add("LOOK");
            comboBox1.Items.Add("C-LOOK");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            disk.Clean();
            this.disk.EnqueueDiskQ(this.tbQueueList.Text);
            this.chtSchedule.Series[0].Points.Clear();
            this.chtSchedule.Series[1].Points.Clear();
            if (comboBox1.Text == "FCFS")
            {
                var t = this.disk.SchedulingWithFCFS(int.Parse(this.tbInital.Text));
                TracerRead(t);
                t.Clear();
            }
            else if(comboBox1.Text == "SSTF")
            {
                var t = this.disk.SchedulingWithSSTF(int.Parse(this.tbInital.Text));
                TracerRead(t);
                t.Clear();
            }
            else if (comboBox1.Text == "SCAN")
            {
                var t = this.disk.SchedulingWithSCAN(int.Parse(this.tbInital.Text));
                TracerRead(t);
                t.Clear();
            }
            else if (comboBox1.Text == "C-SCAN")
            {
                var t = this.disk.SchedulingWithC_SCAN(int.Parse(this.tbInital.Text));
                TracerRead(t);
                t.Clear();
            }
            else if (comboBox1.Text == "LOOK")
            {

                var t = this.disk.SchedulingWithLOOK(int.Parse(this.tbInital.Text));
                TracerRead(t);
                t.Clear();

            }
            else if (comboBox1.Text == "C-LOOK")
            {
                var t = this.disk.SchedulingWithC_LOOK(int.Parse(this.tbInital.Text));
                TracerRead(t);
                t.Clear();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Policy를 선택해 주세요", "경고");
            }
        }

        private void TracerRead(List<Tracer> tr)
        {
            int total = 0;
            double seek=0;
            foreach ( var tmp in tr )
            {
                var listViewItem = new ListViewItem(tmp.jobNumber.ToString());
                listViewItem.SubItems.Add(tmp.jobPosition.ToString());
                listViewItem.SubItems.Add(tmp.jobMovement.ToString());
                listViewItem.SubItems.Add(tmp.accumulateTime.ToString());
                listView1.Items.Add(listViewItem);

                this.chtSchedule.Series[0].Points.AddXY(tmp.jobPosition, tmp.jobNumber);
                this.chtSchedule.Series[1].Points.AddXY(tmp.jobPosition, tmp.jobNumber);
                total = tmp.accumulateTime;
                seek=tmp.total;
            }
            this.lbDebugText.Text = "총 이동거리: " + total+"\n총 실행시간: "+seek+"ms";
 //           this.lbDebugText.Text = "전체 실행 시간: " + seek+" ms";    //<-추가로 출력해야됨
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int count = rd.Next(8, 20);
            StringBuilder sb = new StringBuilder();

            this.tbInital.Text = rd.Next(0, 400).ToString();
            for ( int i = 0; i < count; i++ )
            {
                sb.Append(rd.Next(0, 400));
                sb.Append(",");
            }
            sb[sb.Length-1] = '\0';
            this.tbQueueList.Text = sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
