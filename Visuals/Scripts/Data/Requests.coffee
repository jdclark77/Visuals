amplify.request.define( "Posts", "ajax", {
	url: window.Config.AppPath + "Breeze/Posts"
	type: "POST"
	dataType: "json"
	# If success and error functions aren't defined in the request call, the decoder below can be defined 
	# which will always be called
	###
	decoder: ( data, status, xhr, success, error ) ->
		if status == "success"
			alert('success')
		else if status == "error"
			alert('error')
		return
	###
	
    
    
});