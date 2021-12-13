using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOfTime.Models;

namespace BankOfTime
{
    public partial class Dashboard : Form
    {
        string currentUser = "654131918";
        public Dashboard(string user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private string GetMobilePhone()
        {
            try
            {
                return usersDashboard.Rows[usersDashboard.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                return null;
            }
        }
        private int? GetPetitionId(string phoneNumber)
        {
            try
            {
                int? id;
               using (masterEntities db = new masterEntities())
                {
                    id = (from d in db.petition
                              where d.Performer == phoneNumber && d.Status != (int?)PetitionStatus.status.finished && d.Status != (int?)PetitionStatus.status.canceled
                              select (int?)d.Id).FirstOrDefault<int?>();

                    if (id == null)
                    {
                        petition p = new petition();
                        p.Performer = phoneNumber;
                        p.Requester = currentUser;
                        p.Status = (int?)PetitionStatus.status.pending;

                        db.petition.Add(p);
                        db.SaveChanges();

                        id = p.Id;
                    }
                }
                return id;

            }
            catch
            {
                Debug.WriteLine("ERROR RETRIEVING PETITION");
                return null;
            }
        }

        private int? GetPetitionStatus(int? petition)
        {
            int? status;
            using (masterEntities db = new masterEntities())
            {
                status = (from d in db.petition
                      where d.Id == petition
                      select (int?)d.Status).FirstOrDefault<int?>();
            }
            return status;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            using (masterEntities db = new masterEntities())
            {
                var lstUsers = from d in db.user
                          select new { d.MobilePhone, d.Name, d.MonthlyHours, d.Capabilities };
                usersDashboard.DataSource = lstUsers.ToList();
                // usersDashboard.Columns[0].Visible = false;

                // var lstMessages = db.message.Where(d=> d.petition.Performer == currentUser || d.petition.Requester == currentUser)
                //.GroupBy(p => p.PetitionId)
                // .Aggregate(db.message)
                //   .Select(p => p.First())
                /*  (from d in db.message
                                 where ()
                                 .GroupBy().Select(x)*/

                /*var lstMessages = db.message.Where(d => d.petition.Performer == currentUser || d.petition.Requester == currentUser)
                                            .Select(d => new { d.PetitionId, d.Message1, d.DateSent })
                                            .Join()*/

                var lstMessages = from d in db.message
                                  where d.petition.Performer == currentUser || d.petition.Requester == currentUser
                                  group d by d.PetitionId into op
                                  join p in db.message on op.Max(x => x.DateSent) equals p.DateSent
                                  select new
                                  {
                                      //petitionId = op.Key,
                                      DateSent = op.Max(x => x.DateSent),
                                      Message = p.Message1
                                  };

                //     select new
                //      {
                //petitionId = op.Key,
                //         DateSent = op.Max(x => x.DateSent),
                //        Message = op.Select(x
                //     };
                messagesDashboard.DataSource = lstMessages.ToList();



                var userData = (from d in db.user
                                where d.MobilePhone == currentUser
                                select new { d.Name, d.Balance, d.Capabilities }).FirstOrDefault();

                UserDatalbl.Text = $"{userData.Name}\n\nBalance: {userData.Balance}\n\nCapacidades: {userData.Capabilities}"; 






            }

       
        }

        private void usersDashboard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string phoneNumber = GetMobilePhone();
            if(phoneNumber != null) { 
            int? petitionId = GetPetitionId(phoneNumber);

                if(petitionId != null) {
                    int? status = GetPetitionStatus(petitionId);
                    Messages messagesForm = new Messages(phoneNumber,currentUser, petitionId, status, true);
                    messagesForm.Show();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPeticiones_Click(object sender, EventArgs e)
        {
            lastRequests lrequests = new lastRequests();
            lrequests.ShowDialog();
        }
    }
}
