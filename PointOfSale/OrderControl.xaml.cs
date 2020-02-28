//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/23/2020
//OrderControl.xaml.cs

using System;
using System.Collections.Generic;
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
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that adds entree to the order list
        /// </summary>
        private void AddEntreeToOrder(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "AngryChickenButton":
                    OrderSummaryBox.Items.Add(new AngryChicken().ToString());
                    break;
                case "CowpokeChiliButton":
                    OrderBox.Items.Add(new CowpokeChili().ToString());
                    break;
                case "DakotaDoubleBurgerButton":
                    OrderBox.Items.Add(new DakotaDoubleBurger().ToString());
                    break;
                case "PecosPulledPorkButton":
                    OrderBox.Items.Add(new PecosPulledPork().ToString());
                    break;
                case "RustlersRibsButton":
                    OrderBox.Items.Add(new RustlersRibs().ToString());
                    break;
                case "TexasTripleBurgerButton":
                    OrderBox.Items.Add(new TexasTripleBurger().ToString());
                    break;
                case "TrailBurgerButton":
                    OrderBox.Items.Add(new TrailBurger().ToString());
                    break;
                default:
                    throw new NotImplementedException("Unknown entree button clicked");
            }
        }

        /// <summary>
        /// Method that adds side to the order list
        /// </summary>
        private void AddSideToOrder(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "BakedBeansButton":
                    OrderBox.Items.Add(new BakedBeans().ToString());
                    break;
                case "ChiliCheeseFriesButton":
                    OrderBox.Items.Add(new ChiliCheeseFries().ToString());
                    break;
                case "CornDodgersButton":
                    OrderBox.Items.Add(new CornDodgers().ToString());
                    break;
                case "PanDeCampoButton":
                    OrderBox.Items.Add(new PanDeCampo().ToString());
                    break;
                default:
                    throw new NotImplementedException("Unknown side button clicked");
            }
        }

        /// <summary>
        /// Method that adds drink to the order list
        /// </summary>
        private void AddDrinkToOrder(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Name)
            {
                case "CowboyCoffeeButton":
                    OrderBox.Items.Add(new CowboyCoffee().ToString());
                    break;
                case "JerkedSodaButton":
                    OrderBox.Items.Add(new JerkedSoda().ToString());
                    break;
                case "TexasTeaButton":
                    OrderBox.Items.Add(new TexasTea().ToString());
                    break;
                case "WaterButton":
                    OrderBox.Items.Add(new Water().ToString());
                    break;
                default:
                    throw new NotImplementedException("Unknown drink button clicked");
            }
        }
    }
}

