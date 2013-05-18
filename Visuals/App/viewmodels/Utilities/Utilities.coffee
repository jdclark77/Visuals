define(['services/logger', './BreadCrumb'],  (logger, BreadCrumb) ->
	class Utilites
		constructor: (data) ->
			self = this
			@self = this
			

			if data != null
				ko.mapping.fromJS(data, {}, this)

		BreadCrumbs: (module) =>
			if module == 'home'
				return [ new BreadCrumb({Route: '#/home',Tip: 'Visuals Home', Name: 'Home', Order: 0 })] 

	return Utilites
)