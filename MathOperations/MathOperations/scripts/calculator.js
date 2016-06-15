var calculatorModule = angular.module('calculatorApp', []);

calculatorModule.controller('calculatorController', ['$scope', '$http', function ($scope, $http) {

    var operationEndpoint = {
        "+": "add",
        "-": "substract",
        "*": "multiply",
        "/": "divide",
    };

    $scope.operation = "";

    $scope.calculate = function () {
        $http.post("/api/" + operationEndpoint[$scope.operation], { number1: $scope.number1, number2: $scope.number2 }).then(function (result) {
            $scope.result = result.data;

            getHistory();
        });
    }

    function getHistory() {

        $http.get("/api/history", { params: { count: 5 } }).then(function (result) {
            $scope.history = result.data;
        });
    }

    getHistory();
}]);