var Model = angular.module('School', []);
Model.controller('LoginPage', function indexMaste($scope, $http, $window, $location) {
    $scope.RegisterLink = "/Home/Register";

    $scope.initLogin = function () {
        console.log("Login");
    };
    $scope.Login = function () {
        console.log("Login");
        $http({
            method: "GET",
            url:"/Home/Loginfn",
            datatype: "Json"
        }).then(function (response) {
            if (response.data.status == true) {
                    $window.location.href = response.data.link;
            }
        });
    }


});


Model.controller('IndexPage', function indexMaste($scope, $http) {
    $scope.initIndex = function () {
        console.log("Index");
    };
});