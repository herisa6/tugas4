namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            espressoRadioButton = new RadioButton();
            latteRadioButton = new RadioButton();
            cappuccinoRadioButton = new RadioButton();
            label1 = new Label();
            sugarComboBox = new ComboBox();
            iceComboBox = new ComboBox();
            bubbleCheckBox = new CheckBox();
            grassJellyCheckBox = new CheckBox();
            nataDeCocoCheckBox = new CheckBox();
            whippedCreamCheckBox = new CheckBox();
            chocoChipCheckBox = new CheckBox();
            oreoCheckBox = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            totalHargaLabel = new Label();
            sizeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // espressoRadioButton
            // 
            espressoRadioButton.AutoSize = true;
            espressoRadioButton.Location = new Point(113, 94);
            espressoRadioButton.Name = "espressoRadioButton";
            espressoRadioButton.Size = new Size(70, 19);
            espressoRadioButton.TabIndex = 0;
            espressoRadioButton.TabStop = true;
            espressoRadioButton.Text = "espresso";
            espressoRadioButton.UseVisualStyleBackColor = true;
            espressoRadioButton.CheckedChanged += espressoRadioButton_CheckedChanged;
            // 
            // latteRadioButton
            // 
            latteRadioButton.AutoSize = true;
            latteRadioButton.Location = new Point(113, 119);
            latteRadioButton.Name = "latteRadioButton";
            latteRadioButton.Size = new Size(48, 19);
            latteRadioButton.TabIndex = 1;
            latteRadioButton.TabStop = true;
            latteRadioButton.Text = "latte";
            latteRadioButton.UseVisualStyleBackColor = true;
            latteRadioButton.CheckedChanged += latteRadioButton_CheckedChanged;
            // 
            // cappuccinoRadioButton
            // 
            cappuccinoRadioButton.AutoSize = true;
            cappuccinoRadioButton.Location = new Point(113, 144);
            cappuccinoRadioButton.Name = "cappuccinoRadioButton";
            cappuccinoRadioButton.Size = new Size(87, 19);
            cappuccinoRadioButton.TabIndex = 2;
            cappuccinoRadioButton.TabStop = true;
            cappuccinoRadioButton.Text = "cappuccino";
            cappuccinoRadioButton.UseVisualStyleBackColor = true;
            cappuccinoRadioButton.CheckedChanged += cappuccinoRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 94);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Menu:";
            // 
            // sugarComboBox
            // 
            sugarComboBox.FormattingEnabled = true;
            sugarComboBox.Items.AddRange(new object[] { "100", "75", "50", "25", "0" });
            sugarComboBox.Location = new Point(317, 148);
            sugarComboBox.Name = "sugarComboBox";
            sugarComboBox.Size = new Size(121, 23);
            sugarComboBox.TabIndex = 7;
            sugarComboBox.Text = "Sugar Level";
            sugarComboBox.SelectedIndexChanged += sugarComboBox_SelectedIndexChanged;
            // 
            // iceComboBox
            // 
            iceComboBox.FormattingEnabled = true;
            iceComboBox.Items.AddRange(new object[] { "100", "75", "50", "25", "0" });
            iceComboBox.Location = new Point(317, 198);
            iceComboBox.Name = "iceComboBox";
            iceComboBox.Size = new Size(121, 23);
            iceComboBox.TabIndex = 8;
            iceComboBox.Text = "Ice Level";
            iceComboBox.SelectedIndexChanged += iceComboBox_SelectedIndexChanged;
            // 
            // bubbleCheckBox
            // 
            bubbleCheckBox.AutoSize = true;
            bubbleCheckBox.Location = new Point(620, 95);
            bubbleCheckBox.Name = "bubbleCheckBox";
            bubbleCheckBox.Size = new Size(109, 19);
            bubbleCheckBox.TabIndex = 9;
            bubbleCheckBox.Text = "Bubble += 3000";
            bubbleCheckBox.UseVisualStyleBackColor = true;
            bubbleCheckBox.CheckedChanged += bubbleCheckBox_CheckedChanged;
            // 
            // grassJellyCheckBox
            // 
            grassJellyCheckBox.AutoSize = true;
            grassJellyCheckBox.Location = new Point(620, 120);
            grassJellyCheckBox.Name = "grassJellyCheckBox";
            grassJellyCheckBox.Size = new Size(125, 19);
            grassJellyCheckBox.TabIndex = 10;
            grassJellyCheckBox.Text = "Grass Jelly += 3500";
            grassJellyCheckBox.UseVisualStyleBackColor = true;
            grassJellyCheckBox.CheckedChanged += grassJellyCheckBox_CheckedChanged;
            // 
            // nataDeCocoCheckBox
            // 
            nataDeCocoCheckBox.AutoSize = true;
            nataDeCocoCheckBox.Location = new Point(620, 148);
            nataDeCocoCheckBox.Name = "nataDeCocoCheckBox";
            nataDeCocoCheckBox.Size = new Size(142, 19);
            nataDeCocoCheckBox.TabIndex = 11;
            nataDeCocoCheckBox.Text = "Nata de coco += 2500";
            nataDeCocoCheckBox.UseVisualStyleBackColor = true;
            nataDeCocoCheckBox.CheckedChanged += nataDeCocoCheckBox_CheckedChanged;
            // 
            // whippedCreamCheckBox
            // 
            whippedCreamCheckBox.AutoSize = true;
            whippedCreamCheckBox.Location = new Point(620, 173);
            whippedCreamCheckBox.Name = "whippedCreamCheckBox";
            whippedCreamCheckBox.Size = new Size(156, 19);
            whippedCreamCheckBox.TabIndex = 12;
            whippedCreamCheckBox.Text = "Whipped cream += 1000";
            whippedCreamCheckBox.UseVisualStyleBackColor = true;
            whippedCreamCheckBox.CheckedChanged += whippedCreamCheckBox_CheckedChanged;
            // 
            // chocoChipCheckBox
            // 
            chocoChipCheckBox.AutoSize = true;
            chocoChipCheckBox.Location = new Point(620, 198);
            chocoChipCheckBox.Name = "chocoChipCheckBox";
            chocoChipCheckBox.Size = new Size(133, 19);
            chocoChipCheckBox.TabIndex = 13;
            chocoChipCheckBox.Text = "Choco chip += 1500";
            chocoChipCheckBox.UseVisualStyleBackColor = true;
            chocoChipCheckBox.CheckedChanged += chocoChipCheckBox_CheckedChanged;
            // 
            // oreoCheckBox
            // 
            oreoCheckBox.AutoSize = true;
            oreoCheckBox.Location = new Point(620, 223);
            oreoCheckBox.Name = "oreoCheckBox";
            oreoCheckBox.Size = new Size(98, 19);
            oreoCheckBox.TabIndex = 14;
            oreoCheckBox.Text = "Oreo += 2000";
            oreoCheckBox.UseVisualStyleBackColor = true;
            oreoCheckBox.CheckedChanged += oreoCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 91);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 15;
            label3.Text = "Topping:";
            // 
            // button1
            // 
            button1.Location = new Point(348, 343);
            button1.Name = "button1";
            button1.Size = new Size(90, 41);
            button1.TabIndex = 16;
            button1.Text = "Pesan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += pesanButton_Click;
            // 
            // totalHargaLabel
            // 
            totalHargaLabel.AutoSize = true;
            totalHargaLabel.Location = new Point(328, 294);
            totalHargaLabel.Name = "totalHargaLabel";
            totalHargaLabel.Size = new Size(70, 15);
            totalHargaLabel.TabIndex = 17;
            totalHargaLabel.Text = "Total Harga:";
            // 
            // sizeComboBox
            // 
            sizeComboBox.FormattingEnabled = true;
            sizeComboBox.Items.AddRange(new object[] { "Medium", "Large" });
            sizeComboBox.Location = new Point(317, 95);
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(121, 23);
            sizeComboBox.TabIndex = 18;
            sizeComboBox.Text = "Size";
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sizeComboBox);
            Controls.Add(totalHargaLabel);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(oreoCheckBox);
            Controls.Add(chocoChipCheckBox);
            Controls.Add(whippedCreamCheckBox);
            Controls.Add(nataDeCocoCheckBox);
            Controls.Add(grassJellyCheckBox);
            Controls.Add(bubbleCheckBox);
            Controls.Add(iceComboBox);
            Controls.Add(sugarComboBox);
            Controls.Add(label1);
            Controls.Add(cappuccinoRadioButton);
            Controls.Add(latteRadioButton);
            Controls.Add(espressoRadioButton);
            Name = "Form1";
            Text = "Cafe Poltek SSN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton espressoRadioButton;
        private RadioButton latteRadioButton;
        private RadioButton cappuccinoRadioButton;
        private Label label1;
        private ComboBox sugarComboBox;
        private ComboBox iceComboBox;
        private CheckBox bubbleCheckBox;
        private CheckBox grassJellyCheckBox;
        private CheckBox nataDeCocoCheckBox;
        private CheckBox whippedCreamCheckBox;
        private CheckBox chocoChipCheckBox;
        private CheckBox oreoCheckBox;
        private Label label3;
        private Button button1;
        private Label totalHargaLabel;
        private ComboBox sizeComboBox;
    }
}