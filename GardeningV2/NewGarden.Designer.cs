namespace GardeningV2
{
    partial class NewGarden
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
            tabControl1 = new TabControl();
            gardenTab = new TabPage();
            createGardenButton = new Button();
            gardenNameTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            label4 = new Label();
            gardenName = new Label();
            userName = new Label();
            plantTab = new TabPage();
            blossomPeriodCalendarButton = new Button();
            prunePeriodCalendarButton = new Button();
            plantColorComboBox = new ComboBox();
            plantTypeTextBox = new TextBox();
            plantNameTextBox = new TextBox();
            getInfoButton = new Button();
            removePlantButton = new Button();
            addPlantButton = new Button();
            plantsListBox = new ListBox();
            plantName = new Label();
            blossomPeriod = new Label();
            plantColor = new Label();
            prunePeriod = new Label();
            plantType = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            gardenTab.SuspendLayout();
            plantTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(gardenTab);
            tabControl1.Controls.Add(plantTab);
            tabControl1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(14, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(887, 402);
            tabControl1.TabIndex = 0;
            // 
            // gardenTab
            // 
            gardenTab.Controls.Add(createGardenButton);
            gardenTab.Controls.Add(gardenNameTextBox);
            gardenTab.Controls.Add(customerNameTextBox);
            gardenTab.Controls.Add(label4);
            gardenTab.Controls.Add(gardenName);
            gardenTab.Controls.Add(userName);
            gardenTab.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gardenTab.Location = new Point(4, 27);
            gardenTab.Name = "gardenTab";
            gardenTab.Padding = new Padding(3);
            gardenTab.Size = new Size(879, 371);
            gardenTab.TabIndex = 0;
            gardenTab.Text = "Garden";
            gardenTab.UseVisualStyleBackColor = true;
            // 
            // createGardenButton
            // 
            createGardenButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createGardenButton.Location = new Point(315, 263);
            createGardenButton.Name = "createGardenButton";
            createGardenButton.Size = new Size(264, 76);
            createGardenButton.TabIndex = 5;
            createGardenButton.Text = "Create Garden";
            createGardenButton.UseVisualStyleBackColor = true;
            createGardenButton.Click += createGardenButton_Click;
            // 
            // gardenNameTextBox
            // 
            gardenNameTextBox.Location = new Point(386, 162);
            gardenNameTextBox.Name = "gardenNameTextBox";
            gardenNameTextBox.Size = new Size(139, 27);
            gardenNameTextBox.TabIndex = 4;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(386, 73);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(139, 27);
            customerNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 228);
            label4.Name = "label4";
            label4.Size = new Size(0, 18);
            label4.TabIndex = 2;
            // 
            // gardenName
            // 
            gardenName.AutoSize = true;
            gardenName.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            gardenName.Location = new Point(51, 157);
            gardenName.Name = "gardenName";
            gardenName.Size = new Size(289, 32);
            gardenName.TabIndex = 1;
            gardenName.Text = "Input garden name:";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(85, 68);
            userName.Name = "userName";
            userName.Size = new Size(255, 32);
            userName.TabIndex = 0;
            userName.Text = "Input your name:";
            // 
            // plantTab
            // 
            plantTab.Controls.Add(blossomPeriodCalendarButton);
            plantTab.Controls.Add(prunePeriodCalendarButton);
            plantTab.Controls.Add(plantColorComboBox);
            plantTab.Controls.Add(plantTypeTextBox);
            plantTab.Controls.Add(plantNameTextBox);
            plantTab.Controls.Add(getInfoButton);
            plantTab.Controls.Add(removePlantButton);
            plantTab.Controls.Add(addPlantButton);
            plantTab.Controls.Add(plantsListBox);
            plantTab.Controls.Add(plantName);
            plantTab.Controls.Add(blossomPeriod);
            plantTab.Controls.Add(plantColor);
            plantTab.Controls.Add(prunePeriod);
            plantTab.Controls.Add(plantType);
            plantTab.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            plantTab.Location = new Point(4, 27);
            plantTab.Name = "plantTab";
            plantTab.Padding = new Padding(3);
            plantTab.Size = new Size(879, 371);
            plantTab.TabIndex = 1;
            plantTab.Text = "Plant";
            plantTab.UseVisualStyleBackColor = true;
            // 
            // blossomPeriodCalendarButton
            // 
            blossomPeriodCalendarButton.Location = new Point(284, 285);
            blossomPeriodCalendarButton.Name = "blossomPeriodCalendarButton";
            blossomPeriodCalendarButton.Size = new Size(88, 32);
            blossomPeriodCalendarButton.TabIndex = 15;
            blossomPeriodCalendarButton.Text = "Calendar";
            blossomPeriodCalendarButton.UseVisualStyleBackColor = true;
            blossomPeriodCalendarButton.Click += blossomPeriodCalendarButton_Click;
            // 
            // prunePeriodCalendarButton
            // 
            prunePeriodCalendarButton.Location = new Point(238, 222);
            prunePeriodCalendarButton.Name = "prunePeriodCalendarButton";
            prunePeriodCalendarButton.Size = new Size(88, 32);
            prunePeriodCalendarButton.TabIndex = 14;
            prunePeriodCalendarButton.Text = "Calendar";
            prunePeriodCalendarButton.UseVisualStyleBackColor = true;
            prunePeriodCalendarButton.Click += prunePeriodCalendarButton_Click;
            // 
            // plantColorComboBox
            // 
            plantColorComboBox.FormattingEnabled = true;
            plantColorComboBox.Location = new Point(226, 166);
            plantColorComboBox.Name = "plantColorComboBox";
            plantColorComboBox.Size = new Size(100, 26);
            plantColorComboBox.TabIndex = 13;
            // 
            // plantTypeTextBox
            // 
            plantTypeTextBox.Location = new Point(226, 100);
            plantTypeTextBox.Name = "plantTypeTextBox";
            plantTypeTextBox.PlaceholderText = "Blush";
            plantTypeTextBox.Size = new Size(100, 27);
            plantTypeTextBox.TabIndex = 12;
            // 
            // plantNameTextBox
            // 
            plantNameTextBox.Location = new Point(134, 36);
            plantNameTextBox.Name = "plantNameTextBox";
            plantNameTextBox.PlaceholderText = "Palm Tree";
            plantNameTextBox.Size = new Size(100, 27);
            plantNameTextBox.TabIndex = 11;
            // 
            // getInfoButton
            // 
            getInfoButton.Location = new Point(685, 322);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(82, 46);
            getInfoButton.TabIndex = 10;
            getInfoButton.Text = "Info";
            getInfoButton.UseVisualStyleBackColor = true;
            getInfoButton.Click += getInfoButton_Click;
            // 
            // removePlantButton
            // 
            removePlantButton.Location = new Point(791, 322);
            removePlantButton.Name = "removePlantButton";
            removePlantButton.Size = new Size(82, 46);
            removePlantButton.TabIndex = 9;
            removePlantButton.Text = "Remove";
            removePlantButton.UseVisualStyleBackColor = true;
            removePlantButton.Click += removePlantButton_Click;
            // 
            // addPlantButton
            // 
            addPlantButton.Location = new Point(574, 322);
            addPlantButton.Name = "addPlantButton";
            addPlantButton.Size = new Size(82, 46);
            addPlantButton.TabIndex = 8;
            addPlantButton.Text = "Add";
            addPlantButton.UseVisualStyleBackColor = true;
            addPlantButton.Click += addPlantButton_Click;
            // 
            // plantsListBox
            // 
            plantsListBox.FormattingEnabled = true;
            plantsListBox.ItemHeight = 18;
            plantsListBox.Location = new Point(574, 7);
            plantsListBox.Name = "plantsListBox";
            plantsListBox.Size = new Size(299, 310);
            plantsListBox.TabIndex = 7;
            // 
            // plantName
            // 
            plantName.AutoSize = true;
            plantName.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantName.Location = new Point(35, 31);
            plantName.Name = "plantName";
            plantName.Size = new Size(93, 32);
            plantName.TabIndex = 6;
            plantName.Text = "Plant:";
            // 
            // blossomPeriod
            // 
            blossomPeriod.AutoSize = true;
            blossomPeriod.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            blossomPeriod.Location = new Point(35, 285);
            blossomPeriod.Name = "blossomPeriod";
            blossomPeriod.Size = new Size(231, 32);
            blossomPeriod.TabIndex = 4;
            blossomPeriod.Text = "Blossom Period:";
            // 
            // plantColor
            // 
            plantColor.AutoSize = true;
            plantColor.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantColor.Location = new Point(35, 160);
            plantColor.Name = "plantColor";
            plantColor.Size = new Size(173, 32);
            plantColor.TabIndex = 3;
            plantColor.Text = "Plant Color:";
            // 
            // prunePeriod
            // 
            prunePeriod.AutoSize = true;
            prunePeriod.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prunePeriod.Location = new Point(35, 222);
            prunePeriod.Name = "prunePeriod";
            prunePeriod.Size = new Size(187, 32);
            prunePeriod.TabIndex = 2;
            prunePeriod.Text = "PrunePeriod:";
            // 
            // plantType
            // 
            plantType.AutoSize = true;
            plantType.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantType.Location = new Point(35, 95);
            plantType.Name = "plantType";
            plantType.Size = new Size(166, 32);
            plantType.TabIndex = 1;
            plantType.Text = "Plant Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(369, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 38);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // NewGarden
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 484);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "NewGarden";
            Text = "New Garden";
            tabControl1.ResumeLayout(false);
            gardenTab.ResumeLayout(false);
            gardenTab.PerformLayout();
            plantTab.ResumeLayout(false);
            plantTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage gardenTab;
        private Label label4;
        private Label gardenName;
        private Label userName;
        private TabPage plantTab;
        private Label plantName;
        private Label blossomPeriod;
        private Label plantColor;
        private Label prunePeriod;
        private Label plantType;
        private Label label1;
        private TextBox gardenNameTextBox;
        private TextBox customerNameTextBox;
        private ComboBox plantColorComboBox;
        private TextBox plantTypeTextBox;
        private TextBox plantNameTextBox;
        private Button getInfoButton;
        private Button removePlantButton;
        private Button addPlantButton;
        private ListBox plantsListBox;
        private Button blossomPeriodCalendarButton;
        private Button prunePeriodCalendarButton;
        private Button createGardenButton;
    }
}