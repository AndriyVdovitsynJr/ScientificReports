using Microsoft.AspNetCore.Identity;
using ScientificReports.Domain.Entities;

namespace ScientificReports.DAL.Models
{
    public class User : IdentityUser
    {
        public int? CathedraId { get; set; }

        public CathedraEntity Cathedra { get; set; }

        public int? FacultyId { get; set; }

        public FacultyEntity Faculty { get; set; }

        public int PublicationCounterBeforeRegistration { get; set; } = 0;

        public int MonographCounterBeforeRegistration { get; set; } = 0;

        public int BookCounterBeforeRegistration { get; set; } = 0;

        public int TrainingBookCounterBeforeRegistration { get; set; } = 0;

        public int OtherWritingCounterBeforeRegistration { get; set; } = 0;

        public int ConferenceCounterBeforeRegistration { get; set; } = 0;

        public int PatentCounterBeforeRegistration { get; set; } = 0;

        public bool IsActive { get; set; } = false;

        public DateTime BirthDate { get; set; }

        public DateTime? GraduationDate { get; set; }

        public DateTime? AwardingDate { get; set; }

        public DateTime? DefenseYear { get; set; }

        public DateTime? AspirantStartYear { get; set; }

        public DateTime? AspirantFinishYear { get; set; }

        public DateTime? DoctorStartYear { get; set; }

        public DateTime? DoctorFinishYear { get; set; }

        public string ApprovedById { get; set; }

        public virtual User ApprovedBy { get; set; } // User.Name?

        //public virtual ICollection<Publication> Publication { get; set; }

        //public virtual ICollection<I18nUserInitials> I18nUserInitials { get; set; }

        //public virtual ICollection<CathedraReport> CathedraReport { get; set; }
    }
}