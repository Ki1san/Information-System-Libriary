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

namespace Information_System_Libriary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBox text;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pass = password.Text.ToString();
                string log = login.Text.ToString();

                if (string.IsNullOrEmpty(log) || string.IsNullOrEmpty(pass))
                {
                    throw new ArgumentException("Логин и пароль не могут быть пустыми!");
                }

                if (log == "Kilsan" && pass == "Soevmen12")
                {
                    MessageBox.Show("Welcome admin");

                    admin Admin = new admin();
                    Admin.Show();

                    this.Close();
                }
                else
                {
                    throw new UnauthorizedAccessException("Incorrect login or password");
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Login error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error unknown: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}