namespace MauiAppConApi.Controls;

public partial class FullDetailCharacterCardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.
        Create(nameof(CardTitle), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);

    public static readonly BindableProperty IconImageSourceProperty =
    BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);
    
    public static readonly BindableProperty CardDescriptionProperty =
            BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);

    public static readonly BindableProperty StatusProperty =
    BindableProperty.Create(nameof(Status), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);

    public static readonly BindableProperty GenderProperty =
    BindableProperty.Create(nameof(Gender), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);



    public string Gender
    {
        get => (string)GetValue(GenderProperty);
        set => SetValue(GenderProperty, value);
    }

    public static readonly BindableProperty OriginProperty =
    BindableProperty.Create(nameof(Origin), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);
    public string Origin
    {
        get => (string)GetValue(OriginProperty);
        set => SetValue(OriginProperty, value);
    }

    public static readonly BindableProperty SpeciesProperty =
        BindableProperty.Create(nameof(Species), typeof(string), typeof(FullDetailCharacterCardView), string.Empty);





    public string Status
    {
        get => (string)GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }
    public string Species
    {
        get => (string)GetValue(SpeciesProperty);
        set => SetValue(SpeciesProperty, value);
    }

    public string CardTitle
    {
        get => (string)GetValue(FullDetailCharacterCardView.CardTitleProperty);
        set => SetValue(FullDetailCharacterCardView.CardTitleProperty, value);
    }

    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardDescriptionProperty, value);
    }
    public string IconImageSource
    {
        get => (string)GetValue(IconImageSourceProperty);
        set => SetValue(IconImageSourceProperty, value);
    }




    public FullDetailCharacterCardView()
	{
		InitializeComponent();
	}
}