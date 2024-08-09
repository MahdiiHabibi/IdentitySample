using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace IdentitySample.Authorization.ClaimBasedAuthorization.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ClaimBasedAuthorizationAttribute : AuthorizeAttribute
    {
        public ClaimBasedAuthorizationAttribute(string claimToAuthorize) : base("ClaimBasedAuthorization")
        {
            ClaimToAuthorize = claimToAuthorize;
        }
        
        public string ClaimToAuthorize { get; }
    }
}
