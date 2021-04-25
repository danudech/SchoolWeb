var Model = angular.module('School', []);
Model.controller('LoginPage', function indexMaste($scope, $http) {
    $scope.initLogin = function () {
        console.log("Login");
    };
});


Model.controller('IndexPage', function indexMaste($scope, $http) {
    $scope.initIndex = function () {
        console.log("Index");
    };
});