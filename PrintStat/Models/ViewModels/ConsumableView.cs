﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintStat.Models.ViewModels
{
    public class ConsumableView : BaseView
    {
        [Display(Name = "Рабочий ресурс")]
        public int Endurance { get; set; }

        [Display(Name = "Короткое название")]
        public string ShortName { get; set; }
        [Display(Name = "Тип комплектующего")]
        [Required(ErrorMessage = "Выберите тип комплектующего")]
        public int TypeConsumableID { get; set; }
        [Display(Name = "Поддерживаемые модели")]
        public int[] ChosenModelIds { get; set; }

        private List<Model> _Models = new List<Model>();
        public List<Model> Models
        {
            get { return _Models; }
            set { _Models = value; }
        }
    }
}
