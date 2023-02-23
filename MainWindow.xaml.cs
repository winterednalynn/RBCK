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

namespace RBCK
{ // EDNA LYNN LAXA 
  // FEBRUARY 20, 2023 
  // RADIO BOXES & CHECK BOXES ASSIGNMENT 
  // CSI - PROGRAM II 
  





    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }
        
        private void btnPizzaSize_Click(object sender, RoutedEventArgs e)
        {
            // Radio Buttons always return True or False  - Booleans 
            // To get the result of our radio button, use name.isChecked.Value; 

            bool smallPizza = rbSmall.IsChecked.Value;
            bool mediumPizza = rbMedium.IsChecked.Value;
            bool largePizza = rbLarge.IsChecked.Value;
            bool extraLargePizza = rbExtraLarge.IsChecked.Value; 

            //Since the structure of radio buttons is multiple choices but one selection,
            // usage of if/else if / else structure is considered.

            if (smallPizza == true)
            {
                runDisplay.Text = "Small Pizza";
            }
            else if (mediumPizza)
            {
                runDisplay.Text = "Medium Pizza";
            }
            else if (largePizza)
            {
                runDisplay.Text = "Large Pizza";
            }
            else if (extraLargePizza)
            {
                runDisplay.Text = "Extra Large Pizza";
            }
            else
            {
                runDisplay.Text = "Please select a Pizza Size";
            }

        }
       

        private void btnSubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            ////Prompting customer name 
            //// When customer enters name onto txtbox, this will display in RTB once an event is initiated by selecting the submit order button
            runDisplay.Foreground = new SolidColorBrush(Colors.DarkMagenta);
            runDisplay.Text = txtName.Text;


            //Check Boxes always return as a true / false = booleans
            //If checkboxes are considered true / false, then the inital structure will start w/ bool. 

            bool hasPepperoni = ckPepperoniRoses.IsChecked.Value;
            bool hasChicken = ckChicken.IsChecked.Value;
            bool hasGreenPeppers = ckGreenBellPeppers.IsChecked.Value;
            bool hasMushroom = ckMushrooms.IsChecked.Value;

            //This code structure will prompt onto the RTB as true b/c Pepperoni is one of the options on Checkboxes. 
            runDisplay.Text = hasPepperoni.ToString();

            //Clears the RTB 
            runDisplay.Text = "";

            if (hasPepperoni == true)
            {
                runDisplay.Text += "Pepperoni\n";
            }
            if (hasChicken)
            {
                runDisplay.Text += "Chicken\n";
            }
            if (hasGreenPeppers)
            {
                runDisplay.Text += "Green Bell Peppers\n";
            }
            if (hasMushroom)
            {
                runDisplay.Text += "Mushrooms\n";
            }
          

        }

        private void BtnDrinkSize_Click(object sender, RoutedEventArgs e)
        {
            //Radio Button for Drink Size 

            // Using bool as Radio Button returns true / false 

            bool smallDrink = rbDrinkSmall.IsChecked.Value;
            bool mediumDrink = rbDrinkMedium.IsChecked.Value;
            bool largeDrink = rbDrinkLarge.IsChecked.Value;
            bool xlargeDrink = rbDrinkExtraLrg.IsChecked.Value;

            //Using if, else if, else statement for Radio Button b/c it multi- opiton w/ a decision of one 

            if (smallDrink == true)
            {
                runDisplay.Text = "Small Drink";
            }
            else if (mediumDrink)
            {
                runDisplay.Text = "Medium Drink";
            }
            else if (largeDrink)
            {
                runDisplay.Text = "Large Drink";
            }
            else if (xlargeDrink)
            {
                runDisplay.Text = "Extra Large Drink";
            }
            else
            {
                runDisplay.Text = "Select a drink size";
            }
        }

        private void btnDrinkSelect_Click(object sender, RoutedEventArgs e)
        {
            //Radio Buttons for Soda 

            bool selectPepsi = rbPepsi.IsChecked.Value;
            bool selectSprite = rbSprite.IsChecked.Value;

            // Using if, else if, else structure because RB is based on multi-option & one decision 

            if (selectPepsi == true)
            {
                runDisplay.Text = "Pespi";
            }
            else if (selectSprite)
            {
                runDisplay.Text = "Sprite";
            }
            else
            {
                runDisplay.Text = "Please select a drink";
            }
        }
    }
}
