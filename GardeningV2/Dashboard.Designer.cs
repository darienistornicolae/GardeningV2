namespace GardeningV2
{
    partial class Dashboard
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
            gardenNameLabel = new Label();
            existingGardensComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            BlossomPeriodLabel = new Label();
            prunePeriodLabel = new Label();
            plantColorLabel = new Label();
            plantTypeLabel = new Label();
            plantNameLabel = new Label();
            showInfoButton = new Button();
            removePlantButton = new Button();
            addPlantButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            plantsListTextBox = new ListBox();
            newGardenButton = new Button();
            removeGardenButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gardenNameLabel
            // 
            gardenNameLabel.AutoSize = true;
            gardenNameLabel.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            gardenNameLabel.Location = new Point(357, 48);
            gardenNameLabel.Name = "gardenNameLabel";
            gardenNameLabel.Size = new Size(113, 38);
            gardenNameLabel.TabIndex = 0;
            gardenNameLabel.Text = "label1";
            // 
            // existingGardensComboBox
            // 
            existingGardensComboBox.FormattingEnabled = true;
            existingGardensComboBox.Location = new Point(631, 9);
            existingGardensComboBox.Name = "existingGardensComboBox";
            existingGardensComboBox.Size = new Size(121, 26);
            existingGardensComboBox.TabIndex = 1;
            existingGardensComboBox.SelectedIndexChanged += existingGardenComboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BlossomPeriodLabel);
            groupBox1.Controls.Add(prunePeriodLabel);
            groupBox1.Controls.Add(plantColorLabel);
            groupBox1.Controls.Add(plantTypeLabel);
            groupBox1.Controls.Add(plantNameLabel);
            groupBox1.Controls.Add(showInfoButton);
            groupBox1.Controls.Add(removePlantButton);
            groupBox1.Controls.Add(addPlantButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(plantsListTextBox);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1005, 439);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "MyGarden";
            // 
            // BlossomPeriodLabel
            // 
            BlossomPeriodLabel.AutoSize = true;
            BlossomPeriodLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BlossomPeriodLabel.Location = new Point(226, 373);
            BlossomPeriodLabel.Name = "BlossomPeriodLabel";
            BlossomPeriodLabel.Size = new Size(80, 23);
            BlossomPeriodLabel.TabIndex = 13;
            BlossomPeriodLabel.Text = "label11";
            // 
            // prunePeriodLabel
            // 
            prunePeriodLabel.AutoSize = true;
            prunePeriodLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prunePeriodLabel.Location = new Point(186, 282);
            prunePeriodLabel.Name = "prunePeriodLabel";
            prunePeriodLabel.Size = new Size(80, 23);
            prunePeriodLabel.TabIndex = 12;
            prunePeriodLabel.Text = "label10";
            // 
            // plantColorLabel
            // 
            plantColorLabel.AutoSize = true;
            plantColorLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantColorLabel.Location = new Point(128, 203);
            plantColorLabel.Name = "plantColorLabel";
            plantColorLabel.Size = new Size(46, 23);
            plantColorLabel.TabIndex = 11;
            plantColorLabel.Text = "Red";
            // 
            // plantTypeLabel
            // 
            plantTypeLabel.AutoSize = true;
            plantTypeLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantTypeLabel.Location = new Point(186, 130);
            plantTypeLabel.Name = "plantTypeLabel";
            plantTypeLabel.Size = new Size(63, 23);
            plantTypeLabel.TabIndex = 10;
            plantTypeLabel.Text = "Blush";
            // 
            // plantNameLabel
            // 
            plantNameLabel.AutoSize = true;
            plantNameLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantNameLabel.Location = new Point(128, 56);
            plantNameLabel.Name = "plantNameLabel";
            plantNameLabel.Size = new Size(56, 23);
            plantNameLabel.TabIndex = 9;
            plantNameLabel.Text = "Rose";
            // 
            // showInfoButton
            // 
            showInfoButton.Location = new Point(808, 389);
            showInfoButton.Name = "showInfoButton";
            showInfoButton.Size = new Size(94, 41);
            showInfoButton.TabIndex = 8;
            showInfoButton.Text = "Info";
            showInfoButton.UseVisualStyleBackColor = true;
            showInfoButton.Click += showInfoButton_Click;
            // 
            // removePlantButton
            // 
            removePlantButton.Location = new Point(908, 389);
            removePlantButton.Name = "removePlantButton";
            removePlantButton.Size = new Size(91, 41);
            removePlantButton.TabIndex = 7;
            removePlantButton.Text = "Remove";
            removePlantButton.UseVisualStyleBackColor = true;
            removePlantButton.Click += removePlantButton_Click;
            // 
            // addPlantButton
            // 
            addPlantButton.Location = new Point(727, 389);
            addPlantButton.Name = "addPlantButton";
            addPlantButton.Size = new Size(75, 41);
            addPlantButton.TabIndex = 6;
            addPlantButton.Text = "Add";
            addPlantButton.UseVisualStyleBackColor = true;
            addPlantButton.Click += addPlantButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 367);
            label6.Name = "label6";
            label6.Size = new Size(183, 25);
            label6.TabIndex = 5;
            label6.Text = "Blossom Period:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 280);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 4;
            label5.Text = "PrunePeriod:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 197);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 123);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 2;
            label3.Text = "Plant type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 54);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Plant:";
            // 
            // plantsListTextBox
            // 
            plantsListTextBox.FormattingEnabled = true;
            plantsListTextBox.ItemHeight = 18;
            plantsListTextBox.Location = new Point(727, 19);
            plantsListTextBox.Name = "plantsListTextBox";
            plantsListTextBox.Size = new Size(272, 364);
            plantsListTextBox.TabIndex = 0;
            // 
            // newGardenButton
            // 
            newGardenButton.Location = new Point(777, 9);
            newGardenButton.Name = "newGardenButton";
            newGardenButton.Size = new Size(112, 49);
            newGardenButton.TabIndex = 3;
            newGardenButton.Text = "NewGarden";
            newGardenButton.UseVisualStyleBackColor = true;
            newGardenButton.Click += newGardenButton_Click;
            // 
            // removeGardenButton
            // 
            removeGardenButton.Location = new Point(895, 9);
            removeGardenButton.Name = "removeGardenButton";
            removeGardenButton.Size = new Size(101, 49);
            removeGardenButton.TabIndex = 4;
            removeGardenButton.Text = "Remove";
            removeGardenButton.UseVisualStyleBackColor = true;
            removeGardenButton.Click += removeGardenButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(removeGardenButton);
            Controls.Add(newGardenButton);
            Controls.Add(groupBox1);
            Controls.Add(existingGardensComboBox);
            Controls.Add(gardenNameLabel);
            Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gardenNameLabel;
        private ComboBox existingGardensComboBox;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox plantsListTextBox;
        private Button removePlantButton;
        private Button addPlantButton;
        private Label label6;
        private Button showInfoButton;
        private Button newGardenButton;
        private Button removeGardenButton;
        private Label plantTypeLabel;
        private Label plantNameLabel;
        private Label BlossomPeriodLabel;
        private Label prunePeriodLabel;
        private Label plantColorLabel;
    }
}