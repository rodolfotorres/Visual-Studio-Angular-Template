'use strict';
window.app.factory('dataservice', [
    '$http', '$q', '$timeout', 'breeze', function ($http, $q, $timeout, breeze) {
        var serviceName = 'breeze/contacts';

        var manager = new breeze.EntityManager(serviceName);
        //manager.enableSaveQueuing(true);

        var service = {
            getContacts: getContacts
        };

        return service;

        function getContacts() {
            var query = breeze.EntityQuery.from("Contacts");

            var promise = manager.executeQuery(query).catch(queryFailed);
            return promise;

            function queryFailed(error) {
                //logger.error(error.message, "Query failed");
                return $q.reject(error); // so downstream promise users know it failed
            }
        }
    }
]);