using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_system.Infra.Extensions
{
	public static class StringExtensions
	{
		public static int ToInt(this string source, int defaultvalue)
		{
			bool isInt = int.TryParse(source, out int value);
			return isInt ? value : defaultvalue;
		}
		public static int? ToNullableInt(this string source, int? defaultvalue = null)
		{
			bool isInt = int.TryParse(source, out int value);
			return isInt ? value : defaultvalue;
		}
	}
}
