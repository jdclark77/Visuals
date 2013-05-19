(function() {
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };

  define(['services/logger'], function(logger) {
    var Feeds;
    Feeds = (function() {

      function Feeds() {
        this.activate = __bind(this.activate, this);
        this.title = ko.observable('Feeds');
      }

      Feeds.prototype.activate = function() {
        logger.log('Feeds View Activated', null, 'details', true);
        return true;
      };

      return Feeds;

    })();
    return Feeds;
  });

}).call(this);
