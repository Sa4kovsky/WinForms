namespace WinFormsTask
{
    partial class FormAddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonCancelTask = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.dTPExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownWorkload = new System.Windows.Forms.NumericUpDown();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkload)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(157)))), ((int)(((byte)(56)))));
            this.buttonAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(157)))), ((int)(((byte)(56)))));
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(124)))), ((int)(((byte)(43)))));
            this.buttonAddTask.Location = new System.Drawing.Point(236, 234);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 31);
            this.buttonAddTask.TabIndex = 7;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // buttonCancelTask
            // 
            this.buttonCancelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(157)))), ((int)(((byte)(56)))));
            this.buttonCancelTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(157)))), ((int)(((byte)(56)))));
            this.buttonCancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(124)))), ((int)(((byte)(43)))));
            this.buttonCancelTask.Location = new System.Drawing.Point(317, 234);
            this.buttonCancelTask.Name = "buttonCancelTask";
            this.buttonCancelTask.Size = new System.Drawing.Size(75, 31);
            this.buttonCancelTask.TabIndex = 8;
            this.buttonCancelTask.Text = "Cancel";
            this.buttonCancelTask.UseVisualStyleBackColor = true;
            this.buttonCancelTask.Click += new System.EventHandler(this.buttonCancelTask_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(315, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Work load";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start date";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Location = new System.Drawing.Point(77, 118);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(315, 20);
            this.dTPStartDate.TabIndex = 3;
            // 
            // dTPExpiryDate
            // 
            this.dTPExpiryDate.Location = new System.Drawing.Point(77, 144);
            this.dTPExpiryDate.Name = "dTPExpiryDate";
            this.dTPExpiryDate.Size = new System.Drawing.Size(315, 20);
            this.dTPExpiryDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Expiry date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contractor";
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.DataSource = this.staffBindingSource;
            this.comboBoxStaff.DisplayMember = "Name";
            this.comboBoxStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(77, 196);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(315, 21);
            this.comboBoxStaff.TabIndex = 6;
            this.comboBoxStaff.SelectedIndexChanged += new System.EventHandler(this.comboBoxStaff_SelectedIndexChanged);
            this.comboBoxStaff.Enter += new System.EventHandler(this.comboBoxStaff_Enter);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(WinFormsTask.ServiceReference1.Staff);
            // 
            // numericUpDownWorkload
            // 
            this.numericUpDownWorkload.Location = new System.Drawing.Point(77, 92);
            this.numericUpDownWorkload.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownWorkload.Name = "numericUpDownWorkload";
            this.numericUpDownWorkload.Size = new System.Drawing.Size(315, 20);
            this.numericUpDownWorkload.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Не начата",
            "В процессе ",
            "Завершена ",
            "Отложена"});
            this.comboBoxStatus.Location = new System.Drawing.Point(77, 169);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(315, 21);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(68)))), ((int)(((byte)(99)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(404, 277);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.numericUpDownWorkload);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTPExpiryDate);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonCancelTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddTask";
            this.Text = "Add Task";
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonCancelTask;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.DateTimePicker dTPExpiryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkload;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.BindingSource staffBindingSource;
    }
}