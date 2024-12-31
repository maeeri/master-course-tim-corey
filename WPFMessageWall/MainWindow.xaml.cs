using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMessageWall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<string> messages = new BindingList<string>();
        public MainWindow()
        {
            InitializeComponent();
            lstMessages.ItemsSource = messages;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            messages.Add(txtMessage.Text);
            txtMessage.Text = "";
            txtMessage.Focus();
        }
    }
}