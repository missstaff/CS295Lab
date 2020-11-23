﻿using Shawna_Staff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shawna_Staff.Repos
{
    public class FakeForumsRepository : IForums
    {
        List<ForumPosts> posts = new List<ForumPosts>();

        public IQueryable<ForumPosts> Posts { get { return (IQueryable<ForumPosts>)posts; } }

        public void AddPost(ForumPosts forumPost)
        {
            forumPost.PostID = posts.Count;
            posts.Add(forumPost);
        }

        public ForumPosts GetForumPostsByPostTitle(string postTitle)
        {
            throw new NotImplementedException();
        }
    }
}
