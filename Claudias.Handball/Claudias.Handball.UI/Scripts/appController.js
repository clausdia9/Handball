$(document).ready(function () {
    var _serviceContext = new ServiceContext();
    var _baseURL = "http://localhost:57820/api";
    var _menuController = new MenuController(_serviceContext, _baseURL);
    _menuController.GenerateMenu();
 

});