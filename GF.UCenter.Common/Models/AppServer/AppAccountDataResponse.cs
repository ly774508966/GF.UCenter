﻿namespace GF.UCenter.Common
{
    using System.Runtime.Serialization;

    [DataContract]
    public class AppAccountDataResponse
    {
        [DataMember]
        public string AccountId { get; set; }

        [DataMember]
        public string AppId { get; set; }

        [DataMember]
        public string Data { get; set; }
    }
}