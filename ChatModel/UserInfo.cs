using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatModel
{
    /// <summary>
    /// 用户细节
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 连接ID
        /// </summary>
        public string ConnectionId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime JoimTime { get; set; }
    }
}
