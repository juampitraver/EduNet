using System;
using System.Collections.Generic;

namespace TP3.Core.Data.Challenge
{
    public class ChallengeResultData
    {

        public string Student { get; set; }

        public string ChallengeCode { get; set; }

        public string ChallengeTitle { get; set; }

        public string ChallengeDescription { get; set; }

        public DateTime TimeLimit { get; set; }

        public List<NetElement> NetElementOption { get; set; }
        public List<CableData> Cable { get; set; }
    }
}