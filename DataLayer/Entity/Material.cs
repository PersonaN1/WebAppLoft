namespace DataLayer.Entity
{
    public class Material:Page
    {
        public int DirectoryId { get; set; }//outer key
        public Directory Directory { get; set; }//navigation property
    }
}