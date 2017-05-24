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
    /// Interaction logic for ClientItems.xaml
    /// </summary>
    public partial class ClientItems : Window
    {
        private ClientPage cpage;
        public ClientItems(ClientPage mw)
        {
            InitializeComponent();
            this.cpage = mw;
        }

        private void Return_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            cpage.Show();
        }
    }
}
