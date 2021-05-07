using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BeadandoBD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Szamlak szamla1;
        public Szamlak szamla2;

        public MainWindow()
        {
            InitializeComponent();

            szamla1 = new Szamlak(1, "Dominik", 1000);
            szamla2 = new Szamlak(2, "Donald", 1000);

            SzamlaInformacioFrissites();
        }

        public void SzamlaFeltoltes(Szamlak szamla, string egyenleg)
        {
            if (Regex.IsMatch(egyenleg, @"^\d+$"))
            {
                if (Convert.ToInt32(egyenleg) > 0)
                {
                    szamla.Egyenleg += Convert.ToInt32(egyenleg);
                }
                else
                {
                    MessageBox.Show("The selected value is wrong!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("The selected value is wrong!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            SzamlaInformacioFrissites();
        }

        public void SzamlaUtalas(Szamlak kuldo, Szamlak fogado, string egyenleg)
        {
            if (Regex.IsMatch(egyenleg, @"^\d+$"))
            {
                if (Convert.ToInt32(egyenleg) > 0)
                {
                    if (kuldo.Egyenleg >= Convert.ToInt32(egyenleg))
                    {
                        kuldo.Egyenleg -= Convert.ToInt32(egyenleg);
                        fogado.Egyenleg += Convert.ToInt32(egyenleg);
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The selected value is wrong!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("The selected value is wrong!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            SzamlaInformacioFrissites();
        }

        public void SzamlaKivetel(Szamlak szamla, string egyenleg)
        {
            if (Regex.IsMatch(egyenleg, @"^\d+$"))
            {
                if (Convert.ToInt32(egyenleg) > 0)
                {
                    if (szamla.Egyenleg >= Convert.ToInt32(egyenleg))
                    {
                        szamla.Egyenleg -= Convert.ToInt32(egyenleg);
                    }
                    else
                    {
                        MessageBox.Show("Not enough money!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The selected value is wrong!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("The given text is in unproper form!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            SzamlaInformacioFrissites();
        }

        public void TulajNevValtas(Szamlak szamla, string nev)
        {
            if (nev != null)
            {
                szamla.Tulajdonos = nev;
            }
            else
            {
                MessageBox.Show("The given text is in unproper form!", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            SzamlaInformacioFrissites();
        }

        public void SzamlaInformacioFrissites()
        {
            SzamlaTulajdonosTextbox1.Text = szamla1.Tulajdonos;
            SzamlaTulajdonosTextbox2.Text = szamla2.Tulajdonos;
            SzamlaEgyenlegeTextbox1.Text = szamla1.Egyenleg.ToString();
            SzamlaEgyenlegeTextbox2.Text = szamla2.Egyenleg.ToString();
        }

        private void SzamlaFeltoltesButton1_Click(object sender, RoutedEventArgs e) //Feltöltés gomb 
        {
            SzamlaFeltoltes(szamla1, BevitelMezoTextbox1.Text);
        }

        private void UtalasButton1_Click(object sender, RoutedEventArgs e) //Utalás gomb
        {
            SzamlaUtalas(szamla1, szamla2, BevitelMezoTextbox1.Text);
        }

        private void KivetelButton1_Click(object sender, RoutedEventArgs e) //Kivétel gomb
        {
            SzamlaKivetel(szamla1, BevitelMezoTextbox1.Text);
        }

        private void TulajdonosNevValtasButton1_Click(object sender, RoutedEventArgs e) //Tulajdonos névváltásának gomb
        {
            TulajNevValtas(szamla1, BevitelMezoTextbox1.Text);
        }

        private void SzamlaFeltoltesButton2_Click(object sender, RoutedEventArgs e)
        {
            SzamlaFeltoltes(szamla2, BevitelMezoTextbox2.Text);
        }

        private void UtalasButton2_Click(object sender, RoutedEventArgs e)
        {
            SzamlaUtalas(szamla2, szamla1, BevitelMezoTextbox2.Text);
        }

        private void KivetelButton2_Click(object sender, RoutedEventArgs e)
        {
            SzamlaKivetel(szamla2, BevitelMezoTextbox2.Text);
        }

        private void TulajdonosNevValtasButton2_Click(object sender, RoutedEventArgs e)
        {
            TulajNevValtas(szamla2, BevitelMezoTextbox2.Text);
        }
       
    }
}
