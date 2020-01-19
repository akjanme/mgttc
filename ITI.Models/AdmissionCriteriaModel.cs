using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class AdmissionCriteriaModel
    {
        public int ID { get; set; }
        [Required,MaxLength(50)]
        public string SessionStartDate { get; set; }
        [Required, MaxLength(50)]
        public string DateOfNotice { get; set; }
        [Required, MaxLength(50)]
        public string LastDateOfReciept { get; set; }
        public Nullable<int> NumberOfApplication { get; set; }
        [Required, MaxLength(50)]
        public string DateOfAdmissionCompleted { get; set; }
        [Required, MaxLength(50)]
        public string CriteriaForAddmision { get; set; }
        [Required, MaxLength(50)]
        public string IsTraineeQualified { get; set; }
        [Required, MaxLength(50)]
        public string IsCopyEnclosed { get; set; }
        [Required, MaxLength(50)]
        public string CCE { get; set; }
    }
}
