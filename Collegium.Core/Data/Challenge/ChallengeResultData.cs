using System;
using System.Collections.Generic;
using TP3.Domain.Entities;

namespace TP3.Core.Data.Challenge
{
    public class ChallengeResultData
    {

        public string Student { get; set; }

        public string ChallengeCode { get; set; }

        public string ChallengeTitle { get; set; }

        public string ChallengeDescription { get; set; }

        public DateTime TimeLimit { get; set; }

        public eCommand CommandOption { get; set; }

        public eConectionType ConnectionTypeOption { get; set; }

        public eNetType NetTypeOption { get; set; }

        public List<NetElement> NetElementOption { get; set; }
        public List<CableData> Cable { get; set; }
    }
}