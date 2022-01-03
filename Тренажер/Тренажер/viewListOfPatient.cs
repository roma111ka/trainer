using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Тренажер
{
    public partial class viewListOfPatient : Form
    {
        private DB db = new DB();
        private string select = "SELECT * FROM `users` ORDER BY id";
        public viewListOfPatient()
        {
            InitializeComponent();
            LoadData(select);
        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {

            int takePatient = Convert.ToInt32(dataGridView1.CurrentCell.Value);


            db.openConnection();
            string MySqlTake = $"SELECT * FROM `users` WHERE id = {takePatient}";

            MySqlCommand takeCommand = new MySqlCommand(MySqlTake, db.getConnection());
            MySqlDataReader myreader;

            db.openConnection();
            myreader = takeCommand.ExecuteReader();
            myreader.Read();
            var dto = new DtoPatient();
            MainForm MainForm = new MainForm();

            dto.surname =(string)myreader["surname"]; 
            dto.name = (string)myreader["name"]; ;
            dto.dadname = (string)myreader["dadname"];
            dto.sex = (string)myreader["sex"];
            dto.age = (string)myreader["age"].ToString();
            MainForm.DtoPatient = dto;

            db.closeConnection();
            this.Hide();
            MainForm.Show();
        }

        private void LoadData(string select)
        {
          
            db.openConnection();
            
            MySqlCommand command = new MySqlCommand(select, db.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            
            DataTable data = new DataTable();
            adapter.Fill(data);
            
            dataGridView1.DataSource = data.DefaultView;
            db.closeConnection();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int delPatient = Convert.ToInt32(dataGridView1.CurrentCell.Value);


            db.openConnection();
            string MySqlDeelete = $"DELETE FROM `users` WHERE id = {delPatient}";

            MySqlCommand deleteCommand = new MySqlCommand(MySqlDeelete, db.getConnection()) ;

            deleteCommand.ExecuteNonQuery();

            db.closeConnection();

            LoadData(select);
        }
    }
}
