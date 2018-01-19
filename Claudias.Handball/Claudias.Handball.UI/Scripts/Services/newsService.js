var NewsService = function () {
    this.ReadAll=function(){
        return $.ajax({
            type: "GET",
            url: 'http://localhost:57820/api/news',
            async: false
        }).responseText;
    }

}
