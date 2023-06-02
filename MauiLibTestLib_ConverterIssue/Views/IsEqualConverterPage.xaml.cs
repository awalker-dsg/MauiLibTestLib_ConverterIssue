using MauiLibTestLib_ConverterIssue.ViewModels;

namespace MauiLibTestLib_ConverterIssue.Views;

public partial class IsEqualConverterPage : ContentPage
{
    public IsEqualConverterPage(IsEqualConverterViewModel equalConverterViewModel)
    {
        InitializeComponent();
        BindingContext = equalConverterViewModel;
    }
}