/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.03.2016
 * Time: 17:12
 */
using System;
using System.ComponentModel;

namespace GameCore
{
    public enum BodyPart
    {
        None,
        [Description("Голова")]
        Head,
        [Description("Корпус")]
        Body,
        [Description("Ноги")]
        Legs
    }
    
    public delegate void PlayerEvent(IPlayer player, string name);

    public interface IPlayer
    {
        string Name { get; }
        int MaxHp { get; }
        int Hp { get; }
        int Damage { get; }
        BodyPart AttackPoint { get; set; }
        BodyPart BlockPoint { get; set; }
        void GetHit(BodyPart part, string name);
        void SetBlock(BodyPart part, string name);
        event PlayerEvent Wounded;
        event PlayerEvent Blocked;
        event PlayerEvent Dead;
    }
}
