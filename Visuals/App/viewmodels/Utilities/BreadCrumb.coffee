define(['services/logger'],  (logger) ->
	class BreadCrumb
		constructor: (data) ->
			self = this
			@self = this
			@Route = ko.observable()
			@Tip = ko.observable()
			@Name = ko.observable()
			@Order = ko.observable()

			if data != null
				ko.mapping.fromJS(data, {}, this)
	return BreadCrumb
)