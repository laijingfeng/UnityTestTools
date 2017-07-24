using System;
using NUnit.Framework;

public class PlayerTestWrong
{
    [Test]
    public void TestHeathWrong()
    {
        Player player = new Player();
        player.Health = 1000;

        player.DamageWrong(200);
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
        player.DamageNoException(500);
        player.DamageNoException(600);
    }
}