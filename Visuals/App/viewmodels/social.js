define(['services/logger'], function (logger) {
    var vm = {
        activate: activate,
        title: 'Social View'
    };

    return vm;

    //#region Internal Methods
    function activate() {
        logger.log('Social View Activated', null, 'social', true);
        return true;
    }
    //#endregion
});