public class LivroViewModel
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public AutorViewModel Autor { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacao { get; set; }
}
