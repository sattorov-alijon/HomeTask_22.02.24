﻿namespace Tasc4;

public class Country
{
    string _name;
    string _capital;
    int _population;
    string _officialLanguage;
    

    public void SetName(string name)
    {
        _name=name;
    }
        public string GetName()
    {
        return _name;
    }
    public void SetCapital(string capital)
    {
        _capital=capital;
    }
        public string GetCapital()
    {
        return _capital;
    }
        public void SetPopulation(int population)
    {
        _population=population;
    }
        public int GetPopulation()
    {
        return _population;
    }
    public void SetOfficialLanguage(string officialLanguage)
    {
        _officialLanguage=officialLanguage;
    }
        public string GetOfficialLanguage()
    {
        return _officialLanguage;
    }



        public Country(string name, string capital, int population,string officialLanguage)
    {
        _name=name;
        _capital=capital;
        _population=population;
        _officialLanguage=officialLanguage;
    }

}
