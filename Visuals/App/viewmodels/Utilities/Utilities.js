(function() {
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };

  define(['services/logger', './BreadCrumb'], function(logger, BreadCrumb) {
    var Utilites;
    Utilites = (function() {

      function Utilites(data) {
        this.BreadCrumbs = __bind(this.BreadCrumbs, this);

        var self;
        self = this;
        this.self = this;
        if (data !== null) {
          ko.mapping.fromJS(data, {}, this);
        }
      }

      Utilites.prototype.BreadCrumbs = function(module) {
        if (module === 'home') {
          return [
            new BreadCrumb({
              Route: '#/home',
              Tip: 'Visuals Home',
              Name: 'Home',
              Order: 0
            })
          ];
        }
      };

      return Utilites;

    })();
    return Utilites;
  });

}).call(this);
