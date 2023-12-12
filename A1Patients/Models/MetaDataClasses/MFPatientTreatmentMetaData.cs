using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1Patients.Models
{
    [ModelMetadataType(typeof(PatientTreatmentMetadata))]
    public partial class PatientTreatment { }
    public class PatientTreatmentMetadata
    {
        public int PatientTreatmentId { get; set; }
        public int TreatmentId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy hh:mm}")]
        public DateTime DatePrescribed { get; set; }
        public string Comments { get; set; }
        public int PatientDiagnosisId { get; set; }
    }
}
