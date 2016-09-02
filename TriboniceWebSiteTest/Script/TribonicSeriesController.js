
myapp.controller('TribonnicController', function ($scope, TribonnicService)
{

    alert('asdf');
    $scope.SeriesLimit = "";
    $scope.Divisibleby = "";
    $scope.Position = "";


    $scope.FetchSeries = function () {
        debugger;
        alert('Hi');
        var promiseGet = TribonnicService.GetTribonnicSeries($scope.SeriesLimit, $scope.Divisibleby, $scope.Position);
        promiseGet.then(function (p) {
            alert(p);
            debugger;
            alert('asdf');
            $scope.result = p.data.Result;
            $scope.TribonicSericesList = p.data.Series;
        },
              function (errorPl) {
                  $log.error('Some Error in Getting Records.', errorPl);
              });
    }

   
});




