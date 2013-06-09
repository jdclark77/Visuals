(function() {

  amplify.request.define("Posts", "ajax", {
    url: window.Config.AppPath + "api/Breeze/Posts?user={user}",
    type: "GET",
    dataType: "json"
    /*
    	decoder: ( data, status, xhr, success, error ) ->
    		if status == "success"
    			alert('success')
    		else if status == "error"
    			alert('error')
    		return
    */

  });

}).call(this);
