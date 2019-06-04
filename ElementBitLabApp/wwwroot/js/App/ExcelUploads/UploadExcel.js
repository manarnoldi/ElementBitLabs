(function () {
    'use strict';

    angular
        .module('uploadsmodule', ['importSheetJs', 'ngFileUpload', 'ngHandsontable'])
        .controller('UploadExcelCtrl', UploadExcelCtrlFunction);

    UploadExcelCtrlFunction.$inject = ['UtilService', '$window', '$q', '$routeParams', '$http'];
    function UploadExcelCtrlFunction(UtilService, $window, $q, $routeParams, $http) {
        var upload = this;
        var baseUrl = $window.location.origin;
        var excelIdArr = $window.location.href.split('/');
        var excelId = excelIdArr[excelIdArr.length - 1];
        var promises = [];
        promises.push(UtilService.getItems(baseUrl + '/ExcelUploads/GetExcel'));
        promises.push(UtilService.getItems(baseUrl + '/ExcelUploads/GetClients'));
        promises.push(UtilService.getItems(baseUrl + '/ExcelUploads/GetDisciplines'));
        if (!isNaN(excelId)) {
            var params = { excelid: excelId };
            promises.push(UtilService.getItems(baseUrl + '/ExcelUploads/GetExcelDetails', params));
        }
        $q
            .all(promises)
            .then(function (promiseResults) {
                upload.excelDatas = promiseResults[0].data;
                upload.clients = promiseResults[1].data;
                upload.disciplines = promiseResults[2].data;
                upload.viewData = [];
                if (promiseResults[3]) {
                    upload.viewData = JSON.parse(promiseResults[3].data.excelData);
                    upload.viewDataColsTitles = Object.keys(upload.viewData[0]);
                    upload.readOnlyCols = Object.values(upload.viewData[0]);
                    upload.viewDataCols = [];
                    for (var i = 0; i < upload.viewDataColsTitles.length; i++) {
                        var viewDataCol = {};
                        viewDataCol.title = upload.viewDataColsTitles[i];
                        viewDataCol.data = upload.viewDataColsTitles[i];
                        viewDataCol.readOnly = !upload.readOnlyCols[i];
                        upload.viewDataCols.push(viewDataCol);
                    }
                }
            })
            .catch(function (error) {
                console.log("Error: ", error);
            });

        upload.uploadUpdatedData = function () {
            if (!isNaN(excelId)) {
                var excelUpload = {
                    Id: excelId,
                    ExcelData: JSON.stringify(upload.viewData)
                };

                var body = JSON.stringify(excelUpload);
                UtilService
                    .postItems(baseUrl + '/ExcelUploads/PostExcelUpdatedData', body)
                    .then(function (results) {
                        $window.location = baseUrl + '/ExcelUploads';
                    })
                    .catch(function (error) {
                        console.log("Error: ", error);
                    });
            }

        };

        upload.loadProjects = function () {
            upload.projects = [];
            var params = { clientName: upload.client.clientName };
            UtilService
                .getItems(baseUrl + '/ExcelUploads/GetProjects', params)
                .then(function (results) {
                    upload.projects = results.data;
                })
                .catch(function (error) {
                    console.log("Error: ", error);
                });
        };

        upload.loadBuildings = function () {
            upload.buildings = [];
            var params = { projectName: upload.project.projectName };
            UtilService
                .getItems(baseUrl + '/ExcelUploads/GetBuildings', params)
                .then(function (results) {
                    upload.buildings = results.data;
                })
                .catch(function (error) {
                    console.log("Error: ", error);
                });
        };

        upload.SelectFile = function (file) {
            upload.SelectedFile = file;
            upload.ExcelName = file.name;
        };

        upload.submitFile = function () {
            var regex = /^([a-zA-Z0-9\s_\\.\-:])+(.xls|.xlsx)$/;
            if (regex.test(upload.SelectedFile.name.toLowerCase())) {
                if (typeof (FileReader) != "undefined") {
                    var reader = new FileReader();
                    if (reader.readAsBinaryString) {
                        reader.onload = function (e) {
                            upload.ProcessExcel(e.target.result);
                        };
                        reader.readAsBinaryString(upload.SelectedFile);
                    } else {
                        reader.onload = function (e) {
                            var data = "";
                            var bytes = new Uint8Array(e.target.result);
                            for (var i = 0; i < bytes.byteLength; i++) {
                                data += String.fromCharCode(bytes[i]);
                            }
                            upload.ProcessExcel(data);
                        };
                        reader.readAsArrayBuffer(upload.SelectedFile);
                    }
                } else {
                    $window.alert("This browser does not support HTML5.");
                }
            } else {
                $window.alert("Please upload a valid Excel file.");
            }
        };

        upload.ProcessExcel = function (data) {
            var workbook = XLSX.read(data, {
                type: 'binary'
            });
            var firstSheet = workbook.SheetNames[0];
            var excelRows = XLSX.utils.sheet_to_row_object_array(workbook.Sheets[firstSheet]);
            upload.Exceldatas = excelRows;
            var excelUpload = {
                DisciplineId: upload.discipline.id,
                BuildingId: upload.building.id,
                ExcelName: upload.ExcelName,
                ExcelData: JSON.stringify(excelRows)
            };

            var body = JSON.stringify(excelUpload);

            UtilService
                .postItems(baseUrl + '/ExcelUploads/PostExcelData', body)
                .then(function (results) {
                    $window.location = baseUrl + '/ExcelUploads';
                })
                .catch(function (error) {
                    console.log("Error: ", error);
                });
        };

        upload.openExcel = function (uploadId) {
            $window.location = baseUrl + '/ExcelUploads/Details/' + uploadId;
        };

        upload.downloadExcel = function (uploadId) {
            var params = { excelid: uploadId };
            UtilService
                .getItems(baseUrl + '/ExcelUploads/GetExcelDetails', params)
                .then(function (results) {
                    var toDownloadExcelData = JSON.parse(results.data.excelData);
                    var ws = XLSX.utils.json_to_sheet(toDownloadExcelData);
                    /* add to workbook */
                    var wb = XLSX.utils.book_new();
                    XLSX.utils.book_append_sheet(wb, ws, "Sheet1");
                    /* write workbook and force a download */
                    XLSX.writeFile(wb, results.data.excelName);
                })
                .catch(function (error) {
                    console.log("Error: ", error);
                });
        };

        upload.deleteExcel = function (uploadId) {
            if (!isNaN(uploadId)) {
                var excelUpload = {
                    Id: uploadId
                };

                var body = JSON.stringify(excelUpload);
                UtilService
                    .postItems(baseUrl + '/ExcelUploads/DeleteExcelData', body)
                    .then(function (results) {
                        $window.location = baseUrl + '/ExcelUploads';
                    })
                    .catch(function (error) {
                        console.log("Error: ", error);
                    });
            }
        };
    }
})();