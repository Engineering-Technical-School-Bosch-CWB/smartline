using Microsoft.Extensions.Logging;
using SmartLine.Services.AlertService;
using SmartLine.Services.ProductService;
using SmartLine.Services.DemandService;
using SmartLine.Services.DatabaseService;

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

		// Adiciona o DatabaseService singleton
		builder.Services.AddSingleton(new DatabaseService(dbPath));

		builder.Services.AddSingleton<IDemandRepository, DemandService>(p=>ActivatorUtilities.CreateInstance<DemandService>(p,dbPath));
		builder.Services.AddSingleton<IProductRepository, ProductService>(p=>ActivatorUtilities.CreateInstance<ProductService>(p,dbPath));

		builder.Services.AddSingleton<IAlertService, AlertService>();

		return builder.Build();
	}
}
