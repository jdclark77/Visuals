define(['require', 'services/logger', 'data/Comment'], (require, logger, Comment) ->
	
	class Post
		constructor: (data) ->
			self = this
			@self = this
			@Avatar = ko.observable()
			@User = ko.observable()
			@AvatarLink = ko.observable()
			@Message = ko.observable()
			@Comments = ko.observableArray()

			if data != null
				Mapping = require("data/Mapping")
				map = new Mapping()
				ko.mapping.fromJS(data, map.PostMapping, this)
		
			@Editing = ko.observable(false)
			@NewComment = ko.observable('')
			@SkipAdd = ko.observable(false)
			@CommentCreator = ko.computed( =>
				if @SkipAdd()
					return
				comment = @NewComment()
				if comment != ''
					newComment = new Comment()
					newComment.Message(comment)
					newComment.Avatar(viewModel.MiniAvatar())
					newComment.AvatarLink(viewModel.Link())
					newComment.User(viewModel.Name())
					newComment.Id(@Comments().length)
					@Comments.push(newComment)
					@SkipAdd(true)
					@NewComment('')
					@SkipAdd(false)
			)
		
		
			@Id = ko.observable()
		Edit: () =>
			@Editing(true)
		
	return Post

)