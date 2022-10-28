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

namespace VoorArno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Names { get; set; }
        public string ChosenName { get; set; }

        public MainWindow()
        {
            Names = new List<string>()
            {
                "Arno", "Ken", "Bart", "Gert", "Stef", "Samson"
            };

            ChosenName = Names[new Random().Next(Names.Count)];
            InitializeComponent();
        }

        private void BtnGuess_Click(object sender, RoutedEventArgs e)
        {
            Guess();
        }

        private void PressedEnter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Guess();
            }
        }

        private void Guess()
        {
            if (ChosenName.ToLower() == TxtInput.Text.ToLower())
            {
                MessageBox.Show("Juist geraden!");
                ChosenName = Names[new Random().Next(Names.Count)];
            }
            else
            {
                MessageBox.Show("Fout geraden!");
            }

            TxtInput.Text = string.Empty;
        }

        private void BtnWindow_Click(object sender, RoutedEventArgs e)
        {
            NewWindow newWindow = new NewWindow(TxtInput.Text);
            newWindow.Show();
        }
    }
}
