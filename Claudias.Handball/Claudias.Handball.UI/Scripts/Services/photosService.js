var PhotosService = function () {
    var _photos = [
        {
            Id: "1",
            Path:"PhotoResources/img1.jpg"
        },
        {
            Id: "2",
            Path:"PhotoResources/img2.jpg"
        },
        {
            Id: "3",
            Path:"PhotoResources/img4.jpg"
        },
        {
            Id: "4",
            Path: "PhotoResources/img10.jpg"
        },
        {
            Id: "5",
            Path: "PhotoResources/img17.jpg"
        },
    ];

    this.ReadAll = function () {
        return _photos;
    }

    this.ReadById = function (id) {
        for (var index = 0; index < _photos.length; index++) {
            if (index == _photos[index].Id) {
                return _photos[index];
            }
        }

        return null;
    }
}