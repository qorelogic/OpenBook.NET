﻿namespace OpenBook.Models.ApiResults.UserProfileDetails
{
    public class UserProfileDetailsResult : LocalizedResultBase
    {
        public ProfileUser User { get; set; }
        public int Copiers { get; set; }
        public int Followers { get; set; }
        public bool IsCurrentUserCopy { get; set; }
        public bool IsCurrentUserFollow { get; set; }
        public bool IsVerified { get; set; }
        public int MirrorID { get; set; }
        public string AboutMe { get; set; }
        public bool? IsPaused { get; set; }
    }
}