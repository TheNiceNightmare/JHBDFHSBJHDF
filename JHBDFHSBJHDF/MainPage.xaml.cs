namespace JHBDFHSBJHDF
{
    public partial class MainPage : ContentPage
    {
        private string titulo = "Registro";
        public Estudiante MiEstudiante { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = MiEstudiante;
        }
        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            if (IsValid())
            {
                DisplayAlert("Registro", MiEstudiante.Nombre + " sus datos se ingresaron correctamente.", "Ok");
            }
        }
        private bool IsValid()
        {
            if (String.IsNullOrEmpty(MiEstudiante.Nombre))
            {
                DisplayAlert(titulo, "Debe ingresar un nombre", "ok");
                return false;
            }
            
            if (String.IsNullOrEmpty(MiEstudiante.Apellido))
            {
                DisplayAlert(titulo, "Debe ingresar un Apellido", "ok");
                return false;
            }
            if (String.IsNullOrEmpty(MiEstudiante.Materia))
            {
                DisplayAlert(titulo, "Debe ingresar su materia", "ok");
                return false;
            }
            return true;
        }
    }
}