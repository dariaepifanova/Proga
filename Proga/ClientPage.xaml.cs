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

namespace Proga
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Window
    {
        /* public MainWindow()
         {
             InitializeComponent();
         }
         */
        public ClientPage(Client client)
        {
            InitializeComponent();
            ClientName.Content = client.Name;
        }

        private void SizeDown_Click(object sender, RoutedEventArgs e)
        {
            int size;
            if (!int.TryParse(SizeBox.Text, out size))
            {
                MessageBox.Show("Некорректное значение в поле 'размер'");
            }
            else
            {
                if (size >= 27 && size <= 47)
                    size--;
                else
                {
                    MessageBox.Show("Некорректное значение в поле 'размер'. Выход за пределы диапазона значений (26, 47)");
                }
                SizeBox.Text = "" + size;
            }
        }

        private void SizeUp_Click(object sender, RoutedEventArgs e)
        {
            int size;
            if (!int.TryParse(SizeBox.Text, out size))
            {
                MessageBox.Show("Некорректное значение в поле 'размер'");
            }
            else
            {
                if (size >= 26 && size <= 46)
                    size++;
                else
                {
                    MessageBox.Show("Некорректное значение в поле 'размер'. Выход за пределы диапазона значений (26, 47)");
                }
                SizeBox.Text = "" + size;
            }
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyItems_KeyDown(object sender, MouseButtonEventArgs e)
        {
            ClientItems mi = new ClientItems(this);
            mi.Show();
            this.Hide();
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Close();
        }
    }
}
