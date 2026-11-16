namespace Zadanie5_github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } // super kod

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal totalVolume = numCapacity.Value * numCount.Value;
            decimal pureSubstance = totalVolume * numPercentage.Value / 100m;

            txtTotalVolume.Text = $"{totalVolume:0.0} ml";
            txtPureSubstance.Text = $"{pureSubstance:0.0} ml";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Miejsce na czyszczenie pól formularza
            MessageBox.Show("Temp | btnClear");
        }

        private void cmbTypicalVessels_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Miejsce na obsługę wyboru typowego naczynia z logiki
            MessageBox.Show("Temp | cmbTypicalVessels");
        }

        private void cmbTypicalSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Miejsce na obsługę wyboru typowego roztworu z logiki
            MessageBox.Show("Temp | cmbTypicalSolutions");
        }
    }
}