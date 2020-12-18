using Newtonsoft.Json.Linq;
using RestSharp;
using SpeakRec.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakRec
{
    class API
    {
        private static string baseUrl = "http://127.0.0.1:8000/";
        public delegate void CallBack(JObject json);
        public delegate void CallBackGenSub(GenSub json);
        public delegate void CallBackAddPerson(AddPerson json);

        public static void AddPerson(string audio, string label, CallBackAddPerson callBack)
        {
            JObject body = new JObject();
            body.Add("audio", audio);
            body.Add("label", label);
            callApiPost("add_person", body, (json) =>
            {
                callBack(json.ToObject<AddPerson>());
            });
        }

        public static void GenSub(string meeting, CallBackGenSub callback)
        {
            JObject body = new JObject();
            body.Add("meeting", meeting);
            callApiPost("gen_sub", body, json =>
            {
                callback(json.ToObject<GenSub>());
            });
        }

        private static LoadingForm loadingForm;
        private static Thread thread;
        private static void callApiPost(string path, JObject body, CallBack callBack)
        {
            JObject json;
            thread = new Thread(() =>
            {
                var client = new RestClient(baseUrl + path);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                try
                {
                    if (loadingForm.InvokeRequired)
                        loadingForm.Invoke(new MethodInvoker(delegate
                        {
                            for (int i = loadingForm.progressBarLoading.Maximum / 10 * 8; i <= loadingForm.progressBarLoading.Maximum; i++)
                            {
                                if (loadingForm.progressBarLoading.Maximum == loadingForm.progressBarLoading.Value)
                                    break;
                                loadingForm.progressBarLoading.Value = i;
                            }
                            loadingForm.closeThis();
                            json = JObject.Parse(response.Content);
                            callBack(json);
                        }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            });
            thread.Start();
            loadingForm = new LoadingForm();
            loadingForm.progressBarLoading.Minimum = 0;
            loadingForm.progressBarLoading.Maximum = 1000000;
            for (int i = 0; i <= 800000; i++)
                loadingForm.progressBarLoading.Value = i;
            loadingForm.ShowDialog();
            
        }

    }
}
