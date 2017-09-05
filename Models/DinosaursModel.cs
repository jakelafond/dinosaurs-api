using System;
using System.Collections.Generic;

namespace DinosaursAPI.Models
{
    public class DinosaurModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Period { get; set; }
        public string Habitats { get; set; }

        public DinosaurModel()
        {

        }

        public List<DinosaurModel> GetDinosaurs()
        {
            return new List<DinosaurModel>{
            new DinosaurModel{
    ID = 1,
    Name = "TYRANNOSAURUS",
    Image =  "http://www.activewild.com/wp-content/uploads/2016/07/Tyrannosaurus-Rex.jpg",
    Size =  "23 ft.",
    Weight =  "16,000 pounds",
    Period =  "Late Cretaceous",
    Habitats =  "coastal,tropical,forest"
    },
    new DinosaurModel{

    ID = 2,
    Name =  "STEGASAURUS",
    Image = "https://vignette1.wikia.nocookie.net/dino/images/4/4c/Stegosaurus-detail-header.png/revision/latest?cb=20150407211604",
    Size =  "11 ft.",
    Weight = "6,000 pounds",
    Period = "Late Jurassic",
    Habitats = "sub-tropical,forest"
  },
  new DinosaurModel{
    ID = 3,
    Name = "TRICERATOPS",
    Image = "https://vignette2.wikia.nocookie.net/dino/images/f/f6/JW_triceratops.png/revision/latest?cb=20150407211112",
    Size =  "9.5 ft.",
    Weight = "14,0000 pounds",
    Period = "Late Cretaceous",
    Habitats = "tropical"
  },
  new DinosaurModel{
    ID = 4,
    Name = "TITANOSAURUS",
    Image = "http://images.dinosaurpictures.org/titanosaurus-colberti-2_4c21.jpg",
    Size =  "50 ft.",
    Weight = "30,000 pounds",
    Period = "Late Cretaceous",
    Habitats = "forest"
  }
        };
        }
    }
}
