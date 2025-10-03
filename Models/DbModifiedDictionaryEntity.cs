namespace UEFASwissFormatSelector.Models
{
    public class DbModifiedDictionaryEntity<T> where T : Identifiable
    {
        public DbModifiedDictionaryEntity(Guid siId)
        {
            ScenarioInstanceId = siId;
        }
        public Guid DictionaryId { get; set; }
        public Guid ScenarioInstanceId { get; set; }
        public Guid DictionaryKey { get; set; }
        public Guid ObjectId { get; set; }
        public virtual ScenarioInstance ScenarioInstance { get; set; }
        /// <summary>
        /// To be used only for db purpose
        /// </summary>
        public DbModifiedDictionaryEntity()
        {
            
        }
    }   
}
