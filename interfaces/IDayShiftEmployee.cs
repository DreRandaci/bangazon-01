namespace bangazon_01
{
    public interface IDayShiftEmployee
    {
        System.DateTime shift_start_time { get; set; }
        System.DateTime shift_end_time { get; set; }
    }
}