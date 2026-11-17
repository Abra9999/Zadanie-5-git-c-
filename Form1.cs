namespace Zadanie5_github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTypicalVessels.SelectedIndex = 0;
            cmbTypicalSolutions.SelectedIndex = 0;
        } // super kod

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // pobieramy dane z formularza
            decimal capacity = numCapacity.Value;
            decimal percentage = numPercentage.Value;
            decimal count = numCount.Value;

            // pojemność nie może być zerem
            if (capacity <= 0)
            {
                MessageBox.Show("Podaj pojemność naczynia większą od zera.");
                return;
            }

            // liczymy
            decimal totalVolume = capacity * count;
            decimal pureSubstance = totalVolume * percentage / 100;

            // wyświetlamy wyniki
            txtTotalVolume.Text = totalVolume.ToString("0.0") + " ml";
            txtPureSubstance.Text = pureSubstance.ToString("0.0") + " ml";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbTypicalVessels.SelectedIndex = 0;
            cmbTypicalSolutions.SelectedIndex = 0;
            numCapacity.Value = 0;
            numPercentage.Value = 0;
            numCount.Value = 1;
            txtTotalVolume.Text = "0,0 ml";
            txtPureSubstance.Text = "0,0 ml";
        }

        private void cmbTypicalVessels_SelectedIndexChanged(object sender, EventArgs e)
        {
            // indeks 0 to własna pojemność, więc nic nie ustawiamy
            switch (cmbTypicalVessels.SelectedIndex)
            {
                case 1: numCapacity.Value = 50; break;    // kieliszek
                case 2: numCapacity.Value = 150; break;   // filiżanka
                case 3: numCapacity.Value = 250; break;   // szklanka
                case 4: numCapacity.Value = 330; break;   // kubek
                case 5: numCapacity.Value = 500; break;   // puszka / butelka
                case 6: numCapacity.Value = 1000; break;  // butelka
            }
        }

        private void cmbTypicalSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // indeks 0 to własne stężenie, więc nic nie ustawiamy
            switch (cmbTypicalSolutions.SelectedIndex)
            {
                case 1: numPercentage.Value = 0; break;     // woda
                case 2: numPercentage.Value = 0.9m; break;  // sól fizjologiczna
                case 3: numPercentage.Value = 5; break;     // piwo
                case 4: numPercentage.Value = 10; break;    // ocet
                case 5: numPercentage.Value = 12; break;    // wino
                case 6: numPercentage.Value = 40; break;    // wódka
                case 7: numPercentage.Value = 95; break;    // spirytus
            }
        }
    }
}