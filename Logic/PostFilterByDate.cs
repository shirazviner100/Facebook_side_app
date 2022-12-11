using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    //// The class filters the posts that have been published in the last three years
    public class PostFilterByDate : IPostFilter
    {
        public bool FilterPost(Post i_PostToCheck)
        {
            bool v_ToAdd = false;

            v_ToAdd = i_PostToCheck.CreatedTime.Value.Year > (DateTime.Now.Year - 3);

            return v_ToAdd;
        }
    }
}
