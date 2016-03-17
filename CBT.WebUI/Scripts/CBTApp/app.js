angular.module("CBTApp", ["ngRoute"])
.config(function ($routeProvider) {
    $routeProvider.when("/batches", {
        templateUrl: "/Scripts/CBTApp/View/index.html", controller: "rootCtrl"
    })
    .when("/settings", {
        templateUrl: "/Scripts/CBTApp/View/settings.html", controller: "settingsCtrl"
    })
    .when("/questions", {
        templateUrl: "/Scripts/CBTApp/View/questions.html", controller: "questionsCtrl"
    })
    .when("/questions/add", {
        templateUrl: "/Scripts/CBTApp/View/addSq.html", controller: "AddSquestion"
    })
    .when("/questions/edit/:id", {
        templateUrl: "/Scripts/CBTApp/View/editSq.html", controller: "EditSquestion"
    })
    .when("/settings/add", {
        templateUrl: "Scripts/CBTApp/View/addSettings.html", controller: "settingsCtrl"
    })
    .otherwise({ redirectTo: "/", templateUrl: "/Scripts/CBTApp/View/index.html", controller: "rootCtrl"});
});