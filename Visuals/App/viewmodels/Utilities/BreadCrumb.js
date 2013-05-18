(function() {

  define(['services/logger'], function(logger) {
    var BreadCrumb;
    BreadCrumb = (function() {

      function BreadCrumb(data) {
        var self;
        self = this;
        this.self = this;
        this.Route = ko.observable();
        this.Tip = ko.observable();
        this.Name = ko.observable();
        this.Order = ko.observable();
        if (data !== null) {
          ko.mapping.fromJS(data, {}, this);
        }
      }

      return BreadCrumb;

    })();
    return BreadCrumb;
  });

}).call(this);
