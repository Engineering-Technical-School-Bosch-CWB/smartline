using Microsoft.Maui.Controls;

namespace SmartLine.Services.AlertService;

public class AlertService : IAlertService
{
    public async Task ShowAlertAsync(string title, string message, string cancel)
    {
        var mainPage = Application.Current?.Windows.FirstOrDefault()?.Page;

        if (mainPage != null)
        {
            await mainPage.DisplayAlert(title, message, cancel);
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("No window available to show alert.");
        }
    }
}