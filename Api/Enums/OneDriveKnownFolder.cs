﻿using System.Runtime.Serialization;

namespace KoenZomers.OneDrive.Sync.BusinessLogic.Enums
{
    public enum OneDriveKnownFolder
    {
        [EnumMember(Value = "approot")]
        AppFolder,

        [EnumMember(Value = "documents")]
        Documents,

        [EnumMember(Value = "photos")]
        Photos,

        [EnumMember(Value = "cameraroll")]
        CameraRoll,

        [EnumMember(Value = "public")]
        Public
    }
}
