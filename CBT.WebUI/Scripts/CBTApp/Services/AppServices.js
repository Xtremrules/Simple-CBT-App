angular.module("CBTApp")
 .constant("SettingsUrl", "/api/settings")
.factory("Settings", function ($http, SettingsUrl) {
    var result = null;
    //$http.get(SettingsUrl).success(function (data) {
    //    result = data;
    //});
    //return result;
    return function () {
        $http.get(SettingsUrl).success(function (data) {
                result = data;
        });
        return result;
    }
})