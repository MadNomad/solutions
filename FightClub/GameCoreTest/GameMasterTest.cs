/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.03.2016
 * Time: 12:35
 */
using System;
using NUnit.Framework;
using GameCore;

namespace GameCoreTest
{
    [TestFixture]
    public class GameMasterTest
    {
        [Test]
        public void NewBattlePlayerNameFromForm()
        {
            GameMaster Battle = new GameMaster("Player");
            Assert.AreEqual(Battle.Human.Name, "Player", "Recived name form form not 'Player'");
        }
        [Test]
        public void NewBattleNullPlayerName()
        {
            GameMaster Battle = new GameMaster(null);
            Assert.AreEqual(Battle.Human.Name, "Jack", "Nulled player name don't changed to default name 'Jack'");
        }
        [Test]
        public void NewBattleWhiteSpacedPlayerName()
        {
            GameMaster Battle = new GameMaster(" ");
            Assert.AreEqual(Battle.Human.Name, "Jack", "WhiteSpaced player name don't changed to default name 'Jack'");
        }
        [Test]
        public void NewBattleEmptyPlayerName()
        {
            GameMaster Battle = new GameMaster("");
            Assert.AreEqual(Battle.Human.Name, "Jack", "Empty player name don't changed to default name 'Jack'");
        }
    }
}
