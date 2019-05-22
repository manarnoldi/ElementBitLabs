(function () {
    'use strict';
    angular.module('utilServices', [])
        .service('UtilService', UtilServiceFunction);

    UtilServiceFunction.$inject = ['$http'];
    function UtilServiceFunction($http) {
        var utils = this;

        utils.getItems = function (itemsUrl) {
            var items = $http({
                method: "GET",
                url: itemsUrl
            });
            return items;
        };

    }
})();