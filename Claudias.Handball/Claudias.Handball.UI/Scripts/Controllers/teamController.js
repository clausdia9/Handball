var TeamController = function (serviceContext, baseURL) {

    this.RenderPage = function () {
        $("#divPlayerCards").empty();
        var variable = serviceContext.TeamService().ReadAll(baseURL+"/team").then(function (allCards) {
            
            $('#progress').hide(); 
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