using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CLINICAL_SYSTEM
{
    public partial class SOAP_form : Form
    {
        String connString = "server=localhost; port=3306; user id=root; password= Dina@2020; database=clinical_system; sslmode=none";

        public SOAP_form()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String mysql = "INSERT INTO doctor_assessment(patient_Name,Gender,patient_type,Age," +
                "Number_of_sessions,diagnosis,Payment_process,Pain_of,Referred_to ," +
                "swelling_of ,Stiffness ,Limitation_ROM ,Weakness_of ,Paralysis ,Others, Tenderness_of)values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            MySqlCommand cmd = new MySqlCommand(mysql, conn);
            cmd.CommandText = mysql;
            cmd.Parameters.AddWithValue("patient_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("Gender", comboBox4.Text);
            cmd.Parameters.AddWithValue("patient_type", comboBox1.Text);
            cmd.Parameters.AddWithValue("Age", textBox5.Text);
            cmd.Parameters.AddWithValue("Number_of_sessions", textBox4.Text);
            cmd.Parameters.AddWithValue("diagnosis", textBox6.Text);
            cmd.Parameters.AddWithValue("Payment_process", textBox1.Text);
            cmd.Parameters.AddWithValue("Pain_of", textBox7.Text);
            cmd.Parameters.AddWithValue("Referred_to", textBox8.Text);
            cmd.Parameters.AddWithValue("swelling_of", textBox9.Text);
            cmd.Parameters.AddWithValue("Stiffness", textBox11.Text);
            cmd.Parameters.AddWithValue("Limitation_ROM", textBox13.Text);
            cmd.Parameters.AddWithValue("Weakness_of", textBox12.Text);
            cmd.Parameters.AddWithValue("Paralysis", textBox15.Text);
            cmd.Parameters.AddWithValue("Others", textBox14.Text);
            cmd.Parameters.AddWithValue("Tenderness_of", textBox10.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
