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

namespace ApartmanOtomasyonDeneme
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SQLHelper nurhat=new SQLHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt32(comboBox1.Text);
            int para=(int)numericUpDown1.Value;
            DateTime yeni = dateTimePicker1.Value;
            SqlParameter p1=new SqlParameter("Daireno",daireno);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", yeni);
            nurhat.ExecuteProc("odeme_al",p1,p2,p3);


        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dt =nurhat.GetDataTable("select * from AidatOdemesi");
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["DaireNo"]).ToString();
                listBox2.Items.Add(dr["Para"]).ToString();
                listBox3.Items.Add(dr["Tarih"]).ToString();
            }

        }
    }
}
