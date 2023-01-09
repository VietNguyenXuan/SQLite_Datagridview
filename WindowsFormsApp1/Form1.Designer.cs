
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.panel3 = new System.Windows.Forms.Panel();
      this.textBox_value_read = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.comboBox_read = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.textBox_value_write = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox_write = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button_write = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button_connect = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.textBox_ip1 = new System.Windows.Forms.TextBox();
      this.textBox_ip2 = new System.Windows.Forms.TextBox();
      this.textBox_ip3 = new System.Windows.Forms.TextBox();
      this.textBox_ip4 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox_port = new System.Windows.Forms.TextBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RegisterAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RegisterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel4 = new System.Windows.Forms.Panel();
      this.button_status = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label11 = new System.Windows.Forms.Label();
      this.timer_update_database = new System.Windows.Forms.Timer(this.components);
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.Silver;
      this.panel3.Controls.Add(this.textBox_value_read);
      this.panel3.Controls.Add(this.label6);
      this.panel3.Controls.Add(this.label7);
      this.panel3.Controls.Add(this.comboBox_read);
      this.panel3.Controls.Add(this.label8);
      this.panel3.Location = new System.Drawing.Point(12, 349);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(369, 159);
      this.panel3.TabIndex = 19;
      // 
      // textBox_value_read
      // 
      this.textBox_value_read.Enabled = false;
      this.textBox_value_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_value_read.Location = new System.Drawing.Point(201, 115);
      this.textBox_value_read.Multiline = true;
      this.textBox_value_read.Name = "textBox_value_read";
      this.textBox_value_read.Size = new System.Drawing.Size(156, 30);
      this.textBox_value_read.TabIndex = 12;
      this.textBox_value_read.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(15, 118);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(62, 20);
      this.label6.TabIndex = 15;
      this.label6.Text = "Value:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(11, 73);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(159, 20);
      this.label7.TabIndex = 14;
      this.label7.Text = "Register address:";
      // 
      // comboBox_read
      // 
      this.comboBox_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox_read.FormattingEnabled = true;
      this.comboBox_read.ItemHeight = 20;
      this.comboBox_read.Items.AddRange(new object[] {
            "D3000",
            "D3001",
            "D3002",
            "D3003",
            "D3004",
            "D3005",
            "D3006",
            "D3007",
            "D3008",
            "D3009"});
      this.comboBox_read.Location = new System.Drawing.Point(201, 70);
      this.comboBox_read.Name = "comboBox_read";
      this.comboBox_read.Size = new System.Drawing.Size(156, 28);
      this.comboBox_read.TabIndex = 13;
      this.comboBox_read.SelectedIndexChanged += new System.EventHandler(this.comboBox_read_SelectedIndexChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(10, 11);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(139, 29);
      this.label8.TabIndex = 12;
      this.label8.Text = "Read data:";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Silver;
      this.panel2.Controls.Add(this.textBox_value_write);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.comboBox_write);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.button_write);
      this.panel2.Location = new System.Drawing.Point(12, 97);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(369, 246);
      this.panel2.TabIndex = 18;
      // 
      // textBox_value_write
      // 
      this.textBox_value_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_value_write.Location = new System.Drawing.Point(201, 125);
      this.textBox_value_write.Multiline = true;
      this.textBox_value_write.Name = "textBox_value_write";
      this.textBox_value_write.Size = new System.Drawing.Size(156, 30);
      this.textBox_value_write.TabIndex = 12;
      this.textBox_value_write.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(11, 135);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(62, 20);
      this.label5.TabIndex = 15;
      this.label5.Text = "Value:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(11, 75);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(159, 20);
      this.label4.TabIndex = 14;
      this.label4.Text = "Register address:";
      // 
      // comboBox_write
      // 
      this.comboBox_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox_write.FormattingEnabled = true;
      this.comboBox_write.Items.AddRange(new object[] {
            "D3000",
            "D3001",
            "D3002",
            "D3003",
            "D3004",
            "D3005",
            "D3006",
            "D3007",
            "D3008",
            "D3009"});
      this.comboBox_write.Location = new System.Drawing.Point(201, 72);
      this.comboBox_write.Name = "comboBox_write";
      this.comboBox_write.Size = new System.Drawing.Size(156, 28);
      this.comboBox_write.TabIndex = 13;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(14, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(140, 29);
      this.label3.TabIndex = 12;
      this.label3.Text = "Wrire data:";
      // 
      // button_write
      // 
      this.button_write.BackColor = System.Drawing.Color.DimGray;
      this.button_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_write.Location = new System.Drawing.Point(19, 183);
      this.button_write.Name = "button_write";
      this.button_write.Size = new System.Drawing.Size(338, 50);
      this.button_write.TabIndex = 12;
      this.button_write.Text = "Write PLC";
      this.button_write.UseVisualStyleBackColor = false;
      this.button_write.Click += new System.EventHandler(this.button_write_Click_1);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.button_connect);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.flowLayoutPanel1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.textBox_port);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(880, 59);
      this.panel1.TabIndex = 17;
      // 
      // button_connect
      // 
      this.button_connect.BackColor = System.Drawing.Color.SpringGreen;
      this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_connect.Location = new System.Drawing.Point(716, 10);
      this.button_connect.Name = "button_connect";
      this.button_connect.Size = new System.Drawing.Size(140, 41);
      this.button_connect.TabIndex = 11;
      this.button_connect.Text = "Connect";
      this.button_connect.UseVisualStyleBackColor = false;
      this.button_connect.Click += new System.EventHandler(this.button_connect_Click_1);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(553, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 29);
      this.label2.TabIndex = 8;
      this.label2.Text = "Port:";
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.textBox_ip1);
      this.flowLayoutPanel1.Controls.Add(this.textBox_ip2);
      this.flowLayoutPanel1.Controls.Add(this.textBox_ip3);
      this.flowLayoutPanel1.Controls.Add(this.textBox_ip4);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(159, 11);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 40);
      this.flowLayoutPanel1.TabIndex = 7;
      // 
      // textBox_ip1
      // 
      this.textBox_ip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_ip1.Location = new System.Drawing.Point(3, 3);
      this.textBox_ip1.Name = "textBox_ip1";
      this.textBox_ip1.Size = new System.Drawing.Size(65, 34);
      this.textBox_ip1.TabIndex = 6;
      this.textBox_ip1.Text = "192";
      this.textBox_ip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox_ip2
      // 
      this.textBox_ip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_ip2.Location = new System.Drawing.Point(74, 3);
      this.textBox_ip2.Name = "textBox_ip2";
      this.textBox_ip2.Size = new System.Drawing.Size(65, 34);
      this.textBox_ip2.TabIndex = 7;
      this.textBox_ip2.Text = "168";
      this.textBox_ip2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox_ip3
      // 
      this.textBox_ip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_ip3.Location = new System.Drawing.Point(145, 3);
      this.textBox_ip3.Name = "textBox_ip3";
      this.textBox_ip3.Size = new System.Drawing.Size(65, 34);
      this.textBox_ip3.TabIndex = 8;
      this.textBox_ip3.Text = "1";
      this.textBox_ip3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox_ip4
      // 
      this.textBox_ip4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_ip4.Location = new System.Drawing.Point(216, 3);
      this.textBox_ip4.Name = "textBox_ip4";
      this.textBox_ip4.Size = new System.Drawing.Size(65, 34);
      this.textBox_ip4.TabIndex = 9;
      this.textBox_ip4.Text = "254";
      this.textBox_ip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(14, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(145, 29);
      this.label1.TabIndex = 5;
      this.label1.Text = "IP address:";
      // 
      // textBox_port
      // 
      this.textBox_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox_port.Location = new System.Drawing.Point(627, 13);
      this.textBox_port.Name = "textBox_port";
      this.textBox_port.Size = new System.Drawing.Size(83, 34);
      this.textBox_port.TabIndex = 10;
      this.textBox_port.Text = "100";
      this.textBox_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RegisterAddress,
            this.RegisterValue});
      this.dataGridView1.Location = new System.Drawing.Point(406, 97);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 70;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(682, 372);
      this.dataGridView1.TabIndex = 20;
      // 
      // Id
      // 
      this.Id.HeaderText = "Id";
      this.Id.MinimumWidth = 6;
      this.Id.Name = "Id";
      this.Id.Visible = false;
      // 
      // RegisterAddress
      // 
      this.RegisterAddress.HeaderText = "RegisterAddress";
      this.RegisterAddress.MinimumWidth = 6;
      this.RegisterAddress.Name = "RegisterAddress";
      // 
      // RegisterValue
      // 
      this.RegisterValue.HeaderText = "RegisterValue";
      this.RegisterValue.MinimumWidth = 6;
      this.RegisterValue.Name = "RegisterValue";
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel4.Controls.Add(this.button_status);
      this.panel4.Controls.Add(this.label9);
      this.panel4.Location = new System.Drawing.Point(898, 12);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(186, 59);
      this.panel4.TabIndex = 21;
      // 
      // button_status
      // 
      this.button_status.BackColor = System.Drawing.Color.Red;
      this.button_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_status.Location = new System.Drawing.Point(107, 17);
      this.button_status.Name = "button_status";
      this.button_status.Size = new System.Drawing.Size(27, 28);
      this.button_status.TabIndex = 12;
      this.button_status.UseVisualStyleBackColor = false;
      this.button_status.Visible = false;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(6, 16);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(92, 29);
      this.label9.TabIndex = 12;
      this.label9.Text = "Status:";
      // 
      // timer1
      // 
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(696, 479);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(123, 29);
      this.label11.TabIndex = 23;
      this.label11.Text = "Database";
      // 
      // timer_update_database
      // 
      this.timer_update_database.Interval = 5000;
      this.timer_update_database.Tick += new System.EventHandler(this.timer_update_database_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1100, 521);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "Connected PLC";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_value_read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_read;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_value_write;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_write;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_ip1;
        private System.Windows.Forms.TextBox textBox_ip2;
        private System.Windows.Forms.TextBox textBox_ip3;
        private System.Windows.Forms.TextBox textBox_ip4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Timer timer_update_database;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn RegisterAddress;
    private System.Windows.Forms.DataGridViewTextBoxColumn RegisterValue;
  }
}

