using GroceryList.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryList
{
    public partial class MainForm : Form
    {
        IAppDao Dao;
        #region Constructors 
        public MainForm()
        {
            InitializeComponent();
        }

        static MainForm()
        {

        }
        #endregion

        #region Event Handler
        private void MainForm_Load(object sender, EventArgs e)
        {

            Initialize();
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
           var selection =  MessageBox.Show("Do you want to exit?", "Exit GroceryLsit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (selection.ToString() == "Yes")
            {
                this.Close();
            }
            
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            //TODO - at the end of all the code above 
            Initialize();
        }
        #endregion

        #region Worker Methods
        private void Initialize()
        {
            ItemName.Text = "Enter Item ";
            ItemPrice.Text = "0.00";
            ItemQuantity.Text = "0";

            checkTax.Checked = false;   // boolean value 

        }


        #endregion

        private void btn1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
