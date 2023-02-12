using Microsoft.AspNetCore.Identity;

namespace BackEnd_Project.Helpers
{
    public class CustomIdentityErrors:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description=$"lover case mecburidir"
            };
        }
    }

}
