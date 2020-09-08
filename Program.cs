using System;

namespace practica1
{
  class Program
  {

    struct person
    {
      public enum genders : int { male, female };
      public string firstname;
      public string secondname;
      int age;
      public genders gender;
      public person(string _firstname, string _secondname, int _age, genders _gender)
      {
        firstname = _firstname;
        secondname = _secondname;
        age = _age;
        gender = _gender;
      }
      public override string ToString()
      {
        return firstname + " " + secondname + " (" + gender + "),age " + age;
      }
    }
    static void Main(string[] args)
    {

      person p = new person("Tony", "Allen", 32, person.genders.male);
      GC.Collect();
      Console.WriteLine(p.ToString());
    }
  }
}

