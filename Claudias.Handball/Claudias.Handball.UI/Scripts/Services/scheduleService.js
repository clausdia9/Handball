﻿var ScheduleService = function (serviceManager) {
    $('#progress').show();

    this.ReadAll = function (url) {
        return serviceManager.ajax(url, "GET");
    }
}