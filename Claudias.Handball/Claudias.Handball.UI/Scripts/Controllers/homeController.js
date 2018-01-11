var HomeController = function (serviceContext) {

    this.RenderPage = function () {
        var homeJumbotron = new HomeJumbotronController("divHomeJumbotron");
        homeJumbotron.RenderJumbotron();
        var allArticles = serviceContext.HomeService().ReadAll();
        for (var i = 0; i < allArticles.length; i++) {
            var homeArticleController = new HomeArticleController("divHomeArticles", allArticles[i]);
            homeArticleController.RenderArticle();
        }
    }
}