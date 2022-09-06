using System;

public class CombatUnit
{
    #region Properties

    /// <summary>
    /// Gets the current Focus value of the unit.
    /// </summary>
    public int FocusCurrent { get; }

    /// <summary>
    /// Gets the maximum Focus value of the unit.
    /// </summary>
    public int FocusMax { get; }

    /// <summary>
    /// Gets the current Stamina value of the unit.
    /// </summary>
    public int StaminaCurrent { get; }

    /// <summary>
    /// Gets the maximum Stamina value of the unit.
    /// </summary>
    public int StaminaMax { get; }

    /// <summary>
    /// Gets the Speed stat value of the unit.
    /// </summary>
    public int Speed { get; }

    /// <summary>
    /// Gets the Agility stat value of the unit.
    /// </summary>
    public int Agility { get; }

    /// <summary>
    /// Gets the Health Points stat value of the unit.
    /// </summary>
    public int HealthPoints { get; }

    /// <summary>
    /// Gets the Ranged Skill stat value of the unit.
    /// </summary>
    public int RangedSkill { get; }

    /// <summary>
    /// Gets the Melee Skill stat value of the unit.
    /// </summary>
    public int MeleeSkill { get; }

    /// <summary>
    /// Gets the Power stat value of the unit.
    /// </summary>
    public int Power { get; }

    /// <summary>
    /// Gets the Toughness stat value of the unit.
    /// </summary>
    public int Toughness { get; }

    /// <summary>
    /// Gets the Luck stat value of the unit.
    /// </summary>
    public int Luck { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Base constructor
    /// </summary>
    public CombatUnit()
    {
        // TODO
    }

    #endregion
}
