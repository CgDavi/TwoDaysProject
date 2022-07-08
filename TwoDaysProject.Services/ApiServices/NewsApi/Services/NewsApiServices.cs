using Newtonsoft.Json;
using RestSharp;
using TwoDaysProject.Database;
using TwoDaysProject.Services.ApiServices.NewsApi.Dto;

namespace TwoDaysProject.Services.ApiServices.NewsApi.Services
{
    public class NewsApiServices : INewsApiManager
    {
        private readonly CustomDbContext _context;
        public NewsApiServices(CustomDbContext context)
        {
            _context = context;
        }
        public NewsApiDto GetArticles(string apiKey, string category)
        {
            var apiUrl = "https://newsapi.org/v2/top-headlines?category=" + category + "&apiKey=" + apiKey;
            var client = new RestClient(apiUrl);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);


            //var apiUrl = "https://newsapi.org/v2/top-headlines?category="+category+"&apiKey="+apiKey;
            //var client = new RestClient(apiUrl);
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            var json = response.Content;
            if (json == "")
            {
                return null;
            }
            var jsonResult = JsonConvert.DeserializeObject(json)?.ToString();
            var datalist = JsonConvert.DeserializeObject<NewsApiDto>(jsonResult);
            //var clientTasks = JsonConvert.DeserializeObject<IEnumerable<ArticleDto>>(jsonResult, new JsonSerializerSettings
            //{
            //    NullValueHandling = NullValueHandling.Ignore
            //});
            return datalist;
        }
    }
}