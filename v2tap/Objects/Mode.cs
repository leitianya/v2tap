using System.Collections.Generic;

namespace v2tap.Objects
{
    public class Mode
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name;

        /// <summary>
        /// 规则
        /// </summary>
        public List<KeyValuePair<string, string>> Rule = new List<KeyValuePair<string, string>>();
    }
}
