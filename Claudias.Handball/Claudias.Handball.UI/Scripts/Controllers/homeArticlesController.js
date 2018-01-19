var HomeArticleController = function (containerId, article) {

    this.RenderArticle = function () {
        var jqArticle = $("<article class='col-md-6' id='"+article.ArticleId+"'>")
            .append("<figure class='col-lg-12'>")
            .append("<img class='img img-responsive article-img' src= 'PhotoResources/img4.jpg' >")
            .append("<figcaption class='article- caption'>")
            .append("<h1 class='article-title'><a href='#'>" + article.Title + "</a></h1>")
            .append("<div class='article-intro col-lg-12 article-intro-style'>")
            .append("<strong > " + article.Author+"</strong");

        $("#" + containerId).append(jqArticle);
    }
}
