myapp.service('TribonnicService', function ($http) {

    var rootURL = "http://localhost:53190/"; //URLFactory.rootURL;
    //All Requesst as per status wise
    this.GetTribonnicSeries = function (SeriesLimit, Divisibleby, Position) {
        //  var rootURL = TravelTypeFactory.rootURL;       
        return $http.get(rootURL + "/api/Tribonnic/GetSeriesValue?SeriesLimit=" + SeriesLimit + "&divisible=" + Divisibleby + "&position=" + Position);
    }

});

