using System;
using NUnit.Framework;

public class PlayerTest
{
    [Test]
    public void TestHeath()
    {
        Player player = new Player();
        player.Health = 1000;

        player.Damage(200);
        Assert.AreEqual(800, player.Health);

        player.Recover(150);
        Assert.AreEqual(950, player.Health);
    }

    [Test]
    [ExpectedException(typeof(Exception))]
    public void NegativeHealth()
    {
        Player player = new Player();
        player.Health = 1000;
        player.Damage(500);
        player.Damage(600);
    }
}