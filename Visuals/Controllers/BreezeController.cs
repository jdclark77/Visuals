using System.Web.Http;
using Visuals.Models;

namespace Visuals.Controllers
{
	public class BreezeController : ApiController
	{
		[HttpGet]
		public object Posts(string user)
		{


			var person = new Person
				             {
					             Name = "Jake Sully",
					             MiniAvatar = "http://placehold.it/50x50",
					             Link = "Home/Home"
				             };
			//var context = new VisualContext();
			using(var context = new VisualContext())
			{
				var all = context.People.SqlQuery("select *");

			}

			using (var context = new VisualContext())
			{
				context.People.Add(person);
				context.SaveChanges();
			}
			using (var context = new VisualContext())
			{
				var all = context.People.SqlQuery("select *");

			}
			//	context.People.Add(person);
			//	context.SaveChanges();
			
			/*using(var postContext = new Model1Container())
			{



				var post = new Post
					           {
						           Avatar = "http://placehold.it/50x50,",
						           User = "Jake Sully",
						           AvatarLink = "/Home/Home",
						           Message = "Guys, check out this awesome website I found about trees. Man, I love trees. Big trees.",
						           PersonId = person.Id,
								   Article = new Article
					               {
						              Thumbnail = "http://placehold.it/300x300",
						              Link = "Home/Home",
						              Title = "Huge Trees and You: How to live in a giant tree",
						              Synopsis =
							              "This is a website for people who live in gigantic trees. Learn about how to go from branch to branch, and where to keep your crazy screaming flying dragon thing.",
									
								   }
					           };
				postContext.Posts.Add(post);
				postContext.Articles.Add(post.Article);
				postContext.SaveChanges();
			}
			/*using(var articleContext = new Model1Container())
			{
				var article = 
										       Comments = new[]
											                  {
												                  new Comment
													                  {
														                  Avatar = "http://placehold.it/50x50",
														                  User = "TheColonel",
														                  AvatarLink = "#",
														                  Message = "Don't get too comfy, I'm coming for that tree."
													                  },
												                  new Comment
													                  {
														                  Avatar = "http://placehold.it/50x50",
														                  User = "Jake",
														                  AvatarLink = "#",
														                  Message = "You're such a tool."
													                  }
											                  }
									       },
								       new Post
									       {
										       Avatar = "http://placehold.it/50x50",
										       User = "Jake Sully",
										       AvatarLink = "#,",
										       Message = "Has anyone seen my wheelchair? This isn't funny guys.",
										       Comments = new[]
											                  {
												                  new Comment
													                  {
														                  Avatar = "http://placehold.it/50x50",
														                  User = "Jake",
														                  AvatarLink = "#",
														                  Message =
													                  "Found it. Whoever decided it'd be a fun game to kick it around with those walkers owes me a new one."
													                  }
											                  }
									       },
								       new Post
									       {
										       Avatar = "http://placehold.it/50x50",
										       User = "Jake Sully",
										       AvatarLink = "#",
										       Message = "Has anyone seen my wheelchair? This isn't funny guys.",
										       Comments = new[]
											                  {
												                  new Comment
													                  {
														                  Avatar = "http://placehold.it/50x50",
														                  User = "Jake",
														                  AvatarLink = "#",
														                  Message =
													                  "Found it. Whoever decided it'd be a fun game to kick it around with those walkers owes me a new one.",
													                  }
											                  }
									       }
							       },
						      
					       Pics = new[]
						              {
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 1",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 2",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 3",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 4",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 5",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 6",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 7",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 8",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 9",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 10",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 11",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 12",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 13",
									              Link = "Test/Page/Link/OnClick"
								              },
							              new Pic
								              {
									              Url = "http://placehold.it/100x100",
									              Title = "Picture 14",
									              Link = "Test/Page/Link/OnClick"
								              }
						              },
					       InterestingPics = new[]
						                         {
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 1",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 2",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 3",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 4",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 5",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 6",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 7",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 8",
									                         Link = "Test/Page/Link/OnClick"
								                         },
							                         new Pic
								                         {
									                         Url = "http://placehold.it/100x100",
									                         Title = "Picture 9",
									                         Link = "Test/Page/Link/OnClick"
								                         }
						                         }
				       };
			using(var context = new Model1Container())
			{
				context.People.Add(person);
				context.SaveChanges();
			}*/
			return person;
		}
	}
}
