(function () {

    var app = angular.module([
        'ngRoute',
        'tsi.employee'
    ]);

    app.module('tsi').config(['$routeProvider', '$locationProvider', configFunction]);

    /*@ngInject*/
    function configFunction($routeProvider, $locationProvider) {
        $locationProvider.html5Mode({ enabled: true, requireBase: false }).hashPrefix('!');

        // Routes
    }
})();