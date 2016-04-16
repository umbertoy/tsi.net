(function () {
    'use strict';
    angular.module('tsi.employee').controller('myCtrl',['$scope',myCtrl] );
    
    function myCtrl($scope) {
        $scope.myVariable = "John";
    }
    //'employeesCtrl', ['$scope', 'employeesService', employeesCtrl]);

    //function employeesCtrl($scope,employeesService) {
        
    //    $scope.myVariable = 'hello there';
    //    //function getemployees() {
    //    //   employeesservice.getemployees().then(function (response) {
    //    //       $scope.employees = response.data;
    //    //   }, function (error) {
    //    //       $scope.status = 'unable to retrieve employees: ' + error.message;
    //    //   });
    //    //}
    //}
})();