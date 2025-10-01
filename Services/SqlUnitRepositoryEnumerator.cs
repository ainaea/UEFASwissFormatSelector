using System.Collections;

namespace UEFASwissFormatSelector.Services
{
    public class SqlUnitRepositoryEnumerator<T> : IEnumerator<T> where T : class
    {
        private List<T> data;
        private int index = -1;
        public SqlUnitRepositoryEnumerator(List<T> data)
        {
            this.data = data;
        }

        public T Current => data[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            index++;
            if (data == null)
            {
                return false;
            }
            return index < data.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
