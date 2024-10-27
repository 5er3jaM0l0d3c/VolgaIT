using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableEntities;

namespace TimeTableServices.Interface
{
    public interface ITimetable
    {
        public void AddTimetable(Schedule schedule);
        public void UpdateTimetable(Schedule schedule);
        public void DeleteTimetable(int id);
        public void DeleteDoctorTimetable(int doctorid);
        public void DeleteHospitalTimetable(int hospitalid);
        public List<Schedule> GetHospitalTimetable(int hospitalid);
        public List<Schedule> GetDoctorTimetable(int doctorid);
        public List<Schedule> GetRoomTimetable(int roomid);
        public List<DateTime> GetEmptyAppointments(int idtimetable);
        public void AddAppointment(DateTime time);
        public void DeleteAppointment(int id);
    }
}
