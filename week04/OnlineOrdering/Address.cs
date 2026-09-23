using System;

public class Address
{
    private string _street;
    private string _city;
    private string _statProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _statProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _city.Trim().Equals("USA", StringComparison.OrdinalIgnoreCase) || _country.Trim().Equals("United States", StringComparison.OrdinalIgnoreCase);

    }

    public string GetFullAdress()
    {
        return $"{_street}\n{_statProvince}\n{_country}";
    }

}