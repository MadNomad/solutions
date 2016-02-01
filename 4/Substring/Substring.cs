/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 01.02.2016
 * Time: 17:16
 */
using System;

namespace Substring
{
	/// <summary>
	/// Description of Substring.
	/// </summary>
	public static class Substring
	{
		public static string MySubstring(this string str, int index, int length)
		{
			str = str.Remove(0, index);
			return str;
		}
	}
}
