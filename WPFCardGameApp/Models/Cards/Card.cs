﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCardGameApp.Models.Cards
{
    class Card : ICloneable
    {
        public int Id { get; set; }
        public int IdFraction { get; set; }
        public int IdType { get; set; }
        public int? IdSpecialSkill { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        
        public Card()
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
