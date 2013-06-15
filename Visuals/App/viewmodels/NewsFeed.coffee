define(['services/logger', 'data/Mapping'], (logger, Mapping) ->
	
	class NewsFeeds
		constructor: (posts) ->
			self = this
			@self = this
			@title = ko.observable('News Feeds')
			@Name = ko.observable()
			@AppPath = ko.observable()
			@Profile = ko.observable()
			@ShowLoading = ko.observable(true)
			@Posts = ko.observableArray()
			@MiniAvatar = ko.observable() 
			@Link = ko.observable()

			@Pics = ko.observableArray()
			@Page = ko.observable(0)
			@MaxPicPage = ko.computed ( =>
				numPics = @Pics().length
				return Math.ceil((numPics) / 12) - 1
			)
			@DisplayPics = ko.computed( =>
				picStart = @Page() * 12
				selectedList = _.rest(@Pics(), picStart) 
				_.first(selectedList, 12)
			)

			@InterestingPics = ko.observableArray()
			@InterestingPage = ko.observable(0)
			@InterestingMaxPage = ko.computed ( =>
				numPics = @InterestingPics().length
				return Math.ceil((numPics) / 12) - 1
			)
			@DisplayInterestingPics = ko.computed( =>
				picStart = @InterestingPage() * 12
				selectedList = _.rest(@InterestingPics(), picStart) 
				_.first(selectedList, 12)
			)
			@LoggingIn = ko.observable(false)
		

			@DomTree = ko.observable()

			@GetPosts()
	
		LogIn: () =>
			@LoggingIn(true)
		
		Edit:(val) =>
			val.Editing(true)		
			
		init: (s) =>
		

			# Loader is global and bound initialized here
			#loader = document.getElementById('loading');
			#ko.applyBindings(@self, loader)
		
		GetPosts: () =>
			self = @self
			amplify.request( 
				resourceId: "Posts", 
				data: { user: "amplifyjs" }, 
				success: ( data ) =>
					window.viewModel = this
					map = new Mapping()

					ko.mapping.fromJS(data, map.SocialNetworkMapping, this)
					
					return
    
				error: ( message, level ) =>
					alert( "always handle errors with alerts." )
					return
			)

		PostLoad: () =>
			@ShowLoading(false)
		
			return 
		PrevPicPage: () =>
			if @Page() != 0
				newPage = @Page() - 1
				@Page(newPage)

		NextPicPage: () =>
			if @Page() != @MaxPicPage()
				newPage = @Page() + 1 
				@Page(newPage)

		DisableHref: (disableLink, element) =>
			if disableLink
				return ''
			return '#'
		activate: () =>
			logger.log('News View Activated', null, 'details', true);
			return true;

	
	return NewsFeeds
	

)