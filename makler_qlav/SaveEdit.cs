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
    public partial class SaveEdit : Form
    {

        public Random rnd;
        int ID, Nomer = 0, Nomer1 = 0, Max, Max1, k;
        string[] mas = new string[16];
        bool z, b = false;

        public SqlConnection con = new SqlConnection("Data source=.\\SQLEXPRESS;Initial catalog=makler;Integrated Security=SSPI;");
        SqlCommand com;

        Dictionary<int, string> c = new Dictionary<int, string>(3);
        Dictionary<int, string> c1 = new Dictionary<int, string>(4);


        public SaveEdit()
        {
            InitializeComponent();

            Unvantxt.KeyPress += TextBoxOnTextChanged;
        }

        private void TextBoxOnTextChanged(object sender, KeyPressEventArgs e)
        {
           //// TextBox textBox = (TextBox)sender;
           //// ComboBox cmbx = (ComboBox)sender;
           // if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')
           //     &&
           //     (textBox.Text.IndexOf(',') == -1) && (textBox.Text.Length != 0)))
           // {
           //     if (e.KeyChar != (char)Keys.Back)
           //     {
           //         e.Handled = true;
           //     }
           // }
        }




        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string message = "Save?";
            //  string title = "Close program";
            // MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            // DialogResult result = MessageBox.Show(message, title, buttons);
            // if (result == DialogResult.Yes)
            // {
            //      button1_Click(sender, e);
            //  }
            //  else if(Class1.vernul(1) == true)
            //  {

            ///     con.Open();
            //    com = new SqlCommand("delete from t2 where kluch like '" + textBox1.Text + "'", con);              
            //    com.ExecuteNonQuery();
            //  con.Close();

            //   }

        }



        //*************************************************************************
        public void Otr_new(string s)
        {
            con.Open();
            DataSet dataSet = new DataSet();
            new SqlDataAdapter(s, con).Fill(dataSet);
            con.Close();

            idtxt.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();          
            EmlakNovucmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            emeliyatcmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
            Unvantxt.Text = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            TikintininNovcmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            layihecmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[6].ToString();
            Otaqsayicmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
            mertebetxt.Text = dataSet.Tables[0].Rows[0].ItemArray[8].ToString();
            UmumiSahetxt.Text = dataSet.Tables[0].Rows[0].ItemArray[9].ToString();
            qiymettxt.Text = dataSet.Tables[0].Rows[0].ItemArray[10].ToString();
            valutacmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[11].ToString();
            maskedTextBox1.Text = dataSet.Tables[0].Rows[0].ItemArray[12].ToString();
            melumatverentxt.Text = dataSet.Tables[0].Rows[0].ItemArray[13].ToString();
            Temircmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[14].ToString();
            textBox1.Text = dataSet.Tables[0].Rows[0].ItemArray[15].ToString();
            Senedcmbx.Text = dataSet.Tables[0].Rows[0].ItemArray[16].ToString();
        }
        public void Otrazit1(string s, int P)
        {
            con.Open();
            DataSet dataSet = new DataSet();
            new SqlDataAdapter(s, con).Fill(dataSet);
            con.Close();
            Max = dataSet.Tables[0].Rows.Count;
            try
            {
                pictureBox1.ImageLocation = dataSet.Tables[0].Rows[P].ItemArray[1].ToString();
            }
            catch
            {
            }
        }

        //public void Otrazit2(string s, int P)
        //{
        //    con.Open();
        //    DataSet dataSet = new DataSet();
        //    new SqlDataAdapter(s, con).Fill(dataSet);
        //    con.Close();
        //    Max1 = dataSet.Tables[0].Rows.Count;
        //    try
        //    {
        //        pictureBox2.ImageLocation = dataSet.Tables[0].Rows[P].ItemArray[1].ToString();
        //    }
        //    catch
        //    {
        //    }
        //}

        public int Poisk(string s)
        {
            con.Open();
            DataSet dataSet = new DataSet();
            new SqlDataAdapter(s, con).Fill(dataSet);
            con.Close();
            return dataSet.Tables[0].Rows.Count;
        }
        public void Random()
        {
            Random rnd = new Random();
            if (Poisk("select * from t1 where ID like '" + idtxt.Text + "'") == 0)
            {
                idtxt.Text = rnd.Next(1234567, 9876543).ToString();
            }
            else
            {
                k = Convert.ToInt32(idtxt.Text);
                idtxt.Text = (rnd.Next(1, 5) + k).ToString();
            }
        }

        bool flag = true;
        string[] gg = new string[15];

        //public void Sravneniye()
        //{

        //    int x, y, Res = 0;

        //    //  Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);

        //    x = pictureBox1.Width;
        //    y = pictureBox1.Height;

        //    Bitmap B1 = new Bitmap(pictureBox1.Image);
        //    Bitmap B2 = new Bitmap(pictureBox2.Image);
        //    // Bitmap b3 = new Bitmap(pictureBox2.ImageLocation);

        //    for (int i = 0; i < x; i++)
        //    {
        //        for (int j = 0; j < y; j++)
        //        {
        //            if (B1.GetPixel(i, j).Equals(B2.GetPixel(i, j))) Res++;



        //        }
        //    }
        //    if (Res == x * y)
        //    {

        //        //if (Nomer1 == i && Nomer == i)
        //        //    listBox1.Items.Add((listBox1.Text == "" ? "" : ",N") + "'" + pictureBox2.ImageLocation.ToString() + "'" + "\n");

        //        // MessageBox.Show(pictureBox1.ImageLocation +" || "+pictureBox2.ImageLocation);
        //        if (Nomer != Nomer1 && Nomer != Nomer1 - 1)
        //        {
        //            if (listBox1.Items.Contains(pictureBox1.ImageLocation) == false)
        //            {
        //                listBox1.Items.Add(pictureBox1.ImageLocation);
        //            }
        //            //   MessageBox.Show("equal");
        //        }
        //        b = true;
        //    }
        //    //else
        //    //{ b = false; }


        //    // else MessageBox.Show("netdamma");

        //}


        public void Fotki()
        {

            int i = 0;
            string backupdir1 = @"C:\Users\Araz\Desktop\" + idtxt.Text;

            if (openFileDialog1.FileName != "")
            {

                foreach (string file in openFileDialog1.FileNames)
                {
                    textBox1.Visible = false;
                    button4.Visible = true;
                    button3.Visible = true;
                    DirectoryInfo info = Directory.CreateDirectory(backupdir1);

                    string backupdir = @"C:\Users\Araz\Desktop\" + idtxt.Text + @"\" + file.Remove(0, 23);



                    File.Copy(file, backupdir);
                    mas[i] = backupdir;

                    con.Open();
                    com = new SqlCommand("insert into t2(kluch, wekil)values('" + idtxt.Text + "', '" + mas[i] + "')", con);
                    com.ExecuteNonQuery();
                    con.Close();

                }
                if (Poisk("select * from t2 where kluch ='" + idtxt.Text + "' and wekil ='" + mas[i] + "'") != 0)
                {
                    button7.Visible = true;
                }
                i++;
            }
        }

        private void SaveEditButton_Click(object sender, EventArgs e)
        {
            if (z)
            {
                Class1.IN(false);
            }
            else
            {
                Otaqsayicmbx.Text = "";
                mertebetxt.Text = "";
                Class1.IN(true);
            }
            if (!Class1.Vernul(1))
            {
                con.Open();

                com = new SqlCommand("update t1 set   ROOM =N'" + Otaqsayicmbx.Text + "', " +
                                                 "CURRENCY =N'" + valutacmbx.Text + "', " +
                                                   "DOCMNT =N'" + Senedcmbx.Text + "'," +
                                                 " PROJECT =N'" + layihecmbx.Text + "'," +
                                          " TYPE_OF_BILDING=N'" + TikintininNovcmbx.Text + "', " +
                                                 "FLOOR    =N'" + mertebetxt.Text + "'," +
                                                " ADRESS   =N'" + Unvantxt.Text + "', " +
                                                 "PLOT     =N'" + UmumiSahetxt.Text + "'," +
                                                " OPERATION=N'" + emeliyatcmbx.Text + "'," +
                                                " PRICE    =N'" + qiymettxt.Text + "'," +
                                                " CONTACT  =N'" + maskedTextBox1.Text + "'," +
                                                " OWNER    =N'" + melumatverentxt.Text + "'," +
                                                "TYPE      =N'" + EmlakNovucmbx.Text + "'," +
                                               "ADDITIONALY=N'" + textBox1.Text + "'" +

                                              "where ID like '" + idtxt.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                Hide();
            }
            else if (Poisk("select * from t1 where ID like '" + idtxt.Text + "'") != 0)
            {
                Random();
                SaveEditButton_Click(sender, e);
            }
            else
            {
                con.Open();

                com = new SqlCommand("insert into t1(ID,DATE,TYPE,OPERATION,ADRESS,TYPE_OF_BILDING,PROJECT,ROOM,FLOOR,PLOT,PRICE,CURRENCY,CONTACT,OWNER,REPAIR,ADDITIONALY,DOCMNT)values(N'" + idtxt.Text + "'," +
                     "N'" + DateTime.Today.AddDays(-1).ToString("dd.MM.yyyy")+ "'," +
                     "N'" + EmlakNovucmbx.Text + "'," +
                     "N'" + emeliyatcmbx.Text + "'," +
                     "N'" + Unvantxt.Text + "'," +
                     "N'" + TikintininNovcmbx.Text + "'," +
                     "N'" + layihecmbx.Text + "'," +
                     "N'" + Otaqsayicmbx.Text + "'," +
                     "N'" + mertebetxt.Text + "', " +
                     "N'" + UmumiSahetxt.Text + "'," +
                     "N'" + qiymettxt.Text + "'," +
                     "N'" + valutacmbx.Text + "',  " +
                     "N'" + textEdit1.Text + "'," +
                     "N'" + melumatverentxt.Text + "'," +
                     "N'" + Temircmbx.Text + "'," +
                     "N'" + textBox1.Text + "'," +
                     "N'" + Senedcmbx.Text + "')", con);

                com.ExecuteNonQuery();
                con.Close();
            }
            this.Hide();
        }
        private void BUtton7(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this photo ?", "Close program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.Nomer >= 0)
                {
                    int num;
                    con.Open();
                    com = new SqlCommand("delete from t2 where kluch like '" + idtxt.Text + "' and wekil like '" + pictureBox1.ImageLocation + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();

                    File.Delete(pictureBox1.ImageLocation);

                    Nomer = num = 0;
                    Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", num);
                }
                if (Poisk("select * from t2 where kluch like '" + idtxt.Text + "'") == 0)
                {
                    button4.Visible = false;
                    button3.Visible = false;
                    button7.Visible = false;
                    pictureBox1.Image = null;
                }
            }
        }
        private void ArxayaChevir(object sender, EventArgs e)
        {
            Nomer--;
            if (Nomer >= 0)
            {
                Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
            }
            else
            {
                Nomer = Max - 1;
                Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
            }
        }
        private void QabagaChevir(object sender, EventArgs e)
        {
            Nomer++;
            if (Nomer < Max)
            {
                Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
            }
            else
            {
                Nomer = 0;
                Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
            c.Add(1, "Mənzil");
            c.Add(2, "Ev / villa");
            c.Add(3, "Ofis");
            DateTime now = DateTime.Now;
            Random();
            if (Poisk("select * from t2 where kluch like '" + idtxt.Text + "'") == 0)
            {
            }
            if (Class1.Vernul(1))
            {
               
                SaveEditButton.Text = "Təstiq et";
            }
            else
            {
                Otr_new("select* from t1 where ID like '" + Class2.PR2() + "'");
                button3.Visible = true;
                button4.Visible = true;
                ID = Class2.Vernul();
                Otrazit1("select* from t2 where kluch like '" + ID.ToString() + "'", Nomer);
               
                SaveEditButton.Text = "Düzəliş et";
                if (Poisk("select * from t2 where kluch like '" + idtxt.Text + "'") != 0)
                {
                    button7.Visible = true;
                }
            }
        }

        private void EmlakNovu_TextChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Otaqsayicmbx.Visible = true;
            UmumiSahetxt.Location = new Point(0x61, 0x106);
            label20.Location = new Point(0xc7, 0x109);
            label12.Text = "Ümumi Sahə:";
            if (((EmlakNovucmbx.Text == c[1]) || (EmlakNovucmbx.Text == c[2])) || (EmlakNovucmbx.Text == c[3]))
            {
                panel1.Visible = true;
                z = true;
                label2.Text = "Otaq sayı:";
                if (EmlakNovucmbx.SelectedIndex == 0)
                {
                    panel1.Visible = true;
                }
            }
            else
            {
                z = false;
                panel1.Visible = false;
                UmumiSahetxt.Location = new Point(110, 0x79);
                label20.Location = new Point(0xd4, 0x7d);
                UmumiSahetxt.Visible = true;
                Otaqsayicmbx.Visible = false;
                label2.Text = "Ümumi Sahə:";
                label12.Text = "";
            }
        }
        private void ShekilleriSil(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("delete from t2", con);
            com.ExecuteNonQuery();
            con.Close();
        }




        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //if (pictureBox1.Image != null && pictureBox1.Image != null)
        //    //{
        //    int q = Max1 * Max1 + Max1;

        //    for (int i = 0; i <= q; i++)
        //    {
        //        if (Nomer1 != Max1)
        //        {
        //            if (Nomer != Max - 1)
        //            {
        //                Otrazit2("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer1);
        //                Sravneniye();
        //                MessageBox.Show(Nomer.ToString() + "||" + Nomer1.ToString());
        //            }
        //        }
        //        else
        //        {
        //            Nomer1 = -1;
        //            Nomer++;
        //            Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);

        //        }
        //        Nomer1++;

        //    }
        //    Nomer = 0;
        //    Nomer1 = 0;
        //    Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
        //    Otrazit2("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer1);
        //}
    
        //else
        //{
        //    Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
        //    Otrazit2("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer1);
        //}
        ////   pictureBox2.ImageLocation = "";
        // }


        private void ShekilElaveEt(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();



           
                if (!Class1.Vernul(1))
                {

                    Fotki();

                }
                else if (Poisk("select * from t1 where ID like '" + idtxt.Text + "'") == 0)
                {
                    Fotki();
                }
                else
                {
                    Random();
                    ShekilElaveEt(sender, e);
                }


            Otrazit1("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer);
           // Otrazit2("select* from t2 where kluch like '" + idtxt.Text + "'", Nomer1);



            //con.Ope
            //com = new SqlCommand("del    ete from t2 where kluch like '" + idtxt.Text + "' and wekil in (N" + label15.Text + ")", con);
            //com.ExecuteNonQuery();
            //con.Close();



        }

        private void  EtrafliMelumat_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }
        private void ShekileBaxmaq(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

    }
}
