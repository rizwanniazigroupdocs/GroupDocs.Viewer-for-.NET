﻿namespace GroupDocs_Viewer_SharePoint.Layouts.GroupDocs_Viewer_SharePoint.BusinessLayer
{
    public class ReorderPageParameters : DocumentParameters
    {
        public int OldPosition { get; set; }
        public int NewPosition { get; set; }
        public string InstanceIdToken { get; set; }
        public string Callback { get; set; }
    }

    public class ReorderPageResponse
    {
        public ReorderPageResponse()
        {
            success = true;
        }

        public bool success { get; set; }
    }
}