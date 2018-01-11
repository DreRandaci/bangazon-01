namespace bangazon_01
{
    public interface ILocation
    {   
        string location { get; set; }
        bool access_card { get; set; }
        bool security_check { get; set; }
    }
}