using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QAManagement.TestAssistant
{
    /// <summary>
    /// Interaction logic for TestRunner.xaml
    /// </summary>
    public partial class TestRunner : Window
    {
        Window DialogWindow;
        public TestRunner()
        {
            InitializeComponent();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow = new ActionResult();
            DialogWindow.Show();

        }
    }
}
