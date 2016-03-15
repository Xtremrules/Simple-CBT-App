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
});