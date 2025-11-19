namespace Models
{
    public class Cliente
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }  
        public List<Cobro> cobros { get; } = new List<Cobro>();
    }
}
