define(['services/logger'], (logger) ->
	
	class Store
		constructor: ()	->
			@title = ko.observable('Store')
		activate: () =>
			logger.log('Feeds View Activated', null, 'details', true);
			return true;

	
	return Store
	

)