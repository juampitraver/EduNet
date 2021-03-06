﻿using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.Challenge
{
    public class ChallenteCableData
    {
        public ChallenteCableData()
        {
            IsSelect = true;
        }
        public int CableId { get; set; }
        [Display(Name = "Cable")]
        public string Name { get; set; }
        [Display(Name = "Orden")]
        public int Order { get; set; }
        public bool IsSelect { get; set; }
    }
}
