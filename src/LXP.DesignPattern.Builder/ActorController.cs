﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Builder
{
    /// <summary>
    /// 游戏角色创建控制器：指挥者
    /// </summary>
    public class ActorController
    {
        /// <summary>
        /// 逐步构建复杂产品对象
        /// </summary>
        /// <param name="ab"></param>
        /// <returns></returns>
        public Actor Construct(ActorBuilder ab)
        {
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairstyle();

            var actor = ab.CreateActor();
            return actor;
        }
    }
}
