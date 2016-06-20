using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }

        [Display(Name = "Code : ")]
        [Required(ErrorMessage = "Code is required")]
        [StringLength(15)]
        public string Code{ get; set; }

        [Display(Name = "Description : ")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(200)]
        public string Desc { get; set; }

        private DateTime _dDate = DateTime.MinValue;
        [Display(Name = "Date : ")]
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime dDate
        {
            get
            {
                return (_dDate == DateTime.MinValue) ? DateTime.Now : _dDate;
            }
            set { _dDate = value; }
        }
        
        [Display(Name = "Price : ")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Stock : ")]
        [Required(ErrorMessage = "Stock is required")]
        public double Stock { get; set; }
    }
}
