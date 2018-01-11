var ScheduleTableController = function (containerId, event) {

    this.RenderTable = function () {
        var jqTable = $(`<table class="table table-condensed table-bordered table-hover" id="`+event.Id+`">
                            <thead class="thead-dark">
                                <tr>
                                    <th>Event</th>
                                    <th>Location</th>
                                    <th>Date</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>`+event.Name+`</td>
                                    <td>`+event.Location+`</td>
                                     <td>`+event.Date+`</td>
                                </tr>
                            </tbody>
                          </table>`);

        $("#" + containerId).append(jqTable);
    }
}
