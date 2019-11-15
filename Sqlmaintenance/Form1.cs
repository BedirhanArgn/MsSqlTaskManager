using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlmaintenance
{
    public partial class Form1 : Form
    {
        Xml x = new Xml();
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnXmlOku_Click(object sender, EventArgs e)
        //{
        //    //OpenFileDialog fd = new OpenFileDialog();
        //    //fd.Filter = "Xml File |*.xml";
        //    //if (fd.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    x.connectionstring = fd.FileName; //Dosya yolu 
        //    //    label4.Text = fd.FileName.ToString();
        //    //    label4.Show();

              
        //    //}
        //}

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(x);
            //this.Opacity = 0;
            //f2.Show();
            string user = kullaniciAdi.Text;
            string pass = kullaniciSifre.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SIMI68N; Initial Catalog=Program;User Id=sa;Password=bedir123456;");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where kullaniciAdi='" + kullaniciAdi.Text + "' AND kullaniciSifre='" + kullaniciSifre.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarıyla Yapıldı");
                con.Close();
                Form2 f2 = new Form2(x);
                this.Opacity = 0;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                x.connectionstring = Path.GetFullPath("cstring.xml");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
