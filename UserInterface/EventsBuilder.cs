using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using FacebookWrapper.ObjectModel;

namespace UserInterface
{
    public class EventsBuilder
    {
        private readonly List<Event> r_EventsApproved = new List<Event>();
        private User m_LoggedInUser;

        public int MaxAttending
        {
            get;
            set;
        }

        public int MinAttending
        {
            get;
            set;
        }

        public DateTime StartDateTime
        {
            get;
            set;
        }

        public EventsBuilder(User i_LoggedInUser, int i_MaxAttending, int i_MinAttending, DateTime i_StartDateTime)
        {
            m_LoggedInUser = i_LoggedInUser;
            MaxAttending = i_MaxAttending;
            MinAttending = i_MinAttending;
            StartDateTime = i_StartDateTime;

            if (fetchEvents())
            {
                CreateFormEvents();
            }
        }

        public void CreateFormEvents()
        {
            FormEvents events = new FormEvents();
            events.SetDataOnList(r_EventsApproved);
        }

        public List<Event> EventsApproved
        {
            get
            {
                return r_EventsApproved;
            }
        }

        private bool fetchEvents()
        {
            bool v_AreThereSuitableEvents = false;
            try
            {
                if (m_LoggedInUser.Events.Count == 0)
                {
                    MessageBox.Show("There are no upcoming events.");
                }
                else
                {
                    v_AreThereSuitableEvents = true;
                    foreach (Event fbEvent in m_LoggedInUser.Events)
                    {
                        if (!ifRemovingEvent(fbEvent))
                        {
                            r_EventsApproved.Add(fbEvent);
                        }
                    }

                    if (r_EventsApproved.Count == 0)
                    {
                        MessageBox.Show("There are no upcoming events by your choice");
                        v_AreThereSuitableEvents = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Events - Permission error !!!!");
            }

            return v_AreThereSuitableEvents;
        }

        private bool ifRemovingEvent(Event i_EventToCheck)
        {
            bool v_ToRemoveAnswer = false;

            v_ToRemoveAnswer = (MaxAttending < i_EventToCheck.AttendingCount
                               || MinAttending > i_EventToCheck.AttendingCount)
                               || StartDateTime > i_EventToCheck.StartTime;

            return v_ToRemoveAnswer;
        }
    }
}