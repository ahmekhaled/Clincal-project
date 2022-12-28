using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICAL_SYSTEM
{
    public partial class Nursing_assessmentcs : Form
    {
        String connString = "server=localhost; port=3306; user id=root; password= Dina@2020; database=clinical_system; sslmode=none";

        public Nursing_assessmentcs()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
    }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String mysql = "INSERT INTO nursing_assessment(medical_number, patient_Name,Mode_of_arrival, Accompanied_By, Language_Spoken,Temp,Pulse,BP,Resp_Rate,Weight,Height, Blood_sugar)values(?,?,?,?,?,?,?,?,?,?,?,?)";
            MySqlCommand cmd = new MySqlCommand(mysql, conn);
            cmd.CommandText = mysql;
            cmd.Parameters.AddWithValue("medical_number", textBox3.Text);
            cmd.Parameters.AddWithValue("patient_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("Mode_of_arrival", comboBox4.Text);
            //cmd.Parameters.AddWithValue("date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("Accompanied_By", comboBox3.Text);
            cmd.Parameters.AddWithValue("Language_Spoken", comboBox2.Text);
            cmd.Parameters.AddWithValue("Temp", textBox4.Text);
            cmd.Parameters.AddWithValue("Pulse", textBox5.Text);
            cmd.Parameters.AddWithValue("BP", textBox6.Text);
            cmd.Parameters.AddWithValue("Resp_Rate", textBox7.Text);
            cmd.Parameters.AddWithValue("Blood_sugar", textBox8.Text);
            cmd.Parameters.AddWithValue("Weight", textBox10.Text);
            cmd.Parameters.AddWithValue("Height", textBox9.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
    }
