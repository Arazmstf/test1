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
using System.Net.NetworkInformation;

namespace makler_qlav
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public  SqlConnection con = new SqlConnection("Data source=ARAZ-PC;Initial catalog=makler;Integrated Security=SSPI");
        SqlCommand com;

        public int Poisk(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            return (ds.Tables[0].Rows.Count);
        }


        private string GetMacAddress()
        {
            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }

            }
            return macAddresses;
        }

        private void Button1_Click(object sender, EventArgs e)
        {    
            switch (textBox1.Text)
            {

                case (string)"admin":
                    

                    button2.Visible = true;
                    break;

                case (string)"user":
                    if (Poisk("select * from t4 where mac like '" + GetMacAddress() + "'") != 0)
                    {
                        Main fr1 = new Main();
                        fr1.ShowDialog();
                        this.Hide();
                    }
                    else { MessageBox.Show("Uxodi ya programist"); }
                    break;

                default:
                    MessageBox.Show("Uxodi ya programist");
                    break;
            }
        }
          /*  if (textBox1.Text == "admin")
            {
                button2.Visible = true;
            }
            else if (Poisk("select * from t4 where mac like '" + GetMacAddress() + "'") != 0 && textBox1.Text == "user")
            {
                Main fr1 = new Main();
                fr1.ShowDialog();
                this.Hide();
            }
            else { MessageBox.Show("Uxodi ya programist"); }
        }
    */
        
        private void Login_Load(object sender, EventArgs e)
        {       
        }

        private void Button2_Click(object sender, EventArgs e)
        {           
            con.Open();
            com = new SqlCommand ("insert into t4 (mac) values('" + GetMacAddress()+ "')", con);
            com.ExecuteNonQuery();
            con.Close();
            button2.Visible = false;
            textBox1.ResetText();
            MessageBox.Show("success!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("delete from t4", con);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
