using System.Data;
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

namespace WpfApp1
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
        private void Segitseg_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.police.hu/index.php/hu/koral/elfogatoparancs-alapjan-korozott-szemelyek",
                UseShellExecute = true
            });
        }

        private void Nyomott(object sender, RoutedEventArgs e) {
            if (sender is Button button)
            {
                beiros.Text += button.Content.ToString();
            }
        }
        private void Clear(object sender, RoutedEventArgs e) {
             beiros.Text = string.Empty;
        }
        private void Szamol(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = beiros.Text;
                var result = new DataTable().Compute(expression, null);
                beiros.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a kifejezés kiértékelésekor: " + ex.Message);
            }
        }




    }
}