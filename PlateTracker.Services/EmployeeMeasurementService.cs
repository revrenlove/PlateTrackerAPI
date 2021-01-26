﻿using PlateTracker.data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.Logging;
using PlateTracker.data.Models;
using PlateTracker.ViewModels;

namespace PlateTracker.Services
{
    public class EmployeeMeasurementService
    {
        EmployeeRepository _employeeRepository;
        ILogger _logger;
        public EmployeeMeasurementService(ILogger logger)
        {
            _logger = logger;
            EmployeeRepository employeeRepository = new EmployeeRepository(new TechnicalPlatingContext(), _logger);
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<EmployeeVM> GetEmployees()
        {
            AutoMapperService mapper = new AutoMapperService();
            List<EmployeeVM> returnValues = new List<EmployeeVM>();

            _employeeRepository.GetEmployees().ToList().ForEach(t =>
            {
                var result = mapper.IMapper.Map<Employee, EmployeeVM>(t);
                returnValues.Add(result);
            });

            return returnValues;
        }
    }
}