using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Book_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sqlquery;
        string currentTable = "[dbo].[free_books]";//This will point  the current table when searching

        private void Form1_Load(object sender, EventArgs e)//Will display the table from the database once the project is run
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlquery = "select * from [dbo].[free_books]";//Select statement to display the Free Books table
            sqlconn.Open();//Opening a connection to the database
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            EmployeesListDataGridView.DataSource = dt;
            sqlconn.Close();//Closing the connection
        }

        private void textSearch_TextChanged(object sender, EventArgs e)//Codeblock for searching from the Table
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from "+currentTable+" where Book_name like '"+textSearch.Text+"%'";//SQL query to search using entered strings
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            EmployeesListDataGridView.DataSource = dt;
            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTable = "[dbo].[paid_books]";//Once the button is clicked this sets the currentTable as the table to be displayed
            string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlquery = "select * from [dbo].[paid_books]";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            EmployeesListDataGridView.DataSource = dt;
            sqlconn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTable = "[dbo].[free_books]";//Once the button is clicked this sets the currentTable as the table to be displayed
            string mainconn = ConfigurationManager.ConnectionStrings["MyCONN"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlquery = "select * from [dbo].[free_books]";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            EmployeesListDataGridView.DataSource = dt;
            sqlconn.Close();
        }
    }
}
