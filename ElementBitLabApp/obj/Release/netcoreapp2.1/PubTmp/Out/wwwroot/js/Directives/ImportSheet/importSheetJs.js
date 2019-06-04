(function () {
    'use strict';

    angular
        .module('importSheetJs', [])
        .directive('filesModel', FilesModelDirective);

    function FilesModelDirective() {
        return {
            require: "ngModel",
            link: function postLink(scope, elem, attrs, ngModel) {
                elem.on("change", function (e) {
                    var files = elem[0].files;
                    ngModel.$setViewValue(files);
                })
            }
        }
    }
})();