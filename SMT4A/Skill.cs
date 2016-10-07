using System;

namespace SMT4A
{
    public enum Class : byte
    {
        ANY_CLASS,
        NO_CLASS,
        ATTACK,
        HEALING,
        UTILITY,
        SUPPORT,
        AILMENT,
        PASSIVE,
    }

    public enum Element : byte
    {
        ANY_ELEMENT,
        NO_ELEMENT,
        PHYS,
        GUN,
        FIRE,
        ICE,
        ELEC,
        FORCE,
        LIGHT,
        DARK,
        ALMIGHTY,
    }

    public enum Power : byte
    {
        UNSPECIFIED_POWER,
        NO_DAMAGE,
        WEAK,
        MEDIUM,
        HEAVY,
        SEVERE,
        MEGA,
        VARIES,
        INSTAKILL,
        UNKNOWN_POWER,
    }

    public enum Target : byte
    {
        ANY_TARGET,
        NO_TARGET,
        SELF,
        ALLY,
        ALL_ALLIES,
        ENEMY,
        MULTI,
        ALL_ENEMIES,
        EVERYONE,
    }

    /// <summary>
    /// Id, Name, AttacksLow, AttacksHigh, Power, Element, Class, Target, Effect, MP
    /// </summary>
    class Skill
    {
        public short Id = -1;
        public string Name { get; set; }
        public Class Class = Class.NO_CLASS;
        public Element Element = Element.NO_ELEMENT;
        public Power Power = Power.NO_DAMAGE;
        public Target Target = Target.NO_TARGET;
        public int AttacksLow = 1;
        public int AttacksHigh = 0;
        public int MP = 0;
        public string Effect = "";
    }

    class SkillComparer : IComparable<Skill>
    {
        public int CompareTo(Skill other)
        {
            return other.Id;
        }
    }
}
