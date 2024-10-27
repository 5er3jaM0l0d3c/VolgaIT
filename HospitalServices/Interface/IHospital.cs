using HospitalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalServices.Interface
{
    public interface IHospital
    {
        public List<Hospital> GetHospitals(int from, int count);
        public Hospital GetHospital(int id);
        public List<Room> GetRooms(int hospitalid);
        public void AddHospital(Hospital hospital);
        public void UpdateHospital(Hospital hospital);
        public void DeleteHospital(int id);
    }
}
