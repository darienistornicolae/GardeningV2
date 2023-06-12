namespace GardeningV2
{
    partial class AddPlant
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
            blossomStartTimePicker = new DateTimePicker();
            pruneEndTimePicker = new DateTimePicker();
            pruneStartPeriodTimePicker = new DateTimePicker();
            blossomEndTimerPeriod = new DateTimePicker();
            plantColorComboBox = new ComboBox();
            plantTypeTextBox = new TextBox();
            plantNameTextBox = new TextBox();
            addPlantButton = new Button();
            plantName = new Label();
            blossomPeriod = new Label();
            plantColor = new Label();
            prunePeriod = new Label();
            plantType = new Label();
            SuspendLayout();
            // 
            // blossomStartTimePicker
            // 
            blossomStartTimePicker.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            blossomStartTimePicker.Location = new Point(249, 324);
            blossomStartTimePicker.Name = "blossomStartTimePicker";
            blossomStartTimePicker.Size = new Size(325, 31);
            blossomStartTimePicker.TabIndex = 36;
            // 
            // pruneEndTimePicker
            // 
            pruneEndTimePicker.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pruneEndTimePicker.Location = new Point(603, 257);
            pruneEndTimePicker.Name = "pruneEndTimePicker";
            pruneEndTimePicker.Size = new Size(299, 31);
            pruneEndTimePicker.TabIndex = 35;
            // 
            // pruneStartPeriodTimePicker
            // 
            pruneStartPeriodTimePicker.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pruneStartPeriodTimePicker.Location = new Point(249, 256);
            pruneStartPeriodTimePicker.Name = "pruneStartPeriodTimePicker";
            pruneStartPeriodTimePicker.Size = new Size(325, 31);
            pruneStartPeriodTimePicker.TabIndex = 34;
            // 
            // blossomEndTimerPeriod
            // 
            blossomEndTimerPeriod.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            blossomEndTimerPeriod.Location = new Point(603, 326);
            blossomEndTimerPeriod.Name = "blossomEndTimerPeriod";
            blossomEndTimerPeriod.Size = new Size(296, 31);
            blossomEndTimerPeriod.TabIndex = 33;
            // 
            // plantColorComboBox
            // 
            plantColorComboBox.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantColorComboBox.FormattingEnabled = true;
            plantColorComboBox.Location = new Point(210, 186);
            plantColorComboBox.Name = "plantColorComboBox";
            plantColorComboBox.Size = new Size(132, 31);
            plantColorComboBox.TabIndex = 32;
            // 
            // plantTypeTextBox
            // 
            plantTypeTextBox.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantTypeTextBox.Location = new Point(210, 115);
            plantTypeTextBox.Name = "plantTypeTextBox";
            plantTypeTextBox.PlaceholderText = "Blush";
            plantTypeTextBox.Size = new Size(132, 31);
            plantTypeTextBox.TabIndex = 31;
            // 
            // plantNameTextBox
            // 
            plantNameTextBox.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantNameTextBox.Location = new Point(149, 42);
            plantNameTextBox.Name = "plantNameTextBox";
            plantNameTextBox.PlaceholderText = "Palm Tree";
            plantNameTextBox.Size = new Size(132, 31);
            plantNameTextBox.TabIndex = 30;
            // 
            // addPlantButton
            // 
            addPlantButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addPlantButton.Location = new Point(317, 399);
            addPlantButton.Name = "addPlantButton";
            addPlantButton.Size = new Size(314, 69);
            addPlantButton.TabIndex = 27;
            addPlantButton.Text = "Add";
            addPlantButton.UseVisualStyleBackColor = true;
            addPlantButton.Click += addPlantButton_Click;
            // 
            // plantName
            // 
            plantName.AutoSize = true;
            plantName.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantName.Location = new Point(38, 41);
            plantName.Name = "plantName";
            plantName.Size = new Size(93, 32);
            plantName.TabIndex = 25;
            plantName.Text = "Plant:";
            // 
            // blossomPeriod
            // 
            blossomPeriod.AutoSize = true;
            blossomPeriod.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            blossomPeriod.Location = new Point(12, 324);
            blossomPeriod.Name = "blossomPeriod";
            blossomPeriod.Size = new Size(231, 32);
            blossomPeriod.TabIndex = 24;
            blossomPeriod.Text = "Blossom Period:";
            // 
            // plantColor
            // 
            plantColor.AutoSize = true;
            plantColor.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantColor.Location = new Point(38, 185);
            plantColor.Name = "plantColor";
            plantColor.Size = new Size(173, 32);
            plantColor.TabIndex = 23;
            plantColor.Text = "Plant Color:";
            // 
            // prunePeriod
            // 
            prunePeriod.AutoSize = true;
            prunePeriod.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prunePeriod.Location = new Point(56, 255);
            prunePeriod.Name = "prunePeriod";
            prunePeriod.Size = new Size(187, 32);
            prunePeriod.TabIndex = 22;
            prunePeriod.Text = "PrunePeriod:";
            // 
            // plantType
            // 
            plantType.AutoSize = true;
            plantType.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plantType.Location = new Point(38, 114);
            plantType.Name = "plantType";
            plantType.Size = new Size(166, 32);
            plantType.TabIndex = 21;
            plantType.Text = "Plant Type:";
            // 
            // AddPlant
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 480);
            Controls.Add(blossomStartTimePicker);
            Controls.Add(pruneEndTimePicker);
            Controls.Add(pruneStartPeriodTimePicker);
            Controls.Add(blossomEndTimerPeriod);
            Controls.Add(plantColorComboBox);
            Controls.Add(plantTypeTextBox);
            Controls.Add(plantNameTextBox);
            Controls.Add(addPlantButton);
            Controls.Add(plantName);
            Controls.Add(blossomPeriod);
            Controls.Add(plantColor);
            Controls.Add(prunePeriod);
            Controls.Add(plantType);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddPlant";
            Text = "AddPlant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker blossomStartTimePicker;
        private DateTimePicker pruneEndTimePicker;
        private DateTimePicker pruneStartPeriodTimePicker;
        private DateTimePicker blossomEndTimerPeriod;
        private ComboBox plantColorComboBox;
        private TextBox plantTypeTextBox;
        private TextBox plantNameTextBox;
        private Button addPlantButton;
        private Label plantName;
        private Label blossomPeriod;
        private Label plantColor;
        private Label prunePeriod;
        private Label plantType;
    }
}