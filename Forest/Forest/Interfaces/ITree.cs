/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 14:59
 */
using System;
using Forest;

namespace Forest
{
    /// <summary>
    /// Description of ITree.
    /// </summary>
    public interface ITree
    {
        TypeOfTree type { get; }
        int lenght { get; set; }
        string color { get; set; }
        bool shapely { get; set; }
        void grow();
    }

    public enum TypeOfTree
    {
        None,
        Fir,
        Oak,
        Birch
    }
}
