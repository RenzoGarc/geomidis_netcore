namespace GeomidisSystem.Models.Masters
{
    public class Respuesta
    {
        public bool error { get; set; }
        public object data { get; set; }
        public string message { get; set; }
        public int status { get; set; }
    }
}