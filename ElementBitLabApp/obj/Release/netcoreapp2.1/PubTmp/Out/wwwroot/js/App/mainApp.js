(function () {
    'use strict';

    var app = angular.module('App', ['utilServices', 'directives.dirPagination', 'ngRoute', 'uploadsmodule', 'usersmanager']);
    app.config(['$routeProvider', function ($routeprovider) {
        $routeprovider.
            when('/ExcelUploads/Details/:id', {
                controller: 'UploadExcelCtrl'
            });
    }]);

})();