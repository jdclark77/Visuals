(function() {
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };

  define(['require', 'services/logger', 'data/Comment'], function(require, logger, Comment) {
    var Post;
    Post = (function() {

      function Post(data) {
        this.Edit = __bind(this.Edit, this);

        var Mapping, map, self,
          _this = this;
        self = this;
        this.self = this;
        this.Avatar = ko.observable();
        this.User = ko.observable();
        this.AvatarLink = ko.observable();
        this.Message = ko.observable();
        this.Comments = ko.observableArray();
        if (data !== null) {
          Mapping = require("data/Mapping");
          map = new Mapping();
          ko.mapping.fromJS(data, map.PostMapping, this);
        }
        this.Editing = ko.observable(false);
        this.NewComment = ko.observable('');
        this.SkipAdd = ko.observable(false);
        this.CommentCreator = ko.computed(function() {
          var comment, newComment;
          if (_this.SkipAdd()) {
            return;
          }
          comment = _this.NewComment();
          if (comment !== '') {
            newComment = new Comment();
            newComment.Message(comment);
            newComment.Avatar(viewModel.MiniAvatar());
            newComment.AvatarLink(viewModel.Link());
            newComment.User(viewModel.Name());
            newComment.Id(_this.Comments().length);
            _this.Comments.push(newComment);
            _this.SkipAdd(true);
            _this.NewComment('');
            return _this.SkipAdd(false);
          }
        });
        this.Id = ko.observable();
      }

      Post.prototype.Edit = function() {
        return this.Editing(true);
      };

      return Post;

    })();
    return Post;
  });

}).call(this);
