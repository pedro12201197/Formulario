namespace Formulariohj.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public required string NomeConexao { get; set; }
        public required string FerramentaAnalise { get; set; }
        public required string URL { get; set; }
        public required string Usuario { get; set; }
        public required string SecretKey { get; set; }
    }
}
