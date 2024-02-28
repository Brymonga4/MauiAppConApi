using System.Diagnostics;
using System.Windows.Input;

namespace MauiAppConApi.Controls;

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.
        Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardView.CardTitleProperty);
        set => SetValue(CardView.CardTitleProperty, value);
    }

    public static readonly BindableProperty BorderColorProperty =
        BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), Colors.Transparent);

    public Color BorderColor
    {
        get => (Color)GetValue(BorderColorProperty);
        set => SetValue(BorderColorProperty, value);
    }

    public static readonly BindableProperty CardDescriptionProperty =
        BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);

    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardDescriptionProperty, value);
    }

    public static readonly BindableProperty StatusProperty =
        BindableProperty.Create(nameof(Status), typeof(string), typeof(CardView), string.Empty);

    public string Status
    {
        get => (string)GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }

    public static readonly BindableProperty SpeciesProperty =
        BindableProperty.Create(nameof(Species), typeof(string), typeof(CardView), string.Empty);

    public string Species
    {
        get => (string)GetValue(SpeciesProperty);
        set => SetValue(SpeciesProperty, value);
    }
    public static readonly BindableProperty IconBackgroundColorProperty =
        BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), Colors.Transparent);

    public Color IconBackgroundColor
    {
        get => (Color)GetValue(IconBackgroundColorProperty);
        set => SetValue(IconBackgroundColorProperty, value);
    }

    public static readonly BindableProperty IconImageSourceProperty =
        BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(CardView), string.Empty);

    public string IconImageSource
    {
        get => (string)GetValue(IconImageSourceProperty);
        set => SetValue(IconImageSourceProperty, value);
    }




    public static readonly BindableProperty ImageTappedCommandProperty =
    BindableProperty.Create(nameof(ImageTappedCommand), typeof(ICommand), typeof(CardView));

    public ICommand ImageTappedCommand
    {
        get => (ICommand)GetValue(ImageTappedCommandProperty);
        set => SetValue(ImageTappedCommandProperty, value);
    }


    private void OnImageTapped(object sender, EventArgs e)
    {
        // Aquí puedes invocar un comando o un evento que esté vinculado a tu ViewModel
        Trace.WriteLine("hola");
        ImageTappedCommand?.Execute(null);
    }
    public CardView()
    {
        InitializeComponent();
    }
}