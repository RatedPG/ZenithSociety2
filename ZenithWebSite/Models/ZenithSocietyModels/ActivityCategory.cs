using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models.ZenithSocietyModels
{
    public class ActivityCategory
    {
        [Key]
        public int ActivityCategoryId { get; set; }
        [Required]
        [Display(Name = "Activity Category")]
        public string ActivityDescription { get; set; }
        private DateTime _CreateDate = DateTime.Now;
        [DataType(DataType.DateTime)]
        [Display(Name = "Created On")]
        [HiddenInput(DisplayValue = true)]
        public DateTime CreationDate { get { return _CreateDate; } set { _CreateDate = value; } }

        public List<Event> Events { get; set; }
    }
}
