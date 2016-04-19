(function () {
    'use strict';
    tsiApp.controller("employeesCtrl", ['$scope', 'employeesService', 'uiGridConstants', employeesCtrl]);

    function employeesCtrl($scope, employeesService, uiGridConstants) {
        $scope.highlightFilteredHeader = function (row, rowRenderIndex, col, colRenderIndex) {
            if (col.filters[0].term) {
                return 'header-filtered';
            } else {
                return '';
            }
        };

        $scope.init = function () {
            $scope.gridOptions = {
                enableFiltering: true,
                columnDefs: [
                  // default
                  { field: 'Nombre', headerCellClass: $scope.highlightFilteredHeader },
                  // pre-populated search field
                  {
                      field: 'Tipo', headerCellClass: $scope.highlightFilteredHeader
                  },
                  // no filter input
                  { field: 'FechaInicio', displayName: "Fecha Inicio", headerCellClass: $scope.highlightFilteredHeader },
                  { field: 'Salario', headerCellClass: $scope.highlightFilteredHeader },
                  { field: 'TarifaHora', displayName: "Tarifa/Hora", headerCellClass: $scope.highlightFilteredHeader }
                ]
            };
            employeesService.getEmployees().then(function (response) {
                $scope.employees = response.data;
                $scope.gridOptions.data = $scope.employees;
            }, function (error) {
                alert("error");
                $scope.status = 'Unable to retrieve employees: ' + error.message;
            });
        };

        $scope.reloadGrid = function(){
            employeesService.getEmployees().then(function (response) {
                $scope.employees = response.data;
                $scope.gridOptions.data = $scope.employees;
            }, function (error) {
                alert("error");
                $scope.status = 'Unable to retrieve employees: ' + error.message;
            });
        }

    }
})()