namespace ScientificReports.Domain.Entities
{
    public class FacultyEntity : BaseEntity
    {
        public string Name { get; set; }

        public List<CathedraEntity> Cathrdras { get; set; } = new ();
    }
}
