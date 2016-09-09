using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace OneRepo4.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {           
            //list all available repository items

          var client = new RestClient(ConfigurationManager.AppSettings["repo_url"]);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var getRepoItemsRequest = new RestRequest("repoitems/", Method.GET) {RequestFormat = DataFormat.Json};


            // add files to upload (works with compatible verbs)
            //request.AddFile(path);

            //var response2 = client.Execute<OneRepoCQRS.ReadModel.RepoItemDto>(request);
            //var name = response2.Data.Name;

            client.ExecuteAsync(getRepoItemsRequest, restResponse =>
            {
                Console.WriteLine(restResponse.Content);
            });
            //var content = response.Content; // raw content as string

            Console.ReadLine();

        }
    }
}
