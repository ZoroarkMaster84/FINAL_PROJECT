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
        public List<Berry> ListOfBerries = new List<Berry>();
        public List<HealingItem> ListOfHealingItems = new List<HealingItem>();
        
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
            Berry Cheri_Berry = new Berry("paralysis", "Cheri Berry");
            ListOfBerries.Add(Cheri_Berry);
            Berry Chesto_Berry = new Berry("sleep", "Chesto Berry");
            ListOfBerries.Add(Chesto_Berry);
            Berry Pecha_Berry = new Berry("poison", "Pecha Berry");
            ListOfBerries.Add(Pecha_Berry);
            Berry Rawst_Berry = new Berry("burn", "Rawst Berry");
            ListOfBerries.Add(Rawst_Berry);
            Berry Aspear_Berry = new Berry("freeze", "Aspear Berry");
            ListOfBerries.Add(Aspear_Berry);
            Berry Persim_Berry = new Berry("confusion", "Persim Berry");
            ListOfBerries.Add(Persim_Berry);

        }

        private void HealingItemButtom(object sender, RoutedEventArgs e)
        {
            HealingItem Potion = new HealingItem(20, "Potion");
            ListOfHealingItems.Add(Potion);
            HealingItem SuperPotion = new HealingItem(50, "Super Potion");
            ListOfHealingItems.Add(SuperPotion);
            HealingItem HyperPotion = new HealingItem(200, "Hyper Potion");
            ListOfHealingItems.Add(HyperPotion);
            HealingItem FreshWater = new HealingItem(50, "Fresh Water");
            ListOfHealingItems.Add(FreshWater);
            HealingItem SodaPop = new HealingItem(60, "Soda Pop");
            ListOfHealingItems.Add(SodaPop);
            HealingItem Lemonade = new HealingItem(80, "Lemonade");
            ListOfHealingItems.Add(Lemonade);
            HealingItem MooMooMilk = new HealingItem(100, "MooMoo Milk");
            ListOfHealingItems.Add(MooMooMilk);
        }
    }
}
