define(['services/logger', 'data/Data', 'data/Post', 'data/Pic', 'data/Comment'], (logger, MockData, Post, Pic, Comment) ->
	class Mapping
		constructor: (posts) ->
			@SocialNetworkMapping =
				'Posts': {
					create: (options) ->
						return new Post(options.data)
				}
				'Pics': {
					create: (options) ->
						return new Pic(options.data)
				}
				'InterestingPics': {
					create: (options) ->
						return new Pic(options.data)
				}
			@PostMapping = 
				'Comments': {
					create: (options) ->
						return new Comment(options.data)
				}
	return Mapping
)