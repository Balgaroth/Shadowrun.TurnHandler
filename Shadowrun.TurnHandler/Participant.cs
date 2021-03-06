﻿using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Shadowrun.Sql;
using Shadowrun.Sql.Models;

namespace Shadowrun.TurnHandler
{
    public partial class Participant : UserControl
    {
        public Participant()
        {
            InitializeComponent();
            CalculateAndSetModifier();
        }

        public int index { get; set; }
        public delegate void RemoveParticipantHandler(object sender, ParticipantArgs e);
        public event RemoveParticipantHandler onRemoveParticipant;
        public delegate void ActionPassHandler(object sender, ParticipantArgs e);
        public event ActionPassHandler onActionPass;

        public ParticipantModel data = new ParticipantModel();

        public void SetData(ParticipantModel data)
        {
            this.data = data;
            NameTextBox.Text = data.name;
            InitiativeValue.Value = data.initiative;
            PhysicalDamageValue.Value = data.physicalDamage;
            PhysMonValue.Value = data.physicalMonitor;
            StunMonValue.Value = data.stunMonitor;
            StunDamageValue.Value = data.stunDamage;
            PainThresholdValue.Value = data.painThreshold;
            DefActCounterValue.Value = data.defensiveActions;
            AccruedRecoilValue.Value = data.accruedRecoil;
            ActionPassCheckBox.Checked = data.actionPass;
            InitDiceValue.Value = data.initDice;
            InitPlusValue.Value = data.initPlus;
            PlayerAsset.Checked = data.playerAsset;
            CalculateAndSetModifier();
        }

        public void DoActionPass()
        {
            if (InitiativeValue.Value > 0)
            {
                InitiativeValue.Value -= 10;
                data.actionPass = ActionPassCheckBox.Checked = false;
            }
        }

        public void DoEndOfTurn()
        {
            if (!PlayerAsset.Checked && InitDiceValue.Value > 0 && InitPlusValue.Value > 0)
            {
                InitiativeValue.Value = TurnHandler.RollInit((int)InitDiceValue.Value, (int)InitPlusValue.Value, int.Parse(ModifierValueLabel.Text));
            }
            data.actionPass = ActionPassCheckBox.Checked = false;
            DefActCounterValue.Value = 0;
        }

        private async void GetFromDbButton_Click(object sender, EventArgs e)
        {
            if (data.name != null)
            {
                var entity = new ShadowrunRepo().GetEntity(data.name);
                if (entity != null)
                    SetData(ParticipantMapper.EntityToParticipantModel(entity));
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await new ShadowrunRepo().UpdateOrSaveEntityAsync(ParticipantMapper.ParticipantToEntity(data));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            onRemoveParticipant(this, new ParticipantArgs(index));
        }

        private void InitiativeDiceChanged(object sender, EventArgs e)
        {
            data.initDice = (int)((NumericUpDown)sender).Value;
        }

        private void InititivePlusChanegd(object sender, EventArgs e)
        {
            data.initPlus = (int)((NumericUpDown)sender).Value;
        }

        private void InitiativeValueChanged(object sender, EventArgs e)
        {
            data.initiative = (int)((NumericUpDown)sender).Value;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            data.name = ((TextBox)sender).Text;
        }

        private void ActionPassClicked(object sender, EventArgs e)
        {
            data.actionPass = ((CheckBox)sender).Checked;
            onActionPass(this, new ParticipantArgs(index));
        }

        private void PlayerAssetClicked(object sender, EventArgs e)
        {
            data.playerAsset = ((CheckBox)sender).Checked;
        }

        private void PhysicalMonitorChanged(object sender, EventArgs e)
        {
            data.physicalMonitor = (int)((NumericUpDown)sender).Value;
        }

        private void StunMonitorChanged(object sender, EventArgs e)
        {
            data.stunMonitor = (int)((NumericUpDown)sender).Value;
        }

        private void PhysicalDamageChanged(object sender, EventArgs e)
        {
            data.physicalDamage = (int)((NumericUpDown)sender).Value;
            CalculateAndSetModifier();
        }

        private void StunDamageChanged(object sender, EventArgs e)
        {
            data.stunDamage = (int)((NumericUpDown)sender).Value;
            CalculateAndSetModifier();
        }

        private void PainThresholdChanged(object sender, EventArgs e)
        {
            data.painThreshold = (int)((NumericUpDown)sender).Value;
            CalculateAndSetModifier();
        }

        private void DefensiveActionsChanged(object sender, EventArgs e)
        {
            data.defensiveActions = (int)((NumericUpDown)sender).Value;
        }

        private void AccruedRecoilChanged(object sender, EventArgs e)
        {
            data.accruedRecoil = (int)((NumericUpDown)sender).Value;
        }

        private void CalculateAndSetModifier()
        {
            data.actionModifier = 0;
            if (data.painThreshold > 0 && data.physicalDamage >= data.painThreshold)
            {
                data.actionModifier -= data.physicalDamage / data.painThreshold;
            }
            if (data.painThreshold > 0 && data.stunDamage >= data.painThreshold)
            {
                data.actionModifier -= data.stunDamage / data.painThreshold;
            }
            ModifierValueLabel.Text = data.actionModifier.ToString();
        }
    }

    public class ParticipantArgs : EventArgs
    {
        public int index { get; set; }

        public ParticipantArgs(int value)
        {
            index = value;
        }
    }
}
