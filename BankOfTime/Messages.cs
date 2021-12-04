using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOfTime.Models;
namespace BankOfTime
{
    public partial class Messages : Form
    {
        public string mobilePhoneTarget;
        public string mobilePhoneSender;
        public int? petitionId;
        public int? petitionStatus;
        bool petitioner;
        public Messages(string mobilePhoneTarget,string mobilePhoneSender, int? petitionid, int? petitionStatus, bool petitioner)
        {
            InitializeComponent();
            this.mobilePhoneTarget = mobilePhoneTarget;
            this.mobilePhoneSender = mobilePhoneSender;
            this.petitionId = petitionid;
            this.petitioner = petitioner;
            this.petitionStatus = petitionStatus;

            LoadMessages();
            LoadButton();
        }

        private void LoadMessages()
        {
            MessagesLayout.Controls.Clear();
            using(masterEntities db = new masterEntities())
            {
                var messages = (from d in db.message
                               where d.PetitionId == petitionId
                               select new { d.Message1, d.DateSent, d.user.Name }).OrderBy(d => d.DateSent ).ToList();

                foreach(var message in messages)
                {

                    Label lbl = new Label();
                    lbl.Text = $"{message.Name}: \n {message.Message1}";
                    lbl.Dock = DockStyle.Top;
                    lbl.AutoSize = true;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    MessagesLayout.Controls.Add(lbl);
                }
            }
        }

        private void LoadButton()
        {
            splitContainer2.Panel1.Controls.Clear();
            Button buttonToAdd = new Button();
            buttonToAdd.Dock = DockStyle.Right;
            if(petitioner)
            {
                if(petitionStatus == (int?)PetitionStatus.status.pending) { 
                buttonToAdd.Name = "btnConsolidatePetition";
                buttonToAdd.Text = "Consolidate Petition";
                buttonToAdd.Click += new EventHandler(btn_ConsolidatePetition_Click);
                }
                else
                {
                    buttonToAdd.Name = "btnFinishPetition";
                    buttonToAdd.Text = "Finish Petition";
                    buttonToAdd.Click += new EventHandler(btn_FinishPetition_Click);
                }
            }
            else
            {
                buttonToAdd.Name = "Cancel Petition";
                buttonToAdd.Text = "Cancel Petition";
                buttonToAdd.Click += new EventHandler(btn_CancelPetition_Click);
            }
            splitContainer2.Panel1.Controls.Add(buttonToAdd);
        }
        private void btn_ConsolidatePetition_Click(object sender, EventArgs e)
        {
            ConsolidatePetition form = new ConsolidatePetition((int)petitionId);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                using (masterEntities db = new masterEntities())
                {
                    petition p = db.petition.Find(petitionId);
                    p.Status = (int?)PetitionStatus.status.onGoing;

                    db.SaveChanges();
                }
                petitionStatus = (int?)PetitionStatus.status.onGoing;
                LoadButton();
            }
        }
        private void btn_CancelPetition_Click(object sender, EventArgs e)
        {
            //ConsolidatePetition form = new ConsolidatePetition((int)petitionId);
           // form.ShowDialog();
        }
        private void btn_FinishPetition_Click(object sender, EventArgs e)
        {
            //ConsolidatePetition form = new ConsolidatePetition((int)petitionId);
            // form.ShowDialog();
        }
        private void btn_messageSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_MessageToSend.Text))
            {
                using(masterEntities db = new masterEntities())
                {
                    message varMessage = new message();
                    varMessage.DateSent = DateTime.Now;
                    varMessage.Sender = mobilePhoneSender;
                    varMessage.Message1 = txt_MessageToSend.Text;
                    varMessage.PetitionId = petitionId;

                    db.message.Add(varMessage);

                    db.SaveChanges();
                }
                txt_MessageToSend.Clear();
                LoadMessages();
            }
        }

    }
}
