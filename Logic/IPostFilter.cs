using FacebookWrapper.ObjectModel;

namespace Logic
{
    public interface IPostFilter
    {
        bool FilterPost(Post i_PostToCheck);
    }
}
