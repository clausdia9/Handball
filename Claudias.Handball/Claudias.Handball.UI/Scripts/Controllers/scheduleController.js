﻿var ScheduleController = function (serviceContext) {

    this.RenderPage = function () {
        var allEvents = JSON.parse(serviceContext.ScheduleService().ReadAll());
        for (var i = 0; i < allEvents.length; i++) {
            var scheduleTableController = new ScheduleTableController("divScheduleTable", allEvents[i]);
            scheduleTableController.RenderTable();
        }
    }
}