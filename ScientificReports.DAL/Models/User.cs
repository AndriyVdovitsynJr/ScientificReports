using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using ScientificReports.Domain.Entities;

namespace ScientificReports.DAL.Models
{
    public class User : IdentityUser
    {
        //public int Name { get; set; } // -

        public int? CathedraId { get; set; }

        public CathedraEntity Cathedra { get; set; } // Cathedra?

        public int? FacultyId { get; set; }

        public FacultyEntity Faculty { get; set; } // auto?

        //public int Role { get; set; } // -

        /////////////////////////
        public Int32 PublicationCounterBeforeRegistration { get; set; } = 0; // int?

        public Int32 MonographCounterBeforeRegistration { get; set; } = 0;

        public Int32 BookCounterBeforeRegistration { get; set; } = 0;

        public Int32 TrainingBookCounterBeforeRegistration { get; set; } = 0;

        public Int32 OtherWritingCounterBeforeRegistration { get; set; } = 0;

        public Int32 ConferenceCounterBeforeRegistration { get; set; } = 0;

        public Int32 PatentCounterBeforeRegistration { get; set; } = 0;

        [Display(Name = "Активний")]
        public Boolean IsActive { get; set; } = false; // bool?

        [DataType(DataType.Date)]
        [Display(Name = "Дата народження")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік закінчення ЗВО")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? GraduationDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік присвоєння вченого звання")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? AwardingDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік захисту")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DefenseYear { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік початку перебування в аспірантурі")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? AspirantStartYear { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік закінчення перебування в аспірантурі")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? AspirantFinishYear { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік початку перебування в докторатурі")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DoctorStartYear { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Рік закінчення перебування в докторантурі")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DoctorFinishYear { get; set; }

        public string ApprovedById { get; set; }

        public virtual User ApprovedBy { get; set; } // User.Name?

        //public virtual ICollection<Publication> Publication { get; set; }

        //public virtual ICollection<I18nUserInitials> I18nUserInitials { get; set; }

        //public virtual ICollection<CathedraReport> CathedraReport { get; set; }

    }
}