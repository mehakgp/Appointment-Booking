﻿using Appointment.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.DataAccessLayer
{
    public interface IDataAccess
    {
        public bool Register(SignUpModel newUser, TimeOnly startTime, TimeOnly endTime);
        public int IsValidUser(LogInModel user);
        public bool IsEmailExists(string email);
        public List<DoctorViewModel> GetDoctors();
        public bool BookAppointment(AppointmentViewModel newAppointment);
        public List<TimeOnly> GetTimeSlots(int doctorId, DateOnly appointmentDate);
        public List<AppointmentViewModel> GetListOfAppointments(int doctorId, DateOnly selectedDate);
        public bool CancelAppointment(int appointmentId);
        public bool CloseAppointment(int appointmentId);
        public List<AppointmentSummaryReportModel> GetAppointmentSummaryReport(int doctorId, int month, int year);
        public List<AppointmentDetailedReportModel> GetAppointmentDetailedReport(int doctorId, int month, int year);
    }
}
