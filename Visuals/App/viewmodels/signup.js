(function() {
  var __bind = function(fn, me){ return function(){ return fn.apply(me, arguments); }; };

  define(['services/logger'], function(logger) {
    var SignUp;
    SignUp = (function() {

      function SignUp() {
        this.activate = __bind(this.activate, this);
        this.title = ko.observable('Sign-Up');
      }

      SignUp.prototype.activate = function() {
        logger.log('Signup View Activated', null, 'details', true);
        return true;
      };

      return SignUp;

    })();
    return SignUp;
  });

}).call(this);
