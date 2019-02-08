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
    public partial class Form1 : Form
    {
        Service1Client service = new Service1Client();

        List<Staff> allStaff = new List<Staff>();

        private int idStaff = 0;
        private string surname;
        private string name;
        private string patronymic;
        private int taskId = 0;
        private string nameTask;
        private int workload = 0;
        private DateTime startDate;
        private DateTime expiryDate;
        private string status;
        private string staff;

        public Form1()
        {
            InitializeComponent();
            ViewDataBD();
        }

        public void ViewDataBD()
        {
            dgvStaff.DataSource = service.GetStaff();
            dgvTask.DataSource = service.GetTasks();

            for (int i = 0; i < dgvTask.RowCount; i++)
            {
                dgvTask.Rows[i].Selected = false;
            }

            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                dgvStaff.Rows[i].Selected = false;
            }
        }



        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStaff.SelectedRows)
            {
                idStaff = Convert.ToInt32(row.Cells[0].Value);
                surname = row.Cells[1].Value.ToString();
                name = row.Cells[2].Value.ToString();
                patronymic = row.Cells[3].Value.ToString();
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            FormAddStaff addStaff = new FormAddStaff();
            addStaff.FormClosed += new FormClosedEventHandler(addStaffClosed);
            addStaff.ShowDialog();
        }

        private void buttonRemoveStaff_Click(object sender, EventArgs e)
        {
            FormAddStaff addStaff = new FormAddStaff();
            addStaff.Data(idStaff, surname, name, patronymic);
            addStaff.FormClosed += new FormClosedEventHandler(addStaffClosed);
            addStaff.ShowDialog();
        }

        private void addStaffClosed(object sender, EventArgs e)
        {
            ViewDataBD();
        }

        private void buttonDeleteStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff()
            {
                StaffId = idStaff
            };

            if (service.DeletetStaff(staff) == 1)
            {
                MessageBox.Show("Person Delete");
                ViewDataBD();
            }
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTask.SelectedRows)
            {
                taskId = Convert.ToInt32(row.Cells[0].Value);
                nameTask = row.Cells[1].Value.ToString();
                workload = Convert.ToInt32(row.Cells[2].Value);
                startDate = Convert.ToDateTime(row.Cells[3].Value);
                expiryDate = Convert.ToDateTime(row.Cells[4].Value);
                status = row.Cells[5].Value.ToString();
                staff = row.Cells[6].Value.ToString();
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            FormAddTask addTask = new FormAddTask();
            addTask.FormClosed += new FormClosedEventHandler(addTaskClosed);
            addTask.ShowDialog();
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            FormAddTask addTask = new FormAddTask();
            addTask.FormClosed += new FormClosedEventHandler(addTaskClosed);
            addTask.Data(taskId, nameTask, workload, startDate, expiryDate, status, staff);
            addTask.ShowDialog();
        }

        private void addTaskClosed(object sender, EventArgs e)
        {
            ViewDataBD();
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            ServiceReference1.Task task = new ServiceReference1.Task()
            {
                TaskId = taskId
            };

            if (service.DeletetTask(task) == 1)
            {
                MessageBox.Show("Person Delete");
                ViewDataBD();
            }
        }

        private void textBoxTaskSearch_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvTask.DataSource];
            cm.SuspendBinding();
            for (int i = 0; i < dgvTask.RowCount; i++)
            {
                dgvTask.Rows[i].Selected = false;
                for (int j = 0; j < dgvTask.ColumnCount; j++)
                    if (dgvTask.Rows[i].Cells[j].Value != null)
                        if (dgvTask.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxTaskSearch.Text.ToLower()))
                        {
                            dgvTask.Rows[i].Visible = true;
                            break;
                        }
                        else { dgvTask.Rows[i].Visible = false; }
            }
            cm.ResumeBinding();
        }

        private void textBoxStaffSearch_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvStaff.DataSource];
            cm.SuspendBinding();
            for (int i = 0; i < dgvStaff.RowCount; i++)
            {
                dgvStaff.Rows[i].Selected = false;
                for (int j = 0; j < dgvStaff.ColumnCount; j++)
                    if (dgvStaff.Rows[i].Cells[j].Value != null)
                        if (dgvStaff.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxStaffSearch.Text.ToLower()))
                        {
                            dgvStaff.Rows[i].Visible = true;
                            break;
                        }
                        else { dgvStaff.Rows[i].Visible = false; }
            }
            cm.ResumeBinding();
        }
    }
}
