/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.03.2016
 * Time: 13:37
 */
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Forest
{
    [TestFixture]
    public class ForestTest
    {
        Forest forest = new Forest();
        
        [Test]
        public void ForestCreateTest()
        {
            Assert.AreEqual(forest.CurrentSeason, Season.Spring, "Wrong current season in Forest");
        }
        
        [Test]
        public void AddFirTest()
        {
            forest.Add(TypeOfTree.Fir);
            Assert.That(forest.TreesInForest, Has.Member(TypeOfTree.Fir));
        }

        [Test]
        public void FirWinterColorTest()
        {
            forest.Add(TypeOfTree.Fir);
            forest.CurrentSeason = Season.Winter;
            Assert.That(forest.TreesInForest.Find(x=> x.Type.Equals(TypeOfTree.Fir)).Color, Is.EqualTo("Green"));
        }

        [Test]
        public void FirSummerColorTest()
        {
            forest.Add(TypeOfTree.Fir);
            forest.CurrentSeason = Season.Summer;
            Assert.That(forest.TreesInForest.Find(x=> x.Type.Equals(TypeOfTree.Fir)).Color, Is.EqualTo("Green Too"));
        }
        
        [Test]
        public void FirGrowningTest()
        {
            forest.Add(TypeOfTree.Fir);
            Tree tempFir = forest.TreesInForest.Find(x => x.Type.Equals(TypeOfTree.Fir));
            int tempFirLenght = tempFir.Lenght;
            tempFir.Grow();
            Assert.Greater(tempFirLenght, tempFir.Lenght);
        }

        [Test]
        public void FirIsShapelyTest()
        {
            forest.Add(TypeOfTree.Fir);
            Assert.IsTrue(forest.TreesInForest.Find(x => x.Type.Equals(TypeOfTree.Fir)).Shapely);
        }
        
    }
}
