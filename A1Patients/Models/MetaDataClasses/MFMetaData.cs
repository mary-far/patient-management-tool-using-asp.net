using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A1Patients.Models
{
    [ModelMetadataType(typeof(MFMetadata))]
    public partial class Patient : IValidatableObject
    {
        PatientsContext _context = new PatientsContext();
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           
            FirstName = MFValidations.ABCapitalize(FirstName);
            if (FirstName == "")
            {
                yield return new ValidationResult("First Name cannot be null or just blanks", new[] { nameof(FirstName) });
            }

       
            LastName = MFValidations.ABCapitalize(LastName);
            if (LastName == "")
            {
                yield return new ValidationResult("Last Name cannot be null or just blanks", new[] { nameof(LastName) });
            }

          
            if (Gender == null)
            {
                yield return new ValidationResult("Gender cannot be null or just blanks", new[] { nameof(Gender) });
            }
            else
            {
            
                Gender = Gender.ToUpper();

                if (Gender != "M" && Gender != "F" && Gender != "X")
                {
                    yield return new ValidationResult("Gender must be either 'M', 'F' or 'X'", new[] { nameof(Gender) });
                }
            }

            
            if (Address != null)
            {
                Address = MFValidations.ABCapitalize(Address);
            }

          
            if (City != null)
            {
                City = MFValidations.ABCapitalize(City);
            }

            var province = _context.Province.Where(a => a.ProvinceCode == ProvinceCode).Any();

            if (ProvinceCode != null)
            {
              
                if (!province)
                {
                    yield return new ValidationResult("Province Code is not on file", new[] { nameof(ProvinceCode) });
                }
            }

            if (PostalCode != null)
            {
                if (ProvinceCode == null)
                {
                    yield return new ValidationResult("Province code required to validate postal code", new[] { nameof(ProvinceCode) });
                }
                else
                {
                    var country = _context.Province.Where(a => a.ProvinceCode == ProvinceCode).FirstOrDefault();

                    if (country != null)
                    {
                     
                        if (country.CountryCode == "CA")
                        {
                          
                            if (MFValidations.ABPostalCodeValidation(PostalCode))
                            {
                               
                                PostalCode = MFValidations.ABPostalCodeFormat(PostalCode);
                            }
                            else
                            {
                             
                                yield return new ValidationResult("Canadian Postal Code not in correct format: A3A 3A3", new[] { nameof(PostalCode) });
                            }
                        }
                   
                        else if (country.CountryCode == "US")
                        {
                            string postalCode = PostalCode;
                        
                            if (MFValidations.ABZipCodeValidation(ref postalCode))
                            {
                                PostalCode = postalCode;

                                if (PostalCode.Length == 9)
                                {
                                    PostalCode = String.Format("{0:#####-####}", PostalCode);
                                }
                            }
                            else
                            {
                               
                                yield return new ValidationResult("American Zip Code not in correct format: 55555 or 5555-4444", new[] { nameof(PostalCode) });
                            }
                        }
                        else
                        {
                          
                            yield return new ValidationResult("First letter of postal code is not valid for given province", new[] { nameof(PostalCode) });
                        }
                    }

                }
            }

           
            if (Ohip != null)
            {
           
                if (!MFValidations.ABOhipValidation(Ohip))
                {
                    yield return new ValidationResult("OHIP,if provided, must match pattern: 1234-123-123-XX", new[] { nameof(Ohip) });
                }
                else
                {
                  
                    Ohip = Ohip.Trim().ToUpper();
                }
            }

            if (DateOfBirth > DateTime.Now)
            {
                yield return new ValidationResult("Date of birth cannot be in future", new[] { nameof(DateOfBirth) });
            }

            
            if (HomePhone != null)
            {
              
                HomePhone = MFValidations.ABExtractDigits(HomePhone);
                if (HomePhone.Length < 10 && HomePhone.Length > 10)
                {
                    yield return new ValidationResult("Home phone, if provided, must be 10 digits: 123-123-1234", new[] { nameof(HomePhone) });
                }
                else
                {
               
                    HomePhone = String.Format("{0:###-###-####}", HomePhone);
                }
            }

            if (DateOfDeath > DateTime.Now)
            {
                yield return new ValidationResult("Date of Death cannot be in the future",
                                    new[] { nameof(DateOfDeath) });
            }
       
            else if (DateOfDeath < DateOfBirth)
            {
                yield return new ValidationResult("Date of Death cannot be before Date of Birth",
                                    new[] { nameof(DateOfDeath) });
            }

   
            if (Deceased)
            {
                if (DateOfDeath == null)
                {
                    yield return new ValidationResult("If deceased, date of Death is required",
                                        new[] { nameof(DateOfDeath) });
                }
            }
     
            else
            {

                if (DateOfDeath != null)
                {
                    yield return new ValidationResult("Deceased must be true if Date Of Death is provided",
                                        new[] { nameof(Deceased) });
                }
            }

            yield return ValidationResult.Success;
        }
    }
    public class MFMetadata
    {
        public int PatientId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Ohip { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        public bool Deceased { get; set; }
        [Display(Name = "Date of Death")]
        public DateTime? DateOfDeath { get; set; }
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }
    }
}
