
using System.Collections.Generic;

namespace csharp_dictionary.Models
{
  class User
  {
    public string Name { get; set; }
    private string Password { get; set; }

    public bool ValidatePassword(string input)
    {
      return input == Password;
    }
    // constructor
    public User(string name, string password)
    {
      Name = name;
      Password = password;
    }
  }
}