(function () {
    'use script';

    angular.module('App', ['utilServices'])
        .controller('ExcelController', ExcelControllerFunction);

    ExcelControllerFunction.$inject = ['$q', 'UtilService'];
    function ExcelControllerFunction($q, UtilService) {
        var model = this;
        model.customers = {};
        model.products = {};
        model.excelnames = {};

        var promises = [];
        promises.push(UtilService.getItems('./GetCustomers'));
        promises.push(UtilService.getItems('./GetProducts'));
        promises.push(UtilService.getItems('./GetExcelTitles'));

        $q.all(promises)
            .then(function (promiseResults) {
                model.customers = promiseResults[0].data;
                model.products = promiseResults[1].data;
                model.excelnames = promiseResults[2].data;
            })
            .catch(function (error) {
                console.log("Error: ", error);
            });
       
        model.sendLoadForm = function () {
            if (model.excelname.length > 0) {
                UtilService.getItems('./UpdateExcelData/' + model.excelname)
                    .then(function (results) {
                        model.tabledata = results.data;
                        model.tableheaders = {};
                    })
                    .catch(function (error) {
                        console.log("Error: ", error);
                    });
            }
            
        };
    }
})();