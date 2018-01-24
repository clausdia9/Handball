var ServiceContext = function () {
    var _teamService;
    var _homeService;
    var _newsService;
    var _scheduleService;
    var _photosService;
    var _serviceManager = new ServiceManager();
    this.TeamService = function () {
        if (!_teamService) {
            _teamService = new TeamService(_serviceManager);
        }
        return _teamService;
    }
    this.HomeService = function () {
        if (!_homeService) {
            _homeService = new HomeService(_serviceManager);
        }
        return _homeService;
    }
    this.NewsService = function () {
        if (!_newsService) {
            _newsService = new NewsService(_serviceManager);
        }
        return _newsService;
    }
    this.ScheduleService = function () {
        if (!_scheduleService) {
            _scheduleService = new ScheduleService(_serviceManager);
        }
        return _scheduleService;
    }
    this.PhotosService = function () {
        if (!_photosService) {
            _photosService = new PhotosService(_serviceManager);
        }
        return _photosService;
    }
}
