var ServiceManager =function() {
    this.ReadAll = function (url, type) {
        return new Promise(function (resolve, reject) {
            var xhr = new XMLHttpRequest();
            xhr.onload = function () {
                resolve(this.responseText);
            };
            xhr.onerror = reject;
            xhr.open(type, url);
            xhr.send();
        });
    }
}