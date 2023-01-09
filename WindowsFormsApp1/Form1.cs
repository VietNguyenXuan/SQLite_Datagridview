using McProtocol;
using McProtocol.Mitsubishi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Gateway;
using WindowsFormsApp1.Manager;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      // Đưa con trỏ tại Ip khi bắt đầu chạy chương trình
      this.ActiveControl = textBox_ip1;
      textBox_ip1.Focus();
    }

    RegisterManager _registerManager = new RegisterManager();

    McProtocolTcp mcProtocolTcp;

    private async void button_connect_Click_1(object sender, EventArgs e)
    {
      int port = Convert.ToInt32(textBox_port.Text);
      string iP = textBox_ip1.Text + "." + textBox_ip2.Text + "." + textBox_ip3.Text + "." + textBox_ip4.Text;

      try
      {
        mcProtocolTcp = new McProtocolTcp(iP, port, McFrame.MC3E);
        await mcProtocolTcp.Open();

        MessageBox.Show("Connect Successful!");
        timer1.Start();
        timer_update_database.Start();
      }
      catch 
      {
        MessageBox.Show("Connect failed");
        this.Close();
      }
    }

    string[] id_register = {"D3000", "D3001", "D3002", "D3003", "D3004", "D3005", "D3006", "D3007", "D3008", "D3009" };
    int[] value_register = new int[10];

    private async void button_write_Click_1(object sender, EventArgs e)
    {
      int data;

      data = int.Parse(textBox_value_write.Text);

      value_register[comboBox_write.SelectedIndex] = data;

      await mcProtocolTcp.WriteDeviceBlock("D3000", 10, value_register);
      MessageBox.Show("Complete");
    }

    public void LoadData()
    {
      dataGridView1.Rows.Clear();

      for (int i = 0; i < id_register.Length; i++)
      {
        var students = _registerManager.GetData(id_register[i]);
        dataGridView1.Rows.Add(students[0].Id, students[0].registerAddress, students[0].registerValue);
      }
    }


    public async void Read_WriteDataDB()
    {

      var oDataNew1 = await mcProtocolTcp.ReadDeviceBlock("D3000", 10);

      for (int i = 0; i < oDataNew1.Length; i++)
        value_register[i] = oDataNew1[i];

      for (int i = 0; i < 10; i++)
      {
        try
        {
          Student student = new Student();

          student.registerAddress = id_register[i];
          student.registerValue = oDataNew1[i].ToString();

          if (_registerManager.Add(student))
          {
            //MessageBox.Show("Data has been saved database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Data saved database failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }

        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void comboBox_read_SelectedIndexChanged(object sender, EventArgs e)
    {
      textBox_value_read.Text = value_register[comboBox_read.SelectedIndex].ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      button_status.Visible = !button_status.Visible;
    }
    private void timer_update_database_Tick(object sender, EventArgs e)
    {
      //Read_WriteDataDB(); //Khi kết nối PLC

      randomdata();
      LoadData();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      timer1.Start();
      timer_update_database.Start();
      int i = 10;
      int j =5;
    }
    

    public void randomdata()
    {
      Random rd = new Random();
      for (int i = 0; i < 10; i++) value_register[i] = rd.Next(1, 1000);

      for (int i = 0; i < 10; i++)
      {
        try
        {
          Student student = new Student();

          student.registerAddress = id_register[i];
          student.registerValue = value_register[i].ToString();

          if (_registerManager.Add(student))
          {
            //MessageBox.Show("Data has been saved database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Data saved database failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }

        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
