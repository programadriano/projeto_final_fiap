using API.Entities.Emuns;

namespace API.Entities
{
    public class News : BaseEntity
    {

        public News(string title, string hat, string description, string createdBy, string tags,Status status)
        {
            Id = Guid.NewGuid().ToString();
            PublishDate = DateTime.Now;
            Status = status;

            Title = title;
            Hat = hat;
            Description = description;
            CreatedBy = createdBy;
            Tags = tags;
        }

        #region [Propriedades]
        public string Title { get; private set; }
        public string Hat { get; private set; }
        public string Description { get; private set; }
        #endregion

        #region [Methods]
        public void Delete() => Deleted = 1;
        #endregion

    }
}
