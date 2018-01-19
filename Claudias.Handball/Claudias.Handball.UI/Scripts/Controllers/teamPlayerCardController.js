var TeamPlayerCardController = function (containerId, player) {

    this.RenderCard = function () {
        var jqCard = $("<div class='col-sm-6 col-md-4 col-lg-3 mt-4'>")
            .append("<div id='" + player.PlayerId + "'class='card'>")
            .append("<img class='img-fluid' src='PhotoResources/jumbotron_bg.jpeg' alt='Card image cap'>")
            .append("<div class='card-block'  style='background-color:lightgrey'>")
            .append("<h4 class='card-title'>" + player.PlayerName + "</h4>")
            .append("<a href='#' class='btn btn-primary'>View Details</a>");
        $("#" + containerId).append(jqCard);
    }
}
