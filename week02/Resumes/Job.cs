public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _starteYear;
    public int _endYear;

    public string jobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }
    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }
    public int StartYear
    {
        get { return _starteYear; }
        set { _starteYear = value; }
    }
    public int EndYear
    {
        get { return _endYear; }
        set { _endYear = value; }
    }

    
    public void Display ()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_starteYear} {_endYear} ");
    }


}