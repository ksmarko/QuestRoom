using BLL.DTO;
using BLL.Interfaces;
using System;
using System.Windows.Forms;

namespace QuestRoomApp
{
    public partial class ReservationWindow : Form
    {
        IQuestService qs;
        IReservationService rs;
        QuestDTO quest;

        public ReservationWindow(IQuestService qs, IReservationService rs, QuestDTO quest)
        {
            this.qs = qs;
            this.rs = rs;
            this.quest = quest;

            InitializeComponent();
            this.Text = $"Reservation for quest \"{quest.Name}\"";
            SetTimeSections(quest.Id, DateTime.Now);
        }

        private void btnConfirmReserv_Click(object sender, EventArgs e)
        {
            if (cboxTimeSelector.SelectedIndex < 0)
            {
                MessageBox.Show("Please select time");
                return;
            }

            DateTime date = clndrDateSelector.SelectionRange.Start;
            DateTime time = DateTime.Parse(cboxTimeSelector.SelectedItem.ToString());            
            double cost = quest.Price;
            string code = txtBoxsertifacateCode.Text.Trim().ToUpper();

            if (ckBoxHasSertificate.Checked == true)
                if (!String.IsNullOrEmpty(code))
                    if (rs.VerifyCertificateCode(code))
                        cost = 0;
                    else
                    {
                        MessageBox.Show("Invalid code");
                        return;
                    }
                else
                {
                     MessageBox.Show("Enter code");
                     return;
                }

            rs.Add(new ReservDTO { Quest = quest, DateTimeSections = date.ToShortDateString() + " " + time.ToShortTimeString(), Cost = cost });
            MessageBox.Show($"Quest \"{quest.Name}\" reserved for {date.ToShortDateString()} on {time.ToShortTimeString()}\nCost: {cost} grn");
            this.Close();
        }

        private void clndrDateSelector_DateSelected(object sender, DateRangeEventArgs e)
        {
            SetTimeSections(quest.Id, (sender as MonthCalendar).SelectionRange.Start);
        }

        private void SetTimeSections(int questId, DateTime dateTime)
        {
            cboxTimeSelector.Items.Clear();

            foreach (var el in rs.GetTimeSections(qs.Find(questId), dateTime))
                cboxTimeSelector.Items.Add(el);
        }

        private void ckBoxHasSertificate_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxsertifacateCode.Text = String.Empty;
            txtBoxsertifacateCode.Visible = ckBoxHasSertificate.Checked? true : false;
        }
    }
}
