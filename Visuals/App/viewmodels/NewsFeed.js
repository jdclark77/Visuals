(function() {
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };

  define(['services/logger', 'data/Mapping', 'data/Data'], function(logger, Mapping, MockData) {
    var NewsFeeds;
    NewsFeeds = (function() {

      function NewsFeeds(posts) {
        this.activate = __bind(this.activate, this);

        this.DisableHref = __bind(this.DisableHref, this);

        this.NextPicPage = __bind(this.NextPicPage, this);

        this.PrevPicPage = __bind(this.PrevPicPage, this);

        this.PostLoad = __bind(this.PostLoad, this);

        this.GetPosts = __bind(this.GetPosts, this);

        this.init = __bind(this.init, this);

        this.Edit = __bind(this.Edit, this);

        this.LogIn = __bind(this.LogIn, this);

        var self,
          _this = this;
        self = this;
        this.self = this;
        this.title = ko.observable('News Feeds');
        this.Name = ko.observable();
        this.AppPath = ko.observable();
        this.Profile = ko.observable();
        this.ShowLoading = ko.observable(true);
        this.Posts = ko.observableArray();
        this.MiniAvatar = ko.observable();
        this.Link = ko.observable();
        this.Pics = ko.observableArray();
        this.Page = ko.observable(0);
        this.MaxPicPage = ko.computed((function() {
          var numPics;
          numPics = _this.Pics().length;
          return Math.ceil(numPics / 12) - 1;
        }));
        this.DisplayPics = ko.computed(function() {
          var picStart, selectedList;
          picStart = _this.Page() * 12;
          selectedList = _.rest(_this.Pics(), picStart);
          return _.first(selectedList, 12);
        });
        this.InterestingPics = ko.observableArray();
        this.InterestingPage = ko.observable(0);
        this.InterestingMaxPage = ko.computed((function() {
          var numPics;
          numPics = _this.InterestingPics().length;
          return Math.ceil(numPics / 12) - 1;
        }));
        this.DisplayInterestingPics = ko.computed(function() {
          var picStart, selectedList;
          picStart = _this.InterestingPage() * 12;
          selectedList = _.rest(_this.InterestingPics(), picStart);
          return _.first(selectedList, 12);
        });
        this.LoggingIn = ko.observable(false);
        this.DomTree = ko.observable();
        this.GetPosts();
      }

      NewsFeeds.prototype.LogIn = function() {
        return this.LoggingIn(true);
      };

      NewsFeeds.prototype.Edit = function(val) {
        return val.Editing(true);
      };

      NewsFeeds.prototype.init = function(s) {};

      NewsFeeds.prototype.GetPosts = function() {
        var self,
          _this = this;
        self = this.self;
        return amplify.request({
          resourceId: "Posts",
          data: {
            user: "amplifyjs"
          },
          success: function(data) {
            var map;
            window.viewModel = _this;
            map = new Mapping();
            ko.mapping.fromJS(MockData, map.SocialNetworkMapping, _this);
          },
          error: function(message, level) {
            alert("always handle errors with alerts.");
          }
        });
      };

      NewsFeeds.prototype.PostLoad = function() {
        this.ShowLoading(false);
      };

      NewsFeeds.prototype.PrevPicPage = function() {
        var newPage;
        if (this.Page() !== 0) {
          newPage = this.Page() - 1;
          return this.Page(newPage);
        }
      };

      NewsFeeds.prototype.NextPicPage = function() {
        var newPage;
        if (this.Page() !== this.MaxPicPage()) {
          newPage = this.Page() + 1;
          return this.Page(newPage);
        }
      };

      NewsFeeds.prototype.DisableHref = function(disableLink, element) {
        if (disableLink) {
          return '';
        }
        return '#';
      };

      NewsFeeds.prototype.activate = function() {
        logger.log('News View Activated', null, 'details', true);
        return true;
      };

      return NewsFeeds;

    })();
    return NewsFeeds;
  });

}).call(this);
