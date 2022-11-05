namespace KingdomSpace{
  class Person
  {
    private string? name;
    private int health;
    private int maxHealth;
    private string? classPerson;
    private int strength;

    // Constructor
    public Person(string name, int health, int maxHealth, string classPerson, int strength)
    {
      this.name = name;
      this.health = health;
      this.maxHealth = maxHealth;
      this.classPerson = classPerson;
      this.strength = strength;
    }

    public static void Attack(Person attacker, Person defender)
    {
      defender.health -= attacker.strength;
    }
    public static bool Death(Person person)
    {
      if (person.health <= 0)
      {
        person.health = 0;
        Console.WriteLine(person.name + " has died.");
        return true;
      }else{
        return false;
      }
    }
  }
}
