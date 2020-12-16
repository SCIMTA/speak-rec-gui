using Newtonsoft.Json.Linq;
using RestSharp;
using SpeakRec.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SpeakRec
{
    class API
    {
        private static string baseUrl = "http://127.0.0.1:8000/";
        public static AddPerson AddPerson(string audio = "..\\cache\\meeting\\637437514030398564.wav",string label = "hoàng")
        {
            JObject body = new JObject();
            body.Add("audio",audio );
            body.Add("label",label);
            return callApiPost("add_person", body).ToObject<AddPerson>();
        }

        public static GenSub GenSub(string meeting = "..\\cache\\meeting\\637437514030398564.wav")
        {
            JObject body = new JObject();
            body.Add("meeting", meeting);
            return callApiPost("gen_sub", body).ToObject<GenSub>();
        }

        private static JObject callApiPost(string path,JObject body)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            var client = new RestClient(baseUrl + path);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            loadingForm.closeThis();
            return json;
        }
    }
}
