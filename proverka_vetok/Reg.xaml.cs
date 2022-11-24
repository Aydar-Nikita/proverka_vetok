using System;
using System.Collections.Generic;
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

namespace proverka_vetok
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void CLick_ChekTextBox(object sender, RoutedEventArgs e)
        {
            var TSurname = Surname.Text;
            var TName = Name.Text;
            var TPatronymic = Patronymic.Text;
            var TLogin = Login.Text;
            var TPassword = Password.Text;
            if (TSurname.Length == 0 && TName.Length == 0 && TPatronymic.Length == 0 && TLogin.Length == 0 && TPassword.Length == 0)
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void CLick_TestTextBox(object sender, RoutedEventArgs e)
        {
            char last = '\0';
            string s = "";
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                var temp = (char)(r.Next(1072, 1104));
                if (temp != last)
                {
                    s += temp;
                    last = temp;
                }
            }
            MessageBox.Show(s);
           
        }
    }
}
