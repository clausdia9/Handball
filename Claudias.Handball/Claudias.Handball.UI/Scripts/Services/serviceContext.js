var ServiceContext = function () {
    var _playerService;
    var _homeService;
    var _newsService;
    var _scheduleService;
    this.PlayerService = function () {
        if (!_playerService) {
            _playerService = new PlayerService();
        }
        return _playerService;
    }
    this.HomeService = function () {
        if (!_homeService) {
            _homeService = new HomeService();
        }
        return _homeService;
    }
    this.NewsService = function () {
        if (!_newsService) {
            _newsService = new NewsService();
        }
        return _newsService;
    }
    this.ScheduleService = function () {
        if (!_scheduleService) {
            _scheduleService = new ScheduleService();
        }
        return _scheduleService;
    }
}
