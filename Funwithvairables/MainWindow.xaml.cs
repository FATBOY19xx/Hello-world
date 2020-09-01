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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Funwithvairables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonMyMessage_Click(object sender, RoutedEventArgs e)
        {
            string firstName;

            string lastName;

            firstName = textBoxFirstName.Text;

            lastName = textBoxLastName.Text;

            labelMyMessage.Content = "Hello " + firstName + " " + lastName + ", good to see you! ";


        }

        private void buttonClearMe_Click(object sender, RoutedEventArgs e)
        {

            textBoxFirstName.Text = "";
            
            textBoxLastName.Text = "";

            labelMyMessage.Content = "";






        }
    }
}
