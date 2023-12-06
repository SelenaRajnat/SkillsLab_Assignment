using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using EmployeeTrainingRegistration.DataService;

namespace BusinessLayer.Services
{
    public class TrainingService: ITrainingService
    {
            private readonly IDAL _dataAccessLayer;

            public TrainingService(IDAL dataAccessLayer)
            {
                _dataAccessLayer = dataAccessLayer;
            }

            public List<Training> GetTrainingData()
            {
                try
                {
                    string sql = "SELECT * FROM Training";
                    var dataTable = _dataAccessLayer.RetrieveData(sql);

                    var trainingData = new List<Training>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        var fetchedTraining = new Training
                        {
                            TrainingName = row["TrainingName"].ToString(),
                            TrainingDescription = row["TrainingDescription"].ToString(),
                            LimitedSeat = Convert.ToInt32(row["LimitedSeat"])
                            // Add other properties as needed
                        };

                        trainingData.Add(fetchedTraining);
                    }

                    return trainingData;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        
    }
}
