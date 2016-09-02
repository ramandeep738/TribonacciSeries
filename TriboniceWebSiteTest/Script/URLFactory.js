myapp.controller('URLFactory', function ($location) {
    alert('adsfasdfasdf');
    var FactoryRootURL = {}
    return FactoryRootURL.rootURL = "http://localhost:55681/";
 //return   FactoryRootURL.rootURL = $location.protocol() + "://" + $location.host() + ":" + $location.port();
    
});