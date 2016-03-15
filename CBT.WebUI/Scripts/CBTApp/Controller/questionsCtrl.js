angular.module("CBTApp")
    .constant("SQuestions", "api/squestions")
.controller("questionsCtrl", function ($scope, $http, SQuestions) {
    $scope.data.empty = null;
    $http.get(SQuestions).success(function (data) {
        if (data.length <= 0) {
            $scope.data.empty = true;
        }
        else {
            $scope.data.SQuestions = data;
        }
    })
})
.controller("AddSquestion", function ($scope, $http, SQuestions, $location) {
    //$location.path("/settings");
    //if (Settings.length <= 0) {
    //    $location.path("/settings");
    //}
    //$scope.data.settings = Settings;

    $http.get("api/settings").success(function (data) {
        $scope.data.settings = data;
    });
    console.log("Settings: ", $scope.data.settings);
    $scope.AddSq = function (Sqmodel) {
        var model = angular.copy(Sqmodel);
        $http.post(SQuestions, model).success(function () {
            $location.path("/questions");
        });
    }
});