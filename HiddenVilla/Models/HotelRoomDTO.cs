﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelRoomDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter room name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter room occupancy")]
        public int Occupancy { get; set; }
        [Range(500, 7000)]
        [Required(ErrorMessage = "Please enter room rate between Rs.500 and Rs.15000")]
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqFt { get; set; }

        public virtual ICollection<HotelRoomImageDTO> HotelRoomImages { get; set; }
        public List<string> ImageUrls { get; set; }

    }
}
