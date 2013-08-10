using System.Collections.Generic;
using System.Text;
using RottenTomatoesPortable.Attributes;

namespace RottenTomatoesPortable
{
    internal static class ExtensionMethods
    {
        internal static string GetDescription(this object en)
        {
            var type = en.GetType();
            var memInfo = type.GetMember(en.ToString());

            if (memInfo.Length <= 0) return en.ToString();

            var attrs = memInfo[0].GetCustomAttributes(typeof(Description), false);
            if (attrs != null && attrs.Length > 0)
            {
                return ((Description)attrs[0]).Text;
            }

            return en.ToString();
        }

        internal static string ToUrlParams(this Dictionary<string, string> dictionary)
        {
            var sb = new StringBuilder();

            var i = 0;
            foreach (var item in dictionary)
            {
                var queryType = i == 0 ? "?" : "&";
                sb.AppendFormat("{0}{1}={2}", queryType, item.Key, item.Value);
                i++;
            }

            return sb.ToString();
        }
    }
}
