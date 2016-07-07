using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Resources;

namespace WebDeveloper.Model
{
    public class Product
    {
        [Display(Name = "Product_Id", ResourceType = typeof(Resource))]
        public int ID { get; set; }

        [Display(Name = "Product_Code", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "Code is required")]
        [StringLength(15)]
        public string Code{ get; set; }

        [Display(Name = "Product_Desc", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(200)]
        public string Desc { get; set; }

        [Display(Name = "Product_Creation", ResourceType = typeof(Resource))]
        public DateTime? CreateDate { get; set; }


        private DateTime _dDate = DateTime.MinValue;
        [Display(Name = "Product_Date", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "Date is required")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        public DateTime dDate
        {
            get
            {
                return (_dDate == DateTime.MinValue) ? DateTime.Now : _dDate;
            }
            set { _dDate = value; }
        }

        [Display(Name = "Product_Price", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Product_Stock", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "Stock is required")]
        public double Stock { get; set; }
    }
}
