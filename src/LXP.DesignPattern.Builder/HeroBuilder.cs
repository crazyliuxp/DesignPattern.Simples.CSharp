using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Builder
{
    /// <summary>
    /// 英雄角色建造器：具体建造者
    /// </summary>
    public class HeroBuilder : ActorBuilder
    {
        public override void BuildType()
        {
            actor.Type = "英雄";
        }

        public override void BuildSex()
        {
            actor.Sex = "男";
        }

        public override void BuildFace()
        {
            actor.Face = "英俊";
        }

        public override void BuildCostume()
        {
            actor.Costume = "盔甲";
        }

        public override void BuildHairstyle()
        {
            actor.Hairstyle = "飘逸";
        }
    }
}
