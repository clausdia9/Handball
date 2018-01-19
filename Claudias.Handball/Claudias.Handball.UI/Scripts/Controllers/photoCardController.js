var PhotoCardController = function (containerId, photo) {

    this.RenderCard = function () {
        var jqCard = $(`<img id="` + photo.Id + `" onclick="getElementById('preview').src=this.src" src="` + photo.Path + `" alt="" />`);
        $("#" + containerId).append(jqCard);
    }
    
}
