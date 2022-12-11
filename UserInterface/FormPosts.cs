using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UserInterface
{
    public partial class FormPosts : Form
    {
        private User m_LoggedInUser;
        private MyFilteredPosts m_FilterPost;

        public FormPosts(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            m_FilterPost = new MyFilteredPosts
            {
                LoggedInUser = m_LoggedInUser
            };
        }

        private void fetchAllPosts()
        {
            try
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
                if (m_LoggedInUser.Posts.Count == 0)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("Posts List Empty")));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.DisplayMember = "Message"));
                    if (checkBoxNoFilter.Checked)
                    {
                        foreach (Post post in m_LoggedInUser.Posts)
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                        }
                    }
                    else
                    {
                        m_FilterPost.FilterPostList();
                        foreach (Post post in m_FilterPost)
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                        }
                    }
                }
            }
            catch (NullReferenceException i_Exception)
            {
                MessageBox.Show(i_Exception.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Post permission ERROR");
            }
        }

        private void checkBoxNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoFilter.Checked)
            {
                checkBoxLikes.Enabled = false;
                checkBoxLastYear.Enabled = false;
                checkBoxByLenth.Enabled = false;
                fetchAllPosts();
            }
            else
            {
                checkBoxLikes.Enabled = true;
                checkBoxLastYear.Enabled = true;
                checkBoxByLenth.Enabled = true;
            }
        }

        private void checkBoxLastYear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLastYear.Checked)
            {
                m_FilterPost.PostFilter = new PostFilterByDate();
                checkBoxLikes.Enabled = false;
                checkBoxNoFilter.Enabled = false;
                checkBoxByLenth.Enabled = false;
                fetchAllPosts();
            }
            else
            {
                checkBoxLikes.Enabled = true;
                checkBoxNoFilter.Enabled = true;
                checkBoxByLenth.Enabled = true;
            }
        }

        private void checkBoxByLenth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByLenth.Checked)
            {
                m_FilterPost.PostFilter = new PostFilterByLength();
                checkBoxLikes.Enabled = false;
                checkBoxNoFilter.Enabled = false;
                checkBoxLastYear.Enabled = false;
                fetchAllPosts();
            }
            else
            {
                checkBoxLikes.Enabled = true;
                checkBoxNoFilter.Enabled = true;
                checkBoxLastYear.Enabled = true;
            }
        }

        private void checkBoxLikes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLikes.Checked)
            {
                m_FilterPost.PostFilter = new PostFilterByLikesNumber();
                checkBoxByLenth.Enabled = false;
                checkBoxNoFilter.Enabled = false;
                checkBoxLastYear.Enabled = false;
                fetchAllPosts();
            }
            else
            {
                checkBoxByLenth.Enabled = true;
                checkBoxNoFilter.Enabled = true;
                checkBoxLastYear.Enabled = true;
            }
        }
    }
}