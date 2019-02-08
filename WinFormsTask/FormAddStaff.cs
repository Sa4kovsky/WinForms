using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTask.ServiceReference1;

namespace WinFormsTask
{
    public partial class FormAddStaff : Form
    {
        public FormAddStaff()
        {
            InitializeComponent();
            buttonAddStaff.Text = "Add";

            textBoxName.Clear();
            textBoxPatronymic.Clear();
            textBoxSurname.Clear();
            staffId = 0;
        }

        private int staffId;

        public void Data(int id, string surname, string name, string patronymic)
        {
            staffId = id;
            textBoxSurname.Text = surname;
            textBoxName.Text = name;
            textBoxPatronymic.Text = patronymic;
            buttonAddStaff.Text = "Update";
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (staffId == 0)
            {
                Staff staff = new Staff();

                staff.Surname = textBoxSurname.Text;
                staff.Name = textBoxName.Text;
                staff.Patronymic = textBoxPatronymic.Text;

                Service1Client service = new Service1Client();

                if (service.InsertStaff(staff) == 1)
                {
                    Close();
                }
            }
            else
            {
                Staff staff = new Staff()
                {
                    StaffId = staffId,
                    Surname = textBoxSurname.Text,
                    Name = textBoxName.Text,
                    Patronymic = textBoxPatronymic.Text
                };

                Service1Client service = new Service1Client();
                if (service.UpdateStaff(staff) == 1)
                {
                    Close();
                }
            }
        }

        private void buttonCancelTask_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidText(KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Back) return;
            if (Char.IsLetter(e.KeyChar) == true)
            {
                return;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidText(e);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidText(e);
        }

        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidText(e);
        }
    }
}
