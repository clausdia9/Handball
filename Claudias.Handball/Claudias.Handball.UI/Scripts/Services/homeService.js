var HomeService = function () {

    this.ReadAll=function (url) {
        return new Promise(function (resolve, reject) {
            var xhr = new XMLHttpRequest();
            xhr.onload = function () {
                resolve(this.responseText);
            };
            xhr.onerror = reject;
            xhr.open('GET', url);
            xhr.send();
        });
    }
}