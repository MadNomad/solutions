/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.02.2016
 * Time: 14:38
 */
using System;
using System.Collections.Generic;

namespace AnonymousMethodExt
{
	class Program
	{
		public static void Main(string[] args)
		{
		    MyDelegate quickDelegate = delegate () 
            {
                return new Random().Next(1000);
		    };

            List<MyDelegate> delegates = new List<MyDelegate>();
            for (int i = 0; i < 10; i++) {
                delegates.Add(quickDelegate);
            }
            
            MyAverage average = delegate(List<MyDelegate> delegates1)
            {
                int summ = 0;
                foreach (MyDelegate item in delegates1)
				{
					summ += item.Invoke();
//                    Console.WriteLine(item.Invoke());
				}
				return summ/delegates.Count;
            };

            Console.WriteLine(average.Invoke(delegates));
//			MyDelegate quickRnd = new MyDelegate(RndInt.Next());
//			List<MyDelegate> delegates = new List<MyDelegate>();
//			for (int i = 0; i < 10; i++) {
//				delegates.Add(quickRnd);
//			}
//			int summ;
//			MyAverage average = delegate()
//			{
//				foreach (MyDelegate item in delegates)
//				{
//					summ += item;
//				}
//				return summ;
//			};
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	#region Kitchen

    public delegate int MyDelegate();

    public delegate int MyAverage(List<MyDelegate> delegates);

	#endregion
}