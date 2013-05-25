(function() {
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };

  define(['services/logger'], function(logger) {
    var Store;
    Store = (function() {

      function Store() {
        this.activate = __bind(this.activate, this);
        this.title = ko.observable('Store');
      }

      Store.prototype.activate = function() {
        logger.log('Feeds View Activated', null, 'details', true);
        return true;
      };

      return Store;

    })();
    return Store;
  });

}).call(this);
