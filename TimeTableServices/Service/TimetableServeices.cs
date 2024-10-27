using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableEntities;
using TimeTableServices.Interface;

namespace TimeTableServices.Service
{
    public class TimetableServeices : ITimetable
    {
        private TimetableDbVolgaItContext context;
        public TimetableServeices(TimetableDbVolgaItContext context)
        {
            this.context = context;
        }

        public void AddAppointment(DateTime time)
        {
            throw new NotImplementedException();
        }

        public void AddTimetable(Schedule schedule)
        {
            context.schedule.Add(schedule);
            context.SaveChanges();
        }

        public void DeleteAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctorTimetable(int doctorid)
        {
            var schedule = context.schedule.FirstOrDefault(x => x.doctorid == doctorid);
            context.schedule.Remove(schedule);
            context.SaveChanges();
        }

        public void DeleteHospitalTimetable(int hospitalid)
        {
            var schedule = context.schedule.FirstOrDefault(x => x.hospitalid == hospitalid);
            context.schedule.Remove(schedule);
            context.SaveChanges();
        }

        public void DeleteTimetable(int id)
        {
            var schedule = context.schedule.FirstOrDefault(x => x.id == id);
            context.schedule.Remove(schedule);
            context.SaveChanges();
        }

        public List<Schedule> GetDoctorTimetable(int doctorid)
        {
            return context.schedule.Where(x => x.doctorid == doctorid).ToList();
        }

        public List<DateTime> GetEmptyAppointments(int idtimetable)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetHospitalTimetable(int hospitalid)
        {
            return context.schedule.Where(x => x.hospitalid == hospitalid).ToList();

        }

        public List<Schedule> GetRoomTimetable(int roomid)
        {
            return context.schedule.Where(x => x.roomid == roomid).ToList();

        }

        public void UpdateTimetable(Schedule schedule)
        {
            context.schedule.Update(schedule);
            context.SaveChanges();
        }
    }
}
