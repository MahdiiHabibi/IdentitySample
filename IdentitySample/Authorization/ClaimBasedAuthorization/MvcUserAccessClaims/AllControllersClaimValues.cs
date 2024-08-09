using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Authorization.ClaimBasedAuthorization.MvcUserAccessClaims
{
    public static class AllControllersClaimValues
    {
        public static readonly ReadOnlyCollection<(string claimValueEnglish, string claimValuePersian)> AllClaimValues;

        static AllControllersClaimValues()
        {
            var allClaimValues = new List<(string claimValueEnglish, string claimValuePersian)>();
            
            allClaimValues.AddRange(EmployeeControllerClaimValues.AllClaimValues);

            AllClaimValues = allClaimValues.AsReadOnly();
        }
    }
}
