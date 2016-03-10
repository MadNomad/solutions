/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 10.03.2016
 * Time: 9:54
 */
using System;

namespace GameCore
{
    /// <summary>
    /// Description of IBattle.
    /// </summary>
    public interface IBattle
    {
        void MakeRound(BodyPart attackPoint, BodyPart blockPoint);
    }
}