namespace bangazon_01
{
    public interface IPartTime
    {
        double hours_per_week { get; set; }
        double hourly_rate { get; set; }
        System.DateTime start_date { get; set; }
    }
}