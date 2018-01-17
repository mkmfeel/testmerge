using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Google.Analytics.Additions
{
    public class ResultDataFileSaver<T> where T: class
    {
        private string fileName;
        private PropertyInfo[] props;

        public ResultDataFileSaver()
        {
            string className = typeof (T).Name;
            fileName = $"F:\\Google\\{className}.csv";
            props = typeof (T).GetProperties();
        }

        public void SaveDataToFile(IList<T> savingItems)
        {
            using (var fileStream = File.Create(fileName))
            {
                using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    string header = string.Join(";", props.Select(p => p.Name));
                    writer.WriteLine(header);
                    foreach (var stringToWrite in
                        from object item in savingItems
                        select string.Join(";", props.Select(p => p.GetValue(item, null))))
                    {
                        writer.WriteLine(stringToWrite);
                    }

                    writer.Close();
                }
            }
        }
    }
}