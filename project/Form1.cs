using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Client;

namespace project
{
    public partial class Form1 : Form
    {
        String ordb = "Data Source =ORCL; User Id =scott ;Password =tiger;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            /*
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select title from puser";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from puser where user_id=:id";
            cmd.Parameters.Add("id", textBox1.Text);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into puser values(:id,:name,:title)";
            cmd.Parameters.Add("id", textBox1.Text);
            cmd.Parameters.Add("name", textBox2.Text);
            cmd.Parameters.Add("title", textBox3.Text);
            cmd.CommandType = CommandType.Text;
            int r = cmd.ExecuteNonQuery();
            if (r != -1) 
            {
                MessageBox.Show("congratulations");
            }
            else 
            {
                MessageBox.Show("error");
            } 


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "maxoffer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pid", Int32.Parse(textBox5.Text));
            cmd.Parameters.Add("offer", OracleDbType.Decimal, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            textBox4.Text = cmd.Parameters["offer"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "bidds";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("pid", Int32.Parse(textBox7.Text));
            cmd.Parameters.Add("cur", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox6.Text += dr[0].ToString() + ", " + dr[1].ToString() + Environment.NewLine;
            }
        }
    }
}
