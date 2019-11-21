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

namespace WpfApplication_FINALPROJECT
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

        public List<Pokemon> ListOfPokemon = new List<Pokemon>();
        public List<Berry> ListOfItems = new List<Berry>(); 

        
        private void PokemonButton(object sender, RoutedEventArgs e)
        {
            Pokemon Charizard = new Pokemon("Fire & Flying", 78, 84, 78, 109, 85, 100);
            ListOfPokemon.Add(Charizard);
            Pokemon Zoroark = new Pokemon("Dark", 60, 105, 60, 120, 60, 105);
            ListOfPokemon.Add(Zoroark);
            Pokemon Lucario = new Pokemon("Fighting & Steel", 70, 110, 70, 115, 70, 90);
            ListOfPokemon.Add(Lucario);
            Pokemon Pikachu = new Pokemon("Electric", 35, 55, 40, 50, 50, 90);
            ListOfPokemon.Add(Pikachu);
            Pokemon Raichu = new Pokemon("Electric", 60, 90, 55, 90, 80, 100);
            ListOfPokemon.Add(Raichu);
        }

        private void BerryButton(object sender, RoutedEventArgs e)
        {
            //https://bulbapedia.bulbagarden.net/wiki/Berry#List_of_Berries
        }
    }
}
