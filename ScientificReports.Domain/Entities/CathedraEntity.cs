namespace ScientificReports.Domain.Entities
{
    public class CathedraEntity : BaseEntity
    {
        public string Name { get; set; }

        public FacultyEntity? Faculty { get; set; } // навигационное свойство
    }
}
