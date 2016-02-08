/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.02.2016
 * Time: 14:48
 */
using System;

namespace MyClass
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class MyClass<T>  where T : new()
	{
		public T field;
		
		public T FacrotyMethod()
		{
			return new T();
		}
		
	}
}
