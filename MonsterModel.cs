namespace LostTreasure_MonsterMaker
{
    class MonsterModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public int Level { get; set; }
        public int Blood {  get; set; }
        public int Aura {  get; set; }
        public required string DefenseDie {  get; set; }
        public required string SpellDefenseDie { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Social { get; set; }

        public required string SkillMastery { get; set; }

        public required string Weapons { get; set; }
    }


}