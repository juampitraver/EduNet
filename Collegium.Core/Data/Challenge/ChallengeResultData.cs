using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;
using System;

namespace TP3.Core.Data.Challenge
{
    public class ChallengeResultData
    {        
        public string Student { get; set; }
        
        public string ChallengeCode { get; set; }
        
        public string ChallengeTitle { get; set; }
                
        public string ChallengeDescription { get; set; }

        public DateTime TimeLimit { get; set; }
    }
}