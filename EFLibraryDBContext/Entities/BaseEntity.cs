namespace EFLibraryDBContext.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        public string Status { get; set; }
    
        public DateTime CreatedDate {get; set; }

        public DateTime ModifiedDate { get; set; }

        public BaseEntity() 
        {
            CreatedDate = DateTime.Now;
        }
    }
}
