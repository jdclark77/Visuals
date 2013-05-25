(function() {

  define(['services/logger'], function(logger) {
    var Pic;
    Pic = (function() {

      function Pic(data) {
        var self;
        self = this;
        this.self = this;
        ko.mapping.fromJS(data, {}, this);
      }

      return Pic;

    })();
    return Pic;
  });

}).call(this);
