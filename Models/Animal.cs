using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Individual animal/pet at babysitters
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Animals ID in DataBase
        /// </summary>
        public int AnimalID { get; set; }
        /// <summary>
        /// Animals first name
        /// </summary>
        [Display(Name = "Animal Name")]
        [Required]
        public string AnimalName { get; set; }
        /// <summary>
        /// owner of animals legal
        /// first name and last name of owner
        /// </summary>
        [Display(Name = "Owner's Full Name")]
        [Required]
        public string OwnerFullName { get; set; }
        /// <summary>
        /// the Breed of the animal 
        /// </summary>
        [Display(Name = "Animal Breed")]
        [Required]
        public string Breed { get; set; }
        /// <summary>
        /// Day of animals getting dropped off at animal watcher(animal babysitter)
        /// Time is ignored
        /// </summary>
        [Display(Name = "Drop off date of Animal")]
        [DataType(DataType.Date)]
        public DateTime DateTimeOfDropOff { get; set; }
    }
}
