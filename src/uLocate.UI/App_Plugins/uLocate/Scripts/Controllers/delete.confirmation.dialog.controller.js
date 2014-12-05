﻿(function (controllers, undefined) {

    controllers.DeleteConfirmationDialogController = function ($scope, dialogService) {

        /*-------------------------------------------------------------------
         * Initialization Methods
         * ------------------------------------------------------------------*/

        /**
         * @ngdoc method
         * @name init
         * @function
         * 
         * @description - Called when the $scope is initalized.
         */
        $scope.init = function () {
        };

        /*-------------------------------------------------------------------
         * Event Handler Methods
         *-------------------------------------------------------------------*/

        /*-------------------------------------------------------------------
         * Helper Methods
         * ------------------------------------------------------------------*/

        /*-------------------------------------------------------------------*/

        $scope.init();
    };

    angular.module('umbraco').controller('uLocate.Controllers.DeleteConfirmationDialogController', ['$scope', 'dialogService', uLocate.Controllers.DeleteConfirmationDialogController]);


}(window.uLocate.Controllers = window.uLocate.Controllers || {}));