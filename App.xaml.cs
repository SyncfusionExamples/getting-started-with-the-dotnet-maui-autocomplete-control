namespace MauiExample;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTk1MjYzQDMyMzAyZTM0MmUzMFBGbnUyQytJbTRxTGRMcnBlY1pLZUwyWnNZS3B3R1RaTS9Pd1kvcThwNkE9");
        InitializeComponent();

		MainPage = new AppShell();
	}
}
