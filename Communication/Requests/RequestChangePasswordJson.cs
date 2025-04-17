namespace MyFirstApi.Communication.Requests;

public class RequestChangePasswordJson
{
    public string CurrentPassword { get; set; }
    public string NewPassword { get; set; }
}
