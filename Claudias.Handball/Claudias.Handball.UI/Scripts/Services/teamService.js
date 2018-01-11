var PlayerService = function () {
    var _players = [
        {
            Id: "1",
            Name: "Alice Ardean",
            Goals: 23,
            BirthDay: "12/30/1980"
        },
        {
            Id: "2",
            Name: "Isabelle Gullden",
            Goals: 30,
            BirthDay: "10/12/1985"
        },
        {
            Id: "3",
            Name: "Cristina Neagu",
            Goals: 35,
            BirthDay: "10/26/1988"
        },
        {
            Id: "4",
            Name: "Cristina Zamfir",
            Goals: 12,
            BirthDay: "10/30/1988"
        },
        {
            Id: "5",
            Name: "Adriana Nechita",
            Goals: 28,
            BirthDay: "11/13/1988"
        },
        {
        Id: "6",
        Name: "Paula Ungureanu",
        Goals: 1,
        BirthDay: "10/21/1980"
        },
        {
            Id: "7",
            Name: "Iulia Dumanska",
            Goals: 1,
            BirthDay: "05/12/1996"
        },
        {
            Id: "8",
            Name: "Eliza Buceschi",
            Goals: 15,
            BirthDay: "01/21/1993"
        },
        {
            Id: "9",
            Name: "Florina Chintoan",
            Goals: 21,
            BirthDay: "10/12/1980"
        },
        {
            Id: "10",
            Name: "Cristina Laslo",
            Goals: 23,
            BirthDay: "10/12/1996"
        },
        {
            Id: "11",
            Name: "Florina Amariei",
            Goals: 19,
            BirthDay: "10/11/1980"
        },
        {
            Id: "12",
            Name: "Florina Ionescu",
            Goals: 21,
            BirthDay: "10/12/1980"
        },

    ];

    this.ReadAll = function () {
        return _players;
    }

    this.ReadById = function (id) {
        for (var index = 0; index < _players.length; index++) {
            if (index == _players[index].Id) {
                return _players[index];
            }
        }

        return null;
    }
}