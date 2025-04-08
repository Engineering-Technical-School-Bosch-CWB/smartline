namespace SmartLine.Services.AlertService;

public interface IAlertService
{
    Task ShowAlertAsync(string title, string message, string cancel);
}
