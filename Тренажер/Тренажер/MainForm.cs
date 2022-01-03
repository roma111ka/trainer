using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тренажер
{
    public partial class MainForm : Form
    {
        public DtoPatient DtoPatient;
        public MainForm()
        {
            InitializeComponent();
        }

        private void regMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistNewPatientForm registNewPatientForm = new RegistNewPatientForm();
            registNewPatientForm.Show();
        }

        private void listPatientViewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewListOfPatient viewListOfPatient = new viewListOfPatient();
            viewListOfPatient.Show();
        }

        private void sessionExaminationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            sessionExamination sessionExamination = new sessionExamination();
            sessionExamination.Show();
        }

        private void regNewExaminationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registNewExaminationForm registNewExaminationForm = new registNewExaminationForm();
            registNewExaminationForm.DtoPatient = DtoPatient;
            registNewExaminationForm.Show();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
