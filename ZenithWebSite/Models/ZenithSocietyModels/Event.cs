using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models.ZenithSocietyModels
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [Display(Name = "Start Date & Time")]
        [DataType(DataType.DateTime)]
        public DateTime EventFromDate { get; set; }

        [Required]
        [Display(Name = "End Date & Time")]
        [DataType(DataType.DateTime)]
        public DateTime EventToDate { get; set; }

        [Display(Name = "Created By")]
        [HiddenInput(DisplayValue = true)]
        public string CreatedBy { get; set; }

        [Display(Name = "Is Active")]
        public Boolean IsActive { get; set; }

        private DateTime _CreateDate = DateTime.Now;
        [DataType(DataType.DateTime)]
        [Display(Name = "Created Date")]
        [HiddenInput(DisplayValue = true)]
        public DateTime CreationDate { get { return _CreateDate; } set { _CreateDate = value; } }

        public int ActivityCategoryId { get; set; }
        [Display(Name = "Activity")]
        public ActivityCategory ActivityCategory { get; set; }

    }
}
