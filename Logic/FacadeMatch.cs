using System;
using System.Collections.Generic;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class FacadeMatch: IEnumerable<User>
    {
        private User m_LoggedInUser;
        private ProxyFriends m_ProxyData;

        public eGender Gender { get; set; }
       
        public IEnumerator<User> GetEnumerator()
        {
            List<User> friendsListByGender = m_ProxyData.GetFriendsListByGender(Gender);

            foreach (User fb_Friend in friendsListByGender)
            {
                if(checkIfMatch(fb_Friend))
                {
                    yield return fb_Friend;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public FacadeMatch(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_ProxyData = new ProxyFriends(m_LoggedInUser);
        }

        private bool checkIfMatch(User i_FriendToCheck)
        {
            eZodiac userZodiac;
            eZodiac friendZodiac;
            bool v_IfMatch = true;

            try
            {
                userZodiac = ZodiacData.GetZodiac(m_LoggedInUser.Birthday);
                friendZodiac = ZodiacData.GetZodiac(i_FriendToCheck.Birthday);

                v_IfMatch = friendZodiac == userZodiac || (userZodiac != eZodiac.Pisces && friendZodiac == userZodiac + 1)
                                              || (userZodiac != eZodiac.Aries && friendZodiac == userZodiac - 1);

                return v_IfMatch;
            }
            catch (Exception)
            {
                throw new ArgumentException("Sorry, No matches found.");
            }
        }
    }
}