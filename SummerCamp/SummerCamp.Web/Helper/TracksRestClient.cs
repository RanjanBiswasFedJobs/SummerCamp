using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using RestSharp;
using SummerCamp.Model;

namespace SummerCamp.Web.Helper
{
    public class TracksRestClient : ITracksRestClient
    {

        private readonly RestClient _client;
        private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public TracksRestClient()
        {
            _client = new RestClient(_url);
        }
        public void Add(Model.Track serverDataModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Track> GetAll()
        {
            var request = new RestRequest("api/Tracks", Method.GET) { RequestFormat = DataFormat.Json };
            var response = _client.Execute<List<Track>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public Model.Track GetById(int id)
        {
            var request = new RestRequest("api/Tracks/{id}", Method.GET) { RequestFormat = DataFormat.Json };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            var response = _client.Execute<Track>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public Model.Track GetByIP(int ip)
        {
            throw new NotImplementedException();
        }

        public Model.Track GetByType(int type)
        {
            throw new NotImplementedException();
        }

        public void Update(Model.Track serverDataModel)
        {
            throw new NotImplementedException();
        }
    }
}