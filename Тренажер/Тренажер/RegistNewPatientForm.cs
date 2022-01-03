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
    public partial class RegistNewPatientForm : Form
    {
        public RegistNewPatientForm()
        {
            InitializeComponent();
        }
        private void registNewPatientBtn_Click(object sender, EventArgs e)
        {
            String sex = "M";
            if (surnameField.Text == "")
            {
                MessageBox.Show("Введите Фамилию");
            }
            if (nameField.Text == "")
            {
                MessageBox.Show("Введите имя");
            }
            if (dadnameField.Text == "")
            {
                MessageBox.Show("Введите Отчество");
            }
          
            if (ageField.Text == "")
            {
                MessageBox.Show("Введите Фамилию");
            }
            if (isPatientExists())
                return;
            if (womanRadioBtn.TabStop == true)
            {
                sex = womanRadioBtn.Text;
            }
            else
            {
                sex = manRadioBtn.Text;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `surname`, `name`, `dadname`, `sex`, `age`) VALUES (@surname, @name, @dadname, @sex, @age)", db.getConnection());
           
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@dadname", MySqlDbType.VarChar).Value = dadnameField.Text;
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@age", MySqlDbType.Int32).Value = ageField.Value;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Пациент зарегистрирован");
            else
                MessageBox.Show("Пациент не зарегистрирован");

            db.closeConnection();

            var dto = new DtoPatient();
            MainForm MainForm = new MainForm();

            dto.surname = surnameField.Text;
            dto.name = nameField.Text; ;
            dto.dadname = dadnameField.Text;
            dto.sex = sex;
            dto.age = ageField.Value.ToString();
            MainForm.DtoPatient = dto;

            this.Hide();
            
            MainForm.Show();
        }
        public Boolean isPatientExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  `surname` = @surname AND `name` = @name AND `dadname` = @dadname", db.getConnection());

            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@dadname", MySqlDbType.VarChar).Value = dadnameField.Text;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пациент уже есть, выберите из списка");
                    return true;
            }
            else
            {
               
                return false;
            }
        }
    }
}
