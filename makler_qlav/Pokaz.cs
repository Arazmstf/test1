using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace makler_qlav
{
    public partial class Pokaz : Form
    {
        public Pokaz()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data source=;Initial catalog=makler;Integrated Security=SSPI");
        

        public int R, ID, Nomer = 0, Max;

        private void Button3_Click(object sender, EventArgs e)
        {
            Nomer++;

            if (Nomer < Max)
            {
                Otrazit1("select* from t2 where kluch like '" + textBox1.Text + "'", Nomer);

            }
            else
            {
                Nomer = 0;
                Otrazit1("select* from t2 where kluch like '" + textBox1.Text + "'", Nomer);

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Nomer--;
            if (Nomer >= 0)
            {
                Otrazit1("select* from t2 where kluch like '" + textBox1.Text + "'", Nomer);

            }
            else

            {
                Nomer = Max - 1;
                Otrazit1("select* from t2 where kluch like '" + textBox1.Text + "'", Nomer);

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Otrazit1(string s, int P)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            Max = ds.Tables[0].Rows.Count;

            try
            {
                pictureBox1.ImageLocation = ds.Tables[0].Rows[P].ItemArray[1].ToString();
            }
            catch { }

        }

        private void Pokaz_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Windows\Temp\salam.txt");

            textBox1.Text = lines[0];
            textBox2.Text = lines[1];
            textBox3.Text = lines[2];
            textBox4.Text = lines[3];
            textBox5.Text = lines[4];
            textBox11.Text = lines[5];
            textBox6.Text = lines[6] + " " + lines[7];
            textBox7.Text = lines[8];
            maskedTextBox1.Text = lines[9];
            textBox8.Text = lines[10];
            textBox9.Text = lines[11];
           
            textBox10.Text = lines[12];
            
           Otrazit1("select* from t2 where kluch like '" + textBox1.Text + "'", Nomer);
          
        }
    }
}
