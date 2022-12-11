using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public enum eGender
    {
        PanelMen = 0,
        PanelWomen,
        PanelBsexual
    }

    public sealed class ProxyFriends
    {
        private static readonly object sr_ObjToLock = new object();

        private User m_LoggedInUser;

        public List<User> AllFriends { get; private set; }

        public List<User> MenFriends { get; private set; }

        public List<User> WomenFriends { get; private set; }

        public ProxyFriends(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            AllFriends = new List<User>();
            MenFriends = new List<User>();
            WomenFriends = new List<User>();
            fetchFriends();
        }

        public List<User> Friends
        {
            get
            {
                return AllFriends;
            }
        }

        private void fetchFriends()
        {
            try
            {
                if (m_LoggedInUser.Friends.Count > 0 && m_LoggedInUser.Friends.Count > AllFriends.Count)
                {
                    foreach (User fbFriend in m_LoggedInUser.Friends)
                    {
                        AllFriends.Add(fbFriend);

                        if (fbFriend.Gender != User.eGender.female)
                        {
                            MenFriends.Add(fbFriend);
                        }
                        else
                        {
                            WomenFriends.Add(fbFriend);
                        }
                    }
                }
            }

            catch (Exception)
            {
                throw new ArgumentException("Friends List - permission error !!!!");
            }

        }

        public bool IsChanged
        {
            get
            {
                bool v_IsChanged = AllFriends.Count != m_LoggedInUser.Friends.Count;
                return v_IsChanged;
            }
        }

        public void UpdateFriendsList()
        {
            if (IsChanged)
            {
                fetchFriends();
            }
        }

        public List<User> GetFriendsListByGender(eGender i_PnaelChoice)
        {
            UpdateFriendsList();

            switch (i_PnaelChoice)
            {
                case eGender.PanelMen:
                    return MenFriends;

                case eGender.PanelWomen:
                    return WomenFriends;

                default:
                    return AllFriends;
            }
        }
    }
}