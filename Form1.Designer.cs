namespace Zadanie5_github
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            gbInputs = new GroupBox();
            cmbTypicalVessels = new ComboBox();
            lblTypicalVessels = new Label();
            numCapacity = new NumericUpDown();
            lblCapacity = new Label();
            cmbTypicalSolutions = new ComboBox();
            lblTypicalSolutions = new Label();
            numPercentage = new NumericUpDown();
            lblPercentage = new Label();
            numCount = new NumericUpDown();
            lblCount = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            gbResults = new GroupBox();
            txtTotalVolume = new TextBox();
            lblTotalVolume = new Label();
            txtPureSubstance = new TextBox();
            lblPureSubstance = new Label();

            gbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            gbResults.SuspendLayout();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(56, 189, 248);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kalkulator Objętości Roztworów";

            // 
            // gbInputs
            // 
            gbInputs.Controls.Add(cmbTypicalVessels);
            gbInputs.Controls.Add(lblTypicalVessels);
            gbInputs.Controls.Add(numCapacity);
            gbInputs.Controls.Add(lblCapacity);
            gbInputs.Controls.Add(cmbTypicalSolutions);
            gbInputs.Controls.Add(lblTypicalSolutions);
            gbInputs.Controls.Add(numPercentage);
            gbInputs.Controls.Add(lblPercentage);
            gbInputs.Controls.Add(numCount);
            gbInputs.Controls.Add(lblCount);
            gbInputs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbInputs.ForeColor = Color.FromArgb(226, 232, 240);
            gbInputs.Location = new Point(25, 65);
            gbInputs.Name = "gbInputs";
            gbInputs.Size = new Size(440, 290);
            gbInputs.TabIndex = 1;
            gbInputs.TabStop = false;
            gbInputs.Text = "Dane wejściowe";

            // 
            // lblTypicalVessels
            // 
            lblTypicalVessels.AutoSize = true;
            lblTypicalVessels.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblTypicalVessels.Location = new Point(20, 35);
            lblTypicalVessels.Name = "lblTypicalVessels";
            lblTypicalVessels.Size = new Size(165, 17);
            lblTypicalVessels.TabIndex = 0;
            lblTypicalVessels.Text = "Typowe naczynie (opcja):";

            // 
            // cmbTypicalVessels
            // 
            cmbTypicalVessels.BackColor = Color.FromArgb(51, 65, 85);
            cmbTypicalVessels.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypicalVessels.FlatStyle = FlatStyle.Flat;
            cmbTypicalVessels.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            cmbTypicalVessels.ForeColor = Color.White;
            cmbTypicalVessels.FormattingEnabled = true;
            cmbTypicalVessels.Items.AddRange(new object[] {
            "-- Własna pojemność --",
            "Kieliszek (50 ml)",
            "Filiżanka (150 ml)",
            "Szklanka (250 ml)",
            "Kubek (330 ml)",
            "Puszka / Butelka (500 ml)",
            "Butelka (1000 ml)"
            });
            cmbTypicalVessels.Location = new Point(210, 32);
            cmbTypicalVessels.Name = "cmbTypicalVessels";
            cmbTypicalVessels.Size = new Size(205, 23);
            cmbTypicalVessels.TabIndex = 1;
            cmbTypicalVessels.SelectedIndexChanged += cmbTypicalVessels_SelectedIndexChanged;

            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblCapacity.Location = new Point(20, 80);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(161, 17);
            lblCapacity.TabIndex = 2;
            lblCapacity.Text = "Pojemność naczynia [ml]:";

            // 
            // numCapacity
            // 
            numCapacity.BackColor = Color.FromArgb(51, 65, 85);
            numCapacity.BorderStyle = BorderStyle.FixedSingle;
            numCapacity.DecimalPlaces = 1;
            numCapacity.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            numCapacity.ForeColor = Color.White;
            numCapacity.Location = new Point(210, 78);
            numCapacity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(205, 24);
            numCapacity.TabIndex = 3;

            // 
            // lblTypicalSolutions
            // 
            lblTypicalSolutions.AutoSize = true;
            lblTypicalSolutions.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblTypicalSolutions.Location = new Point(20, 130);
            lblTypicalSolutions.Name = "lblTypicalSolutions";
            lblTypicalSolutions.Size = new Size(163, 17);
            lblTypicalSolutions.TabIndex = 4;
            lblTypicalSolutions.Text = "Typowy roztwór (opcja):";

            // 
            // cmbTypicalSolutions
            // 
            cmbTypicalSolutions.BackColor = Color.FromArgb(51, 65, 85);
            cmbTypicalSolutions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypicalSolutions.FlatStyle = FlatStyle.Flat;
            cmbTypicalSolutions.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            cmbTypicalSolutions.ForeColor = Color.White;
            cmbTypicalSolutions.FormattingEnabled = true;
            cmbTypicalSolutions.Items.AddRange(new object[] {
            "-- Własne stężenie --",
            "Woda (0%)",
            "Sól fizjologiczna (0,9%)",
            "Piwo jasne (5%)",
            "Ocet spirytusowy (10%)",
            "Wino wytrawne (12%)",
            "Wódka (40%)",
            "Spirytus rektyfikowany (95%)"
            });
            cmbTypicalSolutions.Location = new Point(210, 127);
            cmbTypicalSolutions.Name = "cmbTypicalSolutions";
            cmbTypicalSolutions.Size = new Size(205, 23);
            cmbTypicalSolutions.TabIndex = 5;
            cmbTypicalSolutions.SelectedIndexChanged += cmbTypicalSolutions_SelectedIndexChanged;

            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblPercentage.Location = new Point(20, 175);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(173, 17);
            lblPercentage.TabIndex = 6;
            lblPercentage.Text = "Zawartość substancji [%]:";

            // 
            // numPercentage
            // 
            numPercentage.BackColor = Color.FromArgb(51, 65, 85);
            numPercentage.BorderStyle = BorderStyle.FixedSingle;
            numPercentage.DecimalPlaces = 1;
            numPercentage.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            numPercentage.ForeColor = Color.White;
            numPercentage.Location = new Point(210, 173);
            numPercentage.Name = "numPercentage";
            numPercentage.Size = new Size(205, 24);
            numPercentage.TabIndex = 7;

            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblCount.Location = new Point(20, 225);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(141, 17);
            lblCount.TabIndex = 8;
            lblCount.Text = "Liczba sztuk naczyń:";

            // 
            // numCount
            // 
            numCount.BackColor = Color.FromArgb(51, 65, 85);
            numCount.BorderStyle = BorderStyle.FixedSingle;
            numCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            numCount.ForeColor = Color.White;
            numCount.Location = new Point(210, 223);
            numCount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(205, 24);
            numCount.TabIndex = 9;
            numCount.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(14, 165, 233);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(25, 375);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(280, 42);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "OBLICZ";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;

            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(71, 85, 105);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(320, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 42);
            btnClear.TabIndex = 3;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // gbResults
            // 
            gbResults.Controls.Add(txtTotalVolume);
            gbResults.Controls.Add(lblTotalVolume);
            gbResults.Controls.Add(txtPureSubstance);
            gbResults.Controls.Add(lblPureSubstance);
            gbResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbResults.ForeColor = Color.FromArgb(56, 189, 248);
            gbResults.Location = new Point(490, 65);
            gbResults.Name = "gbResults";
            gbResults.Size = new Size(285, 290);
            gbResults.TabIndex = 4;
            gbResults.TabStop = false;
            gbResults.Text = "Wyniki obliczeń";

            // 
            // lblTotalVolume
            // 
            lblTotalVolume.AutoSize = true;
            lblTotalVolume.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblTotalVolume.ForeColor = Color.FromArgb(226, 232, 240);
            lblTotalVolume.Location = new Point(20, 45);
            lblTotalVolume.Name = "lblTotalVolume";
            lblTotalVolume.Size = new Size(173, 17);
            lblTotalVolume.TabIndex = 0;
            lblTotalVolume.Text = "Łączna objętość płynu [ml]:";

            // 
            // txtTotalVolume
            // 
            txtTotalVolume.BackColor = Color.FromArgb(15, 23, 42);
            txtTotalVolume.BorderStyle = BorderStyle.FixedSingle;
            txtTotalVolume.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtTotalVolume.ForeColor = Color.FromArgb(52, 211, 153);
            txtTotalVolume.Location = new Point(20, 70);
            txtTotalVolume.Name = "txtTotalVolume";
            txtTotalVolume.ReadOnly = true;
            txtTotalVolume.Size = new Size(245, 32);
            txtTotalVolume.TabIndex = 1;
            txtTotalVolume.Text = "0,0 ml";
            txtTotalVolume.TextAlign = HorizontalAlignment.Right;

            // 
            // lblPureSubstance
            // 
            lblPureSubstance.AutoSize = true;
            lblPureSubstance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblPureSubstance.ForeColor = Color.FromArgb(226, 232, 240);
            lblPureSubstance.Location = new Point(20, 145);
            lblPureSubstance.Name = "lblPureSubstance";
            lblPureSubstance.Size = new Size(198, 17);
            lblPureSubstance.TabIndex = 2;
            lblPureSubstance.Text = "Objętość czystej substancji [ml]:";

            // 
            // txtPureSubstance
            // 
            txtPureSubstance.BackColor = Color.FromArgb(15, 23, 42);
            txtPureSubstance.BorderStyle = BorderStyle.FixedSingle;
            txtPureSubstance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtPureSubstance.ForeColor = Color.FromArgb(251, 191, 36);
            txtPureSubstance.Location = new Point(20, 170);
            txtPureSubstance.Name = "txtPureSubstance";
            txtPureSubstance.ReadOnly = true;
            txtPureSubstance.Size = new Size(245, 32);
            txtPureSubstance.TabIndex = 3;
            txtPureSubstance.Text = "0,0 ml";
            txtPureSubstance.TextAlign = HorizontalAlignment.Right;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(800, 445);
            Controls.Add(gbResults);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(gbInputs);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zadanie 5 - Kalkulator Roztworów";
            gbInputs.ResumeLayout(false);
            gbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            gbResults.ResumeLayout(false);
            gbResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gbInputs;
        private ComboBox cmbTypicalVessels;
        private Label lblTypicalVessels;
        private NumericUpDown numCapacity;
        private Label lblCapacity;
        private ComboBox cmbTypicalSolutions;
        private Label lblTypicalSolutions;
        private NumericUpDown numPercentage;
        private Label lblPercentage;
        private NumericUpDown numCount;
        private Label lblCount;
        private Button btnCalculate;
        private Button btnClear;
        private GroupBox gbResults;
        private TextBox txtTotalVolume;
        private Label lblTotalVolume;
        private TextBox txtPureSubstance;
        private Label lblPureSubstance;
    }
}