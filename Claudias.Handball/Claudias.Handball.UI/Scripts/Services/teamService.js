var TeamService = function (serviceManager) {
    $('#progress').show(); 

    this.ReadAll = function (url) {
        return serviceManager.ReadAll(url, "GET");
    }
}