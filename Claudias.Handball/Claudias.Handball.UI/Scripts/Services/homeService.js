var HomeService = function () {
    var _articles = [
        {
            Id: "1",
            Title: "Win win win",
            Author: "Kara Denvers",
            Description: "The team won the game yesterday!"
        },
        {
            Id: "2",
            Title: "Big game tonight",
            Author: "Alice Ionescu",
            Description: "The most important game of the season!"
        },
        {
            Id: "3",
            Title: "Merry Christmas from Blue Ravens!",
            Author: "Kara Denvers",
            Description: "Merry Christmas everyone!"
        },
    ];

    this.ReadAll = function () {
        return _articles;
    }

    this.ReadById = function (id) {
        for (var index = 0; index < _articles.length; index++) {
            if (index == _articles[index].Id) {
                return _articles[index];
            }
        }

        return null;
    }
}