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

namespace dich.admin
{
    /// <summary>
    /// Логика взаимодействия для AllContracts.xaml
    /// </summary>
    public partial class AllContracts : Window
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable phonesTable;
        string AccId;
        bool s = false;
        int typeSql;
        public AllContracts()
        {
            InitializeComponent();
            conn = new SqlConnection();
            //сonn = new SqlConnection();
            //adapter = new SqlDataAdapter(command);
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=CompStrahOfAuto;Integrated Security=True";
            phonesGrid.CanUserAddRows = false;
            table_select();
        }

        private void BtnForm_Click(object sender, RoutedEventArgs e)
        {
            /*TaskWindow taskWindow = new TaskWindow();            // Изменение 
            DataRowView row = (DataRowView)phonesGrid.SelectedItems[0];
            taskWindow.rw = row;
            taskWindow.Show();
            //MessageBox.Show(taskWindow.strQuery);
            this.Close();
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataTable phonesTable = new DataTable("Phones");

            SqlCommand comm = new SqlCommand(taskWindow.strQuery, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            comm.CommandText = "SELECT * FROM Аккаунты";
            comm.ExecuteNonQuery();
            adapter.Fill(phonesTable);
            phonesGrid.ItemsSource = phonesTable.DefaultView;*/
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            table_select();
        }
        private void table_select()
        {
            /*if (conn.State == ConnectionState.Closed) conn.Open();

            DataTable phonesTable = new DataTable();
            SqlCommand comm = new SqlCommand("SELECT * FROM [Договор]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            adapter.Fill(phonesTable);
            phonesGrid.ItemsSource = phonesTable.DefaultView;
            //phonesGrid.SelectedIndex = 0;
            phonesGrid.Focus();
            phonesGrid.SelectedItem = phonesGrid.Items[0];
            phonesGrid.ScrollIntoView(phonesGrid.Items[0]);*/
        }


        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            /*try
            {

                DataRowView row = (DataRowView)phonesGrid.SelectedItems[0];

                // MessageBox.Show(Convert.ToString(row["Title"]));
                AccId = Convert.ToString(row["Код"]);
                MessageBox.Show("DELETE  FROM [Водительское удостверение] WHERE Id = '" + AccId + "'");
                if (conn.State == ConnectionState.Closed) conn.Open();
                DataTable phonesTable = new DataTable("Аккаунт");
                SqlCommand comm = new SqlCommand("DELETE  FROM [Водительское удостверение] WHERE Код = '" + AccId + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                comm.CommandText = "SELECT * FROM [Водительское удостверение]";
                comm.ExecuteNonQuery();
                adapter.Fill(phonesTable);
                phonesGrid.ItemsSource = phonesTable.DefaultView;

            }
            catch
            {
                MessageBox.Show("Не удалось удалить");
                return;
            }*/



        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
