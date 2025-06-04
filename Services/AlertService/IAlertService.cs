namespace SmartLine.Services.AlertService;

public interface IAlertService
{
    Task ShowAlertAsync(string title, string message, string accept);
    Task<bool> ShowConfirmAsync(string title, string message, string accept, string cancel);
}
