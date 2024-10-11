public class Address
{
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _country {get; set;}

    public Address (string streetAddress, string city, string state, string country)
    {

    }

    public void SetCountry(string country)
    {

    }
    public string GetCountry()
    {
        return _country;
    }

    public string GetAddress() 
    {
        return $"{_streetAddress}\r\n{_city}, {_state}\r\n{_country}";
    }
}