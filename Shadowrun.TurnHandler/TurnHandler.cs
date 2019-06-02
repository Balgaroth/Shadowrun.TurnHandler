using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowrun.TurnHandler
{
    public partial class TurnHandler : Form
    {
        const int SPACING = 3;
        List<Participant> participants = new List<Participant>();
        string directory;
        string filePath;

        public TurnHandler()
        {
            InitializeComponent();
            directory = @"c:\TurnHandler";
            filePath = $@"{directory}\TurnHandlerState.txt";
        }        

        private void TurnHandler_Load(object sender, EventArgs e)
        {
        }

        private void SortParticipants()
        {
            List<Participant> notFinishedsortedParticipants = participants.Where(x => !x.data.actionPass).OrderByDescending(x => x.data.initative).ToList();
            List<Participant> finishedsortedParticipants = participants.Where(x => x.data.actionPass).OrderByDescending(x => x.data.initative).ToList();
            foreach (var participant in notFinishedsortedParticipants)
            {
                RemoveParticipant(participant, participant.index);
            }
            foreach(var participant in finishedsortedParticipants)
            {
                RemoveParticipant(participant, participant.index);
            }
            foreach(var participant in notFinishedsortedParticipants)
            {
                AddParticipant(participant);
            }
            foreach (var participant in finishedsortedParticipants)
            {
                AddParticipant(participant);
            }
        }        

        private void AddParticipant(Participant participant)
        {
            Participant previous;

            participants.Add(participant);
            ParticipantPanel.Controls.Add(participant);
            if (ParticipantPanel.Controls.Count < 2)
            {
                participant.Location = new Point(0, 0);
            }
            else
            {
                previous = (Participant)ParticipantPanel.Controls[ParticipantPanel.Controls.Count - 2];
                participant.Location = new Point(0, previous.Location.Y + previous.Height + SPACING);
            }

            participant.onRemoveParticipant -= RemoveParticipant_Click;
            participant.onActionPass -= ActionPassHandling;
            participant.onRemoveParticipant += new Participant.RemoveParticipantHandler(RemoveParticipant_Click);
            participant.onActionPass += new Participant.ActionPassHandler(ActionPassHandling);
            participant.index = ParticipantPanel.Controls.Count - 1;

            participant.Width = ParticipantPanel.Width;
            participant.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        }

        private void AddParticipantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddParticipant(new Participant());            
        }

        private void PassDoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure the Pass is over?", "Confirm", MessageBoxButtons.OKCancel);
            if(confirmResult == DialogResult.OK)
            {
                foreach(var participant in participants)
                {
                    participant.DoActionPass();
                }
                SortParticipants();
            }
            else
            {
                //nothing
            }
        }

        private void ActionPassHandling(object sender, ParticipantArgs e)
        {
            SortParticipants();
        }

        private void RemoveParticipant(Participant sender, int index)
        {
            Participant updateList;

            for (int i = index; i < ParticipantPanel.Controls.Count; i++)
            {
                updateList = (Participant)ParticipantPanel.Controls[i];
                updateList.Location = new Point(0, updateList.Location.Y - updateList.Height - SPACING);
                updateList.index = i - 1;
            }

            ParticipantPanel.Controls.RemoveAt(index);
            participants.Remove(sender);
        }

        private void RemoveParticipant_Click(object sender, ParticipantArgs e)
        {
            RemoveParticipant((Participant)sender, e.index);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //save combat-state
            string json = JsonConvert.SerializeObject(participants.Select(x => x.data));
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            File.WriteAllText(filePath, json);
            MessageBox.Show("File saved");
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.InitialDirectory = "c:\\Users";
            //dialog.IsFolderPicker = false;
            //if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            //{

            //}
            RemoveAll();
            string file = File.ReadAllText(filePath);
            List<ParticipantData> pData = JsonConvert.DeserializeObject<List<ParticipantData>>(file);
            foreach(var data in pData)
            {
                Participant participant = new Participant();
                participant.SetData(data);
                AddParticipant(participant);
            }
            MessageBox.Show("File loaded");
        }

        private void RemoveAll()
        {
            foreach(var participant in participants)
            {
                RemoveParticipant(participant, participant.index);
            }
        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortParticipants();
        }
    }
}
