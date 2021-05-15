namespace StiebelEltronDashboard.Services.HtmlServices
{
    public interface IValueParser
    {
        public (double Value, string Unit) GetValueWithUnit(string rawValue);
    }
}