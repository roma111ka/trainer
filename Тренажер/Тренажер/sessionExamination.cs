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
    public partial class sessionExamination : Form
    {
        /* public string paramView
         {
             get { return parametrsView; }
             set { }
         }*/
        public Dto Dto;
        public DtoPatient DtoPatient;
        public sessionExamination()
        {
            InitializeComponent();
        }

       
        private void startSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            sessionViewForm sessionViewForm = new sessionViewForm();
            sessionViewForm.Dto=Dto;
            sessionViewForm.DtoPatient = DtoPatient;
            sessionViewForm.Show();
        }

        private void sessionExamination_Load(object sender, EventArgs e)
        {
            if (this.Dto != null)
            {
                foreach(string item in Dto.Items)
                {
                    parametrsView.Text += item + "\n";
                }
            }
        }

        private void activateSensors_Click(object sender, EventArgs e)
        {
            
            label4.Text = "Установите эти датчики:\n";
            
            for (int i=0;i<checkedListBox1.Items.Count;i++)
            {
                 if(!checkedListBox1.GetItemChecked(i) && Dto.IndexItems[i])
                 {
                    label4.Text += checkedListBox1.Items[i].ToString()+"\n";
                 }        
            }
            if (label4.Text == "Установите эти датчики:\n")
            {
                label4.Text = "Все датчики активированы";
            }
            
        }

        private void checkedSensors_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valueRnd;
            label5.Text = "";
            
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                valueRnd = rnd.Next(1, 5);
                if (checkedListBox1.GetItemChecked(i) && Dto.IndexItems[i] && valueRnd>3)
                {
                    label5.Text += "Не работает " + checkedListBox1.Items[i].ToString() + "\n";
                }
            }
            if (label5.Text == "")
            {
                label5.Text = "Все датчики проверены";
            }
        }
    }
}
