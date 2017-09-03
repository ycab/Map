using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        /// <summary>
        /// ID
        /// </summary>
        public virtual string ID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public virtual string Username { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public virtual string  Pwd{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public virtual int Gender { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public virtual int Authority { get; set; }

        /// <summary>
        /// 进价
        /// </summary>

    }
}
