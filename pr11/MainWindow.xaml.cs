using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr11
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
        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            string inputString = txtInput.Text;
            string primer1 = @"\b(aa|aba|abba|abbba)\b"; // Для первого примера
            string primer2 = @"\ba\d+a\b"; // Для второго примера

            try
            {
                MatchCollection matches1 = Regex.Matches(inputString, primer1);
                MatchCollection matches2 = Regex.Matches(inputString, primer2);

                txtOutput1.Text = "";
                foreach (Match match in matches1)
                {
                    txtOutput1.Text += match.Value + Environment.NewLine;
                }

                txtOutput2.Text = "";
                foreach (Match match in matches2)
                {
                    txtOutput2.Text += match.Value + Environment.NewLine;
                }

                if (matches1.Count == 0 && matches2.Count == 0)
                {
                    txtOutput1.Text = "Совпадений не найдено.";
                    
                }
            }
            catch (Exception ex)
            {
                txtOutput1.Text = "Ошибка: " + ex.Message;
                txtOutput2.Text = "";
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина Екатерина";
            int job = 11;
            string task = ". Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, \r\nкоторое найдет строки aa, aba, abba, abbba.\r\nДана строка 'a1a a2a a3a a4a a5a aba aca'. Напишите регулярное выражение, которое \r\nнайдет строки, в которых по краям стоят буквы 'a', а между ними одна цифра.";
            MessageBox.Show($"Разработчик: {developer}\nНомер работы: {job}\nЗадание: {task}", "О программе");
        }

        // "Выход"
        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    