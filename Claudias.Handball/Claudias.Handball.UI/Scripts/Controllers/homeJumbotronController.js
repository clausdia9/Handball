var HomeJumbotronController = function (containerId) {

    this.RenderJumbotron = function () {
        var jqJumbotron = $(" <div class='jumbotron'>")
            .append(" <h1 class='text-light container text-center' >Blue Ravens Handball</h1><br />")
            .append("<p class='text-white container text-center'>Welcome to the official page of Blue Ravens Handball Team! </p>");
        $("#" + containerId).append(jqJumbotron);
    }
}
