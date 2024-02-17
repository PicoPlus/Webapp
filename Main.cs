using HubSpot.NET.Api.Contact.Dto;
using HubSpot.NET.Api.Deal.Dto;
using HubSpot.NET.Core;
using RestSharp;
using SMS;
using Microsoft.AspNetCore.SignalR.Client;
using System.Runtime.Serialization;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http.Connections;
using HubSpot.NET.Core.Interfaces;

namespace PicoPlus.App
{
#nullable disable
    public partial class Main : Form
    {
        private HubConnection _connection;

        public Main()
        {
            InitializeComponent();

            _connection = new HubConnectionBuilder()

                .WithUrl("https://picocare.ir/api/v1/Notification", HttpTransportType.WebSockets | HttpTransportType.LongPolling)

                .Build();

            _connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await _connection.StartAsync();
            };
            
           
        }
        public string DealStage { get; set; }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    DealStage = "closedwon";
                    break;
                case 1:
                    DealStage = "8198220";
                    break;
                case 2:
                    DealStage = "closedlost";
                    break;
                case 3:
                    DealStage = "8198221";
                    break;



            }

            HubSpotApi hubSpot = new HubSpotApi("pat-na1-8eb63f86-c4a1-4d62-8b1a-ad7731d28ccb");
            SMS sms = new SMS();

            try
            {
                var Contact = hubSpot.Contact.CreateOrUpdate<Model>(new Model
                {
                    FirstName = FullName.Text,
                    Phone = DealPhone.Text,
                    Email = DealPhone.Text + "@picocrm.ir"

                });
                label1.Text = Contact.Id.ToString();
                var Report = hubSpot.Contact.CreateOrUpdate<Model>(new Model
                {
                    FirstName = "Day:",
                    Phone = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day,
                    Email = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "@picocrm.ir"
                });

                var deal = hubSpot.Deal.Create<DealCustomModel>(new DealCustomModel
                {
                    Name = Dealtitle.Text,
                    Stage = DealStage,
                    Amount = int.Parse(DealAmount.Text),
                    Pipeline = "default",
                    CloseDate = DateTime.Now,
                    description = Description.Text,


                });

                hubSpot.Associations.AssociationToObject("contact", Contact.Id.ToString(), "deals", deal.Id.ToString());
                hubSpot.Associations.AssociationToObject("contact", Report.Id.ToString(), "deals", deal.Id.ToString());


                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        await sms.SendDone(DealPhone.Text, Dealtitle.Text, Contact.Id.ToString(), deal.Id.ToString());
                        break;
                    case 1:
                        await sms.SendInProgress(Dealtitle.Text, DealPhone.Text, deal.Id.ToString());
                        break;
                    case 2:
                        break;
                    case 3:
                        await sms.SendInvoice(DealPhone.Text, DealAmount.Text, deal.Id.ToString());
                        break;
                }
                button1.BackColor = Color.Green;
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                var Report = hubSpot.Contact.CreateOrUpdate<Model>(new Model
                {
                    FirstName = "Day:",
                    Phone = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day,
                    Email = DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "@picocrm.ir"
                });

                var deal = hubSpot.Deal.Create<DealHubSpotModel>(new DealCustomModel
                {
                    Name = Dealtitle.Text,
                    Stage = "closedwon",
                    Amount = int.Parse(DealAmount.Text),
                    Pipeline = "default",
                    CloseDate = DateTime.Now,
                    description = Description.Text,


                });

                hubSpot.Deal.AssociateToContact<IHubSpo>();
                MessageBox.Show(ex.Message);
            }

            Dealtitle.Text = "";
            DealPhone.Text = "";
            FullName.Text = "";
            DealAmount.Text = "";



        }
        public class Model : ContactHubSpotModel
        {

            public string TotalRevenue { get; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchDeal viewLines = new SearchDeal();
            viewLines.Show();
        }

        private void DealSearchSubMenu_Click(object sender, EventArgs e)
        {

            SearchDeal Frmsearchdeal = new SearchDeal();

            Frmsearchdeal.Show();
        }
        public void NoteGet(string s1)
        {
            MessageBox.Show(s1);
        }

        private async  void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Starting Server...");

            try
            {
                await _connection.StartAsync();
                await _connection.SendAsync("NotificationSend" , "test");
                // Connection started successfully
                _connection.On<string>("test", (message) =>
                {
                    MessageBox.Show(message, "Notification Received");
                });
            }
            catch (Exception ex)
            {
                // Handle connection error
                MessageBox.Show(ex.Message, "Connection Error");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SearchDeal searchDeal = new SearchDeal();

            searchDeal.Show();

        }
        public class DealCustomModel : DealHubSpotModel
        {
            [DataMember(Name = "description")]

            public string description { get; set; }
        }

        public void getd()
        {
            MessageBox.Show("test");
        }
    }
}