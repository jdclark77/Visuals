define(['durandal/system', 'durandal/plugins/router', 'services/logger', './Utilities/Utilities'],
    function (system, router, logger, Utilities) {
    	util = new Utilities();
    	breadCrumbsArray = util.BreadCrumbs('#/home');
	    window.router = router;
        var shell = {
            activate: activate,
            router: router,
            breadCrumbs: ko.computed(function () {
	            var route = router.activeRoute();
	            if (route != undefined) {
	            	return util.BreadCrumbs(route.url);
	            }
	            return [];
            })
        };
        
        return shell;

        //#region Internal Methods
        function activate() {
            return boot();
        }

        function boot() {
            router.mapNav('home');
            router.mapNav('details');
            log('Hot Towel SPA Loaded!', null, true);
            return router.activate('home');
        }

        function log(msg, data, showToast) {
            logger.log(msg, data, system.getModuleId(shell), showToast);
        }
        //#endregion
    });