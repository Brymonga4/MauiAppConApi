using System.Windows.Input;

namespace MauiAppConApi.Controls;

public partial class LongCardView : ContentView
{
    public static readonly BindableProperty LocationTitleProperty = BindableProperty.
           Create(nameof(LocationTitle), typeof(string), typeof(LongCardView), string.Empty);

    public string LocationTitle
    {
        get => (string)GetValue(LocationTitleProperty);
        set => SetValue(LocationTitleProperty, value);
    }
    public static readonly BindableProperty BorderColorProperty =
    BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(LongCardView), Colors.Transparent);

    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }

    public static readonly BindableProperty CardDescriptionProperty =
        BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(LongCardView), string.Empty);

    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardDescriptionProperty, value);
    }

    public static readonly BindableProperty LocationTypeProperty =
        BindableProperty.Create(nameof(LocationType), typeof(string), typeof(LongCardView), string.Empty);

    public string LocationType
    {
        get => (string)GetValue(LocationTypeProperty);
        set => SetValue(LocationTypeProperty, value);
    }

    public static readonly BindableProperty IconImageSourceProperty =
        BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(LongCardView), string.Empty);

    public string IconImageSource
    {
        get => (string)GetValue(IconImageSourceProperty);
        set => SetValue(IconImageSourceProperty, value);
    }


    public LongCardView()
	{
		InitializeComponent();
	}
}