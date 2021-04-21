using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Data.Constants
{
    public class enums
    {
        public enum ReturnCodes
        {
            RecordAlreadyExists = 0,
            RecordNotExists = 404,
            RecordUpdated = 201,
            RecordDeleted = 202
        }
    }
}
