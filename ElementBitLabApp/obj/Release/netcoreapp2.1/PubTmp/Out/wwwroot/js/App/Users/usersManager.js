(function () {
    'use script';

    angular
        .module('usersmanager', [])
        .controller('UserRolesCtrl', UserRolesCtrlFunction);

    UserRolesCtrlFunction.$inject = ['UtilService', '$window', '$q', '$routeParams', '$http'];
    function UserRolesCtrlFunction(UtilService, $window, $q, $routeParams, $http) {
        var users = this;
        var baseUrl = $window.location.origin;
        var promises = [];
        promises.push(UtilService.getItems(baseUrl + '/Users/GetAllUsers'));
        promises.push(UtilService.getItems(baseUrl + '/Users/GetAllRoles'));

        $q
            .all(promises)
            .then(function (promiseResults) {
                users.usersDatas = promiseResults[0].data;
                users.userRoles = promiseResults[1].data;
            })
            .catch(function (error) {
                console.log("Error: ", error);
            });

        users.submitUserDetails = function () {

        };
    }
})();