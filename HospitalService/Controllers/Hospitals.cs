using HospitalEntities;
using HospitalServices.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hospitals : ControllerBase
    {
        private IHospital Hospital {  get; set; }
        public Hospitals(IHospital hospital)
        {
            this.Hospital = hospital;
        }

        [HttpGet]
        public List<Hospital> GetHospitals(int from, int count) 
        {
            return Hospital.GetHospitals(from, count);
        }

        [HttpGet("Id")]
        public Hospital GetHospital([FromRoute]int id)
        {
            return Hospital.GetHospital(id);
        }

        [HttpGet("Id/Rooms")]
        public List<Room> GetRooms([FromRoute]int id)
        {
            return Hospital.GetRooms(id);
        }

        [HttpPost]
        public void AddHospital(Hospital hospital)
        {
            Hospital.AddHospital(hospital);
        }

        [HttpPut]
        public void UpdateHospital(Hospital hospital)
        {
            Hospital.UpdateHospital(hospital);
        }

        [HttpDelete]
        public void DeleteHospital(int id)
        {
            Hospital.DeleteHospital(id);
        }
    }
}
