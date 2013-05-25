(function() {

  define(['services/logger', 'data/Data', 'data/Post', 'data/Pic', 'data/Comment'], function(logger, MockData, Post, Pic, Comment) {
    var Mapping;
    Mapping = (function() {

      function Mapping(posts) {
        this.SocialNetworkMapping = {
          'Posts': {
            create: function(options) {
              return new Post(options.data);
            }
          },
          'Pics': {
            create: function(options) {
              return new Pic(options.data);
            }
          },
          'InterestingPics': {
            create: function(options) {
              return new Pic(options.data);
            }
          }
        };
        this.PostMapping = {
          'Comments': {
            create: function(options) {
              return new Comment(options.data);
            }
          }
        };
      }

      return Mapping;

    })();
    return Mapping;
  });

}).call(this);
