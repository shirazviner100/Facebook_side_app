using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    //// Using IEnumerable in order not to expose the whole list to unwanted changes
    public class MyFilteredPosts : IEnumerable<Post>
    {
        private readonly List<Post> r_FilteredPostsList = new List<Post>();

        private IPostFilter m_PostFilter;

        public User LoggedInUser { get; set; }

        public IEnumerator<Post> GetEnumerator()
        {
            return r_FilteredPostsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IPostFilter PostFilter
        {
            set
            {
                m_PostFilter = value;
            }
        }

        public void FilterPostList()
        {
            if(m_PostFilter != null && LoggedInUser != null)
            {
                r_FilteredPostsList.Clear();
                foreach(Post post in LoggedInUser.Posts)
                {
                    if(m_PostFilter.FilterPost(post))
                    {
                        r_FilteredPostsList.Add(post);
                    }
                }
            }
            else
            {
                throw new NullReferenceException("Data members wasn`t update yet.");
            }
        }
    }
}
