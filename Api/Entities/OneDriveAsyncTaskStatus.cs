﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace KoenZomers.OneDrive.Sync.BusinessLogic.Entities
{
    public class OneDriveAsyncTaskStatus : OneDriveItemBase
    {
        [JsonProperty("operation"), JsonConverter(typeof(StringEnumConverter))]
        public Enums.OneDriveAsyncJobType Operation { get; set; }

        [JsonProperty("percentageComplete")]
        public double PercentComplete { get; set; }

        [JsonProperty("status"), JsonConverter(typeof(StringEnumConverter))]
        public Enums.OneDriveAsyncJobStatus Status { get; set; }
        
    }
}
