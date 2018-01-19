var HomeController = function (serviceContext) {
   
    this.RenderPage = function () {
        var homeJumbotron = new HomeJumbotronController("divHomeJumbotron");
        homeJumbotron.RenderJumbotron();
        
        var variable=serviceContext.HomeService().ReadAll('http://localhost:57820/api/home').then(function (allArticles) {
            for (var i = 0; i < JSON.parse(allArticles).length; i++) {
                var homeArticleController = new HomeArticleController("divHomeArticles", JSON.parse(allArticles)[i]);
                homeArticleController.RenderArticle();
            }
        })
            .catch(function () {
                console.log("error");
            });
    }
}