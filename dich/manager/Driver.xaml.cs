using dich.manager;
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

namespace dich
{
    /// <summary>
    /// Логика взаимодействия для Driver.xaml
    /// </summary>
    public partial class Driver : Window
    {
        SqlConnection conn;
        public Driver()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=" + System.Environment.MachineName + ";Initial Catalog=CompStrahOfAuto;Integrated Security=True";
        }

        private void Button_Search_Next_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            New_contract dlg = new New_contract();
            dlg.Show();
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {

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
        private string create_vu()
        {
            if (vuser.Text == "" || vunum.Text == "" || d_burn.Text == "" || d_start.Text == "")
            {
                MessageBox.Show("Какое-то из полей не было заполнено");
                return "";
            } //Проверка на заполнение 
            string vu = "insert into [Водительское удостверение] (Серия, Номер, [Дата Рождения], [Дата начала стажа]) values('"  +
            vuser.Text + "', '" + vunum.Text + "', '" +
            d_burn.SelectedDate.ToString() + "', '" + d_start.SelectedDate.ToString() + "')";
            return vu;
        }
        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                string person = create_person();
                string vu = create_vu();
                if (person == "" && vu == "")
                    return;
                conn.Open();
                
                SqlCommand per = new SqlCommand(person, conn);
                SqlCommand vuc = new SqlCommand(vu, conn);
                per.ExecuteNonQuery();
                vuc.ExecuteNonQuery();
                MessageBox.Show(per.CommandText);
                conn.Close();



                this.Hide();
                New_contract dlg = new New_contract();
                dlg.Show();

            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
            
        }

        private void More_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Client dlg = new Client();
            dlg.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Auto dlg = new Auto();
            dlg.Show();
        }
    }
}
