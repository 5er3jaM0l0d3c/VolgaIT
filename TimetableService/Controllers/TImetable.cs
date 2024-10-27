using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimetableEntities;
using TimeTableServices.Interface;

namespace TimetableService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TImetable : ControllerBase
    {
        private ITimetable Schedule {  get; set; }
        public TImetable(ITimetable schedule)
        {
            Schedule = schedule;
        }

        [HttpPost]
        public void AddTimetable(Schedule schedule)
        {
            Schedule.AddTimetable(schedule);
        }

        [HttpPut]
        public void UpdateTimetable(Schedule schedule)
        {
            Schedule.UpdateTimetable(schedule);
        }

        [HttpDelete]
        public void DeleteTimetable(int id)
        {
            Schedule.DeleteTimetable(id);
        }

        [HttpDelete("Doctor")]
        public void DeleteDoctorTimetable(int id)
        {
            Schedule.DeleteDoctorTimetable(id);
        }

        [HttpDelete("Hospital")]
        public void DeleteHospitalTimetable(int id)
        {
            Schedule.DeleteHospitalTimetable(id);
        }

        [HttpGet("Hospital")]
        public List<Schedule> GetHospitalTimetable(int id)
        {
            return Schedule.GetHospitalTimetable(id);
        }

        [HttpGet("Doctor")]
        public List<Schedule> GetDoctorTimetable(int id)
        {
            return Schedule.GetDoctorTimetable(id);
        }

        [HttpGet("Hospital/Room/")]
        public List<Schedule> GetRoomSchedules([FromRoute]int id, [FromRoute]int room)
        {
            return Schedule.GetRoomTimetable(room);
        }

        [HttpGet("Appointments")]
        public string GetAppointments(int id)
        {
            return "запись";
        }

        
    }
}
