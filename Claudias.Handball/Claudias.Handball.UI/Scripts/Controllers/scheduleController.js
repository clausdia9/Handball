var ScheduleController = function (serviceContext, baseURL) {

    this.RenderPage = function () {
        $("#divScheduleTable").empty();
        var variable = serviceContext.ScheduleService().ReadAll(baseURL + "/schedule").then(function (allEvents) {

            $('#progress').hide();
            for (var i = 0; i < JSON.parse(allEvents).length; i++) {
                var scheduleTableController = new ScheduleTableController("divScheduleTable", JSON.parse(allEvents)[i]);
                scheduleTableController.RenderTable();
            }
        })
            .catch(function () {
                console.log("error");
            });
    }
}