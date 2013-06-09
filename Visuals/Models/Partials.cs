using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visuals.Models
{
	public partial class Person
	{
		public void SetForeignKeys()
		{
			foreach(var post in Posts)
			{
				post.PersonId = Id;
				foreach (var comment in post.Comments)
				{
					comment.PostId = post.Id;

				}
				
			}
			foreach (var pic in Pics)
			{
				pic.PersonId = Id;
			}
			foreach(var pic in InterestingPics)
			{
				pic.PersonId = Id;
			}
		}

		/*
		public Post AddPost( Post post)
		{
			Posts.Add(post);
			
			return post;

		}
		public Person AddPic(Pic pic)
		{
			pic.Person = this;
			Pics.Add(pic);
			return this;
		}
		public Person AddInterestingPic(Pic pic)
		{
			pic.Person = this;
			InterestingPics.Add(pic);
			return this;
		} */
	}
	/*public partial class Post
	{
		public Post AddArticle(Article article)
		{
			article.Post = this;
			Article = article;
			return this;
		}
		public Post AddComment(Comment comment)
		{
			comment.Post = this;
			Comments.Add(comment);
			return this;
		}
	}*/
}