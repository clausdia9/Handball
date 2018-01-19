var NewsController = function (serviceContext) {

    this.RenderPage = function () {
        var allNews = JSON.parse(serviceContext.NewsService().ReadAll());
       
      for (var i = 0; i < allNews.length; i++) {
            var newsArticlesController = new NewsArticleController("divNewsArticles", allNews[i]);
            newsArticlesController.RenderNews();
        }
    }
}