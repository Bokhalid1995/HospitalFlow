using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Sahred.Constants
{
    public static class MessagesConstants
    {
        public const string DataCreated = "Data created successfully";
        public const string DataUpdated = "Data updated successfully";
        public const string Done = "Done";
        public const string Success = "Success";
        public const string Failed = "Failed";
        public const string DataRetrieved = "Data Retrieved Successfully";
        public const string UpdateFail = "No changes were saved. Update operation failed.";
        public const string CreateFail = "No changes were saved. Create operation failed.";
        public const string NoDataWithID = "Data not found with specific ID";
        public const string DeleteFail = "No changes were saved. Delete operation failed.";
        public const string DataDeleted = "Data deleted successfully";
        public const string ValidationFailed = "Validation failed";
        public const string UnexpectedError = "An unexpected error occurred";
        public const string Required = "This field is required.";
        public const string InvalidPhone = "Phone number is invalid.";
        public const string MaxLengthExceeded = "Maximum length exceeded.";
        public const string InvalidEmail = "Email address is invalid.";
        public const string InvalidNationalId = "National ID must be 14 digits.";
        public const string InvalidGender = "Gender is invalid.";
        public const string IdRequired = "Id  be provided when updating a patient file.";
    }
}
