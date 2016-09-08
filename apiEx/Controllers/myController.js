var myController = function ($scope, $http) {
    var result = ApiCall.GetApiCall("api", "tblRoads").success(function (data) {
        var data = $.parseJSON(JSON.parse(data));
        $scope.RoadList = data;
    });

    //$scope.RoadList = $http.get('api/tblRoadsController/GettblRoads');
}