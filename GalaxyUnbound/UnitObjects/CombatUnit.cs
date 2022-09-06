using System;

public class CombatUnit
{
    #region Enums

    /// <summary>
    /// The faction keywords
    /// </summary>
    public enum Factions
    {
        Blue,
        Red,
        Yellow
    }

    /// <summary>
    /// The types of Combat Units
    /// </summary>
    public enum UnitTypes
    {
        Hero,
        Core,
        Elite,
        Strike,
        Heavy
    }

    #endregion

    #region Private Data

    private int _focusRemaining;
    private int _focusMax;
    private int _staminaRemaining;
    private int _staminaMax;
    private int _speed;
    private int _agility;
    private int _healthPoints;
    private int _rangedSkill;
    private int _meleeSkill;
    private int _power;
    private int _toughness;
    private int _luck;
    private List<Member> _members;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the current Focus value of the unit.
    /// </summary>
    public int FocusRemaining => _focusRemaining;

    /// <summary>
    /// Gets the maximum Focus value of the unit.
    /// </summary>
    public int FocusMax => _focusMax;

    /// <summary>
    /// Gets the current Stamina value of the unit.
    /// </summary>
    public int StaminaRemaining => _staminaRemaining;

    /// <summary>
    /// Gets the maximum Stamina value of the unit.
    /// </summary>
    public int StaminaMax => _staminaMax;

    /// <summary>
    /// Gets the Speed stat value of the unit.
    /// </summary>
    public int Speed => _speed;

    /// <summary>
    /// Gets the Agility stat value of the unit.
    /// </summary>
    public int Agility => _agility;

    /// <summary>
    /// Gets the Health Points stat value of the unit.
    /// </summary>
    public int HealthPoints => _healthPoints;

    /// <summary>
    /// Gets the Ranged Skill stat value of the unit.
    /// </summary>
    public int RangedSkill => _rangedSkill;

    /// <summary>
    /// Gets the Melee Skill stat value of the unit.
    /// </summary>
    public int MeleeSkill => _meleeSkill;

    /// <summary>
    /// Gets the Power stat value of the unit.
    /// </summary>
    public int Power => _power;

    /// <summary>
    /// Gets the Toughness stat value of the unit.
    /// </summary>
    public int Toughness => _toughness;

    /// <summary>
    /// Gets the Luck stat value of the unit.
    /// </summary>
    public int Luck => _luck;

    /// <summary>
    /// Gets the list of Members in this unit.
    /// </summary>
    public List<Member> Members => _members;

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
