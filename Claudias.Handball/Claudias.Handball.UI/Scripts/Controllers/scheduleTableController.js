var ScheduleTableController = function (containerId, event) {

    this.RenderTable = function () {
        var jqTable = $(`
                         <div class="row" ">
                            <div class="col-sm-4">`+ event.EventName + `</div>
                            <div class="col-sm-4">`+ event.Location + `</div>
                            <div class="col-sm-4" >`+ event.Date + `</div>
                         </div>
                       `);

        $("#" + containerId).append(jqTable);
    }
}
