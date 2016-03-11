angular.module("CBTApp", ["ngRoute"])
.config(function ($routeProvider) {
    //$routeProvider.otherwise({ templateUrl: "/Scripts/CBTApp/home/index.html" });
    $routeProvider.when("/batches", {
        templateUrl: "/Scripts/CBTApp/View/index.html", controller: "rootCtrl"
    })
    .when("/settings", {
        templateUrl: "/Scripts/CBTApp/View/settings.html", controller: "settingsCtrl"
    })
    .when("/questions", {
        templateUrl: "/Scripts/CBTApp/View/questions.html", controller: "questionsCtrl"
    })
    .otherwise({ redirectTo: "/", templateUrl: "/Scripts/CBTApp/home/index.html", controller: "rootCtrl" });
});