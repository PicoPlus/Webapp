using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PicoPlus.App
{
#nullable disable
    public class SMS
    {
        public async  Task SendDone(string Phone , string Dealtitle , string cid , string did)
        {
            var client = new RestClient("http://ippanel.com:8080/");
           
            var request = new RestRequest();

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddQueryParameter("apikey", "yGVxLo0uZCqmvoTPHyfJO9T0g1iU-idlbkpzhB95g3k=");
            request.AddQueryParameter("pid", "b3kmer8k0ej323k");
            request.AddQueryParameter("fnum", "3000505");
            request.AddQueryParameter("tnum", Phone);
            request.AddQueryParameter("p1", "DealTitle");
            request.AddQueryParameter("p2", "CustCode");
            request.AddQueryParameter("p3", "TrackingCode");
            request.AddQueryParameter("v1", Dealtitle);
            request.AddQueryParameter("v2", cid);
            request.AddQueryParameter("v3", did);

            var response =  client.Get(request);
          
            MessageBox.Show(response.Content);
         
        }

        public async Task SendInProgress(string DealTitle , string Phone , string did )
        {
            var client = new RestClient("http://ippanel.com:8080/");

            var request = new RestRequest();

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddQueryParameter("apikey", "yGVxLo0uZCqmvoTPHyfJO9T0g1iU-idlbkpzhB95g3k=");
            request.AddQueryParameter("pid", "f67uj8ahqizrkop");
            request.AddQueryParameter("fnum", "3000505");
            request.AddQueryParameter("tnum", Phone);
            request.AddQueryParameter("p1", "DealName");
         
            request.AddQueryParameter("p2", "TrackingCode");
            request.AddQueryParameter("v1", DealTitle);
            request.AddQueryParameter("v2", did);
     

            var response = client.Get(request);
        }
      
        public async Task SendInvoice(string Phone , string DealAmount, string did )
        {
            var client = new RestClient("http://ippanel.com:8080/");

            var request = new RestRequest();

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddQueryParameter("apikey", "yGVxLo0uZCqmvoTPHyfJO9T0g1iU-idlbkpzhB95g3k=");
            request.AddQueryParameter("pid", "nkgsi4dnmlcghzz");
            request.AddQueryParameter("fnum", "3000505");
            request.AddQueryParameter("tnum", Phone);
            request.AddQueryParameter("p1", "TrackingCode");
           
            request.AddQueryParameter("p2", "DealAmount");

            request.AddQueryParameter("v1", did);
            request.AddQueryParameter("v2", DealAmount);


            var response = client.Get(request);
        }

    }

}
