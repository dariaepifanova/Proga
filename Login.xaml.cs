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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private string ConnectionString = "Data Source=" + System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Database1.sdf");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /*using (SqlCeConnection connection = new SqlCeConnection(ConnectionString))
            {
                string query = "SELECT * FROM USER WHERE LOGIN='" + UsernameBox.Text + "' AND PASSWORD='" + PasswordBox.Password + "'";
                SqlCeDataAdapter sdAdapter = new SqlCeDataAdapter(query, connection);

                DataTable dTable = new DataTable();
                try { 
                sdAdapter.Fill(dTable);}
                catch (Exception xe)
                {
                    Console.WriteLine("{0} Exception caught.", xe);
                }

                if (dTable.Rows.Count > 0)
                {
                    this.Hide();
                    MainWindow mv = new MainWindow();
                    mv.Show();

                }
                else
                {
                    Error.Visibility = Visibility.Visible;
                    
                }
            }*/
            this.Hide();
            ClientPage cpage = new ClientPage(new Client(UsernameBox.Text, 0, false));
            cpage.Show();
            Console.WriteLine(ConnectionString);
        }
    }
}
    
