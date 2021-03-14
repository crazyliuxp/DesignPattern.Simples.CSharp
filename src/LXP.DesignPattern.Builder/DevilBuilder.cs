﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Builder
{
    /// <summary>
    /// 恶魔角色建造器：具体建造者
    /// </summary>
    public class DevilBuilder : ActorBuilder
    {
        public override void BuildType()
        {
            actor.Type = "恶魔";
        }

        public override void BuildSex()
        {
            actor.Sex = "妖";
        }

        public override void BuildFace()
        {
            actor.Face = "丑陋";
        }

        public override void BuildCostume()
        {
            actor.Costume = "黑衣";
        }

        public override void BuildHairstyle()
        {
            actor.Hairstyle = "光头";
        }
    }
}
