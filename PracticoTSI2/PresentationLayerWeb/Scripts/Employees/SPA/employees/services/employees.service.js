(function () {
    'use strict';
    tsiApp.service('employeesService', ["$http", "$q", employeeService]);

    function employeeService($http, $q) {
        var urlBase = 'http://localhost:52905/api/ServiceEmployees/';
        
        var employeeService = {};

        employeeService.getEmployees = function () {
            return $http.get(urlBase);
        };

        return employeeService;
    }
})();