var ServiceContext = function () {
    var _teamService;
    var _homeService;
    var _newsService;
    var _scheduleService;
    var _photosService;
    this.TeamService = function () {
        if (!_teamService) {
            _teamService = new TeamService();
        }
        return _teamService;
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
    this.PhotosService = function () {
        if (!_photosService) {
            _photosService = new PhotosService();
        }
        return _photosService;
    }
}
