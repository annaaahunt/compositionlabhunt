using System;
namespace compositionlabhunt
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

    public Author(string tempName, char tempGender, string tempEmail)
    {
        this.name = tempName;
        this.gender = tempGender;
        this.email = tempEmail;
    }

    public string GetName()
    {
        return name;
    }

    public char GetGender()
    {
        return gender;
    }

    public string GetEmail()
    {
        return email;
    }
    public override string ToString()
    {
       return "name= " + this.GetName() + " gender= " + this.GetGender() + " email= " + this.GetEmail();
    }
    public void SetName(string tempName)
    {
        this.name = tempName;
    }
    public void SetGender(char gender)
    {
        this.gender = gender;
    }
    public void SetEmail(string email)
    {
        this.email = email;
    }
    }
}