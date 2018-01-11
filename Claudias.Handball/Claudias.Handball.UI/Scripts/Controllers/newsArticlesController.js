var NewsArticleController = function (containerId, news) {

    this.RenderNews = function () {
        var jqNews = $("<article class='col-md-12' id='"+news.Id+"'>")
            .append("<img class='img img-responsive article-img' src='PhotoResources/jumbotron_bg.jpeg'>")
            .append("<figcaption class='article- caption'>")
            .append("<h1 class='article-title'>" + news.Title)
            .append("<h5 class='text-muted'>" + news.Author)
            .append("<div>"+news.Description);

        $("#" + containerId).append(jqNews);
    }
}
