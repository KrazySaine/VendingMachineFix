using System.Security.Policy;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private bool myBool = false;
        private void pbZergling_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Two zerglings have been dispensed!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbFlashDrive_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Sorry, product is currently out of stock";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbGamerFuel_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Product has been vended!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbPeach_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Sorry customer, but peach is in another vending machine";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbRedPony_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "The red pony is .. .. freeeeeee ??? PRODUCT HAS BEEN SET FOR DELIVERY!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "I'm not for sale!  Make another selection!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbFungiFriends_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                // Couple Mushroom Art
                DisplayPopup(
                    "The Couple Mushrooms",
                    "Celebrate love and connection with this enchanting couple mushroom print. Perfect for those who believe in soulmates and fungi that grow together!\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbTravelingGuitarist_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                // Traveling Guitarist Mushroom Art
                DisplayPopup(
                    "The Traveling Guitarist Mushroom",
                    "Hit the road with the coolest mushroom in town! Whether it’s blues, rock, or a hint of jazz, this mushroom is strumming for your soul.\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbNurse_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                // Nurse Mushroom Art
                DisplayPopup(
                    "The Caring Nurse Mushroom",
                    "For the healers, the nurturers, and the ones who make the world better one bandage at a time! This nurse mushroom is for you!\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbMotorcycle_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                // Motorcycle Mushroom Art
                DisplayPopup(
                    "The Motorcycle Mushroom",
                    "Rev up your vibe with this bad-to-the-bone biker mushroom. Unique art for the wild souls who ride free and live boldly!\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        // Helper method for displaying pop-ups
        private void DisplayPopup(string title, string message)
        {
            DialogResult result = MessageBox.Show(
                $"{message}\n\nWould you like to visit the website now?",
                $"Unique Art for Unique Souls: {title}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            // Open the website if the user clicks 'Yes'
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.viberantzdesigns.com",
                    UseShellExecute = true
                });
            }
        }


        private void btnCard_Click(object sender, EventArgs e)
        {
            myBool = true;
            txtDisplay.Text = "Card Accepted, make a selection...";
            //bool to show card has been "swiped" or "inserted"
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

            //output message at beginning "welcome" and output messages when each picture
            // is clicked
        }

        private void btnVendOver_Click(object sender, EventArgs e)
        {
            myBool = false;
            Application.Exit();
            //end vending process, then close program
        }
    }
}
