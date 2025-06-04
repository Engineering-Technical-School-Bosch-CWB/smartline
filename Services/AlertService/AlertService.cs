using Microsoft.Maui.Controls;

namespace SmartLine.Services.AlertService;

public class AlertService : IAlertService
{
    public async Task ShowAlertAsync(string title, string message, string accept)
    {
        var mainPage = Application.Current?.Windows.FirstOrDefault()?.Page;

        if (mainPage != null)
        {
            await mainPage.DisplayAlert(title, message, accept);
        }

        System.Diagnostics.Debug.WriteLine("No window available to show alert.");
    }

    public async Task<bool> ShowConfirmAsync(string title, string message, string accept, string cancel)
    {
        var mainPage = Application.Current?.Windows.FirstOrDefault()?.Page;

        if (mainPage != null)
        {
            return await mainPage.DisplayAlert(title, message, accept, cancel);
        }

        System.Diagnostics.Debug.WriteLine("No window available to show confirmation.");
        return false;
    }
}