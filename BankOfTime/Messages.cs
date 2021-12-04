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
        public Messages(string mobilePhoneTarget,string mobilePhoneSender, int? petitionid)
        {
            InitializeComponent();
            this.mobilePhoneTarget = mobilePhoneTarget;
            this.mobilePhoneSender = mobilePhoneSender;
            this.petitionId = petitionid;

            LoadMessages();
        }

        private void LoadMessages()
        {
           ;
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
                    MessagesLayout.Controls.Add(lbl);
                }
            }
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
            }
        }

        private void txt_MessageToSend_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
