using System;
using System.Windows.Forms;

/*
 * Zachary Betters
 * CIS 209
 * October 25, 2016
 * Vending Machine
 * This program will display a vending machine and operate like one
 */

namespace VendingMachine {
    public partial class Form1 : Form {
        
        //structure drink is made with price and amount attributes 
        struct Drink {
            public double price;
            public double amount;
            public string name; 
        }

        public double Total;

        //array of 5 drinks are made
        Drink[] drink = new Drink[5];
        //array of 5 buttons are made
        Button[] buttons = new Button[5];
                    
        public Form1() { 
            InitializeComponent();

            //array of buttons filled up
            buttons[0] = btnCola;
            buttons[1] = btnRoot;
            buttons[2] = btnLime;
            buttons[3] = btnGrape;
            buttons[4] = btnCream;

            //each drink is given a name 
            drink[0].name = "Cola";
            drink[1].name = "Root Beer";
            drink[2].name = "Lemon Lime";
            drink[3].name = "Grape Soda";
            drink[4].name = "Cream Soda";

            //values are given to drinks 
            for (int c = 0; c <= 4; c++) { drink[c].amount = 20; }
            for (int i = 0; i <= 3; i++) { drink[i].price = 1.00; }
            for (int a = 3; a <= 4; a++) { drink[a].price = 1.50; }
        }

        public void Result(int Num) {

            //if there are drinks left
            if (drink[Num].amount > 0) {
                drink[Num].amount--;    

                //display amount of drinks left                   
                buttons[Num].Text = drink[Num].amount.ToString();
                Total += drink[Num].price;

                //display total price formatted as currency 
                btnTotal.Text = Total.ToString("C");
            }
            else {
                MessageBox.Show(drink[Num].name + " is all gone!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //pass drink number to method and execute
        private void btnCola_Click(object sender, EventArgs e)  { Result(0); }
        private void tbnRoot_Click(object sender, EventArgs e) { Result(1); }
        private void btnLime_Click(object sender, EventArgs e) { Result(2); }
        private void btnGrape_Click(object sender, EventArgs e) { Result(3); }
        private void btnCream_Click(object sender, EventArgs e) { Result(4); }

        private void btnExit_Click(object sender, EventArgs e) { Close(); }
    }
}