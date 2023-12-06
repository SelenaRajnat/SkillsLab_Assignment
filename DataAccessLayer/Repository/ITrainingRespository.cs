using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface ITrainingRespository
    {
        List<Training> GetTrainingData(Training training);
        //bool RetrieveTrainingData(Training training);
    }
}
