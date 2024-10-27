using HospitalEntities;
using HospitalServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HospitalServices.Service
{
    public class HospitalSerivices : IHospital
    {
        private HospitalDbVolgaItContext context {  get; set; }
        public HospitalSerivices(HospitalDbVolgaItContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitals(int from, int count)
        {
            return context.hospital.ToList().GetRange(from, count);
        }

        public Hospital GetHospital(int id)
        {
            return context.hospital.FirstOrDefault(x => x.id == id);
        }

        public List<Room> GetRooms(int hospitalid)
        {
            return context.room.Where(x => x.hospitalid == hospitalid).ToList();
        }

        public void AddHospital(Hospital hospital)
        {
            context.hospital.Add(hospital);
            context.SaveChanges();
        }

        public void UpdateHospital(Hospital hospital)
        {
            context.hospital.Update(hospital);
            context.SaveChanges();
        }

        public void DeleteHospital(int id)
        {
            var hospital = context.hospital.FirstOrDefault(y => y.id == id);
            context.hospital.Remove(hospital);
        }
    }
}
