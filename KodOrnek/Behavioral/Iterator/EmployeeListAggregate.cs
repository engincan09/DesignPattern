using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Iterator
{
    public class EmployeeListAggregate : IEmployeeAggregate
    {
        private List<Employee> _employees;
        public EmployeeListAggregate()
        {
            _employees = new List<Employee>();
        }
        public void Add(Employee employee)
        { 
            _employees.Add(employee);
        }

        public int Count()
        {
            return _employees.Count;
        }

        public Employee Get(int index)
        {
            return _employees[index];
        }

        public IIterator<Employee> CreateIterator()
        {
            return new EmployeeIterator(this);
        }
    }
}
