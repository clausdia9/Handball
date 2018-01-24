var HomeController = function (serviceContext, baseURL) {
   
    this.RenderPage = function () {
        $("#divHomeJumbotron").empty();
        $("#divHomeArticles").empty();
        var homeJumbotron = new HomeJumbotronController("divHomeJumbotron");
        homeJumbotron.RenderJumbotron();
        var variable = serviceContext.HomeService().ReadAll(baseURL + "/home").then(function (allArticles) {
            $('#progress').hide(); 
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