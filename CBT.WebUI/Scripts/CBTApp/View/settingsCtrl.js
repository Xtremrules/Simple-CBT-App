angular.module("CBTApp")
.constant("settingsUrl", "/api/settings")
.controller("settingsCtrl", function ($http, $scope, settingsUrl) {
    $scope.data.empty = null;
    $http.get(settingsUrl)
    .success(function (data) {
        if (data.length <= 0) {
            
            $scope.data.empty = true;
        }
        else {
            $scope.data.settings = data;
        }
    })
    .error(function (error) {
        $scope.error = error;
    });
});