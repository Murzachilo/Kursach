using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace dich.manager
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        SqlConnection con;
        public Client()
        {
            InitializeComponent();
            con = new SqlConnection();
            Loaded += Client_Load;
            con.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        }
        private void Client_Load(object sender, EventArgs e)
        {
            check_person();
        }
        private string create_person() // Заполнение таблицы ВУ
        {

            if (fam.Text == "" || name.Text == "" || sname.Text == "" || phone.Text == "" || passport.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return "";
            } //Проверка на заполнение 
            string person = "insert into [Персона]" +
            " (Фамилия, Имя, Отчество, Телефон, [Серия и номер паспорта])" +
            " values('" + fam.Text + "', '" + name.Text + "', '" +
            sname.Text + "', '" + phone.Text + "', '" + passport.Text + "')";
            return person;
        }

        private void check_person()
        {
            /*DataTable useresTable = new DataTable();
            SqlCommand comm = new SqlCommand("select Фамилия, Имя, Отчесво from Персона", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            adapter.Fill(useresTable);*/

            //con.Open();
            string query = "select Код, Фамилия + ' ' + Имя + ' ' + Отчество as ФИО from Персона";
            /*SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Код", typeof(string));
            dt.Columns.Add("ФИО", typeof(string));

            dt.Load(rdr);
            PersonsBox.DataContext = dt;
            PersonsBox.SelectedValuePath = "Код";
            PersonsBox.DisplayMemberPath = "ФИО";
            con.Close();*/

            SqlCommand sqlcmd = new SqlCommand();
            SqlDataAdapter sqladp = new SqlDataAdapter();
            DataSet ds = new DataSet();

            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = query;
            con.Open();
            sqladp.SelectCommand = sqlcmd;
            sqladp.Fill(ds, "defaultTable");
            DataRow nRow = ds.Tables["defaultTable"].NewRow();
            nRow["ФИО"] = "NULL";
            nRow["Код"] = "-1";
            ds.Tables["defaultTable"].Rows.InsertAt(nRow, 0);
            PersonsBox.DataContext = ds.Tables["defaultTable"].DefaultView;

            PersonsBox.DisplayMemberPath = ds.Tables["defaultTable"].Columns[0].ToString();
            PersonsBox.SelectedValuePath = ds.Tables["defaultTable"].Columns[1].ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Driver dlg = new Driver();
            dlg.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            New_contract dlg = new New_contract();
            dlg.Show();
        }
    }
}
