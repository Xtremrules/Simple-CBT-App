angular.module("CBTApp")
.constant("settingsUrl", "/api/settings")
.controller("settingsCtrl", function ($http, $scope, settingsUrl, $location, Settings) {
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

    $scope.delete = function (id) {
        var nu = angular.copy(id);
        $http.delete((settingsUrl + "/" + nu)).success(function(data){})
        .error(function (error){
            $scope.error = error;
        }).finally(function (){
            $scope.data.settings = Settings;
            $location.path("/settings");
        });
    }
});