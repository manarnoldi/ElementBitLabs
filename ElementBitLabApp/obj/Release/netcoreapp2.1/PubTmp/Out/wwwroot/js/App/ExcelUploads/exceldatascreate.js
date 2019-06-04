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

                model.customer = model.customers[0];
                model.product = model.products[0];
                model.excelname = model.excelnames[0];
            })
            .catch(function (error) {
                console.log("Error: ", error);
            });
       
        model.findExcelData = function () {
            if (model.excelname.length > 0) {
                var url = './FindExcelData';
                var params = { excelName: model.excelname };
                UtilService.getItems(url, params)
                    .then(function (results) {
                        model.tabledata = results.data;
                        model.tableheaders = function () {
                            var headers = [];
                            _.forEach(model.tabledata, function (dt) {
                                if (dt.row == 1) {
                                    headers.push(dt);
                                }
                            });
                            return headers;
                        };
                        model.tablebody = function () {
                            var bodyrows = [];
                            var bodyrow = [];
                            _.forEach(model.tabledata, function (db) {                                
                                if (db.row != 0 && db.row == 2 && db.row == 3) {
                                    if (db.column == 0) {
                                        if (bodyrow.length > 0) {
                                            bodyrows.push(bodyrow);
                                        }
                                        bodyrow = [];
                                        bodyrow.push(db);
                                    } else {
                                        bodyrow.push(db);
                                    }

                                    bodyrows.push(db);
                                }
                            });
                            return bodyrows;
                        };
                    })
                    .catch(function (error) {
                        console.log("Error: ", error);
                    });
            }
            
        };
    }
})();