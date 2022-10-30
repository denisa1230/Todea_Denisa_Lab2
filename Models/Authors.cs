namespace Todea_Denisa_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FullName { get; set; }
      

        public ICollection<Book>? Books { get; set; }
    }
}
