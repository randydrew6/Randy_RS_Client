﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RS_Client
{
    public class Skill
    {
        public string SkillName { get; set; }
        public string SkillXp { get; set; }
        public int SkillXpValue { get; set; }
        public string SkillRank { get; set; }
        public string SkillLevel { get; set; }

        public Skill(string aSkillName)
        {
            this.SkillName = aSkillName;
        }
    }
}
