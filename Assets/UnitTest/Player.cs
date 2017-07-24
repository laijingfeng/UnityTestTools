using System;

public class Player
{
    public float Health { get; set; }

    #region Correct Function

    public void Damage(float value)
    {
        Health -= value;
        if (Health < 0)
        {
            throw new NegativeHealthException();
        }
    }

    public void Recover(float value)
    {
        Health += value;
    }

    #endregion Correct Function

    #region Wrong Function

    public void DamageWrong(float value)
    {
        Health -= value + 1;
    }

    public void DamageNoException(float value)
    {
        Health -= value;
    }

    #endregion Wrong Function
}

public class NegativeHealthException : ApplicationException
{

}