using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Census_Program_Project_4
{
    public partial class Form1 : Form
    {
        private int listCounter = 0;
        private double houseOne = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumOfBathrooms.Clear();
            txtNumOfPersons.Clear();
            txtHouseholdIncome.Clear();

            txtAvgNumBaths.Clear();
            txtAvgNumPersons.Clear();
            txtAvgHouseholdIncome.Clear();

            lbOutputList.ClearSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHouseOne_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseTwo_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseThree_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseFour_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseFive_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseSix_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseSeven_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseEight_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseNine_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        private void btnHouseTen_Click(object sender, EventArgs e)
        {
            double numOfBaths = 0;
            double numOfPersons = 0;
            double householdIncome = 0;

            numOfBaths = Convert.ToDouble(txtNumOfBathrooms.Text);
            numOfPersons = Convert.ToDouble(txtNumOfPersons.Text);
            householdIncome = Convert.ToDouble(txtHouseholdIncome.Text);

            listCounter++;
            lbOutputList.Items.Add(listCounter + "        Baths: " + numOfBaths + "        Persons: " + numOfPersons + "           " + "Income: " + householdIncome);

            ProcessHouse();
        }

        public void ProcessHouse()
        {
            AverageBaths();
            //AveragePersons();
            //AverageIncome();
        }

        private double AverageBaths()
        {

        }

        //private double AveragePersons()
        //{

        //}

        //private double AverageIncome()
        //{

        //}
    }
}
