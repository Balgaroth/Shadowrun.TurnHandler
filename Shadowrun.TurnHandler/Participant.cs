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

        public void DoActionPass()
        {
            ActionPassCheckBox.Checked = false;
            if (InitiativeValue.Value > 0)
                InitiativeValue.Value -= 10;
            DefActCounterValue.Value = 0;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            onRemoveParticipant(this, new ParticipantArgs(index));    
        }

        private void InitiativeValueChanged(object sender, EventArgs e)
        {
            initative = (int)((NumericUpDown)sender).Value;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            name = ((TextBox)sender).Text;
        }

        private void ActionPassClicked(object sender, EventArgs e)
        {
            actionPass = ((CheckBox)sender).Checked;
            onActionPass(this, new ParticipantArgs(index));
        }

        private void PhysicalMonitorChanged(object sender, EventArgs e)
        {
            physicalMonitor = (int)((NumericUpDown)sender).Value;
        }

        private void StunMonitorChanged(object sender, EventArgs e)
        {
            stunMonitor = (int)((NumericUpDown)sender).Value;
        }

        private void PhysicalDamageChanged(object sender, EventArgs e)
        {
            physicalDamage = (int)((NumericUpDown)sender).Value;
            CalculateAndSetModifier();
        }

        private void StunDamageChanged(object sender, EventArgs e)
        {
            stunDamage = (int)((NumericUpDown)sender).Value;
            CalculateAndSetModifier();
        }

        private void PainThresholdChanged(object sender, EventArgs e)
        {
            painThreshold = (int)((NumericUpDown)sender).Value;
            CalculateAndSetModifier();
        }

        private void DefensiveActionsChanged(object sender, EventArgs e)
        {
            defensiveActions = (int)((NumericUpDown)sender).Value;
        }

        private void AccruedRecoilChanged(object sender, EventArgs e)
        {
            accruedRecoil = (int) ((NumericUpDown)sender).Value;
        }

        private void CalculateAndSetModifier()
        {
            actionModifier = 0;
            if(painThreshold > 0 && physicalDamage >= painThreshold )
            {
                actionModifier -= physicalDamage / painThreshold;
            }
            if(painThreshold > 0 && stunDamage >= painThreshold )
            {
                actionModifier -= stunDamage / painThreshold;
            }
            ModifierValueLabel.Text = actionModifier.ToString();
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
