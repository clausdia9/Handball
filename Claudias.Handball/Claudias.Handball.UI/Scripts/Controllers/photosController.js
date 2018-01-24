var PhotosController = function (serviceContext) {

    this.RenderPage = function () {
        $("#divPhotos").empty();
        var allPhotos = serviceContext.PhotosService().ReadAll();
        for (var i = 0; i < allPhotos.length; i++) {
            var photoCardController = new PhotoCardController("divPhotos", allPhotos[i]);
            photoCardController.RenderCard();
        }
    }
}