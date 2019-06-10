using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowrun.TurnHandler
{
    public class ParticipantData
    {
        public string name { get; set; }
        public int initative { get; set; }
        public bool actionPass { get; set; }
        public int physicalMonitor { get; set; }
        public int physicalDamage { get; set; }
        public int stunMonitor { get; set; }
        public int stunDamage { get; set; }
        public int painThreshold { get; set; }
        public int actionModifier { get; set; }
        public int defensiveActions { get; set; }
        public int accruedRecoil { get; set; }
    }

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

        public ParticipantData data = new ParticipantData();

        public void SetData(ParticipantData data)
        {
            this.data = data;
            NameTextBox.Text = data.name;
            InitiativeValue.Value = data.initative;
            PhysicalDamageValue.Value = data.physicalDamage;
            PhysMonValue.Value = data.physicalMonitor;
            StunMonValue.Value = data.stunMonitor;
            StunDamageValue.Value = data.stunDamage;
            PainThresholdValue.Value = data.painThreshold;
            DefActCounterValue.Value = data.defensiveActions;
            AccruedRecoilValue.Value = data.accruedRecoil;
            ActionPassCheckBox.Checked = data.actionPass;
            CalculateAndSetModifier();
        }

        public void DoActionPass()
        {            
            if (InitiativeValue.Value > 0)
            {
                InitiativeValue.Value -= 10;
                ActionPassCheckBox.Checked = false;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            onRemoveParticipant(this, new ParticipantArgs(index));    
        }

        private void InitiativeValueChanged(object sender, EventArgs e)
        {
            data.initative = (int)((NumericUpDown)sender).Value;
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
            data.accruedRecoil = (int) ((NumericUpDown)sender).Value;
        }

        private void CalculateAndSetModifier()
        {
            data.actionModifier = 0;
            if(data.painThreshold > 0 && data.physicalDamage >= data.painThreshold )
            {
                data.actionModifier -= data.physicalDamage / data.painThreshold;
            }
            if(data.painThreshold > 0 && data.stunDamage >= data.painThreshold )
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
