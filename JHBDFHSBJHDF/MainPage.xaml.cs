﻿namespace JHBDFHSBJHDF
{
    public partial class MainPage : ContentPage
    {
        public Estudiante MiEstudiante { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = MiEstudiante;
        }
        private void Confirmar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro", MiEstudiante.Nombre + " sus datos se ingresaron correctamente.", "Ok");
        }
    }
}