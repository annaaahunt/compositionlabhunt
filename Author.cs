namespace compositionlabhunt
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

    public Author(string tempName, char tempGender, string tempEmail)
    {
        this.name = name;
        this.gender = gender;
        this.email = email;
    }

    public string GetName()
    {
        return name;
    }

    public string GetGender()
    {
        return gender.ToString();
    }

    public string GetEmail()
    {
        return email;
    }
    public string ToString()
    {
        return "The name is " + name + " the email is " + email + "the gender is " + gender;
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