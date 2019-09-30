﻿using System.Collections.Generic;

namespace diabloblazor.Services
{
    public class AppState
    {
        public bool Loading { get; set; }

        public bool Started { get; set; }

        public bool Compress { get; set; }

        public bool HasSpawn { get; set; }

        public bool ShowSaves { get; set; }

        public bool Error { get; set; }

        public int Dropping { get; set; }

        public IList<string> SaveNames { get; set; } = new List<string>();

        //progress
    }
}