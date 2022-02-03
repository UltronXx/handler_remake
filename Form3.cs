using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace HMS
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
        DataSet DS = new DataSet();
        MySqlDataReader sqlRd;

        public Form3()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void handlerDevicesDB()
        {
            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "SELECT * FROM handler.devices";
                MySqlConnection sqlConn = new MySqlConnection(sqlServer);
                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();

                MySqlDataAdapter sqlDtA = new MySqlDataAdapter();
                sqlDtA.SelectCommand = sqlCmd;

                DataTable sqlDt = new DataTable();
                sqlDtA.Fill(sqlDt);

                dataGridView1.DataSource = sqlDt;

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            handlerDevicesDB();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Random randomReference = new Random();
            int randomRef = randomReference.Next(999,9999);

            try
            {
                string sqlServer = "datasource = localhost; port = 3306; username = root; password = admin";

                string sqlQuery = "INSERT INTO handler.devices (Reference, Device, Label, Address, Assignee, Date, Department, Summary)" +
                    "values('" + randomRef + "'," +
                            "'" + deviceNameTextBox.Text + "'," +
                            "'" + labelTextBox.Text + "'," +
                            "'" + macAddressTextBox.Text + "'," +
                            "'" + assigneeTextBox.Text + "'," +
                            "'" + dateTimePicker.Text + "'," +
                            "'" + departmentComboBox.Text + "'," +
                            "'" + summaryTextBox.Text + "');";

                MySqlConnection sqlConn = new MySqlConnection(sqlServer);

                MySqlCommand sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                MySqlDataReader sqlRd;

                sqlConn.Open();
                sqlRd = sqlCmd.ExecuteReader();
                MessageBox.Show("Devices added successfully");

                sqlConn.Close();
                handlerDevicesDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                deviceNameTextBox.Text      = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                labelTextBox.Text           = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                macAddressTextBox.Text      = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                assigneeTextBox.Text        = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker.Text         = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                departmentComboBox.Text     = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                summaryTextBox.Text         = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
