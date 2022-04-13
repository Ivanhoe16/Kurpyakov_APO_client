using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Excel = Microsoft.Office.Interop.Excel;

namespace APO_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string answer;
        private string[] values = { };
        private byte[] bytes = new byte[1024];

        private void addClubButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string league = leagueTextBox.Text;
            string city = cityTextBox.Text;
            string trainer = trainerTextBox.Text;
            string stadium = stadiumTextBox.Text;
            string entry;
            entry = "'"+ name + "','" + league + "','" + city + "','" + trainer + "','" + stadium + "'";
            try
            {
                //установка удаленной точки для сокета
                IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint ipEP = new IPEndPoint(ipAddr, 11000);
                Socket soket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                //соединение сокета с удаленной точкой
                soket.Connect(ipEP);
                byte[] message = Encoding.UTF8.GetBytes(entry);
                entry = "";
                //отправка и получение
                int bytesSend = soket.Send(message);
                int bytesRec = soket.Receive(bytes);
                answer = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                soket.Shutdown(SocketShutdown.Both);
                soket.Close();
                values = answer.Split(';');
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                for (int i = 0; i < values.Length - 1; i += 5)
                    dataGridView1.Rows.Add(values[i], values[i + 1], values[i + 2], values[i + 3], values[i + 4]);
                nameTextBox.Text = "";
                leagueTextBox.Text = "";
                cityTextBox.Text = "";
                trainerTextBox.Text = "";
                stadiumTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void createEcselButton_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlBook;
            Excel.Worksheet xlList;
            object misValue = System.Reflection.Missing.Value;
            xlBook = xlApp.Workbooks.Add(misValue);
            xlList = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
            xlList.Cells[1, 1] = "Name";
            xlList.Cells[1, 2] = "League";
            xlList.Cells[1, 3] = "City";
            xlList.Cells[1, 4] = "Trainer";
            xlList.Cells[1, 5] = "Stadium";
            for (int i=0; i < dataGridView1.ColumnCount; i++)
                for (int j = 1; j < dataGridView1.RowCount; j++)
                   xlList.Cells[j+1, i+1] = dataGridView1[i,j].Value.ToString();
            xlBook.SaveAs("Clubs.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlBook.Close(true, misValue, misValue);
            xlApp.Quit();
            MessageBox.Show("Данные занесены в Excel файл");
        }
    }
}
