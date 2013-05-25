define(['services/logger'], (logger) ->
	class Pic
		constructor: (data) ->
			self = this
			@self = this
			ko.mapping.fromJS(data, {}, this)
	return Pic		
)