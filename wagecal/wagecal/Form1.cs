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

namespace wagecal
{
    public partial class Form1 : Form
    {
        string des = "";

        SqlConnection s1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\inkitrak1\wagecal\wagecal\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.database1DataSet1.owner);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getwage_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(hours.Text);
            int wage = Calculation(h);
            conclusion.Text = "";
            conclusion.Text = "YOUR WAGE FOR TODAY IS " + wage;



            s1.Open();
            SqlCommand enter = s1.CreateCommand();
            enter.CommandType = CommandType.Text;

            enter.CommandText = "INSERT INTO owner VALUES('" + nametext.Text + "','" + des + "','" + h + "','" + wage + "','" + (h-8) + "')";
            try
            {
                enter.ExecuteNonQuery();

            }
            catch(Exception)
            {
                MessageBox.Show("invalid input !!");
            }
            refreshbox();
            s1.Close();
            h = 0;
            des = "";
        }

        
        public void refreshbox()
        {
            string str = "SELECT * FROM owner";
            SqlDataAdapter da = new SqlDataAdapter(str, s1);
            DataTable d1 = new DataTable();
            da.Fill(d1);
            BindingSource bs = new BindingSource();
            bs.DataSource = d1;
            thetable.DataSource = bs;
            
        }







        private void button4_Click(object sender, EventArgs e)
        {
            if (passbox.Text == "password")
            {
                refreshbox();
                cover.Hide();
                login.Hide();
                tabl.Show();

            }
            else
            {
                MessageBox.Show("incorrect password");
                passbox.Clear();
                login.Hide();
                tabl.Hide();
                cover.Show();
            }
        }
        public int Calculation(int h)
        {
            if (radioButton1.Checked)
            {
                des = "manager";

                if (h == 8)
                    return 1500;
                else if (h > 8&& h<11)
                    return 1500 + (h - 8) * 300;
                else if (h < 5)
                    return 1500 / 2;
                else if (h > 5 && h < 8)
                    return 1500 - ((h - 8) * 300);
                else
                {
                    MessageBox.Show("DONOT LIE ! YOUR WAGE HAS BEEN DECREASED BY RS 50/- \n");
                    return 0;
                }


            }
            else if (radioButton2.Checked)
            {
                des = "supervisor";

                if (h == 8)
                    return 1200;
                else if (h > 8)
                    return 1200 + (h - 8) * 240;
                else if (h < 5)
                    return 1200 / 2;
                else if (h > 5 && h < 8)
                    return 1200 - ((h - 8) * 240);
                else
                {
                    MessageBox.Show("DONOT LIE ! YOUR WAGE HAS BEEN DECREASED BY RS 50/- \n");
                    return 0;
                }
            }
            else if (radioButton3.Checked)
            {
                des = "worker";

                if (h == 8)
                    return 800;
                else if (h > 8)
                    return 800 + (h - 8) * 160;
                else if (h < 5)
                    return 800 / 2;
                else if (h > 5 && h < 8)
                    return 800 - ((h - 8) * 160);
                else
                {
                    MessageBox.Show("DONOT LIE ! YOUR WAGE HAS BEEN DECREASED BY RS 50/- \n");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("please select your designation !!!!!!\n");
                return 0;
            }
        }

       

        private void tabl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cover.Hide();
            tabl.Hide();
            login.Show();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nametext.Clear();
            hours.Clear();
            passbox.Clear();
            cover.Show();
            conclusion.Text = " ---------------------------------------------------------------------------------------";
        }
    }
}
