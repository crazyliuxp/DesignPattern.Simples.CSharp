using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Builder
{
    /// <summary>
    /// 角色类：复杂产品
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 脸型
        /// </summary>
        public string Face { get; set; }
        /// <summary>
        /// 服装
        /// </summary>
        public string Costume { get; set; }
        /// <summary>
        /// 发型
        /// </summary>
        public string Hairstyle { get; set; }
    }
}
