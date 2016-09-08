﻿//Declaring angular module
var AnguarModule = angular.module('App', []);


//Declaring angular controller
// ApiCall---This is the service name which is in ApiCallService.js file
AnguarModule.controller('AppController', function ($scope, $http, ApiCall) {
    //Intital message value
    $scope.message = "Don't Give up";

    //Load dropdown in page load event  with get api call using service
    var result = ApiCall.GetApiCall("Values", "GetDropdownList").success(function (data) {
        var data = $.parseJSON(JSON.parse(data));
        $scope.StateList = data;
    });


    $scope.btnPostCall = function () {
        var obj = {
            'stateName':'Karnataka'
        };
        //Call Post method from web api in angular controller using angular service. I am passing string value to the web api through service.
        var result = ApiCall.PostApiCall("Values", "GetResult", obj).success(function (data) {
            var data = $.parseJSON(JSON.parse(data));
            $scope.message = data;
        });
    };
  

});


