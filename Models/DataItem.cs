using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacollection.Models
{
    /// <summary>
    /// 数据项模型类，存储名称、值和日期时间
    /// </summary>
    public class DataItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}
