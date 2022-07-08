namespace TwoDaysProject.Services.ApiServices.NewsApi.Dto
{
    public class NewsApiDto
    {
        public IEnumerable<ArticleDto>? Articles { get; set; }
    }
    public class ArticleDto
    {
        public SourceDto? Source { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public string? UrlToImage { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
    public class SourceDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
    }
}
