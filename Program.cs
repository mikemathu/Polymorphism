using Polymorphism;
//Base Class
class SearchEngine
{
    static void Main(string[] args)
    {
        GoogleSearch googleSearch = new GoogleSearch();
        googleSearch.Search("");

     
    }
    public virtual string[] Search(string findThis)
    {
        return new string[0]; // I'm terrible at searching... I give up.
    }

}