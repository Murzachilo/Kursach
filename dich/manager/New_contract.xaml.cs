using dich.manager;
using System;
using System.Collections.Generic;
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

namespace dich
{
    /// <summary>
    /// Логика взаимодействия для New_contract.xaml
    /// </summary>
    public partial class New_contract : Window
    {
        SqlConnection conn;
        public New_contract()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Client dlg = new Client();
            dlg.Show();
        }
    }
}
