namespace KingdomSpace
{
  class Enemy : Person
  {
    // Private variables
    private int gold;
    private int exp;
    private int level;


    // Constructor
    public Enemy(string name, int health, int maxHealth, string classPerson, int strength, int gold, int exp, int level) : base(name, health, maxHealth, classPerson, strength)
    {
      this.gold = gold;
      this.exp = exp;
      this.level = level;
    }

  }
}