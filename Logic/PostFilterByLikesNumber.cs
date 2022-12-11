using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PostFilterByLikesNumber :IPostFilter
    {
        //// the class filters the posts that received at least 80 likes
        public bool FilterPost(Post i_PostToCheck)
        {
            bool v_ToAdd = false;

            v_ToAdd = i_PostToCheck.LikedBy.Count >= 80;

            return v_ToAdd;
        }
    }
}
