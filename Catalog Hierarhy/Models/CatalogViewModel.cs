namespace Catalog_Hierarhy.Models
{
    public class CatalogViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public List<Catalog>? Children { get; set; }
    }
}
