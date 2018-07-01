using System.ComponentModel.DataAnnotations;

namespace WebApiServer
{
    public class DataItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DataItem()
        { }

        public DataItem(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
