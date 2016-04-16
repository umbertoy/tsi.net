(function () {

    angular.module('tsi', [
        'ngAnimate',
        'ngRoute',
        'ui.grid',
        // Custom modules 
        'tsi.employee'
    ]);

    angular.module('tsi').config(['$routeProvider', '$locationProvider', '$httpProvider', configFunction]);

    /*@ngInject*/
    function configFunction($routeProvider, $locationProvider,$httpProvider) {
        $locationProvider.html5Mode({ enabled: true, requireBase: false}).hashPrefix('!');  
        $httpProvider.defaults.useXDomain = true;
        // Routes
        $routeProvider
			.when("/", {
			    templateUrl: "/SPA/employees/employee.html",
			})
            .when("/Employees", {
                templateUrl: "/SPA/employees/employee.html"
            })
            .when("/Employees/Index", {
                templateUrl: "/SPA/employees/employee.html"
            });
    }
})();