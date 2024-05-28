namespace DedSad.Models
{
    public class Parents
    {
        public int id_parent { get; set; }
        public string mother { get; set; }
        public string father { get; set; }
        public int id_child { get; set; }
        public string home_telephone { get; set; }

        public Person children { get; set; }
    }
}
