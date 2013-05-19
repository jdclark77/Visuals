define(['services/logger'], (logger) ->
	
	class Feeds
		constructor: ()	->
			@title = ko.observable('Feeds')
		activate: () =>
			logger.log('Feeds View Activated', null, 'details', true);
			return true;

	
	return Feeds
	

)