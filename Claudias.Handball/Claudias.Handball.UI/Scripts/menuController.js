var MenuController = function (serviceContext) {

    var _self = this;

    var _playerController = new PlayersController(serviceContext);

    var _homeController = new HomeController(serviceContext);

    var _newsController = new NewsController(serviceContext);

    var _scheduleController = new ScheduleController(serviceContext);

    var multi = {};

    var _menuElements = [
        {
            Id: "Home",
            ContainerId: "divHomeContainer",
            Controller: _homeController
        },
        {
            Id: "News",
            ContainerId: "divNewsContainer",
            Controller: _newsController
        },
        {
            Id: "Team",
            ContainerId: "divTeamContainer",
            Controller: _playerController
        },
        {
            Id: "Schedule",
            ContainerId: "divScheduleContainer",
            Controller: _scheduleController
        },
        {
            Id: "Photos",
            ContainerId: "divPhotosContainer",
            Controller: null
        },
        {
            Id: "SignIn",
            ContainerId: "divSignInContainer",
            Controller: null
        },
        {
            Id: "LogIn",
            ContainerId: "divLogInContainer",
            Controller: null
        },
        {
            Id: "Search",
            ContainerId: "divSearchContainer",
            Controller: null
        }
    ];

    this.GenerateMenu = function () {
        var jqNavbarContainer = $("#navbarContainer");
        for (i = 0; i < _menuElements.length; i++) {
               if (_menuElements[i].Id.localeCompare("Search") == 0)
                   var jqListItem = $("<form class='form-inline'>").append("<input class='form-control' type='text' placeholder='Search' id='link-box'>")
                      .append("<button class='btn btn-dark' type='submit'  onclick='window.location = document.getElementById('link-box').placeholder;'>Search</button> </form>");
               else
                   var jqListItem = $("<li id='" + _menuElements[i].Id + "' class='nav-item'>")
                       .append("<a class='nav-link' href='#'><b>" + _menuElements[i].Id + "</b></a>");
            jqNavbarContainer.append(jqListItem);
        }

        jqNavbarContainer.on("click", "li", goToPage);
    }

    function goToPage() {
        var jqSelectedListItem = $(this); 
        var selectedId = jqSelectedListItem.attr("id");
        var selectedContainerId;

        for (index = 0; index < _menuElements.length; index++) {
            if (_menuElements[index].Id === selectedId) {
                selectedContainerId = _menuElements[index].ContainerId;
                menuElementId = index;
                break;
            }
        }

        if (!selectedContainerId)
            return;
        
        var mainContainers = $("main > div");
        for (i = 0; i < mainContainers.length; i++) {
            if (mainContainers[i].id != selectedContainerId) {
                $(mainContainers[i]).hide();
            }
            else {
                $(mainContainers[i]).show();
                if (multi[_menuElements[menuElementId].ContainerId] != 1) {
                    _menuElements[menuElementId].Controller.RenderPage();
                    multi[_menuElements[menuElementId].ContainerId] = 1;
                }
            }
        }
        
    }
}

