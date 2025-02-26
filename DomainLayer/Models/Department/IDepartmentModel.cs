﻿using DomainLayer.Models.Employee;

namespace DomainLayer.Models.Department
{
    public interface IDepartmentModel
    {
        string? Decription { get; set; }
        ICollection<IEmployeeModel>? Employees { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}