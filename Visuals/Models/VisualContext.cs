using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Visuals.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public Post Post { get; set; }
		public string Message { get; set; }
	}
	public class Post
	{
		public int Id { get; set; }
		public Person Person { get; set; }
		public string Message { get; set; }
		public Article Article { get; set; }

		


	}
	public class Article
	{
		public int Id { get; set; }
		public string Thumbnail { get; set; }
		public string Link { get; set; }
		public string Title { get; set; }
		public string Synopsis { get; set; }
		
	}
	public class Pic
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string Title { get; set; }
		public Person Person { get; set; }
	}
	public class Person
	{
		public Person()
		{
			this.Posts = new HashSet<Post>();
			this.Pics = new HashSet<Pic>();
			this.InterestingPics = new HashSet<Pic>();
		}

		public int Id { get; set; }
		
		public string MiniAvatar { get; set; }
		public string Link { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Post> Posts { get; set; }
		public virtual ICollection<Pic> Pics { get; set; }
		public virtual ICollection<Pic> InterestingPics { get; set; }
	}
	public class VisualContext : DbContext
	{
		public DbSet<Person> People { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Pic> Pics { get; set; }
		public DbSet<Post> Posts { get; set; }
	}
}