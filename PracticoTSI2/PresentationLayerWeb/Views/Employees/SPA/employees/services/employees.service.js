(function () {
    'use strict';
    angular.module('tsi.employee').service('employeesService', ["$http", "$q", employeeService]);

    function employeeService($http, $q) {
        var urlBase = 'http://localhost/api/ServiceEmployees/';
        
        var employeeService = {};

        employeeService.getEmployees = function () {
            return $http.get(urlBase);
        };


        return employeeService;
    }
})();