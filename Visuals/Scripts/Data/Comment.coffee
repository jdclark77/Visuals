define(['services/logger'], (logger) ->
	class Comment
		constructor: (data) ->
			self = this
			@self = this
			@Avatar = ko.observable()
			@User = ko.observable()
			@AvatarLink = ko.observable()
			@Message = ko.observable()
			@Id = ko.observable()

			if data != null
				ko.mapping.fromJS(data, {}, this)
	
	return Comment	
)