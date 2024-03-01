using MauiAppConApi.ViewModels;

namespace MauiAppConApi.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage(HomeViewModel homeViewModel)
        {
            InitializeComponent();
            BindingContext = homeViewModel;



            int anchoElemento = 250 + 20; // Cambia el 250 al WidthRequest de tu Frame y 20 al espacio total (margen)

            SizeChanged += (sender, args) =>
            {
                if (Width > 0) // Verifica que el ancho del contenedor esté disponible
                {
                    var anchoContenedor = this.Width;
                    // Calcula cuántas columnas caben en el contenedor basándose en el ancho de los elementos
                    var columnas = Math.Max(1, (int)(anchoContenedor / anchoElemento));

                    // Ajusta el Span del GridItemsLayout directamente
                    if (MyCollectionView.ItemsLayout is GridItemsLayout gridItemsLayout)
                    {
                        gridItemsLayout.Span = columnas;
                    }
                }
            };
        }


    }

}
