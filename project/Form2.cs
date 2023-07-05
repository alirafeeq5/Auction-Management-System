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
    public partial class Form2 : Form
    {
        string constr = " Data Source = ORCL; User Id = scott; Password = tiger; ";
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string cmdstr = @"select * from bidding a ,puser p,product c  where a.u_id=p.user_id and  a.p_id=c.product_id  and p_id=:id ";

            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstr = @"select offered_price ,u_id from bidding   where offered_price = (select max(offered_price) from bidding where p_id =:id ) ";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_ShowProducts_Click(object sender, EventArgs e)
        {
            //long userId = UInt64.Parse(text_UserId.Text);
            long userId = Convert.ToInt64(text_UserId.Text);
            string cmdstr = @"select * from product where u_id=:id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", userId);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}


