using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsMgrSys.Models
{
    /// <summary>
    /// 基础类
    /// </summary>
    public class ModelBase
    {
        private int _Guid;
        /// <summary>
        /// 唯一标示
        /// </summary>
        public int Guid
        {
            get { return _Guid; }
            set { _Guid = value; }
        }


        private int _SysModelType;

        public int SysModelType
        {
            get { return _SysModelType; }
            set { _SysModelType = value; }
        }

    }
}
