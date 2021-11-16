namespace compositionlabhunt
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

    public Author(string tempName, char tempGender, string tempEmail)
    {
        this.name = "Jeff";
        this.gender = 'm';
        this.email = "jslucas@cba.com";
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
       return "name =" + name;
       return "email= " + email;
       return "gender= " + gender;
    }
    public void SetName(string tempName)
    {
        this.name = name;
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