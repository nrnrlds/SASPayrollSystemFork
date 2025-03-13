﻿using DomainLayer.Models.Holiday;
using DomainLayer.Models.Salary;

namespace DomainLayer.Models.Payroll
{
    public interface IPayrollModel
    {
        DateOnly CutOffEnd { get; set; }
        DateOnly CutOffStart { get; set; }
        ICollection<HolidayModel> Holidays { get; }
        Guid Id { get; set; }
        DateOnly PayrollDate { get; set; }
        ICollection<SalaryModel> Salaries { get; }
        uint TotalRegularHolidays { get; set; }
        uint TotalSpecialHolidays { get; set; }
        uint TotalWorkingDays { get; set; }

        void CountWorkDaysAndHolidays();
    }
}