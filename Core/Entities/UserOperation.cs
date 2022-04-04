using Core.Entities;

namespace Core.Entities

{
    public class UserOperation:IEntity
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }  

        public Operation   Operation { get; set; }
    }
}
