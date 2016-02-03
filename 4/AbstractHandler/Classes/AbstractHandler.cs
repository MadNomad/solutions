/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 27.01.2016
 * Time: 15:54
 */
using System;

namespace AbstractHandler.Classes
{
	/// <summary>
	/// Description of AbstractHandler.
	/// </summary>
	abstract class AbstractHandler
	{
		public string fileName;
		public Array fileExtension = null;
		public AbstractHandler handler;
		
		internal virtual void Open() {}
		
		internal virtual void Create() {}
		
		internal virtual void Chenge() {}
		
		internal virtual void Save() {}
		
		public AbstractHandler getHandler()
		{
			switch (fileExtension.Split('.').Last().ToLower())
			{
				case "doc":
					return DOCHandller();
				case "txt":
					return TXTHandller();
                case "xml":
                    return XMLHandller();
                default:
                    Console.WriteLine ("Данное разширение файлов не поддерживается!");
			}

		}
	}
}
