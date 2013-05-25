require.config(
	baseUrl: "/App"
	paths:
		"text": "durandal/amd/text" 
		"lib": "/Scripts"
		"data": "/Scripts/Data"
		"plugins": "/Scripts/Plugins"
	waitSeconds: 15
	shim:
		'plugins/underscore': 
			exports: '_'
		'data/Requests': 
			deps: ['plugins/amplify'],
			exports: 'amplify'
		'data/Data':
			exports: 'MockData'
	callback: () ->
		alert('finished')
)
define(['durandal/app', 'durandal/viewLocator', 'durandal/system', 'durandal/plugins/router', 'services/logger', 'plugins/underscore', 'data/Requests'],
(app, viewLocator, system, router, logger, _, amplify) ->
	
	# Enable debug message to show in the console 
	system.debug(true);

	app.start().then( () ->
		toastr.options.positionClass = 'toast-bottom-right';
		toastr.options.backgroundpositionClass = 'toast-bottom-right';

		router.handleInvalidRoute =  (route, params) ->
			logger.logError('No Route Found', route, 'main', true);
		

		# When finding a viewmodel module, replace the viewmodel string 
		# with view to find it partner view.
		router.useConvention();
		viewLocator.useConvention();
        
		# Adapt to touch devices
		app.adaptToDevice();
		#Show the app by setting the root view model for our application.
		app.setRoot('viewmodels/shell', 'entrance');
	)
)