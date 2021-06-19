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

namespace makler_qlav
{
    public partial class Main : Form
    {
      

        public Main()
        {
            InitializeComponent();       
        }
          
        public static SqlConnection con = new SqlConnection("Data source=.\\SQLEXPRESS;Initial catalog=makler;Integrated Security=SSPI");
        SqlCommand com;

        public int R, Nomer = 0, Max;
        public long ID;
       
        bool cl;

        string[] a = new string[3] { "Mənzil", "Ofis", "Ev / villa" };
        string[] b = new string[4] { "Bağ", "Qaraj", "Torpaq", "Obyekt" };

        public void MelumatlariOxu(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataColumn d1 = new DataColumn();

            gridControl1.DataSource = ds.Tables[0];

            for (int i = 0; i <= 12; i++)
            {
                // dataGridView1.Columns[i].DisplayIndex = i;
            }

            con.Close();
        }
        private void Esasseyfe(object sender, EventArgs e)
        {
          
            MelumatlariOxu("select * from t1 ");
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        { // whydene ??
          //e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            MelumatlariOxu("select * from  t1 where PRICE >= '" + textBox2.Text + "'");
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            MelumatlariOxu("select * from  t1 where PRICE <= '" + textBox3.Text + "' and PRICE >= '" + textBox2.Text + "'");
        }
        private void ButunMelumatlar(object sender, EventArgs e)
        {
            //dataGridView1.Columns[7].Visible = true;
            //dataGridView1.Columns[8].Visible = true;
            MelumatlariOxu("select * from t1");
        }
        private void menzilToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            //dataGridView1.Columns[7].Visible = true;
            //dataGridView1.Columns[8].Visible = true;
            MelumatlariOxu("select * from t1 where TYPE like N'" + a[0] + "' or TYPE like N'" + a[1] + "' or TYPE like N'" + a[2] + "'");
        }
        private void bagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            MelumatlariOxu("select * from t1 where TYPE like N'" + b[0] + "' or TYPE like N'" + b[1] + "' or TYPE like N'" + b[2] + "' or TYPE like '" + b[3] + "'");
        }
        private void Elave_et(object sender, EventArgs e)
        {
            Class1.Prinal(true);
            new SaveEdit().ShowDialog();

            if (!Class1.OUT(1))
            {
                //dataGridView1.Columns[7].Visible = true;
                //dataGridView1.Columns[8].Visible = true;
                MelumatlariOxu("select * from t1 where TYPE like N'" + a[0] + "' or TYPE like N'" + a[1] + "' or TYPE like N'" + a[2] + "'");
            }
            else
            {
                //dataGridView1.Columns[7].Visible = false;
                //dataGridView1.Columns[8].Visible = false;
                MelumatlariOxu("select * from t1 where TYPE like N'" + b[0] + "' or TYPE like N'" + b[1] + "' or TYPE like N'" + b[2] + "' or TYPE like '" + b[3] + "'");
            }
        }
        private void ButunMelumatlariSil(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("delete from t1 ", con);
            com.ExecuteNonQuery();
            con.Close();

            MelumatlariOxu("select * from t1 ");
        }
        private void AxtarisPanell(object sender, EventArgs e)
        {
            MelumatlariOxu("select * from t1");
        }
        private void Sondur_Click(object sender, EventArgs e)
        {

        }
        private void EtrafliAxtarish(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        private void ElaniSil(object sender, EventArgs e)
        {
            string text = "Are you sure ?";
            string caption = "Close program";
            if (!cl)
            {
                MessageBox.Show("Выберите значение!");
            }
            else if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                com = new SqlCommand("delete from t1 where ID like '" + textBox1.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                con.Open();
                com = new SqlCommand("delete from t2 where kluch like '" + textBox1.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MelumatlariOxu("select * from t1");
                cl = false;
            }
        }
        private void Axtaris(object sender, EventArgs e)
        {
            foreach (object item in checkedListBox2.CheckedItems)
            {
                label1.Text += (label1.Text == "" ? "" : ",N") + "'" + item.ToString() + "'";
            }
            foreach (object item in checkedListBox1.CheckedItems)
            {
                label12.Text += (label12.Text == "" ? "" : ",N") + "'" + item.ToString() + "'";
                
            }

            string str = "where ",str2 = "",str3 = "";
            if (label1.Text != ""){str2 = "ROOM in  (N" + label1.Text + ")";}
            if (label12.Text != ""){str3 = "TYPE in  (N" + label12.Text + ")";}
            if (str2 != ""){str = (str != "where ") ? (str + " and" + str2) : (str + str2);}
            if (str3 != ""){str = (str != "where ") ? (str + " and " + str3) : (str + str3);}
            if (str == "where ") {MelumatlariOxu("select* from t1");} else{ MelumatlariOxu("select * from t1 " + str);}
           
           // label12.Text = "";
            label1.Text = "";
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
           

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cl = true;
            ID = Convert.ToInt64(gridView1.GetFocusedRowCellValue("ID").ToString());
            textBox1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            Class2.Prinal(int.Parse(ID.ToString()));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

       
        private void DuzelishEt(object sender, EventArgs e)
        {
            Class1.Prinal(false);
            if (!cl)
            {
                MessageBox.Show("Выберите значение!");
            }
            else
            {
                Class2.PR1(gridView1.GetFocusedRowCellValue("ID").ToString());
                new SaveEdit().ShowDialog();
                MelumatlariOxu("select * from t1");
                cl = false;
            }
        }
    }
}

