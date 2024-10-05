namespace LogReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correlationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateUtcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            threadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            levelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loggerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exceptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            logEntryBindingSource = new BindingSource(components);
            label1 = new Label();
            groupBox1 = new GroupBox();
            DebugLabel = new Label();
            label5 = new Label();
            ErrorLabel = new Label();
            label3 = new Label();
            RowCount = new Label();
            groupBox2 = new GroupBox();
            formResetButton = new Button();
            searchButton = new Button();
            saveAsButton = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            messageTextBox = new TextBox();
            exceptionTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logEntryBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, correlationIdDataGridViewTextBoxColumn, dateUtcDataGridViewTextBoxColumn, threadDataGridViewTextBoxColumn, levelDataGridViewTextBoxColumn, loggerDataGridViewTextBoxColumn, messageDataGridViewTextBoxColumn, exceptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = logEntryBindingSource;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1267, 405);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // correlationIdDataGridViewTextBoxColumn
            // 
            correlationIdDataGridViewTextBoxColumn.DataPropertyName = "CorrelationId";
            correlationIdDataGridViewTextBoxColumn.HeaderText = "CorrelationId";
            correlationIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            correlationIdDataGridViewTextBoxColumn.Name = "correlationIdDataGridViewTextBoxColumn";
            correlationIdDataGridViewTextBoxColumn.ReadOnly = true;
            correlationIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateUtcDataGridViewTextBoxColumn
            // 
            dateUtcDataGridViewTextBoxColumn.DataPropertyName = "DateUtc";
            dateUtcDataGridViewTextBoxColumn.HeaderText = "DateUtc";
            dateUtcDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateUtcDataGridViewTextBoxColumn.Name = "dateUtcDataGridViewTextBoxColumn";
            dateUtcDataGridViewTextBoxColumn.ReadOnly = true;
            dateUtcDataGridViewTextBoxColumn.Width = 150;
            // 
            // threadDataGridViewTextBoxColumn
            // 
            threadDataGridViewTextBoxColumn.DataPropertyName = "Thread";
            threadDataGridViewTextBoxColumn.HeaderText = "Thread";
            threadDataGridViewTextBoxColumn.MinimumWidth = 8;
            threadDataGridViewTextBoxColumn.Name = "threadDataGridViewTextBoxColumn";
            threadDataGridViewTextBoxColumn.ReadOnly = true;
            threadDataGridViewTextBoxColumn.Width = 150;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            levelDataGridViewTextBoxColumn.HeaderText = "Level";
            levelDataGridViewTextBoxColumn.MinimumWidth = 8;
            levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            levelDataGridViewTextBoxColumn.ReadOnly = true;
            levelDataGridViewTextBoxColumn.Width = 150;
            // 
            // loggerDataGridViewTextBoxColumn
            // 
            loggerDataGridViewTextBoxColumn.DataPropertyName = "Logger";
            loggerDataGridViewTextBoxColumn.HeaderText = "Logger";
            loggerDataGridViewTextBoxColumn.MinimumWidth = 8;
            loggerDataGridViewTextBoxColumn.Name = "loggerDataGridViewTextBoxColumn";
            loggerDataGridViewTextBoxColumn.ReadOnly = true;
            loggerDataGridViewTextBoxColumn.Width = 150;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            messageDataGridViewTextBoxColumn.HeaderText = "Message";
            messageDataGridViewTextBoxColumn.MinimumWidth = 8;
            messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            messageDataGridViewTextBoxColumn.ReadOnly = true;
            messageDataGridViewTextBoxColumn.Width = 150;
            // 
            // exceptionDataGridViewTextBoxColumn
            // 
            exceptionDataGridViewTextBoxColumn.DataPropertyName = "Exception";
            exceptionDataGridViewTextBoxColumn.HeaderText = "Exception";
            exceptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            exceptionDataGridViewTextBoxColumn.Name = "exceptionDataGridViewTextBoxColumn";
            exceptionDataGridViewTextBoxColumn.ReadOnly = true;
            exceptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // logEntryBindingSource
            // 
            logEntryBindingSource.DataSource = typeof(LogCommon.Models.LogEntry);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Sorok száma: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DebugLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ErrorLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(RowCount);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1316, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 219);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statisztika";
            // 
            // DebugLabel
            // 
            DebugLabel.AutoSize = true;
            DebugLabel.Location = new Point(180, 121);
            DebugLabel.Name = "DebugLabel";
            DebugLabel.Size = new Size(22, 25);
            DebugLabel.TabIndex = 6;
            DebugLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 121);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 5;
            label5.Text = "DEBUG-ok száma: ";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(180, 81);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(22, 25);
            ErrorLabel.TabIndex = 4;
            ErrorLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 81);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 3;
            label3.Text = "ERROR-ok száma: ";
            // 
            // RowCount
            // 
            RowCount.AutoSize = true;
            RowCount.Location = new Point(180, 42);
            RowCount.Name = "RowCount";
            RowCount.Size = new Size(22, 25);
            RowCount.TabIndex = 2;
            RowCount.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(formResetButton);
            groupBox2.Controls.Add(searchButton);
            groupBox2.Controls.Add(saveAsButton);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(1316, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 289);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Keresés";
            // 
            // formResetButton
            // 
            formResetButton.Location = new Point(227, 167);
            formResetButton.Name = "formResetButton";
            formResetButton.Size = new Size(117, 34);
            formResetButton.TabIndex = 6;
            formResetButton.Text = "Visszaállít";
            formResetButton.UseVisualStyleBackColor = true;
            formResetButton.Click += formResetButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(26, 167);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 5;
            searchButton.Text = "Keresés";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // saveAsButton
            // 
            saveAsButton.Location = new Point(15, 229);
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(329, 34);
            saveAsButton.TabIndex = 4;
            saveAsButton.Text = "Mentés Másként";
            saveAsButton.UseVisualStyleBackColor = true;
            saveAsButton.Click += saveAsButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 31);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 33);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 101);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 0;
            label4.Text = "Érték";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 47);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "Mező";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(118, 482);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(1161, 240);
            messageTextBox.TabIndex = 4;
            // 
            // exceptionTextBox
            // 
            exceptionTextBox.Location = new Point(118, 754);
            exceptionTextBox.Multiline = true;
            exceptionTextBox.Name = "exceptionTextBox";
            exceptionTextBox.Size = new Size(1161, 240);
            exceptionTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 482);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 6;
            label6.Text = "Message";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 754);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 7;
            label7.Text = "Exception";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1753, 1037);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(exceptionTextBox);
            Controls.Add(messageTextBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logEntryBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource logEntryBindingSource;
        private Label label1;
        private GroupBox groupBox1;
        private Label RowCount;
        private Label DebugLabel;
        private Label label5;
        private Label ErrorLabel;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label2;
        private Button saveAsButton;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button formResetButton;
        private Button searchButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correlationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateUtcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn threadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loggerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exceptionDataGridViewTextBoxColumn;
        private TextBox messageTextBox;
        private TextBox exceptionTextBox;
        private Label label6;
        private Label label7;
    }
}
