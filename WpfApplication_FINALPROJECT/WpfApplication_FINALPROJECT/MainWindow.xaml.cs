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
        Pokemon Charizard;
        Pokemon Zoroark;
        Pokemon Lucario;
        Pokemon Pikachu;
        Pokemon Raichu;

        Berry Cheri_Berry;
        Berry Chesto_Berry;
        Berry Pecha_Berry;
        Berry Rawst_Berry;
        Berry Aspear_Berry;
        Berry Persim_Berry;

        HealingItem Potion;
        HealingItem SuperPotion;
        HealingItem HyperPotion;
        HealingItem FreshWater;
        HealingItem SodaPop;
        HealingItem Lemonade;
        HealingItem MooMooMilk;


        public MainWindow()
        {
            InitializeComponent();

            Charizard = new Pokemon("Charizard", "Fire & Flying", "78", "84", "78", "109", "85", "100");
            ListOfPokemon.Add(Charizard);
            Zoroark = new Pokemon("Zoroark", "Dark", "60", "105", "60", "120", "60", "105");
            ListOfPokemon.Add(Zoroark);
            Lucario = new Pokemon("Lucario", "Fighting & Steel", "70", "110", "70", "115", "70", "90");
            ListOfPokemon.Add(Lucario);
            Pikachu = new Pokemon("Pikachu", "Electric", "35", "55", "40", "50", "50", "90");
            ListOfPokemon.Add(Pikachu);
            Raichu = new Pokemon("Raichu", "Electric", "60", "90", "55", "90", "80", "100");
            ListOfPokemon.Add(Raichu);


            Cheri_Berry = new Berry("paralysis", "Cheri Berry");
            ListOfBerries.Add(Cheri_Berry);
            Chesto_Berry = new Berry("sleep", "Chesto Berry");
            ListOfBerries.Add(Chesto_Berry);
            Pecha_Berry = new Berry("poison", "Pecha Berry");
            ListOfBerries.Add(Pecha_Berry);
            Rawst_Berry = new Berry("burn", "Rawst Berry");
            ListOfBerries.Add(Rawst_Berry);
            Aspear_Berry = new Berry("freeze", "Aspear Berry");
            ListOfBerries.Add(Aspear_Berry);
            Persim_Berry = new Berry("confusion", "Persim Berry");
            ListOfBerries.Add(Persim_Berry);


            Potion = new HealingItem("20", "Potion");
            ListOfHealingItems.Add(Potion);
            SuperPotion = new HealingItem("50", "Super Potion");
            ListOfHealingItems.Add(SuperPotion);
            HyperPotion = new HealingItem("200", "Hyper Potion");
            ListOfHealingItems.Add(HyperPotion);
            FreshWater = new HealingItem("50", "Fresh Water");
            ListOfHealingItems.Add(FreshWater);
            SodaPop = new HealingItem("60", "Soda Pop");
            ListOfHealingItems.Add(SodaPop);
            Lemonade = new HealingItem("80", "Lemonade");
            ListOfHealingItems.Add(Lemonade);
            MooMooMilk = new HealingItem("100", "MooMoo Milk");
            ListOfHealingItems.Add(MooMooMilk);

        }

        public List<Pokemon> ListOfPokemon = new List<Pokemon>();
        public List<Berry> ListOfBerries = new List<Berry>();
        public List<HealingItem> ListOfHealingItems = new List<HealingItem>();
        

        
        public void PokemonButton(object sender, RoutedEventArgs e)
        {
            string input_Pokemon = Pokemon_TextBox.Text;

            foreach (Pokemon p in ListOfPokemon)
            {
                if (p.Name == input_Pokemon)
                {
                    Pokemon_TextBlock.Text = ($"{p.Name} is a {p.type} pokemon with {p.hp} hp, {p.attack} attack, {p.defense} defense, {p.sp_atk} special attack, {p.sp_def} special defense, and {p.speed} speed,");
                }
            }
        }

        public void BerryButton(object sender, RoutedEventArgs e)
        {
            string input_Berry = Berry_TextBox.Text;

            foreach (Berry b in ListOfBerries)
            {
                if (b.status == input_Berry)
                {
                    Berry_TextBlock.Text = ($" A {b.name} will cure {b.status}");
                }
            }
        }

        public void HealingItemButtom(object sender, RoutedEventArgs e)
        {
            string input_HealingItem = HealingItem_TextBox.Text;

             foreach (HealingItem hI in ListOfHealingItems)
            {
                if (hI.hp == input_HealingItem)
                {
                    HealingItem_TextBlock.Text = ($"A {hI.name} heals {hI.hp} hp");
                }
            }
        }

    }
}
