using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Cann't null!"),StringLength(70,ErrorMessage = "Not more than 70 simvol")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Cann't null!"), StringLength(100, ErrorMessage = "Not more than 100 simvol")]
        public string Description { get; set; }
        [Required,StringLength(200)]
        public string Image { get; set; }

    }

}

