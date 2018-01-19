var TeamController = function (serviceContext) {

    this.RenderPage = function () {
        var variable = serviceContext.TeamService().ReadAll('http://localhost:57820/api/team').then(function (allCards) {
            //console.log(allCards);
             for (var i = 0; i < JSON.parse(allCards).length; i++) {
               var teamPlayerCardController = new TeamPlayerCardController("divPlayerCards", JSON.parse(allCards)[i]);
               teamPlayerCardController.RenderCard();
             }
        })
            .catch(function () {
                console.log("error");
            });
    }
}