namespace Application.Common.Settings;
public class ApplicationJwtSettings
{
    public string Issuer { get; set; }
    public string Audience { get; set;}
    public string SigningKey { get; set; }
}