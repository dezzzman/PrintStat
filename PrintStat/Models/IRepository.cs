﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStat.Models
{
    public interface IRepository
    {
        IQueryable<Device> PrintersAndPlotters { get;  }
        IQueryable<Device> Printers { get; }
        IQueryable<Device> Plotters { get; }

        //Добавление 
        IQueryable<SizePaper> SizePapers { get; }

        IQueryable<PaperType> PaperTypes { get;  }
        IQueryable<PaperType> PrinterPaperTypes { get;  }
        IQueryable<PaperType> PlotterPaperTypes { get; }
        
        IQueryable<DeviceType> DeviceTypes { get;  }

        IQueryable<PrintKind> PrintKinds { get;  }
        IQueryable<Job> Jobs { get;  }

        IQueryable<Application> Applications { get;  }
        IQueryable<Employee> AuthorEmployees { get;  }
        IQueryable<Employee> UserEmployees { get; }

       // IQueryable<Setup> Setup { get; }

        IQueryable<Department> Departments { get; }


        bool CreatePrinter(Device instance);
        bool UpdatePrinter(Device instance);
        bool RemovePrinter(Device instance);


        bool CreatePapertype(PaperType instance);
        bool UpdatePapertype(PaperType instance);

        bool RemovePapertype(PaperType instance);

        // SizePaper
        bool CreateSizePaper(SizePaper instance);
        bool UpdateSizePaper(SizePaper instance);
        bool RemoveSizePaper(SizePaper instance);


        bool CreateDevicetype(DeviceType instance);
        bool UpdateDevicetype(DeviceType instance);

        bool RemoveDevicetype(DeviceType instance);

        bool CreateJob(Job instance);
        bool UpdateJob(Job instance);
        bool RemoveJob(Job instance);

       // bool SaveSettings(Setup settings);
        


    }
}
