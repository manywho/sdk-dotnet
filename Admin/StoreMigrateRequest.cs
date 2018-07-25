namespace ManyWho.Flow.SDK.Admin
{
    public class StoreMigrateRequest
    {
        /// <summary>
        /// A size of batch that will be used to save states during migration
        /// </summary>
        public int? BatchSize
        {
            get;
            set;
        }
    }
}