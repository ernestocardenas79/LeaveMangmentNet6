namespace LeaveManagment.W3b.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
    }
}
