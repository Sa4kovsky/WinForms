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
    public partial class FormAddTask : Form
    {
        Service1Client service = new Service1Client();

        public FormAddTask()
        {
            InitializeComponent();
            comboBoxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            buttonAddTask.Text = "Add";

            textBoxName.Clear();
            taskId = 0;
        }

        private int taskId = 0;

        public void Data(int id, string nameTask, int workload, DateTime startDate, DateTime expiryDate, string status,
                            string staff)
        {
            taskId = id;
            textBoxName.Text = nameTask;
            numericUpDownWorkload.Text = workload.ToString();
            dTPStartDate.Text = startDate.ToString();
            dTPExpiryDate.Text = expiryDate.ToString();
            comboBoxStatus.Text = status;
            comboBoxStaff.Text = staff;
            buttonAddTask.Text = "Update";
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (dTPStartDate.Value > dTPExpiryDate.Value)
            {
                MessageBox.Show("StartDate > ExpiryDate");
            }
            else
            {
                if (taskId == 0)
                {
                    ServiceReference1.Task task = new ServiceReference1.Task();

                    task.NameTask = textBoxName.Text;
                    task.Workload = Convert.ToInt32(numericUpDownWorkload.Text);
                    task.StartDate = Convert.ToDateTime(dTPStartDate.Text);
                    task.ExpiryDate = Convert.ToDateTime(dTPExpiryDate.Text);
                    task.Status = comboBoxStatus.Text;
                    task.Staff = id.ToString();

                    if (service.InsertTask(task) == 1)
                    {
                        Close();
                    }
                }
                else
                {
                    ServiceReference1.Task tasks = new ServiceReference1.Task()
                    {
                        TaskId = taskId,
                        NameTask = textBoxName.Text,
                        Workload = Convert.ToInt32(numericUpDownWorkload.Text),
                        StartDate = Convert.ToDateTime(dTPStartDate.Text),
                        ExpiryDate = Convert.ToDateTime(dTPExpiryDate.Text),
                        Status = comboBoxStatus.Text,
                        Staff = id.ToString()
                    };

                    if (service.UpdateTask(tasks) == 1)
                    {
                        Close();
                    }
                }
            }
        }

        private void Staff()
        {
            comboBoxStaff.DataSource = service.GetStaff();
            comboBoxStaff.ValueMember = "StaffId";
            comboBoxStaff.DisplayMember = "Surname";
        }

        int id;

        private void comboBoxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = (Staff) comboBoxStaff.SelectedItem;
            id = staff.StaffId;
        }

        private void comboBoxStaff_Enter(object sender, EventArgs e)
        {
            Staff();
        }

        private void buttonCancelTask_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
