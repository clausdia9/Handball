var PlayersController = function (serviceContext) {

    this.RenderPage = function () {
        var allPlayers = serviceContext.PlayerService().ReadAll();
        for (var i = 0; i < allPlayers.length; i++) {
            var playerCardController = new PlayerCardController("divPlayerCards", allPlayers[i]);
            playerCardController.RenderCard();
        }
    }
}