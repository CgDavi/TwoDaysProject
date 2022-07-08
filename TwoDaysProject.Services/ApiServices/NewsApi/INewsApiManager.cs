using TwoDaysProject.Services.ApiServices.NewsApi.Dto;

namespace TwoDaysProject.Services.ApiServices.NewsApi
{
    public interface INewsApiManager
    {
        public NewsApiDto GetArticles(string apiKey, string category);
    }
}
