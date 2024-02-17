using HubSpot.NET.Api.Contact.Dto;
using HubSpot.NET.Api.Deal.Dto;
using HubSpot.NET.Core;
using HubSpot.NET.Core.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace PicoPlus.App
{
    public partial class SearchDeal : Form
    {
        public SearchDeal()
        {
            InitializeComponent();
        }
        public string DealStageSelector { get; set; }
        public ContactHubSpotModel FoundContactData = new();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            HubSpotApi hubSpot = new HubSpotApi("pat-na1-8eb63f86-c4a1-4d62-8b1a-ad7731d28ccb");


            var dealinfo = hubSpot.Deal.GetById<DealCustomModel>(long.Parse(TrackingCode.Text));

            DealTitle.Text = dealinfo.Name;
            DealAmount.Text = dealinfo.Amount.ToString();

            LblCreateDate.Text = pc.GetYear(dealinfo.DateCreated.Value) + "/" + pc.GetMonth(dealinfo.DateCreated.Value) + "/" + pc.GetDayOfMonth(dealinfo.DateCreated.Value) + " " + pc.GetHour(dealinfo.DateCreated.Value)+":"+pc.GetMinute(dealinfo.DateCreated.Value);
            DealDescription.Text = dealinfo.description;
            switch (dealinfo.Stage)
            {
                case "closedwon":
                    DealStage.SelectedIndex = 0;
                    break;
                case "8198220":
                    DealStage.SelectedIndex = 1;
                    break;
                case "closedlost":
                    DealStage.SelectedIndex = 2;
                    break;
                case "8198221":
                    DealStage.SelectedIndex = 3;
                    break;
                case "74911669":
                    DealStage.SelectedIndex = 4;
                    break;


            }


            Regex Mobilptrn = new Regex(@"^(?:0|98|\+98|\+980|0098|098|00980)?(9\d{9})$");

            foreach (var ctn in dealinfo.Associations.AssociatedContacts)
            {
                if (Mobilptrn.IsMatch(hubSpot.Contact.GetById<ContactHubSpotModel>(ctn).Phone))
                {
                    FoundContactData = hubSpot.Contact.GetById<ContactHubSpotModel>(ctn);
                }


            }

            FullName.Text = FoundContactData.FirstName;
            PhoneNumber.Text = FoundContactData.Phone;

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            SMS sMS = new SMS();
            switch (DealStage.SelectedIndex)
            {
                case 0:
                    DealStageSelector = "closedwon";
                    break;
                case 1:
                    DealStageSelector = "8198220";
                    break;
                case 2:
                    DealStageSelector = "closedlost";
                    break;
                case 3:
                    DealStageSelector = "8198221";
                    break;
                case 4:
                    DealStageSelector = "74911669";
                    break;
            }

            HubSpotApi hubSpot = new HubSpotApi("pat-na1-8eb63f86-c4a1-4d62-8b1a-ad7731d28ccb");
            try
            {
                var DealUpdate = hubSpot.Deal.Update<DealCustomModel>(new DealCustomModel
                {
                    Id = long.Parse(TrackingCode.Text),
                    Name = DealTitle.Text,
                    Amount = long.Parse(DealAmount.Text),
                    Stage = DealStageSelector,
                    description = DealDescription.Text,
                });
                MessageBox.Show("بروزرسانی موفق");

                switch (DealStage.SelectedIndex)
                {
                    case 0:
                        DealStageSelector = "closedwon";
                        await sMS.SendDone(PhoneNumber.Text, DealTitle.Text, FoundContactData.Id.ToString(), TrackingCode.Text);
                        break;
                    case 1:
                        await sMS.SendInProgress(DealTitle.Text, PhoneNumber.Text, TrackingCode.Text);
                        break;
                    case 2:
                        break;
                    case 3:
                        DealStageSelector = "8198221";
                        await sMS.SendInvoice(PhoneNumber.Text, DealAmount.Text, TrackingCode.Text);
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public class DealCustomModel : DealHubSpotModel
        {
            public string description { get; set; }
        }

        private void SearchDeal_Load(object sender, EventArgs e)
        {

        }

        private void LblCreateDate_Click(object sender, EventArgs e)
        {

        }
    }
}
