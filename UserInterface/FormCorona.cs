using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public partial class FormCorona : Form
    {
        private User m_LoggedInUser;
        private List<string> m_TaggedFriendsAndPlaces;

        public FormCorona(User i_User = null)
        {
            m_LoggedInUser = i_User;
            InitializeComponent();
            m_TaggedFriendsAndPlaces = new List<string>();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            textBoxCorona.Text = @"Hello, #CoronaPost
I am updating you because I was diagnosed with COVID-19 on: ________.
Before I went into isolation I spent time in the following places:
 1._______  on: ______
 2._______  on: ______
 3.________ on: ______
 ....
 If you have visited or near these places recently
 I recommend going into quarantine and getting tested,
 Wishing everyone health!
   -Stay strong together -
";
        }

        private void fetchTagsForCoronaPost()
        {
            new Thread(addTagsFromAlbums).Start();
            new Thread(addTagsFromCheckins).Start();
        }

        private void addTagsFromAlbums()
        {
            try
            {
                if (m_LoggedInUser.Albums.Count > 0)
                {
                    DateTime albumDate;
                    DateTime photoDate;

                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        albumDate = album.UpdateTime.GetValueOrDefault();

                        if (album.UpdateTime.HasValue && isOnDate(albumDate))
                        {
                            foreach (Photo photo in album.Photos)
                            {
                                photoDate = photo.UpdateTime.GetValueOrDefault();
                                if (photo.UpdateTime.HasValue && isOnDate(photoDate))
                                {
                                    if (photo.Tags != null)
                                    {
                                        foreach (PhotoTag tag in photo.Tags)
                                        {
                                            m_TaggedFriendsAndPlaces.Add(tag.User.Name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Album permission error !!!!");
            }
        }

        private void addTagsFromCheckins()
        {
            try
            {
                DateTime checkinDate;
                if (m_LoggedInUser.Checkins.Count > 0)
                {
                    foreach (Checkin checkin in m_LoggedInUser.Checkins)
                    {
                        checkinDate = checkin.CreatedTime.GetValueOrDefault();
                        if (checkin.CreatedTime.HasValue && isOnDate(checkinDate))
                        {
                            m_TaggedFriendsAndPlaces.Add(checkin.Place.Name);

                            if (checkin.TaggedUsers.Count > 0)
                            {
                                foreach (User taggedUser in checkin.TaggedUsers)
                                {
                                    m_TaggedFriendsAndPlaces.Add(taggedUser.Name);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Checkin user tags Permission error !!!!");
            }
        }

        private bool isOnDate(DateTime i_DateTime)
        {
            bool v_IsOnDate = i_DateTime.Month == DateTime.Today.Month || i_DateTime.Month == DateTime.Today.Month - 1;
            return v_IsOnDate;
        }

        private void postStatus()
        {
            try
            {
                if (m_TaggedFriendsAndPlaces.Count > 0)
                {
                    ////add to covid-19 post, all friends and places, that the user taged with them in the last month.
                    StringBuilder friendsIds = new StringBuilder();
                    foreach (string friendName in m_TaggedFriendsAndPlaces)
                    {
                        friendsIds.AppendLine('@' + friendName);
                    }

                    textBoxCorona.Invoke(new Action(() => textBoxCorona.Text += friendsIds.ToString()));
                    this.m_LoggedInUser.PostStatus(textBoxCorona.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Posting Permission error !!!!");
                textBoxCorona.Invoke(new Action(() => textBoxCorona.Clear()));
                this.Close();
            }
        }

        public SmartPictureBox PostButton
        {
            get
            {
                return smartPictureBoxPost;
            }
        }

        private void smartPictureBoxPost_Click(object sender, EventArgs e)
        {
            fetchTagsForCoronaPost();
            postStatus();
        }
    }
}
