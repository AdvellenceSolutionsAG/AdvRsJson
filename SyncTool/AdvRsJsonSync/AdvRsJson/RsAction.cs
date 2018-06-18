using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvRsJson
{
    /// <summary>
    /// type-safe-enum pattern.
    /// 
    /// Currently only the "delete" action needs to be supported.
    /// </summary>
    public sealed class RsAction
    {
        private string m_value;
        private static readonly Dictionary<string, RsAction> m_instance = new Dictionary<string, RsAction>();

        public static readonly RsAction DELETE = new RsAction("delete");
        //public static readonly RsAction CREATE = new RsAction("create");
        //public static readonly RsAction IGNORE = new RsAction("ignore");

        private RsAction( string value )
        {
            m_value = value;
            m_instance[value] = this;
        }

        public override string ToString()
        {
            return m_value;
        }

        public static explicit operator RsAction(string str)
        {
            RsAction result;
            if (m_instance.TryGetValue(str, out result))
                return result;
            else
                throw new InvalidCastException();
        }
    }
}
