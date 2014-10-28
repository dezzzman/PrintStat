﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PrintStat.Models
{
    public partial class SQLRepository : IRepository 
    {

        [Display(Name = "Типоразмер бумаги")]
        public IQueryable<SizePaper> SizePapers
        {
            get { return Db.SizePaper; }
        }

        public IQueryable<CartridgeColor> CartridgeColors
        {
            get
            {
                return Db.CartridgeColor;
            }
        } //private set?


        public bool CreateSizePaper(SizePaper instance)
        {

            Db.SizePaper.InsertOnSubmit(instance);
            Db.SizePaper.Context.SubmitChanges();
            return true;
        }

        public bool UpdateSizePaper(SizePaper instance)
        {

            Db.SizePaper.Context.SubmitChanges();
            return true;
        }

        public bool RemoveSizePaper(SizePaper instance)
        {
            Db.SizePaper.DeleteOnSubmit(instance);
            Db.SizePaper.Context.SubmitChanges();
            return true;
        }


        [Display(Name= "Тип бумаги")]
        public IQueryable<PaperType> PaperTypes
        {
            get
            {
                return Db.PaperType;
            }
        }

        public IQueryable<PaperType> PrinterPaperTypes  
        { 
            get
            {
                //return Db.PaperType.Where(p => p.DeviceTypeID == 2);
                return null;
            }
        }
        public IQueryable<PaperType> PlotterPaperTypes 
        {
            get
            {
                //     return Db.PaperType.Where(p => p.DeviceTypeID == 1);
                return null;
            }
        }


        public bool CreatePapertype(PaperType instance)
        {

            Db.PaperType.InsertOnSubmit(instance);
            Db.PaperType.Context.SubmitChanges();
            return true;
        }

        public bool UpdatePapertype(PaperType instance)
        {
            
            Db.PaperType.Context.SubmitChanges();
            return true;
        }

        public bool RemovePapertype(PaperType instance)
        {
            Db.PaperType.DeleteOnSubmit(instance);
            Db.PaperType.Context.SubmitChanges();
            return true;
        }
#region PrintKind definition

        public bool CreatePrintKind(PrintKind instance)
        {
            Db.PrintKind.InsertOnSubmit(instance);
            Db.PrintKind.Context.SubmitChanges();
            return true;
        }

        public bool UpdatePrintKind(PrintKind instance)
        {
            Db.PrintKind.Context.SubmitChanges();
            return true;
        }

        public bool RemovePrintKind(PrintKind instance)
        {
            Db.PrintKind.DeleteOnSubmit(instance);
            Db.PrintKind.Context.SubmitChanges();
            return true;
        }
#endregion



        public IQueryable<Department> Departments
        {
            get
            {
                return Db.Department;
            }
        }

        public bool CreateDepartment(Department instance)
        {
            if (instance.ID == 0)
            {
                Db.Department.InsertOnSubmit(instance);
                Db.Department.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateDepartment(Department instance)
        {
            Department cache = Db.Department.Where(p => p.ID == instance.ID).FirstOrDefault();
            if (cache != null)
            {
                //TODO : Update fields for Department
                Db.Department.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveDepartment(Department instance)
        {

                Db.Department.DeleteOnSubmit(instance);
                Db.Department.Context.SubmitChanges();
                return true;

        }
        

#region CartridgeColor definition


        [Display(Name = "Приложения")]
        public IQueryable<Application> Applications
        {
            get
            {
                return Db.Application;
            }
        }

        public bool CreateApplication(Application instance)
        {
            if (instance.ID == 0)
            {
                Db.Application.InsertOnSubmit(instance);
                Db.Application.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateApplication(Application instance)
        {
            Application cache = Db.Application.Where(p => p.ID == instance.ID).FirstOrDefault();
            if (cache != null)
            {
                //TODO : Update fields for Application
                Db.Application.Context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool RemoveApplication(Application instance)
        {
            
                Db.Application.DeleteOnSubmit(instance);
                Db.Application.Context.SubmitChanges();
                return true;
        }
        
        public bool CreateCartridgeColor(CartridgeColor instance)
        {
            Db.CartridgeColor.InsertOnSubmit(instance);
            Db.CartridgeColor.Context.SubmitChanges();
            return true;
        }

        public bool UpdateCartridgeColor(CartridgeColor instance)
        {
            Db.CartridgeColor.Context.SubmitChanges();
            return true;
        }

        public bool RemoveCartridgeColor(CartridgeColor instance)
        {
            Db.CartridgeColor.DeleteOnSubmit(instance);
            Db.CartridgeColor.Context.SubmitChanges();
            return true;
        }
#endregion
        [Display(Name = "Типы устройств")]
        public IQueryable<DeviceType> DeviceTypes
        {

            get
            {
                return Db.DeviceType;            
            }
        }



        public bool CreateDevicetype(DeviceType instance)
        {
            Db.DeviceType.InsertOnSubmit(instance);
            Db.DeviceType.Context.SubmitChanges();
            return true;
        }
        
        public bool UpdateDevicetype(DeviceType instance)
        {
            Db.DeviceType.Context.SubmitChanges();
            return true;
        }

        public bool RemoveDevicetype(DeviceType instance)
        {
            Db.DeviceType.DeleteOnSubmit(instance);
            Db.DeviceType.Context.SubmitChanges();
            return true;
        }





        [Display(Name = "Сотрудники-авторы")]
        public IQueryable<Employee> AuthorEmployees
        {
            get
            {
                return Db.Employee.Where(p => p.DepartmentID != 2);
            }
        }

        [Display(Name = "Сотрудники-пользователи")]
        public IQueryable<Employee> UserEmployees
        {
            get
            {
                return Db.Employee.Where(p => p.DepartmentID == 2);
            }
        }


        public IQueryable<PrintKind> PrintKinds
        {
            get
            {
                return Db.PrintKind;
            }
        }




        //public IQueryable<Setup> Setup
        //{
        //    get
        //    {
        //        return Db.Setup;
        //    }
        //}

        //public bool SaveSettings(Setup settings)
        //{

        //    var s = Db.Setup.FirstOrDefault();
        //    if (s != null)
        //    {
        //        s.AccountName = settings.AccountName;
        //        s.MailServer = settings.MailServer;
        //        s.Pwd = settings.Pwd;
        //        s.Employee = Db.Employee.FirstOrDefault(p => p.TabNumber == "1190");
        //        s.Port = settings.Port;
        //    }
        //    else
        //    {
        //        settings.Employee = Db.Employee.FirstOrDefault(p => p.TabNumber == "1190");
        //        Db.Setup.InsertOnSubmit(settings);
        //    }

        //    Db.Setup.Context.SubmitChanges();
        //    return true;
        //}
    }
}