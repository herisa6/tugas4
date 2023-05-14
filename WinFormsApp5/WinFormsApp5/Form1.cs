namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        // set harga minuman dan tambahan
        const int espressoHarga = 10000;
        const int latteHarga = 15000;
        const int cappuccinoHarga = 12000;
        const int largeHarga = 3000;
        const int bubbleHarga = 3000;
        const int grassJellyHarga = 3500;
        const int nataDeCocoHarga = 2500;
        const int whippedCreamHarga = 1000;
        const int chocoChipHarga = 1500;
        const int oreoHarga = 2000;

        // inisialisasi total harga
        int totalHarga = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TambahHargaMinuman(int hargaMinuman)
        {
            totalHarga += hargaMinuman;
            totalHargaLabel.Text = "Total Harga: Rp " + totalHarga.ToString();
        }

        // method untuk menambahkan harga tambahan ke total harga
        private void TambahHargaTambahan(int hargaTambahan)
        {
            totalHarga += hargaTambahan;
            totalHargaLabel.Text = "Total Harga: Rp " + totalHarga.ToString();
        }


        private void espressoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (espressoRadioButton.Checked)
            {
                TambahHargaMinuman(espressoHarga);
            }
        }

        private void latteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (latteRadioButton.Checked)
            {
                TambahHargaMinuman(latteHarga);
            }
        }

        private void cappuccinoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cappuccinoRadioButton.Checked)
            {
                TambahHargaMinuman(cappuccinoHarga);
            }
        }

        private void sugarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sugarComboBox.SelectedIndex)
            {
                case 0: // 100%
                    // tidak perlu menambah harga
                    break;
                case 1: // 75%
                    TambahHargaTambahan(-1000); // kurangi 1000 karena diskon
                    break;
                case 2: // 50%
                    TambahHargaTambahan(-2000); // kurangi 2000 karena diskon
                    break;
                case 3: // 0%
                    TambahHargaTambahan(-3000); // kurangi 3000 karena diskon
                    break;
            }
        }

        private void iceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (iceComboBox.SelectedIndex)
            {
                case 0: // 100%
                    // tidak perlu menambah harga
                    break;
                case 1: // 75%
                    TambahHargaTambahan(-1000); // kurangi 1000 karena diskon
                    break;
                case 2: // 50%
                    TambahHargaTambahan(-2000); // kurangi 2000 karena diskon
                    break;
                case 3: // 0%
                    TambahHargaTambahan(-3000); // kurangi 3000 karena diskon
                    break;
            }
        }

        private void bubbleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bubbleCheckBox.Checked)
            {
                TambahHargaTambahan(bubbleHarga);
            }
            else
            {
                TambahHargaTambahan(-bubbleHarga);
            }
        }

        private void grassJellyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (grassJellyCheckBox.Checked)
            {
                TambahHargaTambahan(grassJellyHarga);
            }
            else
            {
                TambahHargaTambahan(-grassJellyHarga);
            }
        }

        private void nataDeCocoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (nataDeCocoCheckBox.Checked)
            {
                TambahHargaTambahan(nataDeCocoHarga);
            }
            else
            {
                TambahHargaTambahan(-nataDeCocoHarga);
            }
        }

        private void whippedCreamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (whippedCreamCheckBox.Checked)
            {
                TambahHargaTambahan(whippedCreamHarga);
            }
            else
            {
                TambahHargaTambahan(-whippedCreamHarga);
            }
        }

        private void chocoChipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chocoChipCheckBox.Checked)
            {
                TambahHargaTambahan(chocoChipHarga);
            }
            else
            {
                TambahHargaTambahan(-chocoChipHarga);
            }
        }

        private void oreoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oreoCheckBox.Checked)
            {
                TambahHargaTambahan(oreoHarga);
            }
            else
            {
                TambahHargaTambahan(-oreoHarga);
            }
        }

        private void pesanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima kasih telah memesan minuman di Cafe!\nTotal Harga: Rp " + totalHarga.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sizeComboBox.SelectedIndex)
            {
                case 0: // medium
                    // tidak perlu menambah harga
                    break;
                case 1: // large
                    TambahHargaTambahan(largeHarga);
                    break;

            }
        }
    }
}