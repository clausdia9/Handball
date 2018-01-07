var MenuController = function () {
    //trick to preserve the instance of the MenuController where 'this' changes its meaning
    var _self = this;

    var _menuElements = [
        {
            Id: "Home",
            ContainerId: "divHomeContainer",
        },
        {
            Id: "News",
            ContainerId: "divNewsContainer"
        },
        {
            Id: "Team",
            ContainerId: "divTeamContainer"
        },
        {
            Id: "Schedule",
            ContainerId: "divScheduleContainer"
        },
        {
            Id: "Photos",
            ContainerId: "divPhotosContainer"
        },
        {
            Id: "SignIn",
            ContainerId: "divSignInContainer"
        },
        {
            Id: "LogIn",
            ContainerId: "divLogInContainer"
        },
        {
            Id: "Search",
            ContainerId:"divSearchContainer"
        }
    ];

    this.GenerateMenu = function () {
        var jqNavbarContainer = $("#navbarContainer"); //ul ID
       for (i = 0; i < _menuElements.length; i++) {
            //this creates a li jQuery object
               if (_menuElements[i].Id.localeCompare("Search") == 0)
                   //var jqListItem = $("<li id='" + _menuElements[i].Id + "' class='nav-item'>")
                     //  .append("<a class='nav-link' href='#" + _menuElements[i].Id + "'>" +"<form class='form-inline'> <input class='form-control' type='text' placeholder='Search' id='link-box'> <button class='btn btn-dark' type='submit'  onclick='window.location = document.getElementById('link-box').placeholder;'>Search</button> </form>"+ "</a>");
                   var jqListItem = $("<form class='form-inline'>").append("<input class='form-control' type='text' placeholder='Search' id='link-box'>")
                      .append("<button class='btn btn-dark' type='submit'  onclick='window.location = document.getElementById('link-box').placeholder;'>Search</button> </form>");
               else
                   var jqListItem = $("<li id='" + _menuElements[i].Id + "' class='nav-item'>")
                       .append("<a class='nav-link' href='#" + _menuElements[i].Id+"'><b>" + _menuElements[i].Id + "</b></a>");
            jqNavbarContainer.append(jqListItem);
        }

        jqNavbarContainer.on("click", "li", goToPage);
    }

    function goToPage() {
        var jqSelectedListItem = $(this); //'this' is not the same as the one from 'this.GenerateMenu'
        //get the id of the clicked list item
        var selectedId = jqSelectedListItem.attr("id");
        //get the containerId for the selected Id
        var selectedContainerId;
        for (index = 0; index < _menuElements.length; index++) {
            if (_menuElements[index].Id === selectedId) {
                selectedContainerId = _menuElements[index].ContainerId;
                //we found it, we exit the for
                break;
            }
        }

        if (!selectedContainerId)//is not undefined, null or ''
            return;
       
        
        var mainContainers = $("main > div");
        for (i = 0; i < mainContainers.length; i++) {
            if (mainContainers[i].id != selectedContainerId) {
                $(mainContainers[i]).hide();
            }
            else {
                $(mainContainers[i]).show();
            }
        }
     
    }
}
if (!location.hash) {

    // default to #home
    location.hash = "#Home";
}
