using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
namespace Sqlmaintenance
{
    public partial class Form2 : Form
    {
        Xml x=new Xml();
        SqlConnection cn;
        SqlCommand cmd;
        SqlCommand cmd3;
        int kontrolgorev=0;
        int sayac2 = 0;
        string xmlconnectionsorgu;
        string xmlconnectiongorev;
        DataGridView dataGridViewSorguG;
        DataGridView dataGridViewGorevY;
        public Form2(Xml x)
        {
            InitializeComponent();
            this.x = x;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
        }
        public void XmlOku(int hanginode)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(x.connectionstring.ToString());
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//appSettings/add");
            foreach (XmlNode node in nodes)
            {
                sayac2++;
                if(hanginode == 1&&sayac2==1)
                {
                    xmlconnectionsorgu = node.Attributes["value"].Value;
                    sayac2 = 0;
                    break;
                }
                if(hanginode == 2&&sayac2==2)
                {
                    xmlconnectiongorev = node.Attributes["value"].Value;
                    sayac2 = 0;
                    break;
                }
            }
        }
        private void btn_sorgular_Click(object sender, EventArgs e)
        {
            dataGridViewSorguG = new DataGridView();
            if (kontrolgorev > 0)
            {
                cmd.Cancel();
              dataGridViewGorevY.Visible = false;
            }      
            if(timer3.Enabled)
            {
                timer3.Stop();
            }
            XmlOku(1);
            cn = new SqlConnection(xmlconnectionsorgu);
            timer1.Start();
            dataGridViewSorguG.Refresh();
            dataGridViewSorguG.BorderStyle = BorderStyle.None;
            dataGridViewSorguG.Dock = DockStyle.Fill;
            dataGridViewSorguG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSorguG.BackgroundColor = Color.White;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cmd3 = new SqlCommand("sp_executiontime", cn);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dr = new SqlDataAdapter(cmd3);
            DataSet ds = new DataSet();
            dr.Fill(ds,"SqlTask");
            dataGridViewSorguG.DataSource = ds.Tables["SqlTask"];
            panel1.Controls.Add(dataGridViewSorguG);
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
      
            if(timer1.Enabled)
            {
            timer1.Stop();
            cmd3.Cancel();
             dataGridViewSorguG.Visible = false;
            }
            dataGridViewGorevY = new DataGridView();
            dataGridViewGorevY.Dock = DockStyle.Fill;
            dataGridViewGorevY.BackgroundColor = Color.White;
            dataGridViewGorevY.BorderStyle = BorderStyle.None;
            XmlOku(2);
            cn = new SqlConnection(xmlconnectiongorev);
            kontrolgorev++;
            timer3.Interval = 1000;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("sp_runsp", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                SqlCommand cmd2 = new SqlCommand("select * from SqlTask_Clients", cn);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                SqlDataAdapter dr2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                dr2.Fill(ds2, "SqlTask_Clients");

                dataGridViewGorevY.DataSource = ds2.Tables["SqlTask_Clients"];
                panel1.Controls.Add(dataGridViewGorevY);
            }
            cn.Close();
            cmd.Cancel();
        }
    }
}
