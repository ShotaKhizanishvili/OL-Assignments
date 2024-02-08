namespace BookLibrary_Api.Requests
{
    public class MoveToShelfRequest
    {
        public int Id { get; set; }
        public int NewShelfId { get; set; }
    }
}
