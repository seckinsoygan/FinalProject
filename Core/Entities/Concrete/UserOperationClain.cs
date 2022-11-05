using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class UserOperationClain : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
