using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestRoomApp
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        IQuestService qs;
        IReservationService rs;
        
        public Form1(IQuestService qs, IReservationService rs)
        {
            this.qs = qs;
            this.rs = rs;

            InitializeComponent();
            InitializeList(qs.GetAll());
            instance = this;
        }

        private void ItemSelected(object sender, EventArgs e)
        {
            if (lstQuests.SelectedIndex < 0)
                return;

            pnlQuestInfo.Visible = true;
            var quest = qs.Find(x => x.Name == lstQuests.SelectedValue.ToString()).FirstOrDefault();
            //var quest = qs.Find(lstQuests.SelectedIndex + 1);


            lblQuestName.Text = "Name: " + quest.Name;
            lblPrice.Text = "Price: " + quest.Price.ToString();
            lblPlayersLimit.Text = "Players limit: " + quest.PlayersLimit.ToString();
            lblDuration.Text = "Duration: " + quest.Duration.ToString() + " h.";
            lblDescription.Text = "Description: \n" + quest.Description;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstQuests.SelectedIndex = -1;
            pnlQuestInfo.Visible = false;
            ResetFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var quest = qs.Find(x => x.Name == lstQuests.SelectedValue.ToString()).FirstOrDefault();
            ReservationWindow window = new ReservationWindow(qs, rs, quest);
            window.ShowDialog();
        }

        private void InitializeList(IEnumerable<QuestDTO> source)
        {
            List<String> list = new List<string>();

            foreach (var el in source)
                list.Add(el.Name);

            lstQuests.DataSource = list;
            lstQuests.SelectedIndex = -1;
        }

        private void ResetFilter()
        {
            cBoxDuration.DataSource = null;
            cBoxPlayersLimit.DataSource = null;
            cBoxPrice.DataSource = null;

            cBoxDuration.Items.Clear();
            var durItems = qs.GetAll().Select(x => x.Duration).Distinct().ToList();
            cBoxDuration.DataSource = durItems;
            cBoxDuration.SelectedIndex = 0;

            cBoxPlayersLimit.Items.Clear();
            var plItems = qs.GetAll().Select(x => x.PlayersLimit).Distinct().ToList();
            cBoxPlayersLimit.DataSource = plItems;
            cBoxPlayersLimit.SelectedIndex = 0;

            cBoxPrice.Items.Clear();
            var priceItems = qs.GetAll().Select(x => x.Price).Distinct().Where(x => x % 100 == 0).ToList();
            cBoxPrice.DataSource = priceItems;
            cBoxPrice.SelectedIndex = 0;

            InitializeList(qs.GetAll());
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void lstQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
             pnlQuestInfo.Visible = lstQuests.SelectedIndex < 0 ? false : true;
        }

        private void FilterResults(object sender, EventArgs e)
        {
            int players = Convert.ToInt32(cBoxPlayersLimit.SelectedValue);
            int duration = Convert.ToInt32(cBoxDuration.SelectedValue);
            int price = Convert.ToInt32(cBoxPrice.SelectedValue);
            
            InitializeList(qs.FilterResults(players, duration, price));
        }
    }
}
