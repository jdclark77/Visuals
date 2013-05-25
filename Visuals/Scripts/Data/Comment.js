(function() {

  define(['services/logger'], function(logger) {
    var Comment;
    Comment = (function() {

      function Comment(data) {
        var self;
        self = this;
        this.self = this;
        this.Avatar = ko.observable();
        this.User = ko.observable();
        this.AvatarLink = ko.observable();
        this.Message = ko.observable();
        this.Id = ko.observable();
        if (data !== null) {
          ko.mapping.fromJS(data, {}, this);
        }
      }

      return Comment;

    })();
    return Comment;
  });

}).call(this);
