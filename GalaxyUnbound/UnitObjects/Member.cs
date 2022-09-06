using System;

public class Member
{
    #region Private Data

    private int _name;
    private int _healthRemaining;
    private int _healthMax;

    #endregion

    #region Properties

    /// <summary>
    /// The name of the member.
    /// </summary>
    public int Name => _name;

    /// <summary>
    /// The amount of health points remaining for the member.
    /// </summary>
    public int HealthRemaining => _healthRemaining;

    /// <summary>
    /// The maximum health points available for the member.
    /// </summary>
    public int HealthMax => _healthMax;

    #endregion

    #region Constructor

    /// <summary>
    /// Base constructor
    /// </summary>
    public Member()
	{
		// TODO
	}

    #endregion
}
