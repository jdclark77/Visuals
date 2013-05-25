(function() {

  require.config({
    baseUrl: "/App",
    paths: {
      "text": "durandal/amd/text",
      "lib": "/Scripts",
      "data": "/Scripts/Data",
      "plugins": "/Scripts/Plugins"
    },
    waitSeconds: 15,
    shim: {
      'plugins/underscore': {
        exports: '_'
      },
      'data/Requests': {
        deps: ['plugins/amplify'],
        exports: 'amplify'
      },
      'data/Data': {
        exports: 'MockData'
      }
    },
    callback: function() {
      return alert('finished');
    }
  });

  define(['durandal/app', 'durandal/viewLocator', 'durandal/system', 'durandal/plugins/router', 'services/logger', 'plugins/underscore', 'data/Requests'], function(app, viewLocator, system, router, logger, _, amplify) {
    system.debug(true);
    return app.start().then(function() {
      toastr.options.positionClass = 'toast-bottom-right';
      toastr.options.backgroundpositionClass = 'toast-bottom-right';
      router.handleInvalidRoute = function(route, params) {
        return logger.logError('No Route Found', route, 'main', true);
      };
      router.useConvention();
      viewLocator.useConvention();
      app.adaptToDevice();
      return app.setRoot('viewmodels/shell', 'entrance');
    });
  });

}).call(this);
