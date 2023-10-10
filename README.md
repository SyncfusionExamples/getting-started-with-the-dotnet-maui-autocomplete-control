# Getting Started with the .NET MAUI Autocomplete Control

The [.NET MAUI Autocomplete](https://www.syncfusion.com/maui-controls/maui-autocomplete?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples) control is highly optimized to load and populate suggestions quickly from large amounts of data depending on the user’s input characters. A quick-start project that shows how to create and configure the Syncfusion MAUI Autocomplete control. This project also includes a code snippet to populate the control’s data source, set a custom height and width to the control, customize placeholder text, change the filter type, and hide clear button.

### Adding the .NET MAUI AutoComplete
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**
```
xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
```
**[C#]**
```
    using Syncfusion.Maui.Inputs;
```

Step 2: Set the AutoComplete control to content in `ContentPage.`
```
<ContentPage.Content>    
    <editors:SfAutocomplete x:Name="autocomplete" />
</ContentPage.Content>
```
**[C#]**
``` 
SfAutocomplete autocomplete = new SfAutocomplete(); 
Content = autocomplete;
```

### Populating items using data binding

**Step 1**: Create a model class named SocialMedia that contains information such as social media's ID and name. And generate the collection of social media data in the ViewModel class.

```
//Model.cs
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

//ViewModel.cs
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tumblr", ID = 9 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Twitter", ID = 10 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Vimeo", ID = 11 });
        this.SocialMedias.Add(new SocialMedia() { Name = "WhatsApp", ID = 12 });
        this.SocialMedias.Add(new SocialMedia() { Name = "YouTube", ID = 13 });
    }
}
```

**Step 2**: Binding the SocialMedias property to the ItemsSource property of `AutoComplete`.

```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             xmlns:local="clr-namespace:AutocompleteSample"             
             x:Class="AutocompleteSample.MainPage">

       <ContentPage.BindingContext>
            <local:SocialMediaViewModel />
       </ContentPage.BindingContext>

       <ContentPage.Content>
            <!--Setting ItemsSource-->
            <editors:SfAutocomplete x:Name="autocomplete" 
                                    WidthRequest="250"
                                    ItemsSource="{Binding SocialMedias}" />
        </ContentPage.Content>
</ContentPage>
```

## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio with .NET MAUI workloads and .NET SDK version in your machine before starting to work on this project. Refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

## How to run this application?

To run this application, you need to first clone the getting-started-with-the-dotnet-maui-autocomplete-control repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio rename the repository to short, and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.

## Features and Benefits

## Selection

Select a single item from the suggestion list based on the entered text.

## Placeholder

Display hints using the placeholder text. This text will be displayed only if no item is selected, or the edit text is empty.

## Data binding

Data-binding support works for all popular data sources and displays data based on the display member path. It automatically generates items from a data-bound collection. The application can be designed in the MVVM pattern.

## Custom filter

Apply your own filter logic to display custom filtered items. E.g., in the above image, AutoComplete filtered the cities based on country name.

## Dropdown height

Adjust the dropdown height based on the number of items to enhance readability without scrolling.

## Related Links

[Learn More about .NET MAUI Autocomplete](https://www.syncfusion.com/maui-controls/maui-autocomplete?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Download Free Trial](https://www.syncfusion.com/downloads/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Pricing](https://www.syncfusion.com/sales/teamlicense?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Documentation](https://help.syncfusion.com/maui/autocomplete/getting-started?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[View Demos](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-autocomplete-control?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Community Forums](https://www.syncfusion.com/forums/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Suggest a feature or report a bug](https://www.syncfusion.com/feedback/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Online example](https://github.com/SyncfusionExamples/maui-autocomplete-samples?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

[Knowledge base](https://support.syncfusion.com/kb?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)

## About Syncfusion .NET MAUI Controls
Syncfusion's [.NET MAUI UI Controls](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples) library is the only suite that you will ever need to build an application since it contains over 40 high-performance, lightweight, modular, and responsive UI controls in a single package. In addition to Autocomplete, we provide popular .NET MAUI Controls such as [DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples), [Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples), [Scheduler](https://www.syncfusion.com/maui-controls/maui-scheduler?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples), [ListView](https://www.syncfusion.com/maui-controls/maui-listview?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples), and [Excel Library](https://www.syncfusion.com/document-processing/excel-framework/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples).

## About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 29,000 customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today we provide 1800+ controls and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [ASP.NET Web Forms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [Angular](https://www.syncfusion.com/angular-components?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [React](https://www.syncfusion.com/react-components?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [Vue](https://www.syncfusion.com/vue-components?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples)), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)), and desktop development ([Windows Forms](https://www.syncfusion.com/winforms-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [WPF](https://www.syncfusion.com/wpf-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [WinUI](https://www.syncfusion.com/winui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_medium=listing&utm_source=github&utm_campaign=maui-autocomplete-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

<hr style="height:0.3px;border:none;color:lightgrey;background-color:lightgrey;" />

<p align="center">
<a href="mailto:sales@syncfusion.com?Subject=Syncfusion .NET MAUI Autocomplete - GitHub" target="_top">sales@syncfusion.com</a> | <a href="https://www.syncfusion.com?utm_source=github&utm_medium=listing&utm_campaign=maui-autocomplete-github-samples">www.syncfusion.com</a> | Toll Free: 1-888-9 DOTNET <br>
</p>