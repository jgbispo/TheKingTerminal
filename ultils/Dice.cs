namespace KingdomSpace
{
  class Dice
  {
    public static int Roll(string dice)
    {
      Random random = new Random();

      switch (dice)
      {
        case "D2":
          return random.Next(1, 3);
        case "D4":
          return random.Next(1, 5);
        case "D6":
          return random.Next(1, 7);
        case "D8":
          return random.Next(1, 9);
        case "D10":
          return random.Next(1, 11);
        case "D12":
          return random.Next(1, 13);
        case "D20":
          return random.Next(1, 21);
        case "D100":
          return random.Next(1, 101);
        default:
          return 0;
      }
    }
  }
}