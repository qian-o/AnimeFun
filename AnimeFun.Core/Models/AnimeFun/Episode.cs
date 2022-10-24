﻿namespace AnimeFun.Core.Models.AnimeFun
{
    /// <summary>
    /// 剧集
    /// </summary>
    public class Episode : BaseModel
    {
        /// <summary>
        /// 剧集标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 剧集封面
        /// </summary>
        public string Cover { get; set; }

        /// <summary>
        /// 资源Id（对应云端存储Id）
        /// </summary>
        public string SourceId { get; set; }
    }
}
