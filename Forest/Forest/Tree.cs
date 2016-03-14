/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 13:02
 */
using System;
using Forest;

namespace Forest
{
    /// <summary>
    /// Description of Tree.
    /// </summary>
    public class Tree : ITree
    {
        public Tree(TypeOfTree type)
        {
        }
        
        #region ITree implementation

        void grow()
        {
            lenght++;
        }

        TypeOfTree type;
        public TypeOfTree Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        int lenght;
        int Lenght
        {
            public get
            {
                return lenght;
            }
            protected set
            {
                lenght = value;
            }

        }

        string color;
        public string Color
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool shapely
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}
