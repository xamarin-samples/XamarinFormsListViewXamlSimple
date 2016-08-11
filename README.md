# XamarinFormsListViewXamlSimple

Sample: Using Xamarin.Forms.ListView on XAML

## Pickuped code
### Page1.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XamarinFormsListViewXamlSimple.Page1">
    <ListView x:Name="mylist" ItemsSource="{Binding}" VerticalOptions="FillAndExpand">
    </ListView>
</ContentPage>
```

### Page1.xaml.cs
```
public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();

        // Make string list
        List<string> list = new List<string>();
        for(int i = 0; i < 30; i++)
        {
            list.Add(string.Format("item-{0}", i));
        }

        // Bind
        this.BindingContext = list;
    }
}
```

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsListViewXamlSimple/21ccb314952353aaf3d67dcb92d4a02e498993cf/screenshots/screenshot.png)
