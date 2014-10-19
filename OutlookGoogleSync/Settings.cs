﻿
using System;
using System.Drawing;

namespace OutlookGoogleSync {
    /// <summary>
    /// Description of Settings.
    /// </summary>
    public class Settings {
        private static Settings instance;

        public static Settings Instance {
            get {
                if (instance == null) instance = new Settings();
                return instance;
            }
            set {
                instance = value;
            }

        }
        //Outlook
        public OutlookCalendar.Service OutlookService = OutlookCalendar.Service.DefaultMailbox;
        public string MailboxName = "";
        public string EWSuser = "";
        public string EWSpassword = "";
        public string EWSserver = "";

        //Google
        public MyCalendarListEntry UseGoogleCalendar = new MyCalendarListEntry();
        public string RefreshToken = "";
        
        //Sync Options
        public int DaysInThePast = 1;
        public int DaysInTheFuture = 60;
        public int SyncInterval = 1;
        public String SyncIntervalUnit = "Hours";
        public bool AddDescription = true;
        public bool AddReminders = false;
        public bool AddAttendeesToDescription = true;
        public bool DisableDelete = false;
        public bool ConfirmOnDelete = false;        
        
        //App behaviour
        public bool ShowBubbleTooltipWhenSyncing = false;
        public bool StartInTray = false;
        public bool MinimizeToTray = false;
        public bool CreateTextFiles = true;

        public DateTime LastSyncDate = new DateTime(0);

        public Settings() {
        }
    }
}
