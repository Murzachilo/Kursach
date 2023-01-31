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

namespace dich.manager
{
    /// <summary>
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Window
    {
        SqlConnection conn;
        public Auto()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        }

        private string create_ts_factory() // Заполнение таблицы ВУ
        {

            if (stamp.Text == "" || model.Text == "" || category.Text == "" || power.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return "";
            } //Проверка на заполнение 
            string ts_factory = "insert into [БиблиотекаТС]" +
            " (Марка, Модель, Категория, Мощность)" +
            " values('" + stamp.Text + "', '" + stamp.Text + "', '" +
            category.Text + "', '" + power.Text + "')";
            return ts_factory;
        }
        private string create_ts_doc() // Заполнение таблицы ВУ
        {

            if (year.Text == "" || num.Text == "" || VIN.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return "";
            } //Проверка на заполнение 
            string ts_doc = "insert into [Транспортное средство]" +
            " ([Номер VIN], [Год выпуска], [Гос номер])" +
            " values('" + VIN.Text + "', '" + year.Text + "', '" +
            num.Text +"')";
            return ts_doc;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Driver dlg = new Driver();
            dlg.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu dlg = new Menu();
            dlg.Show();
        }
    }
}
