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

namespace dich.admin
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        SqlConnection conn;
        public Registration()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        }

        /*private string create_person() // Заполнение таблицы ВУ
        {

            if (fam.Text == "" || name.Text == "" || sname.Text == "" || phone.Text == "" || passport.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return "";
            } //Проверка на заполнение 
            string person = "insert into [Персона]" +
            " (Фамилия, Имя, Отчество, Телефон, [Серия и номер паспорта])" +
            " values('" + fam.Text + "', '" + name.Text + "', '" +
            sname.Text + "', '" + phone.Text + "', '" + passport.Text + "', '" + male.Text + "')";
            return person;
        }*/
        private void male_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
