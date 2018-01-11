var ScheduleService = function () {
    var _events = [
        {
            Id: "1",
            Name: "Blue Ravens - Gyor",
            Location: "Sala Sporturilor",
            Date: "11/12/2018"
        },
        {
            Id: "2",
            Name: "Blue Ravens - U Cluj",
            Location: "Sala Sporturilor",
            Date:"05/04/2018"
        },
        {
            Id: "3",
            Name: "Vardar - Blue Ravens",
            Location: "Papp Laszlo Arena",
            Date: "01/28/2018"
        },
    ];

    this.ReadAll = function () {
        return _events;
    }

    this.ReadById = function (id) {
        for (var index = 0; index < _events.length; index++) {
            if (id == _events[index].Id) {
                return _events[index];
            }
        }

        return null;
    }
}