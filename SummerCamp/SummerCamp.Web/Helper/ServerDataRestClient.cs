using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Net;
using System.Web;
using RestSharp;
using SummerCamp.Model;

namespace SummerCamp.Web.Helper
{
    public class ServerDataRestClient : IServerDataRestClient
    {


        private readonly RestClient _client;
        private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public ServerDataRestClient()
        {
            _client = new RestClient(_url);
        }

        void IServerDataRestClient.Add(Session serverDataModel)
        {
            throw new NotImplementedException();
        }

        void IServerDataRestClient.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Session> IServerDataRestClient.GetAll()
        {
              var request = new RestRequest("api/Sessions",Method.GET) {RequestFormat = DataFormat.Json};
                var response = _client.Execute<List<Session>>(request);

            if(response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        Session IServerDataRestClient.GetById(int id)
        {
            var request = new RestRequest("api/Sessions/{id}", Method.GET) { RequestFormat = DataFormat.Json };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            var response = _client.Execute<Session>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        Session IServerDataRestClient.GetByIP(int ip)
        {
            throw new NotImplementedException();
        }

        Session IServerDataRestClient.GetByType(int type)
        {
            throw new NotImplementedException();
        }

        void IServerDataRestClient.Update(Session serverDataModel)
        {
            throw new NotImplementedException();
        }
    }
}