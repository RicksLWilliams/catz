using System.Collections.Generic;

namespace catz.DB
{
  public static class FakeDB
  {
    public static List<Cat> Cats = new List<Cat>()
    {
      new Cat("Cat One", "Its delicious", "cat"),
      new Cat("Cat two", "Bacon Galore", "cat"),
      new Cat("Cat three", "It's mostly just Ham", "cat")
    };

    // public static List<Cat> Books = new List<Book>()
    // {
    //   new Book("Where the Sidewalk Ends", "Shel Silverstein"),
    //   new Book("The Hobbit", "J.R.R. Tolkie"),
    //   new Book("The Lion, The Witch, and the Wardrobe", "C.S. Lewis"),
    //   new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling")
    // };
  }
}