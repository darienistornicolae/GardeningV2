namespace GardeningV2
{
    partial class AddGarden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            gardenTab = new TabPage();
            addNewGardenButton = new Button();
            addNewGardenTextBox = new TextBox();
            label1 = new Label();
            plantTab = new TabPage();
            blossomStartTimePicker = new DateTimePicker();
            pruneEndTimePicker = new DateTimePicker();
            pruneStartPeriodTimePicker = new DateTimePicker();
            blossomEndTimerPeriod = new DateTimePicker();
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
            newGardenLabel = new Label();
            goToDashboardButton = new Button();
            tabControl1.SuspendLayout();
            gardenTab.SuspendLayout();
            plantTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(gardenTab);
            tabControl1.Controls.Add(plantTab);
            tabControl1.Location = new Point(12, 80);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(891, 388);
            tabControl1.TabIndex = 0;
            // 
            // gardenTab
            // 
            gardenTab.Controls.Add(addNewGardenButton);
            gardenTab.Controls.Add(addNewGardenTextBox);
            gardenTab.Controls.Add(label1);
            gardenTab.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gardenTab.Location = new Point(4, 25);
            gardenTab.Name = "gardenTab";
            gardenTab.Padding = new Padding(3);
            gardenTab.Size = new Size(883, 359);
            gardenTab.TabIndex = 0;
            gardenTab.Text = "Garden";
            gardenTab.UseVisualStyleBackColor = true;
            // 
            // addNewGardenButton
            // 
            addNewGardenButton.Location = new Point(308, 253);
            addNewGardenButton.Name = "addNewGardenButton";
            addNewGardenButton.Size = new Size(242, 65);
            addNewGardenButton.TabIndex = 2;
            addNewGardenButton.Text = "Add Garden";
            addNewGardenButton.UseVisualStyleBackColor = true;
            addNewGardenButton.Click += addNewGardenButton_Click_1;
            // 
            // addNewGardenTextBox
            // 
            addNewGardenTextBox.Location = new Point(308, 132);
            addNewGardenTextBox.Name = "addNewGardenTextBox";
            addNewGardenTextBox.Size = new Size(242, 31);
            addNewGardenTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 140);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 0;
            label1.Text = "Add the new garden:";
            // 
            // plantTab
            // 
            plantTab.Controls.Add(blossomStartTimePicker);
            plantTab.Controls.Add(pruneEndTimePicker);
            plantTab.Controls.Add(pruneStartPeriodTimePicker);
            plantTab.Controls.Add(blossomEndTimerPeriod);
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
            plantTab.Location = new Point(4, 24);
            plantTab.Name = "plantTab";
            plantTab.Padding = new Padding(3);
            plantTab.Size = new Size(883, 360);
            plantTab.TabIndex = 1;
            plantTab.Text = "Plant";
            plantTab.UseVisualStyleBackColor = true;
            // 
            // blossomStartTimePicker
            // 
            blossomStartTimePicker.Location = new Point(259, 288);
            blossomStartTimePicker.Name = "blossomStartTimePicker";
            blossomStartTimePicker.Size = new Size(296, 23);
            blossomStartTimePicker.TabIndex = 36;
            // 
            // pruneEndTimePicker
            // 
            pruneEndTimePicker.Location = new Point(213, 252);
            pruneEndTimePicker.Name = "pruneEndTimePicker";
            pruneEndTimePicker.Size = new Size(299, 23);
            pruneEndTimePicker.TabIndex = 35;
            // 
            // pruneStartPeriodTimePicker
            // 
            pruneStartPeriodTimePicker.Location = new Point(213, 219);
            pruneStartPeriodTimePicker.Name = "pruneStartPeriodTimePicker";
            pruneStartPeriodTimePicker.Size = new Size(299, 23);
            pruneStartPeriodTimePicker.TabIndex = 34;
            // 
            // blossomEndTimerPeriod
            // 
            blossomEndTimerPeriod.Location = new Point(259, 321);
            blossomEndTimerPeriod.Name = "blossomEndTimerPeriod";
            blossomEndTimerPeriod.Size = new Size(296, 23);
            blossomEndTimerPeriod.TabIndex = 33;
            // 
            // plantColorComboBox
            // 
            plantColorComboBox.FormattingEnabled = true;
            plantColorComboBox.Location = new Point(213, 158);
            plantColorComboBox.Name = "plantColorComboBox";
            plantColorComboBox.Size = new Size(100, 24);
            plantColorComboBox.TabIndex = 32;
            // 
            // plantTypeTextBox
            // 
            plantTypeTextBox.Location = new Point(213, 92);
            plantTypeTextBox.Name = "plantTypeTextBox";
            plantTypeTextBox.PlaceholderText = "Blush";
            plantTypeTextBox.Size = new Size(100, 23);
            plantTypeTextBox.TabIndex = 31;
            // 
            // plantNameTextBox
            // 
            plantNameTextBox.Location = new Point(121, 28);
            plantNameTextBox.Name = "plantNameTextBox";
            plantNameTextBox.PlaceholderText = "Palm Tree";
            plantNameTextBox.Size = new Size(100, 23);
            plantNameTextBox.TabIndex = 30;
            // 
            // getInfoButton
            // 
            getInfoButton.Location = new Point(669, 310);
            getInfoButton.Name = "getInfoButton";
            getInfoButton.Size = new Size(82, 46);
            getInfoButton.TabIndex = 29;
            getInfoButton.Text = "Info";
            getInfoButton.UseVisualStyleBackColor = true;
            // 
            // removePlantButton
            // 
            removePlantButton.Location = new Point(778, 310);
            removePlantButton.Name = "removePlantButton";
            removePlantButton.Size = new Size(82, 46);
            removePlantButton.TabIndex = 28;
            removePlantButton.Text = "Remove";
            removePlantButton.UseVisualStyleBackColor = true;
            // 
            // addPlantButton
            // 
            addPlantButton.Location = new Point(561, 310);
            addPlantButton.Name = "addPlantButton";
            addPlantButton.Size = new Size(82, 46);
            addPlantButton.TabIndex = 27;
            addPlantButton.Text = "Add";
            addPlantButton.UseVisualStyleBackColor = true;
            addPlantButton.Click += addPlantButton_Click;
            // 
            // plantsListBox
            // 
            plantsListBox.FormattingEnabled = true;
            plantsListBox.ItemHeight = 16;
            plantsListBox.Location = new Point(561, 15);
            plantsListBox.Name = "plantsListBox";
            plantsListBox.Size = new Size(299, 292);
            plantsListBox.TabIndex = 26;
            // 
            // plantName
            // 
            plantName.AutoSize = true;
            plantName.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantName.Location = new Point(22, 23);
            plantName.Name = "plantName";
            plantName.Size = new Size(93, 32);
            plantName.TabIndex = 25;
            plantName.Text = "Plant:";
            // 
            // blossomPeriod
            // 
            blossomPeriod.AutoSize = true;
            blossomPeriod.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            blossomPeriod.Location = new Point(6, 288);
            blossomPeriod.Name = "blossomPeriod";
            blossomPeriod.Size = new Size(231, 32);
            blossomPeriod.TabIndex = 24;
            blossomPeriod.Text = "Blossom Period:";
            // 
            // plantColor
            // 
            plantColor.AutoSize = true;
            plantColor.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantColor.Location = new Point(22, 152);
            plantColor.Name = "plantColor";
            plantColor.Size = new Size(173, 32);
            plantColor.TabIndex = 23;
            plantColor.Text = "Plant Color:";
            // 
            // prunePeriod
            // 
            prunePeriod.AutoSize = true;
            prunePeriod.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prunePeriod.Location = new Point(22, 214);
            prunePeriod.Name = "prunePeriod";
            prunePeriod.Size = new Size(187, 32);
            prunePeriod.TabIndex = 22;
            prunePeriod.Text = "PrunePeriod:";
            // 
            // plantType
            // 
            plantType.AutoSize = true;
            plantType.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantType.Location = new Point(22, 87);
            plantType.Name = "plantType";
            plantType.Size = new Size(166, 32);
            plantType.TabIndex = 21;
            plantType.Text = "Plant Type:";
            // 
            // newGardenLabel
            // 
            newGardenLabel.AutoSize = true;
            newGardenLabel.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            newGardenLabel.Location = new Point(388, 19);
            newGardenLabel.Name = "newGardenLabel";
            newGardenLabel.Size = new Size(113, 32);
            newGardenLabel.TabIndex = 1;
            newGardenLabel.Text = "Garden";
            // 
            // goToDashboardButton
            // 
            goToDashboardButton.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            goToDashboardButton.Location = new Point(655, 12);
            goToDashboardButton.Name = "goToDashboardButton";
            goToDashboardButton.Size = new Size(156, 44);
            goToDashboardButton.TabIndex = 2;
            goToDashboardButton.Text = "Dashboard";
            goToDashboardButton.UseVisualStyleBackColor = true;
            goToDashboardButton.Click += goToDashboardButton_Click;
            // 
            // AddGarden
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 480);
            Controls.Add(goToDashboardButton);
            Controls.Add(newGardenLabel);
            Controls.Add(tabControl1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddGarden";
            Text = "AddGarden";
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
        private TextBox addNewGardenTextBox;
        private Label label1;
        private TabPage plantTab;
        private Button addNewGardenButton;
        private DateTimePicker blossomStartTimePicker;
        private DateTimePicker pruneEndTimePicker;
        private DateTimePicker pruneStartPeriodTimePicker;
        private DateTimePicker blossomEndTimerPeriod;
        private ComboBox plantColorComboBox;
        private TextBox plantTypeTextBox;
        private TextBox plantNameTextBox;
        private Button getInfoButton;
        private Button removePlantButton;
        private Button addPlantButton;
        private ListBox plantsListBox;
        private Label plantName;
        private Label blossomPeriod;
        private Label plantColor;
        private Label prunePeriod;
        private Label plantType;
        private Label newGardenLabel;
        private Button goToDashboardButton;
    }
}