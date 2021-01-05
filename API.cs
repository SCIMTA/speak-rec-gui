using Newtonsoft.Json.Linq;
using RestSharp;
using SpeakRec.model;
using SpeakRec.modelAPI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SpeakRec
{
    class API
    {
        private static string baseUrl = "http://127.0.0.1:8000/";
        public delegate void CallBack(JObject json);
        public delegate void CallBackGenSub(GenSub json);
        public delegate void CallBackAddPerson(AddPerson json);
        public delegate void CallBackGetListPerson(ListPerson listPerson);
        public delegate void CallBackEditJoin();
        public delegate void CallBackRemovePerson();

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


        public static void GetListPerson(CallBackGetListPerson callback)
        {
            callApiGet("get_list_person", json =>
            {
                callback(json.ToObject<ListPerson>());
            });
        }

        public static void GetListJoin(CallBackGetListPerson callback)
        {
            callApiGet("get_list_join", json =>
            {
                callback(json.ToObject<ListPerson>());
            });
        }

        public static void EditJoin(string label,bool isCheck, CallBackEditJoin callback)
        {
            JObject body = new JObject();
            body.Add("label", label);
            body.Add("is_check", isCheck);
            callApiPost("edit_join", body, json =>
             {
                 callback();
             }, false);
        }
        public static void RemovePerson(string label, CallBackRemovePerson callback)
        {
            JObject body = new JObject();
            body.Add("label", label);
            callApiPost("remove_person", body, json =>
            {
                callback();
            }, false);
        }
        private static LoadingForm loadingForm;
        private static Thread thread;
        private static void callApiPost(string path, JObject body, CallBack callBack, bool isShowLoading = true)
        {
            thread = new Thread(() =>
            {
                var client = new RestClient(baseUrl + path);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                onCallDone(response, callBack, isShowLoading);
            });
            thread.Start();

            if (isShowLoading)
            {
                loadingForm = new LoadingForm();
                loadingForm.progressBarLoading.Minimum = 0;
                loadingForm.progressBarLoading.Maximum = 1000000;
                for (int i = 0; i <= 800000; i++)
                    loadingForm.progressBarLoading.Value = i;
                loadingForm.ShowDialog();
            }

        }
        private static void callApiGet(string path, CallBack callBack,bool isShowLoading=true)
        {
            thread = new Thread(() =>
            {
                var client = new RestClient(baseUrl + path);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                onCallDone(response, callBack, isShowLoading);
            });
            thread.Start();
            loadingForm = new LoadingForm();
            loadingForm.progressBarLoading.Minimum = 0;
            loadingForm.progressBarLoading.Maximum = 1000000;
            for (int i = 0; i <= 800000; i++)
                loadingForm.progressBarLoading.Value = i;
            loadingForm.ShowDialog();

        }

        private static void onCallDone(IRestResponse response, CallBack callBack, bool isShowLoading)
        {
            if (isShowLoading)
                try
                {
                    JObject json;
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
                    else
                    {
                        Thread.Sleep(1);
                        onCallDone(response, callBack, isShowLoading);
                        return;
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                }
            else
            {
                try
                {
                    JObject json;
                    json = JObject.Parse(response.Content);
                    callBack(json);
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                }
            }
        }
    }
}
