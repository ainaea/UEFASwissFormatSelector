namespace UEFASwissFormatSelector.Models
{
    public class DbModifiedDictionaryEntity<T> where T : Identifiable
    {
        public Guid DictionaryId { get; set; }
        //public Guid ScenarioInstanceId { get; set; }
        public Guid DictionaryKey { get; set; }
        public Guid ObjectId { get; set; }
    }
}
