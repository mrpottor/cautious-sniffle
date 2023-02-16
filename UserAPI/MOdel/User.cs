using System.ComponentModel.DataAnnotations;

namespace UserAPI.MOdel
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}
