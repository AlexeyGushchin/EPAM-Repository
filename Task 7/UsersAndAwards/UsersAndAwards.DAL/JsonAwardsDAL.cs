using Awards.DAL.Common;
using Awards.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.DAL;
using UsersAndAwards.Entities;

namespace Awards.DAL
{
    public class JsonAwardsDAL : IAwardsDAL
    {
        #region FIELDS
        private const string dataFileName = "applicationData.json";
        public static string DataFilePath => Environment.CurrentDirectory + 
            "\\"  + dataFileName;

        public ApplicationDataObject applicationData;
        #endregion
        public JsonAwardsDAL()
        {
            applicationData = new ApplicationDataObject();
            LoadAppData();
        }

        public IEnumerable<Award> GetAllAwards()
        {
            LoadAppData();
            return applicationData._awards;
        }

        public IEnumerable<User> GetAllUsers()
        {
            LoadAppData();
            return applicationData._users;
        }

        private void LoadAppData()
        {
            if (!File.Exists(DataFilePath))
            {
                using (File.Create(DataFilePath)) { }
                applicationData = new ApplicationDataObject();
                return;
            }

            using (var reader = new StreamReader(DataFilePath))
            {
                if (reader.EndOfStream)
                {
                    applicationData = new ApplicationDataObject();
                    return;
                }
                
                applicationData = JsonConvert.DeserializeObject<ApplicationDataObject>(reader.ReadToEnd());
            }
        }

        

        public void SaveAppData(IEnumerable<User> users, IEnumerable<Award> awards)
        {
            applicationData._awards = awards.ToList();
            applicationData._users = users.ToList();

            var data = JsonConvert.SerializeObject(applicationData);

            using (var writer = new StreamWriter(DataFilePath, false))
            {
                writer.Write(data);
            }
        }

        

        
    }

}
