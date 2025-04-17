using Microsoft.Extensions.Logging;
using SmartLine.Services.AlertService;
using SmartLine.Services.ProductService;

namespace SmartLine;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
	#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
	#endif

		var dbPath = Path.Combine(
			@"S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\5 - Aprendizes",
			@"ProductDB.db3"
		);
		builder.Services.AddSingleton<IProductRepository, ProductService>(p=>ActivatorUtilities.CreateInstance<ProductService>(p,dbPath));

		builder.Services.AddSingleton<IAlertService, AlertService>();

		return builder.Build();
	}
}
