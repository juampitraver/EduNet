using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;
using System;

namespace TP3.Core.Data.Challenge
{
    public class NetElement
    {
        public bool Selected { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }        
    }    
}