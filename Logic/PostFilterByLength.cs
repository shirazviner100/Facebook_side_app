using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PostFilterByLength :IPostFilter
    {
        //// The class filters posts that are less than 100 characters long
        public bool FilterPost(Post i_PostToCheck)
        {
            bool v_ToAdd = false;

            if(!string.IsNullOrEmpty(i_PostToCheck.Message))
            {
                v_ToAdd = i_PostToCheck.Message.Length <= 100;
            }

            return v_ToAdd;
        }
    }
}
