using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

namespace SMT4A
{
    class SkillCollection
    {
        public static List<Skill> Skills = new List<Skill>();

        public static void SaveToJson()
        {
            File.WriteAllText(
                Application.StartupPath + "/skills.json",
                JsonConvert.SerializeObject(Skills, Formatting.Indented));
        }

        public static void InitializeFromJson()
        {
            try
            {
                Skills = JsonConvert.DeserializeObject<List<Skill>>(
                    File.ReadAllText(
                        Application.StartupPath + "/skills.json"));
            }
            catch (System.IO.IOException)
            {
                Initialize();
                SaveToJson();
            }
        }

        public static void Initialize()
        {
            Skills.Add(new Skill() { Id = 0x1, Name = "Agi", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.WEAK, Target = Target.ENEMY, MP = 3 });
            Skills.Add(new Skill() { Id = 0x2, Name = "Agilao", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 8 });
            Skills.Add(new Skill() { Id = 0x3, Name = "Agidyne", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.HEAVY, Target = Target.ENEMY, MP = 16 });
            Skills.Add(new Skill() { Id = 0x4, Name = "Maragi", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 10 });
            Skills.Add(new Skill() { Id = 0x5, Name = "Maragion", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 20 });
            Skills.Add(new Skill() { Id = 0x6, Name = "Maragidyne", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 38 });
            Skills.Add(new Skill() { Id = 0x7, Name = "Fire Breath", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 17 });
            Skills.Add(new Skill() { Id = 0x8, Name = "Trisagion", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.SEVERE, Target = Target.ENEMY, MP = 32, Effect = "Smirking: Pierce" });
            Skills.Add(new Skill() { Id = 0x9, Name = "Ragnarok", Class = Class.ATTACK, Element = Element.FIRE, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 48 });

            Skills.Add(new Skill() { Id = 0xa, Name = "Bufu", Class = Class.ATTACK, Element = Element.ICE, Power = Power.WEAK, Target = Target.ENEMY, MP = 3 });
            Skills.Add(new Skill() { Id = 0xb, Name = "Bufula", Class = Class.ATTACK, Element = Element.ICE, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 8 });
            Skills.Add(new Skill() { Id = 0xc, Name = "Bufudyne", Class = Class.ATTACK, Element = Element.ICE, Power = Power.HEAVY, Target = Target.ENEMY, MP = 16 });
            Skills.Add(new Skill() { Id = 0xd, Name = "Mabufu", Class = Class.ATTACK, Element = Element.ICE, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 10 });
            Skills.Add(new Skill() { Id = 0xe, Name = "Mabufula", Class = Class.ATTACK, Element = Element.ICE, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 20 });
            Skills.Add(new Skill() { Id = 0xf, Name = "Mabufudyne", Class = Class.ATTACK, Element = Element.ICE, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 38 });
            Skills.Add(new Skill() { Id = 0x10, Name = "Ice Breath", Class = Class.ATTACK, Element = Element.ICE, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 17 });
            Skills.Add(new Skill() { Id = 0x11, Name = "Glacial Blast", Class = Class.ATTACK, Element = Element.ICE, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 48 });
            Skills.Add(new Skill() { Id = 0x12, Name = "Cold World", Class = Class.ATTACK, Element = Element.ICE, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 56, Effect = "Can instant kill" });

            Skills.Add(new Skill() { Id = 0x13, Name = "Zio", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.WEAK, Target = Target.ENEMY, MP = 3 });
            Skills.Add(new Skill() { Id = 0x14, Name = "Zionga", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 8 });
            Skills.Add(new Skill() { Id = 0x15, Name = "Ziodyne", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.HEAVY, Target = Target.ENEMY, MP = 16 });
            Skills.Add(new Skill() { Id = 0x16, Name = "Mazio", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 10 });
            Skills.Add(new Skill() { Id = 0x17, Name = "Mazionga", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 20 });
            Skills.Add(new Skill() { Id = 0x18, Name = "Maziodyne", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 38 });
            Skills.Add(new Skill() { Id = 0x19, Name = "Shock", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 17 });
            Skills.Add(new Skill() { Id = 0x1a, Name = "Thunder Reign", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.SEVERE, Target = Target.ALL_ENEMIES, MP = 56 });

            Skills.Add(new Skill() { Id = 0x1b, Class = Class.ATTACK, Element = Element.FIRE, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x1c, Name = "Zan", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.WEAK, Target = Target.ENEMY, MP = 3 });
            Skills.Add(new Skill() { Id = 0x1d, Name = "Zanma", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 8 });
            Skills.Add(new Skill() { Id = 0x1e, Name = "Zandyne", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.HEAVY, Target = Target.ENEMY, MP = 16 });
            Skills.Add(new Skill() { Id = 0x1f, Name = "Mazan", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 10 });
            Skills.Add(new Skill() { Id = 0x20, Name = "Mazanma", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 20 });
            Skills.Add(new Skill() { Id = 0x21, Name = "Mazandyne", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 38 });
            Skills.Add(new Skill() { Id = 0x22, Name = "Wind Breath", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 17 });
            Skills.Add(new Skill() { Id = 0x23, Name = "Deadly Wind", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.SEVERE, Target = Target.ENEMY, MP = 32, Effect = "Smirking: Pierce" });
            Skills.Add(new Skill() { Id = 0x24, Name = "Floral Gust", Class = Class.ATTACK, Element = Element.FORCE, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 4, MP = 48 });

            Skills.Add(new Skill() { Id = 0x25, Name = "Megido", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 19 });
            Skills.Add(new Skill() { Id = 0x26, Name = "Megidola", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 35 });
            Skills.Add(new Skill() { Id = 0x27, Name = "Megidolaon", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 56 });
            Skills.Add(new Skill() { Id = 0x28, Name = "Great Logos", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.SEVERE, Target = Target.ALL_ENEMIES, MP = 80 });
            Skills.Add(new Skill() { Id = 0x29, Name = "Antichthon", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.SEVERE, Target = Target.ALL_ENEMIES, MP = 88, Effect = "Smirking: Stats down" });
            Skills.Add(new Skill() { Id = 0x2a, Name = "Babylon Goblet", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 56, Effect = "Inflicts Panic" });
            Skills.Add(new Skill() { Id = 0x2b, Name = "Holy Wrath", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Strong vs. Chaos demons" });
            Skills.Add(new Skill() { Id = 0x2c, Name = "Judgement", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Strong vs. Neutral demons" });
            Skills.Add(new Skill() { Id = 0x2d, Name = "Sea of Chaos", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Strong vs. Law demons" });
            Skills.Add(new Skill() { Id = 0x2e, Name = "Life Drain", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.UNKNOWN_POWER, Target = Target.ENEMY, MP = 3, Effect = "Drains enemy HP" });
            Skills.Add(new Skill() { Id = 0x2f, Name = "Spirit Drain", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.UNKNOWN_POWER, Target = Target.ENEMY, MP = 1, Effect = "Drains enemy MP" });
            Skills.Add(new Skill() { Id = 0x30, Name = "Energy Drain", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.UNKNOWN_POWER, Target = Target.ENEMY, MP = 5, Effect = "Drains enemy HP/MP" });

            Skills.Add(new Skill() { Id = 0x31, Name = "Mudo", Class = Class.ATTACK, Element = Element.DARK, Power = Power.WEAK, Target = Target.ENEMY, MP = 4, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x32, Name = "Mudoon", Class = Class.ATTACK, Element = Element.DARK, Power = Power.HEAVY, Target = Target.ENEMY, MP = 10, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x33, Name = "Mamudo", Class = Class.ATTACK, Element = Element.DARK, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 12, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x34, Name = "Mamudoon", Class = Class.ATTACK, Element = Element.DARK, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 22, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x35, Name = "Die for Me!", Class = Class.ATTACK, Element = Element.DARK, Power = Power.SEVERE, Target = Target.ENEMY, MP = 56, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x36, Name = "Hama", Class = Class.ATTACK, Element = Element.LIGHT, Power = Power.WEAK, Target = Target.ENEMY, MP = 4, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x37, Name = "Hamaon", Class = Class.ATTACK, Element = Element.LIGHT, Power = Power.HEAVY, Target = Target.ENEMY, MP = 10, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x38, Name = "Mahama", Class = Class.ATTACK, Element = Element.LIGHT, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 12, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x39, Name = "Mahamaon", Class = Class.ATTACK, Element = Element.LIGHT, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 22, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x3a, Name = "Judgement Light", Class = Class.ATTACK, Element = Element.LIGHT, Power = Power.SEVERE, Target = Target.ALL_ENEMIES, MP = 44, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x3b, Name = "Dormina", Class = Class.AILMENT, Target = Target.ENEMY, MP = 2, Effect = "Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0x3c, Name = "Lullaby", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 16, Effect = "Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0x3d, Name = "Poisma", Class = Class.AILMENT, Target = Target.ENEMY, MP = 2, Effect = "Inflicts Poison" });
            Skills.Add(new Skill() { Id = 0x3e, Name = "Poison Breath", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 11, Effect = "Inflicts Poison" });
            Skills.Add(new Skill() { Id = 0x3f, Name = "Shibaboo", Class = Class.AILMENT, Target = Target.ENEMY, MP = 3, Effect = "Inflicts Bind" });
            Skills.Add(new Skill() { Id = 0x40, Name = "Bind Voice", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 16, Effect = "Inflicts Bind" });
            Skills.Add(new Skill() { Id = 0x41, Name = "Pulinpa", Class = Class.AILMENT, Target = Target.ENEMY, MP = 3, Effect = "Inflicts Panic" });
            Skills.Add(new Skill() { Id = 0x42, Name = "Panic Voice", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 16, Effect = "Inflicts Panic" });
            Skills.Add(new Skill() { Id = 0x43, Name = "Cough", Class = Class.AILMENT, Target = Target.ENEMY, MP = 4, Effect = "Inflicts Sick" });
            Skills.Add(new Skill() { Id = 0x44, Name = "Pandemic Bomb", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 15, Effect = "Inflicts Sick" });
            Skills.Add(new Skill() { Id = 0x45, Name = "Ancient Curse", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Inflicts a random ailment" });
            Skills.Add(new Skill() { Id = 0x46, Name = "Shivering Taboo", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Inflicts several ailments" });

            Skills.Add(new Skill() { Id = 0x47, Name = "Strange Ray", Class = Class.UTILITY, Element = Element.ALMIGHTY, Target = Target.ENEMY, MP = 5, Effect = "Decreases MP" });
            Skills.Add(new Skill() { Id = 0x48, Name = "Enigmatic Ray", Class = Class.UTILITY, Element = Element.ALMIGHTY, Target = Target.ALL_ENEMIES, MP = 10, Effect = "Decreases MP" });
            Skills.Add(new Skill() { Id = 0x49, Name = "Macca Beam", Class = Class.UTILITY, Element = Element.ALMIGHTY, Target = Target.ENEMY, MP = 5, Effect = "Decreases Macca" });
            Skills.Add(new Skill() { Id = 0x4a, Name = "Wastrel Beam", Class = Class.UTILITY, Element = Element.ALMIGHTY, Target = Target.ENEMY, MP = 10, Effect = "Decreases more Macca" });
            Skills.Add(new Skill() { Id = 0x4b, Name = "Crushing Wave", Class = Class.UTILITY, Element = Element.ALMIGHTY, Power = Power.VARIES, Target = Target.ENEMY, MP = 10, Effect = "Reduces HP to 1" });

            Skills.Add(new Skill() { Id = 0x4c, Name = "Breath", Class = Class.ATTACK, Element = Element.ICE, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 5, MP = 24 });

            Skills.Add(new Skill() { Id = 0x4d, Name = "Death's Door", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 15, Effect = "Sick enemies reduced to 1 HP" });

            Skills.Add(new Skill() { Id = 0x4e, Name = "Makakaja", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 10, Effect = "Increases Magic " });

            Skills.Add(new Skill() { Id = 0x4f, Name = "Marin Karin", Class = Class.AILMENT, Target = Target.ENEMY, MP = 3, Effect = "Inflicts Charm" });
            Skills.Add(new Skill() { Id = 0x50, Name = "Sexy Dance", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 16, Effect = "Inflicts Charm" });

            Skills.Add(new Skill() { Id = 0x51, Name = "Dia", Class = Class.SUPPORT, Target = Target.ALLY, MP = 6, Effect = "Heals HP" });
            Skills.Add(new Skill() { Id = 0x52, Name = "Diarama", Class = Class.SUPPORT, Target = Target.ALLY, MP = 12, Effect = "Greatly heals HP" });
            Skills.Add(new Skill() { Id = 0x53, Name = "Diarahan", Class = Class.SUPPORT, Target = Target.ALLY, MP = 15, Effect = "Fully heals HP" });
            Skills.Add(new Skill() { Id = 0x54, Name = "Media", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 20, Effect = "Heals HP" });
            Skills.Add(new Skill() { Id = 0x55, Name = "Mediarama", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 38, Effect = "Greatly heals HP" });
            Skills.Add(new Skill() { Id = 0x56, Name = "Mediarahan", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 45, Effect = "Fully heals HP" });
            Skills.Add(new Skill() { Id = 0x57, Name = "Salvation", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 50, Effect = "Fully heals HP. Smirking: Removes ailments" });

            Skills.Add(new Skill() { Id = 0x58, Name = "Patra", Class = Class.SUPPORT, Target = Target.ALLY, MP = 1, Effect = "Removes Sleep/Panic/Bind/Charm/Mute/Daze" });
            Skills.Add(new Skill() { Id = 0x59, Name = "Me Patra", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 8, Effect = "Removes Sleep/Panic/Bind/Charm/Mute/Daze" });
            Skills.Add(new Skill() { Id = 0x5a, Name = "Posmudi", Class = Class.SUPPORT, Target = Target.ALLY, MP = 1, Effect = "Removes Poison/Sick" });

            Skills.Add(new Skill() { Id = 0x5b, Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.HEAVY, Target = Target.MULTI, AttacksLow = 2, AttacksHigh = 4, MP = 1, Effect = "Inflicts Brand" });

            Skills.Add(new Skill() { Id = 0x5c, Name = "Amrita", Class = Class.SUPPORT, Target = Target.ALLY, MP = 10, Effect = "Removes all ailments" });
            Skills.Add(new Skill() { Id = 0x5d, Name = "Recarm", Class = Class.SUPPORT, Target = Target.ALLY, MP = 10, Effect = "Revives from KO with half HP" });
            Skills.Add(new Skill() { Id = 0x5e, Name = "Samarecarm", Class = Class.SUPPORT, Target = Target.ALLY, MP = 20, Effect = "Revives from KO with full HP" });
            Skills.Add(new Skill() { Id = 0x5f, Name = "Recarmdra", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 6, Effect = "Revives and fully heals at cost of caster's life" });

            Skills.Add(new Skill() { Id = 0x60, Name = "Hell Thrust", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.MULTI, AttacksLow = 2, AttacksHigh = 4, MP = 22, Effect = "Smirking: Defense down" });

            Skills.Add(new Skill() { Id = 0x61, Name = "Thunder Gods", Class = Class.ATTACK, Element = Element.ELEC, Power = Power.SEVERE, Target = Target.ENEMY, MP = 32, Effect = "Smirking: Pierce" });

            Skills.Add(new Skill() { Id = 0x62, Name = "Ice Age", Class = Class.ATTACK, Element = Element.ICE, Power = Power.SEVERE, Target = Target.ENEMY, MP = 32, Effect = "Smirking: Pierce" });

            Skills.Add(new Skill() { Id = 0x63, Name = "Makajam", Class = Class.AILMENT, Target = Target.ENEMY, MP = 2, Effect = "Inflicts Mute" });
            Skills.Add(new Skill() { Id = 0x64, Name = "Makajamaon", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 11, Effect = "Inflicts Mute" });

            Skills.Add(new Skill() { Id = 0x65, Name = "Tarukaja", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 10, Effect = "Increases Attack" });
            Skills.Add(new Skill() { Id = 0x66, Name = "Sukukaja", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 10, Effect = "Increases Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x67, Name = "Rakukaja", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 10, Effect = "Increases Defense" });
            Skills.Add(new Skill() { Id = 0x68, Name = "Luster Candy", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 40, Effect = "Increases Attack/Defense/Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x69, Name = "Dekaja", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 15, Effect = "Removes status buffs" });
            Skills.Add(new Skill() { Id = 0x6a, Name = "Tarunda", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 10, Effect = "Decreases Attack" });
            Skills.Add(new Skill() { Id = 0x6b, Name = "Sukunda", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 10, Effect = "Decreases Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x6c, Name = "Rakunda", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 10, Effect = "Decreases Defense" });
            Skills.Add(new Skill() { Id = 0x6d, Name = "Debilitate", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Decreases Attack/Defense/Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x6e, Name = "Dekunda", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 15, Effect = "Removes status debuffs" });
            Skills.Add(new Skill() { Id = 0x6f, Name = "Silent Prayer", Class = Class.STATUS, Target = Target.EVERYONE, MP = 10, Effect = "Return all stats to normal" });
            Skills.Add(new Skill() { Id = 0x70, Name = "War Cry", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Decreases Attack/Defense" });
            Skills.Add(new Skill() { Id = 0x71, Name = "Fog Breath", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Decreases Attack/Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x72, Name = "Acid Breath", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Decreases Defense/Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x73, Name = "Taunt", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 10, Effect = "Increase Attack, decreases Defense" });
            Skills.Add(new Skill() { Id = 0x74, Name = "Critical Eye", Class = Class.STATUS, Target = Target.SELF, MP = 6, Effect = "Next Phys/Gun attack will be a critical hit" });

            Skills.Add(new Skill() { Id = 0x75, Class = Class.ATTACK, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Attack power changes based on number of status ailments" });

            Skills.Add(new Skill() { Id = 0x76, Name = "Tetrakarn", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 25, Effect = "Repels Phys/Gun attacks until your next turn" });
            Skills.Add(new Skill() { Id = 0x77, Name = "Makarakarn", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 25, Effect = "Repels Magic attacks until your next turn" });
            Skills.Add(new Skill() { Id = 0x78, Name = "Tetraja", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 5, Effect = "Nulls one Light or Dark attack" });
            Skills.Add(new Skill() { Id = 0x79, Name = "Charge", Class = Class.STATUS, Target = Target.SELF, MP = 4, Effect = "Next Phys/Gun attack deals 2.5x damage" });
            Skills.Add(new Skill() { Id = 0x7a, Name = "Concentrate", Class = Class.STATUS, Target = Target.SELF, MP = 6, Effect = "Next Magic attack deals 2.5x damage" });
            Skills.Add(new Skill() { Id = 0x7b, Name = "Blood Ritual", Class = Class.STATUS, Target = Target.SELF, MP = 10, Effect = "Applies all status buffs, but reduces HP to 1" });

            Skills.Add(new Skill() { Id = 0x7c, Name = "Sabbatama", Class = Class.UTILITY, Target = Target.ALLY, MP = 20, Effect = "Summons an ally demon" });
            Skills.Add(new Skill() { Id = 0x7d, Name = "Invitation", Class = Class.UTILITY, Target = Target.ALLY, MP = 65, Effect = "Summons an ally demon and revives from KO" });

            Skills.Add(new Skill() { Id = 0x7e, Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Smirking: Pierce, Stats down" });

            Skills.Add(new Skill() { Id = 0x7f, Name = "Bad Company", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 5, Effect = "Summons your highest level demons from stock" });

            Skills.Add(new Skill() { Id = 0x80, Name = "Dia", Class = Class.SUPPORT, Target = Target.ALLY, MP = 1, Effect = "Heals HP" });
            Skills.Add(new Skill() { Id = 0x81, Name = "Diarama", Class = Class.SUPPORT, Target = Target.ALLY, MP = 1, Effect = "Greatly heals HP" });
            Skills.Add(new Skill() { Id = 0x82, Name = "Media", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 1, Effect = "Heals HP" });
            Skills.Add(new Skill() { Id = 0x83, Name = "Mediarama", Class = Class.SUPPORT, Target = Target.ALL_ALLIES, MP = 1, Effect = "Greatly heals HP" });

            Skills.Add(new Skill() { Id = 0x84, Name = "Smile Charge", Class = Class.STATUS, Target = Target.SELF, MP = 25, Effect = "Induces Smirk if not suffering from ailments" });
            Skills.Add(new Skill() { Id = 0x85, Name = "Magaon", Class = Class.STATUS, Target = Target.ENEMY, MP = 5, Effect = "Removes Smirk" });

            Skills.Add(new Skill() { Id = 0x86, Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts Panic. Smirking: Pierce" });
            Skills.Add(new Skill() { Id = 0x87, Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts 66% of target's HP as Almighty damage" });

            Skills.Add(new Skill() { Id = 0x88, Class = Class.ATTACK, Element = Element.LIGHT, Power = Power.SEVERE, Target = Target.ENEMY, MP = 1, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x89, Name = "Trafuri", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 1, Effect = "Guaranteed escape when possible" });

            Skills.Add(new Skill() { Id = 0x8a, Name = "Doping", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 50, Effect = "Increases max HP during battle" });
            Skills.Add(new Skill() { Id = 0x8b, Class = Class.STATUS, Target = Target.SELF, MP = 1, Effect = "Induces Smirk. Fully increases Attack and Magic" });

            Skills.Add(new Skill() { Id = 0x8c, Name = "Estoma", Class = Class.UTILITY, MP = 25, Effect = "Avoid battles with low-level demons while skill is in effect" });
            Skills.Add(new Skill() { Id = 0x8d, Name = "Call Ally", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 1, Effect = "Calls an ally" });
            Skills.Add(new Skill() { Id = 0x8e, Name = "Glare", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 1, Effect = "No effect" });
            Skills.Add(new Skill() { Id = 0x8f, Name = "Do Nothing", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 1, Effect = "No effect" });
            Skills.Add(new Skill() { Id = 0x90, Name = "No Reaction", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 1, Effect = "No effect" });

            Skills.Add(new Skill() { Id = 0x91, Class = Class.STATUS, Target = Target.ENEMY, MP = 1, Effect = "Fully decreases Attack and Magic. Inflicts Mute" });
            Skills.Add(new Skill() { Id = 0x92, Class = Class.STATUS, Target = Target.ENEMY, MP = 1, Effect = "Fully decreases Defense. Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0x93, Class = Class.STATUS, Target = Target.ENEMY, MP = 1, Effect = "Fully decreases Hit/Evade rate. Inflicts Brand" });

            Skills.Add(new Skill() { Id = 0x94, Name = "Eternal Rest", Class = Class.ATTACK, Target = Target.EVERYONE, MP = 25, Effect = "Instant kills sleeping targets" });

            Skills.Add(new Skill() { Id = 0x95, Name = "Frenzied Chomp", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 4, Effect = "Inflicts Poison/Bind/Charm" });
            Skills.Add(new Skill() { Id = 0x96, Name = "Eat Whole", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 12, Effect = "Drains enemy HP" });
            Skills.Add(new Skill() { Id = 0x97, Name = "Lunge", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 4, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x98, Name = "Oni-Kagura", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 7, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x99, Name = "Mortal Jihad", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ENEMY, MP = 12, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x9a, Name = "Critical Wave", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 10, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x9b, Name = "Megaton Press", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 16, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x9c, Name = "Titanomachia", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 27, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x9d, Name = "Gram Slice", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 3 });
            Skills.Add(new Skill() { Id = 0x9e, Name = "Fatal Sword", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 6 });
            Skills.Add(new Skill() { Id = 0x9f, Name = "Berserker God", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ENEMY, MP = 11 });
            Skills.Add(new Skill() { Id = 0xa0, Name = "Heat Wave", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 11 });
            Skills.Add(new Skill() { Id = 0xa1, Name = "Javelin Rain", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 25 });
            Skills.Add(new Skill() { Id = 0xa2, Name = "Hades Blast", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 42 });
            Skills.Add(new Skill() { Id = 0xa3, Name = "Bouncing Claw", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, AttacksLow = 1, AttacksHigh = 3, MP = 4 });
            Skills.Add(new Skill() { Id = 0xa4, Name = "Damascus Claw", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, AttacksLow = 1, AttacksHigh = 3, MP = 7 });
            Skills.Add(new Skill() { Id = 0xa5, Name = "Nihil Claw", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ENEMY, AttacksLow = 1, AttacksHigh = 3, MP = 7 });
            Skills.Add(new Skill() { Id = 0xa6, Name = "Scratch Dance", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 3, MP = 7 });
            Skills.Add(new Skill() { Id = 0xa7, Name = "Axel Claw", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 3, MP = 12 });
            Skills.Add(new Skill() { Id = 0xa8, Name = "Madness Nails", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 3, MP = 20 });
            Skills.Add(new Skill() { Id = 0xa9, Name = "Fang Breaker", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 10, Effect = "Attack down" });
            Skills.Add(new Skill() { Id = 0xaa, Name = "Dream Fist", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 7, Effect = "Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0xab, Name = "Purple Smoke", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 3, MP = 18, Effect = "Inflicts Panic" });
            Skills.Add(new Skill() { Id = 0xac, Name = "Carol Hit", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 11, Effect = "Inflicts Lost" });
            Skills.Add(new Skill() { Id = 0xad, Name = "Mist Rush", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 2, AttacksHigh = 4, MP = 22, Effect = "Inflicts Daze" });
            Skills.Add(new Skill() { Id = 0xae, Name = "Tetanus Cut", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 9, Effect = "Inflicts Sick" });
            Skills.Add(new Skill() { Id = 0xaf, Name = "Dark Sword", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, AttacksLow = 2, MP = 12, Effect = "Inflicts Mute" });
            Skills.Add(new Skill() { Id = 0xb0, Name = "Blight", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 14, Effect = "Inflicts Poison" });

            Skills.Add(new Skill() { Id = 0xb1, Class = Class.ATTACK, Element = Element.ICE, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0xb2, Name = "Binding Claw", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 9, Effect = "Inflicts Bind" });
            Skills.Add(new Skill() { Id = 0xb3, Name = "Poison Claw", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 7, Effect = "Inflicts Poison" });
            Skills.Add(new Skill() { Id = 0xb4, Name = "Iron Judgement", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 6 });

            Skills.Add(new Skill() { Id = 0xb5, Name = "Needle Shot", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ENEMY, MP = 2 });
            Skills.Add(new Skill() { Id = 0xb6, Name = "Tathlum Shot", Class = Class.ATTACK, Element = Element.GUN, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 5 });
            Skills.Add(new Skill() { Id = 0xb7, Name = "Grand Tack", Class = Class.ATTACK, Element = Element.GUN, Power = Power.HEAVY, Target = Target.ENEMY, MP = 9 });
            Skills.Add(new Skill() { Id = 0xb8, Name = "Riot Gun", Class = Class.ATTACK, Element = Element.GUN, Power = Power.SEVERE, Target = Target.ENEMY, MP = 24, Effect = "Smirking: Pierce" });
            Skills.Add(new Skill() { Id = 0xb9, Name = "Rapid Needle", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 9 });
            Skills.Add(new Skill() { Id = 0xba, Name = "Blast Arrow", Class = Class.ATTACK, Element = Element.GUN, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 15 });
            Skills.Add(new Skill() { Id = 0xbb, Name = "Heaven's Bow", Class = Class.ATTACK, Element = Element.GUN, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 27 });
            Skills.Add(new Skill() { Id = 0xbc, Name = "Dream Needle", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ENEMY, MP = 7, Effect = "Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0xbd, Name = "Toxic String", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ENEMY, MP = 7, Effect = "Inflicts Poison" });
            Skills.Add(new Skill() { Id = 0xbe, Name = "Stun Needle", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ENEMY, MP = 9, Effect = "Inflicts Bind" });
            Skills.Add(new Skill() { Id = 0xbf, Name = "Madness Needle", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ENEMY, MP = 9, Effect = "Inflicts Panic" });
            Skills.Add(new Skill() { Id = 0xc0, Name = "Stun Needles", Class = Class.ATTACK, Element = Element.GUN, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 3, MP = 18, Effect = "Inflicts Bind" });
            Skills.Add(new Skill() { Id = 0xc1, Name = "Myriad Arrows", Class = Class.ATTACK, Element = Element.GUN, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 2, AttacksHigh = 4, MP = 22 });

            Skills.Add(new Skill() { Id = 0xc2, Name = "Desperate Hit", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 5, MP = 32 });

            Skills.Add(new Skill() { Id = 0xc3, Name = "Sleep Shot", Class = Class.ATTACK, Element = Element.GUN, Power = Power.WEAK, Target = Target.ENEMY, MP = 7, Effect = "Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0xc4, Name = "Rapid Bind", Class = Class.ATTACK, Element = Element.GUN, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 1, AttacksHigh = 3, MP = 12, Effect = "Inflicts Bind" });

            Skills.Add(new Skill() { Id = 0xc5, Name = "Head Crush", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.ENEMY, MP = 4, Effect = "Inflicts Daze" });
            Skills.Add(new Skill() { Id = 0xc6, Name = "Power Punch", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 7, Effect = "Smirking: Daze" });
            Skills.Add(new Skill() { Id = 0xc7, Name = "Earthquake", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 19, Effect = "Inflicts Daze" });

            Skills.Add(new Skill() { Id = 0xc8, Name = "Assist Attack 2", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 2, MP = 1 });
            Skills.Add(new Skill() { Id = 0xc9, Name = "Assist Attack 4", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 4, MP = 1 });
            Skills.Add(new Skill() { Id = 0xca, Name = "Assist Attack 6", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 6, MP = 1 });
            Skills.Add(new Skill() { Id = 0xcb, Name = "Assist Attack 8", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 8, MP = 1 });
            Skills.Add(new Skill() { Id = 0xcc, Name = "Assist Attack 10", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 10, MP = 1 });
            Skills.Add(new Skill() { Id = 0xcd, Name = "Assist Attack 12", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 12, MP = 1 });
            Skills.Add(new Skill() { Id = 0xce, Name = "Assist Attack 14", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 14, MP = 1 });
            Skills.Add(new Skill() { Id = 0xcf, Name = "Assist Attack 0", MP = 1 });

            Skills.Add(new Skill() { Id = 0xd0, Name = "Will of Flame", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 15, Effect = "Fire attacks pierce until end of your turn" });
            Skills.Add(new Skill() { Id = 0xd1, Name = "Will of Frost", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 15, Effect = "Ice attacks pierce until end of your turn" });
            Skills.Add(new Skill() { Id = 0xd2, Name = "Will of Thunder", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 15, Effect = "Elec attacks pierce until end of your turn" });
            Skills.Add(new Skill() { Id = 0xd3, Name = "Will of Wind", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 15, Effect = "Force attacks pierce until end of your turn" });

            Skills.Add(new Skill() { Id = 0xd4, Name = "Coercion", Class = Class.UTILITY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Remove 1 Press Turn Icon on enemy's next turn" });
            Skills.Add(new Skill() { Id = 0xd5, Name = "Imposing Stance", Class = Class.UTILITY, Target = Target.SELF, MP = 25, Effect = "Remove 1 Press Turn Icon on enemy's next turn" });

            Skills.Add(new Skill() { Id = 0xd6, Name = "Spear of Michael", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 8 });
            Skills.Add(new Skill() { Id = 0xd7, Name = "Gungnir", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.SEVERE, Target = Target.ENEMY, MP = 22, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0xd8, Name = "Normal Attack 1", Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Asahi performs a basic attack" });
            Skills.Add(new Skill() { Id = 0xd9, Name = "Normal Attack 2", Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Asahi performs a basic attack" });
            Skills.Add(new Skill() { Id = 0xda, Name = "Normal Attack 3", Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Asahi performs a basic attack" });
            Skills.Add(new Skill() { Id = 0xdb, Name = "Normal Attack 4", Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Asahi performs a basic attack" });
            Skills.Add(new Skill() { Id = 0xdc, Name = "Normal Attack 5", Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Asahi performs a basic attack" });

            Skills.Add(new Skill() { Id = 0xdd, Name = "Mouth of God", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.INSTAKILL, Target = Target.ENEMY, MP = 1, Effect = "Instant kill attack" });

            Skills.Add(new Skill() { Id = 0xde, Name = "Michael's Strike", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ALL_ENEMIES, MP = 19 });
            Skills.Add(new Skill() { Id = 0xdf, Name = "Michael's Syphon", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 13, Effect = "Drains enemy HP" });
            Skills.Add(new Skill() { Id = 0xe0, Name = "Michael's Twin Strike", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.WEAK, Target = Target.MULTI, AttacksLow = 2, MP = 16 });
            Skills.Add(new Skill() { Id = 0xe1, Name = "Michael's Pierce", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 22, Effect = "Removes status buffs" });

            Skills.Add(new Skill() { Id = 0xe2, Name = "Cheer", Class = Class.STATUS, Target = Target.ALLY, MP = 50, Effect = "Induces Smirk if not suffering from ailments" });

            Skills.Add(new Skill() { Id = 0xe3, Name = "Gungnir Strike", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Pierce" });
            Skills.Add(new Skill() { Id = 0xe4, Name = "Gungnir Syphon", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ENEMY, MP = 20, Effect = "Drains enemy HP. Pierce." });
            Skills.Add(new Skill() { Id = 0xe5, Name = "Gungnir Twin Strike", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.MULTI, AttacksLow = 2, MP = 26, Effect = "Pierce" });
            Skills.Add(new Skill() { Id = 0xe6, Name = "Gungnir Pierce", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.HEAVY, Target = Target.ENEMY, MP = 34, Effect = "Pierce, removes status buffs" });
            Skills.Add(new Skill() { Id = 0xe7, Name = "Gungnir Sever", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, AttacksLow = 6, MP = 37, Effect = "Low hit rate. Pierce" });

            Skills.Add(new Skill() { Id = 0xe8, Name = "Enduring Cheer", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 30, Effect = "Grants targets Endure until end of turn. Chance: Medium" });
            Skills.Add(new Skill() { Id = 0xe9, Name = "Warding Shout", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 30, Effect = "Prevents status ailments until the next turn" });

            Skills.Add(new Skill() { Id = 0xea, Name = "Pierce Armor", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 16, Effect = "Pierce, Defense down" });
            Skills.Add(new Skill() { Id = 0xeb, Name = "Assassin's Nata", Class = Class.ATTACK, Element = Element.PHYS, Power = Power.MEDIUM, Target = Target.ENEMY, MP = 19, Effect = "Ailments increase power" });

            Skills.Add(new Skill() { Id = 0xec, Name = "Enlightment", Class = Class.STATUS, Target = Target.SELF, MP = 8, Effect = "Drains weakness until your next turn. Smirking: Stats up" });

            Skills.Add(new Skill() { Id = 0xed, Name = "5.67 Billion Hands", Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.WEAK, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Smirking: More power" });

            Skills.Add(new Skill() { Id = 0xee, Name = "Venomous Raga", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 65, Effect = "Inflicts Poison/Sick/Bind/Attack down" });
            Skills.Add(new Skill() { Id = 0xef, Name = "Dream Raga", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 65, Effect = "Inflicts Poison/Sick/Bind/Defense down" });

            Skills.Add(new Skill() { Id = 0xf0, Name = "Temporal Blade", Power = Power.INSTAKILL, Class = Class.ATTACK, Element = Element.PHYS, Target = Target.ENEMY, MP = 1, Effect = "Might make Phys attack at start of battle" });
            Skills.Add(new Skill() { Id = 0xf1, Name = "Sneak Attack", Power = Power.INSTAKILL, Class = Class.ATTACK, Element = Element.PHYS, Target = Target.ENEMY, MP = 1, Effect = "Pierce. Might make Phys attack during enemy turn" });

            Skills.Add(new Skill() { Id = 0xf2, Name = "Infernal Hail", Power = Power.MEDIUM, Element = Element.ICE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Hit/Evade down" });

            Skills.Add(new Skill() { Id = 0xf3, Name = "Needlestorm", Power = Power.MEDIUM, Element = Element.FORCE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Inflicts Daze" });

            Skills.Add(new Skill() { Id = 0xf4, Name = "Photo Flash", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 20, Effect = "Inflicts Daze/Hit/Evade down" });
            Skills.Add(new Skill() { Id = 0xf5, Name = "Seducing Shot", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Inflicts Charm/Attack down" });

            Skills.Add(new Skill() { Id = 0xf6, Name = "Mother's Discipline", Power = Power.MEDIUM, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Removes Smirk" });

            Skills.Add(new Skill() { Id = 0xf7, Name = "Hellish Brand", Power = Power.HEAVY, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 20, Effect = "Removes status buffs" });

            Skills.Add(new Skill() { Id = 0xf8, Name = "Grand Tack A", Power = Power.HEAVY, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ENEMY, MP = 11 });
            Skills.Add(new Skill() { Id = 0xf9, Name = "Grand Tack B", Power = Power.HEAVY, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ENEMY, MP = 11 });

            Skills.Add(new Skill() { Id = 0xfa, Name = "King Bufula", Power = Power.MEDIUM, Element = Element.ICE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 24, Effect = "Smirking: Defense down" });

            Skills.Add(new Skill() { Id = 0xfb, Name = "Vengeful Curse", Target = Target.SELF, MP = 1 });

            Skills.Add(new Skill() { Id = 0xfc, Name = "Snake's Fangs", Power = Power.HEAVY, Element = Element.GUN, Class = Class.ATTACK, Target = Target.MULTI, AttacksLow = 2, AttacksHigh = 3, MP = 1 });

            Skills.Add(new Skill() { Id = 0xfd, Class = Class.STATUS, Target = Target.SELF, MP = 40, Effect = "Changes your weakness when exploited" });

            Skills.Add(new Skill() { Id = 0xfe, Class = Class.AILMENT, Target = Target.ENEMY, MP = 45, Effect = "Fully decreases Defense. Inflicts Charm" });

            Skills.Add(new Skill() { Id = 0xff, Power = Power.SEVERE, Element = Element.LIGHT, Class = Class.ATTACK, Target = Target.ENEMY, MP = 36, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x100, Power = Power.VARIES, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 100, Effect = "Light resistance affects power eg. Nu=Mega" });

            Skills.Add(new Skill() { Id = 0x101, Power = Power.SEVERE, Element = Element.DARK, Class = Class.ATTACK, Target = Target.ENEMY, MP = 36, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x102, Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, AttacksLow = 2, MP = 30, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x103, Class = Class.STATUS, Target = Target.SELF, MP = 50, Effect = "Fully increases Defense/Hit/Evade rate" });

            Skills.Add(new Skill() { Id = 0x104, Class = Class.UTILITY, Target = Target.SELF, MP = 1, Effect = "When hit next, inflict the same damage. Smirking: Continuous" });
            Skills.Add(new Skill() { Id = 0x105, Class = Class.UTILITY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "When hit next, inflict the same damage. Smirking: Continuous" });

            Skills.Add(new Skill() { Id = 0x106, Class = Class.STATUS, Target = Target.SELF, MP = 1 });

            Skills.Add(new Skill() { Id = 0x107, Name = "Blank Bullet", AttacksLow = 2, Power = Power.MEDIUM, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 22, Effect = "Inflicts Panic" });

            Skills.Add(new Skill() { Id = 0x108, Class = Class.ATTACK, Element = Element.ALMIGHTY, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts 50% of target's HP as Almighty damage" });

            Skills.Add(new Skill() { Id = 0x109, Name = "Evil Gleam", Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 110, Effect = "Inflicts Panic" });

            Skills.Add(new Skill() { Id = 0x10a, Name = "Kingly One", Class = Class.UTILITY, Target = Target.ENEMY, MP = 1, Effect = "Randomly returns a target back to the stock" });

            Skills.Add(new Skill() { Id = 0x10b, Name = "Morning Star", Class = Class.ATTACK, Power = Power.VARIES, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Halves HP of all enemies" });

            Skills.Add(new Skill() { Id = 0x10c, Name = "Chariot", Power = Power.MEDIUM, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 60, Effect = "Hit/Evade down" });
            Skills.Add(new Skill() { Id = 0x10d, Name = "Shalt Not Resist", AttacksLow = 2, Power = Power.MEGA, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.MULTI, MP = 1, Effect = "Defense down" });

            Skills.Add(new Skill() { Id = 0x10e, Name = "Hexagram", Power = Power.INSTAKILL, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Never misses. May fail on bosses." });

            Skills.Add(new Skill() { Id = 0x10f, Power = Power.HEAVY, Element = Element.ELEC, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Pierce" });
            Skills.Add(new Skill() { Id = 0x110, Power = Power.HEAVY, Element = Element.FORCE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x111, Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x112, Class = Class.UTILITY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Removes 3 Press Turn icons on enemy's next turn" });
            Skills.Add(new Skill() { Id = 0x113, Class = Class.UTILITY, Target = Target.SELF, MP = 1, Effect = "Removes 3 Press Turn icons on enemy's next turn" });

            Skills.Add(new Skill() { Id = 0x114, Name = "Combat Tara", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 60, Effect = "Increases Attack/Defense/Hit/Evade rate" });

            Skills.Add(new Skill() { Id = 0x115, Name = "Moxagita", Power = Power.VARIES, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Attack power changes based on number of status ailments" });

            Skills.Add(new Skill() { Id = 0x116, Name = "Ideals of Maruology", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts Sleep" });
            Skills.Add(new Skill() { Id = 0x117, Name = "Maruology Anthem", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts Panic" });

            Skills.Add(new Skill() { Id = 0x118, Name = "Watch Us, Maruo!", AttacksLow = 1, AttacksHigh = 3, Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, MP = 1, Effect = "Inflicts Panic" });
            Skills.Add(new Skill() { Id = 0x119, Name = "Gaze Upon Maruo!", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts Daze" });

            Skills.Add(new Skill() { Id = 0x11a, Name = "Maru-Maru Dance", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts Charm" });

            Skills.Add(new Skill() { Id = 0x11b, Name = "Good Night, Baby", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Inflicts Sleep" });

            Skills.Add(new Skill() { Id = 0x11c, Name = "Being Myself", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts Bind" });

            Skills.Add(new Skill() { Id = 0x11d, Name = "As I Wish", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "High critical/low hit rate" });
            Skills.Add(new Skill() { Id = 0x11e, Name = "Thousand Heads", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "High critical rate" });
            Skills.Add(new Skill() { Id = 0x11f, Name = "Serpent's Hunger", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Inflicts Poison/Bind/Charm" });
            Skills.Add(new Skill() { Id = 0x120, Name = "Seismic Yawm", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "High critical rate" });

            Skills.Add(new Skill() { Id = 0x121, Name = "Wave of Endless Power", Power = Power.MEDIUM, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1 });

            Skills.Add(new Skill() { Id = 0x122, Name = "Venomous Flare", Power = Power.WEAK, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Inflicts poison" });

            Skills.Add(new Skill() { Id = 0x123, Name = "Illogical Rejection", Class = Class.STATUS, Target = Target.SELF, MP = 1, Effect = "Nulls Dekaja for 1 turn" });

            Skills.Add(new Skill() { Id = 0x124, Name = "Miracle", Power = Power.VARIES, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Reduces HP to 1" });

            Skills.Add(new Skill() { Id = 0x125, Name = "Vengeful Curse", Power = Power.UNKNOWN_POWER, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Drains enemy MP" });

            Skills.Add(new Skill() { Id = 0x126, Name = "Dark Grudge", Power = Power.SEVERE, Element = Element.DARK, Class = Class.ATTACK, Target = Target.ENEMY, MP = 30, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x127, Name = "Divine Harmony", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Nulls all support effects" });

            Skills.Add(new Skill() { Id = 0x128, Name = "Planned Chaos", Power = Power.MEDIUM, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Inflicts Bind/Panic/Charm" });

            Skills.Add(new Skill() { Id = 0x129, Name = "Mouth of God", Power = Power.INSTAKILL, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });

            Skills.Add(new Skill() { Id = 0x12a, Name = "Makabuild", Class = Class.STATUS, Target = Target.SELF, MP = 1, Effect = "Greatly increases Magic" });

            Skills.Add(new Skill() { Id = 0x12b, Name = "Lost Hit", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Inflicts Lost" });

            Skills.Add(new Skill() { Id = 0x12c, Name = "Denial", Class = Class.UTILITY, Target = Target.ENEMY, MP = 1, Effect = "Returns a random target to the stock" });

            Skills.Add(new Skill() { Id = 0x12d, Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Inflicts Brand" });

            Skills.Add(new Skill() { Id = 0x12e, Name = "Lightning of God", Power = Power.HEAVY, Element = Element.ELEC, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x12f, Name = "Tetrabreak", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 15, Effect = "Removes the Tetrakarn effect" });

            Skills.Add(new Skill() { Id = 0x130, Name = "Thousand Heads", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Nulls all support effects" });

            Skills.Add(new Skill() { Id = 0x131, Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });

            Skills.Add(new Skill() { Id = 0x132, Name = "Tornado of God", Power = Power.HEAVY, Element = Element.FORCE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x133, Power = Power.MEDIUM, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Inflicts Bind/Panic/Charm" });

            Skills.Add(new Skill() { Id = 0x134, Name = "Hailstorm of God", Power = Power.HEAVY, Element = Element.ICE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x135, Name = "Makarabreak", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 15, Effect = "Removes the Makarakarn effect" });

            Skills.Add(new Skill() { Id = 0x136, AttacksLow = 6, AttacksHigh = 10, Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, MP = 1 });

            Skills.Add(new Skill() { Id = 0x137, Power = Power.UNKNOWN_POWER, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Drains enemy MP" });

            Skills.Add(new Skill() { Id = 0x138, Name = "Inferno of God", Power = Power.HEAVY, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x139, Power = Power.MEDIUM, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 30, Effect = "Weakens random resist. Pierce" });

            Skills.Add(new Skill() { Id = 0x13a, AttacksLow = 2, Power = Power.MEDIUM, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 25, Effect = "Hit/Evade down" });

            Skills.Add(new Skill() { Id = 0x13b, Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 80, Effect = "Weakens random resist. Pierce" });

            Skills.Add(new Skill() { Id = 0x13c, Power = Power.MEDIUM, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ENEMY, MP = 30, Effect = "Weakens random resist. Pierce" });

            Skills.Add(new Skill() { Id = 0x13d, Name = "Pressure", Class = Class.UTILITY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Removes 2 Press Turn icons on enemy's next turn" });
            Skills.Add(new Skill() { Id = 0x13e, Name = "Pressuring Stance", Class = Class.UTILITY, Target = Target.SELF, MP = 1, Effect = "Removes 2 Press Turn icons on enemy's next turn" });

            Skills.Add(new Skill() { Id = 0x13f, Name = "Gungnir", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x140, AttacksLow = 2, Power = Power.MEDIUM, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ENEMY, MP = 25, Effect = "Removes Smirk" });

            Skills.Add(new Skill() { Id = 0x141, Name = "Guardian's Eye", Class = Class.UTILITY, Target = Target.ALL_ALLIES, MP = 255, Effect = "Adds 3 Turn Press icons" });

            Skills.Add(new Skill() { Id = 0x142, Name = "Snake's Fangs", AttacksLow = 2, AttacksHigh = 3, Power = Power.HEAVY, Element = Element.GUN, Class = Class.ATTACK, Target = Target.MULTI, MP = 24, Effect = "Inflicts Bind" });

            Skills.Add(new Skill() { Id = 0x143, Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 100, Effect = "Decreases Attack/Defense/Hit/Evade rate" });

            Skills.Add(new Skill() { Id = 0x144, Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 50, Effect = "Smirking: 2x damage" });

            Skills.Add(new Skill() { Id = 0x145, Power = Power.SEVERE, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 43 });

            Skills.Add(new Skill() { Id = 0x146, Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 66, Effect = "Defense down" });

            Skills.Add(new Skill() { Id = 0x147, Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 45, Effect = "Pierce. High critical rate" });

            Skills.Add(new Skill() { Id = 0x148, Name = "Dark Nandaka", AttacksLow = 4, Power = Power.HEAVY, Element = Element.DARK, Class = Class.ATTACK, Target = Target.MULTI, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x149, Name = "Move Slowly", Class = Class.UTILITY, Target = Target.SELF, MP = 1 });
            Skills.Add(new Skill() { Id = 0x14a, Name = "Silence", Class = Class.UTILITY, Target = Target.SELF, MP = 1 });
            Skills.Add(new Skill() { Id = 0x14b, Name = "Scorn", Class = Class.UTILITY, Target = Target.SELF, MP = 1 });

            Skills.Add(new Skill() { Id = 0x14c, Name = "Light Nandaka", AttacksLow = 4, Power = Power.HEAVY, Element = Element.LIGHT, Class = Class.ATTACK, Target = Target.MULTI, MP = 1, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x14d, Name = "Raging Hellfire", Power = Power.SEVERE, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 45, Effect = "Gain Ice weakness" });
            Skills.Add(new Skill() { Id = 0x14e, Name = "Raging Blizzard", Power = Power.SEVERE, Element = Element.ICE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 45, Effect = "Gain Fire weakness" });
            Skills.Add(new Skill() { Id = 0x14f, Name = "Raging Lightning", Power = Power.SEVERE, Element = Element.ELEC, Class = Class.ATTACK, Target = Target.ENEMY, MP = 45, Effect = "Gain Force weakness" });
            Skills.Add(new Skill() { Id = 0x150, Name = "Raging Tempest", Power = Power.SEVERE, Element = Element.FORCE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 45, Effect = "Gain Elec weakness" });

            Skills.Add(new Skill() { Id = 0x151, Name = "Fire of Sinai ", AttacksLow = 1, AttacksHigh = 5, Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.MULTI, MP = 55 });
            Skills.Add(new Skill() { Id = 0x152, Name = "Godslayer's Sword", Power = Power.VARIES, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 35, Effect = "Highly effective vs YHVH. Weakens random resist" });

            Skills.Add(new Skill() { Id = 0x153, Name = "Expert Spearplay", Power = Power.WEAK, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 10 });
            Skills.Add(new Skill() { Id = 0x154, Name = "Spearman's Strike", Power = Power.WEAK, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 25 });
            Skills.Add(new Skill() { Id = 0x155, Name = "Spearman's Syphon", Power = Power.WEAK, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 17, Effect = "Drains enemy HP" });
            Skills.Add(new Skill() { Id = 0x156, Name = "Spearman's Twin Strike", AttacksLow = 2, Power = Power.WEAK, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, MP = 20 });
            Skills.Add(new Skill() { Id = 0x157, Name = "Spearman's Pierce", Power = Power.WEAK, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 28, Effect = "Removes buffs" });

            Skills.Add(new Skill() { Id = 0x158, Name = "Magic Compression", Class = Class.STATUS, Target = Target.SELF, MP = 20, Effect = "Pierce" });

            Skills.Add(new Skill() { Id = 0x159, Name = "Soul Drain", Power = Power.UNKNOWN_POWER, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 7, Effect = "Drains enemy HP/MP. Smirking: More power" });

            Skills.Add(new Skill() { Id = 0x15a, Name = "Blink of Death", Power = Power.HEAVY, Element = Element.DARK, Class = Class.ATTACK, Target = Target.ENEMY, MP = 30, Effect = "Defense down. Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x15b, Name = "Fire of Lethargy", Power = Power.HEAVY, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 45, Effect = "Defense/Hit/Evade rate down" });

            Skills.Add(new Skill() { Id = 0x15c, Name = "Light Devourer", Power = Power.HEAVY, Element = Element.DARK, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 33, Effect = "Drains enemy HP" });

            Skills.Add(new Skill() { Id = 0x15d, Name = "True Agidyne", Power = Power.SEVERE, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 32 });
            Skills.Add(new Skill() { Id = 0x15e, Name = "True Bufudyne", Power = Power.SEVERE, Element = Element.ICE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 32 });
            Skills.Add(new Skill() { Id = 0x15f, Name = "True Ziodyne", Power = Power.SEVERE, Element = Element.ELEC, Class = Class.ATTACK, Target = Target.ENEMY, MP = 32 });
            Skills.Add(new Skill() { Id = 0x160, Name = "True Zandyne", Power = Power.SEVERE, Element = Element.FORCE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 32 });

            Skills.Add(new Skill() { Id = 0x161, Name = "Magic Torrent", AttacksLow = 4, AttacksHigh = 6, Power = Power.HEAVY, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.MULTI, MP = 50 });

            Skills.Add(new Skill() { Id = 0x162, Name = "Vengeful Thunder", Power = Power.HEAVY, Element = Element.ELEC, Class = Class.ATTACK, Target = Target.ENEMY, MP = 25 });

            Skills.Add(new Skill() { Id = 0x163, Name = "Crush", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });

            Skills.Add(new Skill() { Id = 0x164, Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1 });

            Skills.Add(new Skill() { Id = 0x165, Class = Class.STATUS, Target = Target.SELF, MP = 1, Effect = "Fully increases all stats and induces Smirk" });
            Skills.Add(new Skill() { Id = 0x166, Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Fully decreases all stats" });

            Skills.Add(new Skill() { Id = 0x167, Name = "Barrage", Power = Power.WEAK, Element = Element.GUN, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 10 });

            Skills.Add(new Skill() { Id = 0x168, Name = "Rending Claws", AttacksLow = 3, AttacksHigh = 4, Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 15 });

            Skills.Add(new Skill() { Id = 0x169, Name = "Severe Judgement", Power = Power.WEAK, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 50, Effect = "Smirking: More power" });

            Skills.Add(new Skill() { Id = 0x16a, Name = "Megiddo Ark", Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 60 });

            Skills.Add(new Skill() { Id = 0x16b, Name = "Akasha Arts", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Smirking: Pierce" });

            Skills.Add(new Skill() { Id = 0x16c, Name = "Messiah Blast", Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Smirk only" });
            Skills.Add(new Skill() { Id = 0x16d, Name = "Messiah Blast", Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 30, Effect = "Smirk only" });

            Skills.Add(new Skill() { Id = 0x16e, Name = "Agilao Stone", Power = Power.MEDIUM, Element = Element.FIRE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });
            Skills.Add(new Skill() { Id = 0x16f, Name = "Bufula Stone", Power = Power.MEDIUM, Element = Element.ICE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });
            Skills.Add(new Skill() { Id = 0x170, Name = "Zionga Stone", Power = Power.MEDIUM, Element = Element.ELEC, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });
            Skills.Add(new Skill() { Id = 0x171, Name = "Zanma Stone", Power = Power.MEDIUM, Element = Element.FORCE, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });
            Skills.Add(new Skill() { Id = 0x172, Name = "Hamaon Stone", Power = Power.HEAVY, Element = Element.LIGHT, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x173, Name = "Mudoon Stone", Power = Power.HEAVY, Element = Element.DARK, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x174, Name = "Megido Stone", Power = Power.MEDIUM, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1 });

            Skills.Add(new Skill() { Id = 0x175, Name = "Attack Mirror", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 1, Effect = "Repels Phys/Gun attacks for 1 turn" });
            Skills.Add(new Skill() { Id = 0x176, Name = "Magic Mirror", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 1, Effect = "Repel all non-status Magic attacks for 1 turn" });

            Skills.Add(new Skill() { Id = 0x177, Name = "Dekaja Stone", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Removes status buffs" });
            Skills.Add(new Skill() { Id = 0x178, Name = "Dekunda Stone", Class = Class.STATUS, Target = Target.ALL_ALLIES, MP = 1, Effect = "Removes status debuffs" });

            Skills.Add(new Skill() { Id = 0x179, Name = "Loyalty Slash", Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 20, Effect = "Smirking: Instant kill" });

            Skills.Add(new Skill() { Id = 0x17a, Name = "Dance of Mara", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 20, Effect = "Inflicts Charm" });

            Skills.Add(new Skill() { Id = 0x17b, Name = "Shine More", AttacksLow = 2, AttacksHigh = 4, Power = Power.HEAVY, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.MULTI, MP = 1, Effect = "Inflicts Daze" });

            Skills.Add(new Skill() { Id = 0x17c, Name = "Struggle", Class = Class.UTILITY, Target = Target.SELF, MP = 1 });

            Skills.Add(new Skill() { Id = 0x17d, Name = "Divine Wave", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });

            Skills.Add(new Skill() { Id = 0x17e, Name = "Authority", Class = Class.UTILITY, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Remove 3 Press Turn icons on enemy's next turn" });
            Skills.Add(new Skill() { Id = 0x17f, Name = "Authoritative Stance", Class = Class.UTILITY, Target = Target.SELF, MP = 1, Effect = "Remove 3 Press Turn icons on enemy's next turn" });

            Skills.Add(new Skill() { Id = 0x180, Name = "Holy Stigmata", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 1 });

            Skills.Add(new Skill() { Id = 0x181, Name = "Rampage", AttacksLow = 6, AttacksHigh = 10, Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, MP = 1 });

            Skills.Add(new Skill() { Id = 0x182, Name = "Black Hole", Power = Power.UNKNOWN_POWER, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Drains enemy MP" });

            Skills.Add(new Skill() { Id = 0x183, Name = "Supernova", Power = Power.SEVERE, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 1 });

            Skills.Add(new Skill() { Id = 0x184, Name = "Infinite Power", Class = Class.STATUS, Target = Target.SELF, MP = 1, Effect = "Fully increases all stats and induces Smirk" });
            Skills.Add(new Skill() { Id = 0x185, Name = "Unending Curse", Class = Class.STATUS, Target = Target.ALL_ENEMIES, MP = 1, Effect = "Fully decreases all stats. Inflicts Mute" });

            Skills.Add(new Skill() { Id = 0x186, Name = "Diploid Force", Class = Class.UTILITY, Target = Target.SELF, MP = 1, Effect = "Adds 2 Press Turn icons" });

            Skills.Add(new Skill() { Id = 0x187, Name = "Haunting Rhapsody", Class = Class.AILMENT, Target = Target.ALL_ENEMIES, MP = 100, Effect = "Inflicts Panic/Stats down" });

            Skills.Add(new Skill() { Id = 0x188, Name = "Andalusia", AttacksLow = 4, AttacksHigh = 12, Power = Power.HEAVY, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, MP = 20 });

            Skills.Add(new Skill() { Id = 0x189, Name = "God's Bow", Power = Power.HEAVY, Element = Element.LIGHT, Class = Class.ATTACK, Target = Target.ENEMY, MP = 40, Effect = "Instant kill" });

            Skills.Add(new Skill() { Id = 0x18a, Name = "Blade of Terror", AttacksLow = 1, AttacksHigh = 5, Power = Power.MEDIUM, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.MULTI, MP = 35, Effect = "Pierce" });
            Skills.Add(new Skill() { Id = 0x18b, Name = "Ruinous Brand", Power = Power.SEVERE, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ENEMY, MP = 20 });

            Skills.Add(new Skill() { Id = 0x18c, Name = "Soul Divide", Power = Power.HEAVY, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 40, Effect = "Inflicts Mute/Hit/Evade rate down" });

            Skills.Add(new Skill() { Id = 0x18d, Name = "Calibrate", Class = Class.STATUS, Target = Target.SELF, MP = 30, Effect = "Greatly increases Hit/Evade rate" });

            Skills.Add(new Skill() { Id = 0x18e, Name = "Pestilence", Power = Power.WEAK, Element = Element.PHYS, Class = Class.ATTACK, Target = Target.ALL_ALLIES, MP = 50, Effect = "Ailments increase power" });

            Skills.Add(new Skill() { Id = 0x18f, Name = "Evil Melody", Power = Power.WEAK, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ENEMY, MP = 45, Effect = "Smirking: Instant kill" });
            Skills.Add(new Skill() { Id = 0x190, Name = "Death Lust", Power = Power.WEAK, Element = Element.ALMIGHTY, Class = Class.ATTACK, Target = Target.ALL_ENEMIES, MP = 70, Effect = "Inflicts Charm" });

            Skills.Add(new Skill() { Id = 0x191, Name = "Resist Phys", Class = Class.PASSIVE, Effect = "Increases resistance to Phys attacks" });
            Skills.Add(new Skill() { Id = 0x192, Name = "Null Phys", Class = Class.PASSIVE, Effect = "Nulls Phys attacks" });
            Skills.Add(new Skill() { Id = 0x193, Name = "Repel Phys", Class = Class.PASSIVE, Effect = "Repels Phys attacks" });
            Skills.Add(new Skill() { Id = 0x194, Name = "Drain Phys", Class = Class.PASSIVE, Effect = "Drains Phys attacks" });

            Skills.Add(new Skill() { Id = 0x195, Name = "Resist Gun", Class = Class.PASSIVE, Effect = "Increases resistance to Gun attacks" });
            Skills.Add(new Skill() { Id = 0x196, Name = "Null Gun", Class = Class.PASSIVE, Effect = "Nulls Gun attacks" });
            Skills.Add(new Skill() { Id = 0x197, Name = "Repel Gun", Class = Class.PASSIVE, Effect = "Repels Gun attacks" });
            Skills.Add(new Skill() { Id = 0x198, Name = "Drain Gun", Class = Class.PASSIVE, Effect = "Drains Gun attacks" });

            Skills.Add(new Skill() { Id = 0x199, Name = "Resist Fire", Class = Class.PASSIVE, Effect = "Increases resistance to Fire attacks" });
            Skills.Add(new Skill() { Id = 0x19a, Name = "Null Fire", Class = Class.PASSIVE, Effect = "Nulls Fire attacks" });
            Skills.Add(new Skill() { Id = 0x19b, Name = "Repel Fire", Class = Class.PASSIVE, Effect = "Repels Fire attacks" });
            Skills.Add(new Skill() { Id = 0x19c, Name = "Drain Fire", Class = Class.PASSIVE, Effect = "Drains Fire attacks" });

            Skills.Add(new Skill() { Id = 0x19d, Name = "Resist Ice", Class = Class.PASSIVE, Effect = "Increases resistance to Ice attacks" });
            Skills.Add(new Skill() { Id = 0x19e, Name = "Null Ice", Class = Class.PASSIVE, Effect = "Nulls Ice attacks" });
            Skills.Add(new Skill() { Id = 0x19f, Name = "Repel Ice", Class = Class.PASSIVE, Effect = "Repels Ice attacks" });
            Skills.Add(new Skill() { Id = 0x1a0, Name = "Drain Ice", Class = Class.PASSIVE, Effect = "Drains Ice attacks" });

            Skills.Add(new Skill() { Id = 0x1a1, Name = "Resist Elec", Class = Class.PASSIVE, Effect = "Increases resistance to Elec attacks" });
            Skills.Add(new Skill() { Id = 0x1a2, Name = "Null Elec", Class = Class.PASSIVE, Effect = "Nulls Elec attacks" });
            Skills.Add(new Skill() { Id = 0x1a3, Name = "Repel Elec", Class = Class.PASSIVE, Effect = "Repels Elec attacks" });
            Skills.Add(new Skill() { Id = 0x1a4, Name = "Drain Elec", Class = Class.PASSIVE, Effect = "Drains Elec attacks" });

            Skills.Add(new Skill() { Id = 0x1a5, Name = "Resist Force", Class = Class.PASSIVE, Effect = "Increases resistance to Force attacks" });
            Skills.Add(new Skill() { Id = 0x1a6, Name = "Null Force", Class = Class.PASSIVE, Effect = "Nulls Force attacks" });
            Skills.Add(new Skill() { Id = 0x1a7, Name = "Repel Force", Class = Class.PASSIVE, Effect = "Repels Force attacks" });
            Skills.Add(new Skill() { Id = 0x1a8, Name = "Drain Force", Class = Class.PASSIVE, Effect = "Drains Force attacks" });

            Skills.Add(new Skill() { Id = 0x1a9, Name = "Resist Dark", Class = Class.PASSIVE, Effect = "Increases resistance to Dark attacks" });
            Skills.Add(new Skill() { Id = 0x1aa, Name = "Null Dark", Class = Class.PASSIVE, Effect = "Nulls Dark attacks" });

            Skills.Add(new Skill() { Id = 0x1ab, Name = "Resist Light", Class = Class.PASSIVE, Effect = "Increases resistance to Light attacks" });
            Skills.Add(new Skill() { Id = 0x1ac, Name = "Null Light", Class = Class.PASSIVE, Effect = "Nulls Light attacks" });

            Skills.Add(new Skill() { Id = 0x1ad, Name = "Null Mind", Class = Class.PASSIVE, Effect = "Nulls Sleep/Panic/Charm/Mute" });
            Skills.Add(new Skill() { Id = 0x1ae, Name = "Null Nerve", Class = Class.PASSIVE, Effect = "Nulls Poison/Bind/Sick/Daze" });

            Skills.Add(new Skill() { Id = 0x1af, Name = "Phys Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Phys attacks" });
            Skills.Add(new Skill() { Id = 0x1b0, Name = "High Phys Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Phys attacks" });

            Skills.Add(new Skill() { Id = 0x1b1, Name = "Gun Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Gun attacks" });
            Skills.Add(new Skill() { Id = 0x1b2, Name = "High Gun Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Gun attacks" });

            Skills.Add(new Skill() { Id = 0x1b3, Name = "Fire Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Fire attacks" });
            Skills.Add(new Skill() { Id = 0x1b4, Name = "High Fire Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Fire attacks" });

            Skills.Add(new Skill() { Id = 0x1b5, Name = "Ice Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Ice attacks" });
            Skills.Add(new Skill() { Id = 0x1b6, Name = "High Ice Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Ice attacks" });

            Skills.Add(new Skill() { Id = 0x1b7, Name = "Elec Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Elec attacks" });
            Skills.Add(new Skill() { Id = 0x1b8, Name = "High Elec Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Elec attacks" });

            Skills.Add(new Skill() { Id = 0x1b9, Name = "Force Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Force attacks" });
            Skills.Add(new Skill() { Id = 0x1ba, Name = "High Force Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Force attacks" });

            Skills.Add(new Skill() { Id = 0x1bb, Name = "Heal Pleroma", Class = Class.PASSIVE, Effect = "Strengthens healing magic" });
            Skills.Add(new Skill() { Id = 0x1bc, Name = "High Heal Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens healing magic" });

            Skills.Add(new Skill() { Id = 0x1bd, Name = "Endure", Class = Class.PASSIVE, Effect = "Revive from KO once per battle with 1 HP" });
            Skills.Add(new Skill() { Id = 0x1be, Name = "Enduring Soul", Class = Class.PASSIVE, Effect = "Revive from KO once per battle with full HP" });

            Skills.Add(new Skill() { Id = 0x1bf, Name = "Counter", Class = Class.PASSIVE, Effect = "Chance of countering Phys or Gun attack" });
            Skills.Add(new Skill() { Id = 0x1c0, Name = "Retaliate", Class = Class.PASSIVE, Effect = "High chance of countering Phys or Gun attack" });
            Skills.Add(new Skill() { Id = 0x1c1, Name = "Ally Counter", Class = Class.PASSIVE, Effect = "Chance of countering Phys or Gun attack to ally" });
            Skills.Add(new Skill() { Id = 0x1c2, Name = "Ally Retaliate", Class = Class.PASSIVE, Effect = "High chance of countering Phys or Gun attack to ally" });

            Skills.Add(new Skill() { Id = 0x1c3, Name = "Life Aid", Class = Class.PASSIVE, Effect = "Recover full HP after battle" });
            Skills.Add(new Skill() { Id = 0x1c4, Name = "Mana Aid", Class = Class.PASSIVE, Effect = "Recover full MP after battle" });
            Skills.Add(new Skill() { Id = 0x1c5, Name = "Victory Cry", Class = Class.PASSIVE, Effect = "Recover full HP/MP after battle" });

            Skills.Add(new Skill() { Id = 0x1c6, Name = "Spring of Life", Class = Class.PASSIVE, Effect = "Recover some HP while walking. Inactive when in stock" });
            Skills.Add(new Skill() { Id = 0x1c7, Name = "Chakra Walk", Class = Class.PASSIVE, Effect = "Recover some MP while walking. Inactive when in stock" });

            Skills.Add(new Skill() { Id = 0x1c8, Name = "Lost Catcher", Class = Class.PASSIVE, Effect = "Prevents demons from becoming Lost. Returns them to party 100% of the time" });

            Skills.Add(new Skill() { Id = 0x1c9, Name = "Hiding", Class = Class.PASSIVE, Effect = "Less likely to be targeted by enemies" });

            Skills.Add(new Skill() { Id = 0x1ca, Name = "Temporal Blade", Class = Class.PASSIVE, Effect = "Might make Phys attack at start of battle. Pierce, instant kill" });
            Skills.Add(new Skill() { Id = 0x1cb, Name = "Sneak Attack", Class = Class.PASSIVE, Effect = "Might make Phys attack during enemy turn. Pierce, instant kill" });

            Skills.Add(new Skill() { Id = 0x1cc, Name = "Self-Righteous Vow", Class = Class.PASSIVE, Effect = "Raises stats every time own weak point is hit" });

            Skills.Add(new Skill() { Id = 0x1cd, Name = "Life Bonus", Class = Class.PASSIVE, Effect = "Slightly increases maximum HP" });
            Skills.Add(new Skill() { Id = 0x1ce, Name = "Life Gain", Class = Class.PASSIVE, Effect = "Increases maximum HP" });
            Skills.Add(new Skill() { Id = 0x1cf, Name = "Life Surge", Class = Class.PASSIVE, Effect = "Greatly increases maximum HP" });

            Skills.Add(new Skill() { Id = 0x1d0, Name = "Mana Bonus", Class = Class.PASSIVE, Effect = "Slightly increases maximum MP" });
            Skills.Add(new Skill() { Id = 0x1d1, Name = "Mana Gain", Class = Class.PASSIVE, Effect = "Increases maximum MP" });
            Skills.Add(new Skill() { Id = 0x1d2, Name = "Mana Surge", Class = Class.PASSIVE, Effect = "Greatly increases maximum MP" });

            Skills.Add(new Skill() { Id = 0x1d3, Name = "Dark Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Dark attacks" });
            Skills.Add(new Skill() { Id = 0x1d4, Name = "High Dark Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Dark attacks" });

            Skills.Add(new Skill() { Id = 0x1d5, Name = "Light Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Light attacks" });
            Skills.Add(new Skill() { Id = 0x1d6, Name = "High Light Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens Light attacks" });

            Skills.Add(new Skill() { Id = 0x1d7, Name = "Healing Knowhow", Class = Class.PASSIVE, Effect = "Enables the use of healing/support items" });

            Skills.Add(new Skill() { Id = 0x1d8, Name = "High Poly Pleroma", Class = Class.PASSIVE, Effect = "Greatly strengthens all attacks" });

            Skills.Add(new Skill() { Id = 0x1d9, Name = "Repel Dark", Class = Class.PASSIVE, Effect = "Repels Dark attacks" });
            Skills.Add(new Skill() { Id = 0x1da, Name = "Drain Dark", Class = Class.PASSIVE, Effect = "Drains Dark attacks" });

            Skills.Add(new Skill() { Id = 0x1db, Name = "Attack Knowhow", Class = Class.PASSIVE, Effect = "Enables use of attack items" });

            Skills.Add(new Skill() { Id = 0x1dc, Name = "Repel Light", Class = Class.PASSIVE, Effect = "Repels Light attacks" });

            Skills.Add(new Skill() { Id = 0x1dd, Name = "Light Life Aid", Class = Class.PASSIVE, Effect = "Repels Light attacks" });
            Skills.Add(new Skill() { Id = 0x1de, Name = "Light Mana Aid", Class = Class.PASSIVE, Effect = "Recover a little HP after a battle" });

            Skills.Add(new Skill() { Id = 0x1df, Name = "Light Pierce", Class = Class.PASSIVE, Effect = "Light attacks pierce the enemy's Light Drain/Repel/Null/Resist" });
            Skills.Add(new Skill() { Id = 0x1e0, Name = "Dark Pierce", Class = Class.PASSIVE, Effect = "Dark attacks pierce the enemy's Dark Drain/Repel/Null/Resist" });

            Skills.Add(new Skill() { Id = 0x1e1, Name = "Drain Light", Class = Class.PASSIVE, Effect = "Drains Light attacks" });

            Skills.Add(new Skill() { Id = 0x1e2, Name = "Hellish Mask", Class = Class.PASSIVE, Effect = "Decreases chances of suffering ailments" });

            Skills.Add(new Skill() { Id = 0x1e3, Name = "Hard Worker", Class = Class.PASSIVE, Effect = "Obtain more EXP after battles" });
            Skills.Add(new Skill() { Id = 0x1e4, Name = "Workaholic", Class = Class.PASSIVE, Effect = "Obtain much more EXP after battles" });

            Skills.Add(new Skill() { Id = 0x1e5, Name = "Beastly Reaction", Class = Class.PASSIVE, Effect = "Increases Hit/Evade rate" });
            Skills.Add(new Skill() { Id = 0x1e6, Name = "Draconic Reaction", Class = Class.PASSIVE, Effect = "Greatly increases Hit/Evade rate" });

            Skills.Add(new Skill() { Id = 0x1e7, Name = "Bloody Glee", Class = Class.PASSIVE, Effect = "Increases critical hit rate" });

            Skills.Add(new Skill() { Id = 0x1e8, Name = "Phys Pierce", Class = Class.PASSIVE, Effect = "Phys attacks pierce the enemy's Phys Drain/Repel/Null/Resist" });
            Skills.Add(new Skill() { Id = 0x1e9, Name = "Gun Pierce", Class = Class.PASSIVE, Effect = "Gun attacks pierce the enemy's Gun Drain/Repel/Null/Resist" });
            Skills.Add(new Skill() { Id = 0x1ea, Name = "Fire Pierce", Class = Class.PASSIVE, Effect = "Fire attacks pierce the enemy's Fire Drain/Repel/Null/Resist" });
            Skills.Add(new Skill() { Id = 0x1eb, Name = "Ice Pierce", Class = Class.PASSIVE, Effect = "Ice attacks pierce the enemy's Ice Drain/Repel/Null/Resist" });
            Skills.Add(new Skill() { Id = 0x1ec, Name = "Elec Pierce", Class = Class.PASSIVE, Effect = "Elec attacks pierce the enemy's Elec Drain/Repel/Null/Resist" });
            Skills.Add(new Skill() { Id = 0x1ed, Name = "Force Pierce", Class = Class.PASSIVE, Effect = "Force attacks pierce the enemy's Force Drain/Repel/Null/Resist" });

            Skills.Add(new Skill() { Id = 0x1ee, Name = "Awakened Power (+Pierce)", Class = Class.PASSIVE, Effect = "Strengthens and adds pierce to all attacks" });
            Skills.Add(new Skill() { Id = 0x1ef, Name = "Awakened Power (+Healing)", Class = Class.PASSIVE, Effect = "Greatly strengthens healing magic" });
            Skills.Add(new Skill() { Id = 0x1f0, Name = "Awakened Power (+Gun +Pierce Gun)", Class = Class.PASSIVE, Effect = "Strengthens and adds pierce to all Gun attacks" });
            Skills.Add(new Skill() { Id = 0x1f1, Name = "Awakened Power (+Magic)", Class = Class.PASSIVE, Effect = "Greatly strengthens Magic attacks" });
            Skills.Add(new Skill() { Id = 0x1f2, Name = "Awakened Power (+Phys)", Class = Class.PASSIVE, Effect = "Greatly strengthens Phys attacks" });
            Skills.Add(new Skill() { Id = 0x1f3, Name = "Awakened Power (+Phys Pierce +Sneak)", Class = Class.PASSIVE, Effect = "Phys attacks gain pierce. Sneak Attack activation rate increased" });

            Skills.Add(new Skill() { Id = 0x1f4, Name = "Almighty Pleroma", Class = Class.PASSIVE, Effect = "Strengthens Almighty attacks" });

            foreach (Skill s in Skills)
            {
                if (string.IsNullOrEmpty(s.Name))
                {
                    s.Name = s.Id.ToString();
                }
            }
        }
    }
}
