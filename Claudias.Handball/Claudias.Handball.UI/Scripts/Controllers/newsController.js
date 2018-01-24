var NewsController = function (serviceContext, baseURL) {

    this.RenderPage = function () {
        $("#divNewsArticles").empty();
        var variable = serviceContext.NewsService().ReadAll(baseURL + "/news").then(function (allNews) {
            
            $('#progress').hide();
            for (var i = 0; i < JSON.parse(allNews).length; i++) {
                var newsArticlesController = new NewsArticleController("divNewsArticles", JSON.parse(allNews)[i]);
                newsArticlesController.RenderNews();
            }
        })
            .catch(function () {
                console.log("error");
            });
    }
}