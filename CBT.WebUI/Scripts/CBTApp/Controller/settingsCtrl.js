angular.module("CBTApp")
.constant("settingsUrl", "/api/settings")
.controller("settingsCtrl", function ($http, $scope, settingsUrl, $location) {
    $scope.data.empty = null;
    $http.get(settingsUrl)
    .success(function (data) {
        if (data.length <= 0) {

            $scope.data.empty = true;
        }
        else {
            $scope.data.settings = data;
            $scope.j = 0;
        }
    })
    .error(function (error) {
        $scope.error = error;
    });

    $scope.Addsettings = function (AddSettingsmodel) {
        var settings = angular.copy(AddSettingsmodel);
        $http.post(settingsUrl, settings).success(function (data) {

        })
        .error(function (error) {
            $scope.error = error;
        }).finally(function () {
            $scope.data.AddSettings = null;
            $location.path("/settings");
        });
    }
});