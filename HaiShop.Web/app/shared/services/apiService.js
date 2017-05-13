(function (app) {
    app.service('apiService', apiService);

    apiService.$inject = ['$http']; //without this line code working fine in normal, but got a problem when minifile

    function apiService($http) {
        return {
            get: get
        }
        function get(url, params, success, failure) {
            $http.get(url, params).then(function (result) {
                success(result);
            }, function (error) {
                failure(error);
            });
        }
    }
})(angular.module('haishop.common'));