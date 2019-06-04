(function () {
    'use strict';
    angular.module('utilServices', [])
        .service('UtilService', UtilServiceFunction);

    UtilServiceFunction.$inject = ['$http'];
    function UtilServiceFunction($http) {
        var utils = this;

        utils.getItems = function (itemsUrl, params) {
            var items = $http({
                method: "GET",
                url: itemsUrl,
                params: params
            });
            return items;
        };

        utils.postItems = function (itemsUrl, body) {
            var items = $http({
                method: "POST",
                url: itemsUrl,
                data: body,
                headers: {
                    "Content-Type": "application/json; charset=utf-8"
                }
            });
            return items;
        };
    }
})();