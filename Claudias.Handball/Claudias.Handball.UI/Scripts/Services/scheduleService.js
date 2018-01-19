var ScheduleService = function () {

        this.ReadAll = function () {
            return $.ajax({
                type: "GET",
                url: 'http://localhost:57820/api/schedule',
                async: false
            }).responseText;
        }

}