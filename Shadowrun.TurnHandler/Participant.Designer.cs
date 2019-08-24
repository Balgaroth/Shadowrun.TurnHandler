namespace Shadowrun.TurnHandler
{
    partial class Participant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DefActCounterLabel = new System.Windows.Forms.Label();
            this.InitiativeLabel = new System.Windows.Forms.Label();
            this.PhysMonLabel = new System.Windows.Forms.Label();
            this.PhysicalDamageLabel = new System.Windows.Forms.Label();
            this.StunMonitorLabel = new System.Windows.Forms.Label();
            this.StunDamageLabel = new System.Windows.Forms.Label();
            this.PainThresholdLabel = new System.Windows.Forms.Label();
            this.InitiativeValue = new System.Windows.Forms.NumericUpDown();
            this.PhysicalDamageValue = new System.Windows.Forms.NumericUpDown();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhysMonValue = new System.Windows.Forms.NumericUpDown();
            this.StunMonValue = new System.Windows.Forms.NumericUpDown();
            this.StunDamageValue = new System.Windows.Forms.NumericUpDown();
            this.PainThresholdValue = new System.Windows.Forms.NumericUpDown();
            this.DefActCounterValue = new System.Windows.Forms.NumericUpDown();
            this.AccruedRecoilLabel = new System.Windows.Forms.Label();
            this.AccruedRecoilValue = new System.Windows.Forms.NumericUpDown();
            this.ModifierLabel = new System.Windows.Forms.Label();
            this.ActionPassCheckBox = new System.Windows.Forms.CheckBox();
            this.ModifierValueLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InitDiceLabel = new System.Windows.Forms.Label();
            this.InitDiceValue = new System.Windows.Forms.NumericUpDown();
            this.InitPlusLabel = new System.Windows.Forms.Label();
            this.InitPlusValue = new System.Windows.Forms.NumericUpDown();
            this.PlayerAsset = new System.Windows.Forms.CheckBox();
            this.SaveToDb = new System.Windows.Forms.Button();
            this.GetFromDbButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InitiativeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalDamageValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysMonValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunMonValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunDamageValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PainThresholdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefActCounterValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccruedRecoilValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitDiceValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitPlusValue)).BeginInit();
            this.SuspendLayout();
            // 
            // DefActCounterLabel
            // 
            this.DefActCounterLabel.AutoSize = true;
            this.DefActCounterLabel.Location = new System.Drawing.Point(178, 50);
            this.DefActCounterLabel.Name = "DefActCounterLabel";
            this.DefActCounterLabel.Size = new System.Drawing.Size(190, 20);
            this.DefActCounterLabel.TabIndex = 2;
            this.DefActCounterLabel.Text = "Defensive Action Counter";
            // 
            // InitiativeLabel
            // 
            this.InitiativeLabel.AutoSize = true;
            this.InitiativeLabel.Location = new System.Drawing.Point(329, 4);
            this.InitiativeLabel.Name = "InitiativeLabel";
            this.InitiativeLabel.Size = new System.Drawing.Size(67, 20);
            this.InitiativeLabel.TabIndex = 4;
            this.InitiativeLabel.Text = "Initiative";
            // 
            // PhysMonLabel
            // 
            this.PhysMonLabel.AutoSize = true;
            this.PhysMonLabel.Location = new System.Drawing.Point(789, 8);
            this.PhysMonLabel.Name = "PhysMonLabel";
            this.PhysMonLabel.Size = new System.Drawing.Size(123, 20);
            this.PhysMonLabel.TabIndex = 6;
            this.PhysMonLabel.Text = "Physical Monitor";
            // 
            // PhysicalDamageLabel
            // 
            this.PhysicalDamageLabel.AutoSize = true;
            this.PhysicalDamageLabel.Location = new System.Drawing.Point(1004, 8);
            this.PhysicalDamageLabel.Name = "PhysicalDamageLabel";
            this.PhysicalDamageLabel.Size = new System.Drawing.Size(131, 20);
            this.PhysicalDamageLabel.TabIndex = 9;
            this.PhysicalDamageLabel.Text = "Physical Damage";
            // 
            // StunMonitorLabel
            // 
            this.StunMonitorLabel.AutoSize = true;
            this.StunMonitorLabel.Location = new System.Drawing.Point(1220, 10);
            this.StunMonitorLabel.Name = "StunMonitorLabel";
            this.StunMonitorLabel.Size = new System.Drawing.Size(100, 20);
            this.StunMonitorLabel.TabIndex = 10;
            this.StunMonitorLabel.Text = "Stun Monitor";
            // 
            // StunDamageLabel
            // 
            this.StunDamageLabel.AutoSize = true;
            this.StunDamageLabel.Location = new System.Drawing.Point(1398, 10);
            this.StunDamageLabel.Name = "StunDamageLabel";
            this.StunDamageLabel.Size = new System.Drawing.Size(108, 20);
            this.StunDamageLabel.TabIndex = 12;
            this.StunDamageLabel.Text = "Stun Damage";
            // 
            // PainThresholdLabel
            // 
            this.PainThresholdLabel.AutoSize = true;
            this.PainThresholdLabel.Location = new System.Drawing.Point(1592, 10);
            this.PainThresholdLabel.Name = "PainThresholdLabel";
            this.PainThresholdLabel.Size = new System.Drawing.Size(114, 20);
            this.PainThresholdLabel.TabIndex = 13;
            this.PainThresholdLabel.Text = "Pain Threshold";
            // 
            // InitiativeValue
            // 
            this.InitiativeValue.Location = new System.Drawing.Point(441, 5);
            this.InitiativeValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.InitiativeValue.Name = "InitiativeValue";
            this.InitiativeValue.Size = new System.Drawing.Size(72, 26);
            this.InitiativeValue.TabIndex = 14;
            this.InitiativeValue.ValueChanged += new System.EventHandler(this.InitiativeValueChanged);
            // 
            // PhysicalDamageValue
            // 
            this.PhysicalDamageValue.Location = new System.Drawing.Point(1140, 6);
            this.PhysicalDamageValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.PhysicalDamageValue.Name = "PhysicalDamageValue";
            this.PhysicalDamageValue.Size = new System.Drawing.Size(74, 26);
            this.PhysicalDamageValue.TabIndex = 16;
            this.PhysicalDamageValue.ValueChanged += new System.EventHandler(this.PhysicalDamageChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(128, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(188, 26);
            this.NameTextBox.TabIndex = 17;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameChanged);
            // 
            // PhysMonValue
            // 
            this.PhysMonValue.Location = new System.Drawing.Point(918, 6);
            this.PhysMonValue.Name = "PhysMonValue";
            this.PhysMonValue.Size = new System.Drawing.Size(80, 26);
            this.PhysMonValue.TabIndex = 18;
            this.PhysMonValue.ValueChanged += new System.EventHandler(this.PhysicalMonitorChanged);
            // 
            // StunMonValue
            // 
            this.StunMonValue.Location = new System.Drawing.Point(1324, 8);
            this.StunMonValue.Name = "StunMonValue";
            this.StunMonValue.Size = new System.Drawing.Size(68, 26);
            this.StunMonValue.TabIndex = 19;
            this.StunMonValue.ValueChanged += new System.EventHandler(this.StunMonitorChanged);
            // 
            // StunDamageValue
            // 
            this.StunDamageValue.Location = new System.Drawing.Point(1512, 8);
            this.StunDamageValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.StunDamageValue.Name = "StunDamageValue";
            this.StunDamageValue.Size = new System.Drawing.Size(74, 26);
            this.StunDamageValue.TabIndex = 20;
            this.StunDamageValue.ValueChanged += new System.EventHandler(this.StunDamageChanged);
            // 
            // PainThresholdValue
            // 
            this.PainThresholdValue.Location = new System.Drawing.Point(1712, 8);
            this.PainThresholdValue.Name = "PainThresholdValue";
            this.PainThresholdValue.Size = new System.Drawing.Size(69, 26);
            this.PainThresholdValue.TabIndex = 21;
            this.PainThresholdValue.ValueChanged += new System.EventHandler(this.PainThresholdChanged);
            // 
            // DefActCounterValue
            // 
            this.DefActCounterValue.Location = new System.Drawing.Point(375, 48);
            this.DefActCounterValue.Name = "DefActCounterValue";
            this.DefActCounterValue.Size = new System.Drawing.Size(74, 26);
            this.DefActCounterValue.TabIndex = 22;
            this.DefActCounterValue.ValueChanged += new System.EventHandler(this.DefensiveActionsChanged);
            // 
            // AccruedRecoilLabel
            // 
            this.AccruedRecoilLabel.AutoSize = true;
            this.AccruedRecoilLabel.Location = new System.Drawing.Point(580, 50);
            this.AccruedRecoilLabel.Name = "AccruedRecoilLabel";
            this.AccruedRecoilLabel.Size = new System.Drawing.Size(116, 20);
            this.AccruedRecoilLabel.TabIndex = 23;
            this.AccruedRecoilLabel.Text = "Accrued Recoil";
            // 
            // AccruedRecoilValue
            // 
            this.AccruedRecoilValue.Location = new System.Drawing.Point(704, 48);
            this.AccruedRecoilValue.Name = "AccruedRecoilValue";
            this.AccruedRecoilValue.Size = new System.Drawing.Size(80, 26);
            this.AccruedRecoilValue.TabIndex = 24;
            this.AccruedRecoilValue.ValueChanged += new System.EventHandler(this.AccruedRecoilChanged);
            // 
            // ModifierLabel
            // 
            this.ModifierLabel.AutoSize = true;
            this.ModifierLabel.Location = new System.Drawing.Point(1786, 10);
            this.ModifierLabel.Name = "ModifierLabel";
            this.ModifierLabel.Size = new System.Drawing.Size(114, 20);
            this.ModifierLabel.TabIndex = 25;
            this.ModifierLabel.Text = "Action Modifier";
            // 
            // ActionPassCheckBox
            // 
            this.ActionPassCheckBox.AutoSize = true;
            this.ActionPassCheckBox.Location = new System.Drawing.Point(3, 3);
            this.ActionPassCheckBox.Name = "ActionPassCheckBox";
            this.ActionPassCheckBox.Size = new System.Drawing.Size(119, 24);
            this.ActionPassCheckBox.TabIndex = 26;
            this.ActionPassCheckBox.Text = "Action Pass";
            this.ActionPassCheckBox.UseVisualStyleBackColor = true;
            this.ActionPassCheckBox.Click += new System.EventHandler(this.ActionPassClicked);
            // 
            // ModifierValueLabel
            // 
            this.ModifierValueLabel.AutoSize = true;
            this.ModifierValueLabel.Location = new System.Drawing.Point(1906, 10);
            this.ModifierValueLabel.Name = "ModifierValueLabel";
            this.ModifierValueLabel.Size = new System.Drawing.Size(40, 20);
            this.ModifierValueLabel.TabIndex = 27;
            this.ModifierValueLabel.Text = "Mod";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(1551, 48);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(140, 38);
            this.RemoveButton.TabIndex = 28;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InitDiceLabel
            // 
            this.InitDiceLabel.AutoSize = true;
            this.InitDiceLabel.Location = new System.Drawing.Point(519, 8);
            this.InitDiceLabel.Name = "InitDiceLabel";
            this.InitDiceLabel.Size = new System.Drawing.Size(63, 20);
            this.InitDiceLabel.TabIndex = 29;
            this.InitDiceLabel.Text = "InitDice";
            // 
            // InitDiceValue
            // 
            this.InitDiceValue.Location = new System.Drawing.Point(586, 5);
            this.InitDiceValue.Name = "InitDiceValue";
            this.InitDiceValue.Size = new System.Drawing.Size(68, 26);
            this.InitDiceValue.TabIndex = 30;
            this.InitDiceValue.ValueChanged += new System.EventHandler(this.InitiativeDiceChanged);
            // 
            // InitPlusLabel
            // 
            this.InitPlusLabel.AutoSize = true;
            this.InitPlusLabel.Location = new System.Drawing.Point(658, 5);
            this.InitPlusLabel.Name = "InitPlusLabel";
            this.InitPlusLabel.Size = new System.Drawing.Size(18, 20);
            this.InitPlusLabel.TabIndex = 31;
            this.InitPlusLabel.Text = "+";
            // 
            // InitPlusValue
            // 
            this.InitPlusValue.Location = new System.Drawing.Point(682, 5);
            this.InitPlusValue.Name = "InitPlusValue";
            this.InitPlusValue.Size = new System.Drawing.Size(70, 26);
            this.InitPlusValue.TabIndex = 32;
            this.InitPlusValue.ValueChanged += new System.EventHandler(this.InititivePlusChanegd);
            // 
            // PlayerAsset
            // 
            this.PlayerAsset.AutoSize = true;
            this.PlayerAsset.Location = new System.Drawing.Point(3, 50);
            this.PlayerAsset.Name = "PlayerAsset";
            this.PlayerAsset.Size = new System.Drawing.Size(123, 24);
            this.PlayerAsset.TabIndex = 33;
            this.PlayerAsset.Text = "Player Asset";
            this.PlayerAsset.UseVisualStyleBackColor = true;
            this.PlayerAsset.Click += new System.EventHandler(this.PlayerAssetClicked);
            // 
            // SaveToDb
            // 
            this.SaveToDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToDb.Location = new System.Drawing.Point(1870, 48);
            this.SaveToDb.Name = "SaveToDb";
            this.SaveToDb.Size = new System.Drawing.Size(140, 38);
            this.SaveToDb.TabIndex = 34;
            this.SaveToDb.Text = "Save";
            this.SaveToDb.UseVisualStyleBackColor = true;
            this.SaveToDb.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GetFromDbButton
            // 
            this.GetFromDbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetFromDbButton.Location = new System.Drawing.Point(1712, 48);
            this.GetFromDbButton.Name = "GetFromDbButton";
            this.GetFromDbButton.Size = new System.Drawing.Size(140, 38);
            this.GetFromDbButton.TabIndex = 35;
            this.GetFromDbButton.Text = "Get";
            this.GetFromDbButton.UseVisualStyleBackColor = true;
            this.GetFromDbButton.Click += new System.EventHandler(this.GetFromDbButton_Click);
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.GetFromDbButton);
            this.Controls.Add(this.SaveToDb);
            this.Controls.Add(this.PlayerAsset);
            this.Controls.Add(this.InitPlusValue);
            this.Controls.Add(this.InitPlusLabel);
            this.Controls.Add(this.InitDiceValue);
            this.Controls.Add(this.InitDiceLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ModifierValueLabel);
            this.Controls.Add(this.ActionPassCheckBox);
            this.Controls.Add(this.ModifierLabel);
            this.Controls.Add(this.AccruedRecoilValue);
            this.Controls.Add(this.AccruedRecoilLabel);
            this.Controls.Add(this.DefActCounterValue);
            this.Controls.Add(this.PainThresholdValue);
            this.Controls.Add(this.StunDamageValue);
            this.Controls.Add(this.StunMonValue);
            this.Controls.Add(this.PhysMonValue);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PhysicalDamageValue);
            this.Controls.Add(this.InitiativeValue);
            this.Controls.Add(this.PainThresholdLabel);
            this.Controls.Add(this.StunDamageLabel);
            this.Controls.Add(this.StunMonitorLabel);
            this.Controls.Add(this.PhysicalDamageLabel);
            this.Controls.Add(this.PhysMonLabel);
            this.Controls.Add(this.InitiativeLabel);
            this.Controls.Add(this.DefActCounterLabel);
            this.Name = "Participant";
            this.Size = new System.Drawing.Size(2013, 92);
            ((System.ComponentModel.ISupportInitialize)(this.InitiativeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysicalDamageValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhysMonValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunMonValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StunDamageValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PainThresholdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefActCounterValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccruedRecoilValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitDiceValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitPlusValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DefActCounterLabel;
        private System.Windows.Forms.Label InitiativeLabel;
        private System.Windows.Forms.Label PhysMonLabel;
        private System.Windows.Forms.Label PhysicalDamageLabel;
        private System.Windows.Forms.Label StunMonitorLabel;
        private System.Windows.Forms.Label StunDamageLabel;
        private System.Windows.Forms.Label PainThresholdLabel;
        private System.Windows.Forms.NumericUpDown InitiativeValue;
        private System.Windows.Forms.NumericUpDown PhysicalDamageValue;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown PhysMonValue;
        private System.Windows.Forms.NumericUpDown StunMonValue;
        private System.Windows.Forms.NumericUpDown StunDamageValue;
        private System.Windows.Forms.NumericUpDown PainThresholdValue;
        private System.Windows.Forms.NumericUpDown DefActCounterValue;
        private System.Windows.Forms.Label AccruedRecoilLabel;
        private System.Windows.Forms.NumericUpDown AccruedRecoilValue;
        private System.Windows.Forms.Label ModifierLabel;
        private System.Windows.Forms.CheckBox ActionPassCheckBox;
        private System.Windows.Forms.Label ModifierValueLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label InitDiceLabel;
        private System.Windows.Forms.NumericUpDown InitDiceValue;
        private System.Windows.Forms.Label InitPlusLabel;
        private System.Windows.Forms.NumericUpDown InitPlusValue;
        private System.Windows.Forms.CheckBox PlayerAsset;
        private System.Windows.Forms.Button SaveToDb;
        private System.Windows.Forms.Button GetFromDbButton;
    }
}
