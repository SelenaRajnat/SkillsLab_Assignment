using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using EmployeeTrainingRegistration.DataService;

namespace DataAccessLayer.Repository
{
    public class TrainingRepository : ITrainingRespository
    {
        //    private readonly IDataAccessLayer _dataAccesslayer;
        //    public TrainingRepository(IDataAccessLayer layer)
        //    {
        //        _dataAccesslayer = layer;
        //    }
        //    public List<Training> GetTrainingData(Training training)
        //    {
        //        try
        //       {
        //    //        List<SqlParameter> parameters = new List<SqlParameter>
        //    //{
        //    //    new SqlParameter("@TrainingName", SqlDbType.VarChar, 100) { Value = training.TrainingName },
        //    //    new SqlParameter("@TrainingDescription", SqlDbType.VarChar, 255) { Value = training.TrainingDescription},
        //    //    new SqlParameter("@LimitedSeat", SqlDbType.Int) { Value = training.LimitedSeat },
        //    //};
        //            string sql = "SELECT * FROM Training /* WHERE TrainingName=@TrainingName AND TrainingDescription=@TrainingDescription AND LimitedSeat =@LimitedSeat */";
        //            var dataTable = _dataAccesslayer.RetrieveData(sql);

        //            var trainingData = new List<Training>();

        //            foreach (DataRow row in dataTable.Rows)
        //            {
        //                var fetchedTraining = new Training
        //                {
        //                    TrainingName = row["TrainingName"].ToString(),
        //                    TrainingDescription = row["TrainingDescription"].ToString(),
        //                    LimitedSeat = Convert.ToInt32(row["LimitedSeat"])
        //                    // Add other properties as needed
        //                };

        //                trainingData.Add(fetchedTraining);
        //            }

        //            return trainingData;
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        public List<Training> GetTrainingData(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
