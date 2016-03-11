angular.module("CBTApp")
    .constant("batchesUrl", "/api/batches")
    .controller("rootCtrl", function ($scope, $http, batchesUrl) {
        $scope.data = {};
        $http.get(batchesUrl).success(function (data) {
            if (data.length <= 0) {
                $scope.data.empty = true;
            }
            else {
                $scope.data.batches = data;
                //$scope.j = 1;
            }
        }).error(function (error) {
            $scope.data.error = error;
        });
    });