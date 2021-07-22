using System;
using System.Collections.Generic;
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
        public string AnimalName { get; set; }
        /// <summary>
        /// owner of animals legal
        /// first name and last name of owner
        /// </summary>
        public string OwnerFullName { get; set; }
        /// <summary>
        /// Day of animals getting dropped off at animal watcher(animal babysitter)
        /// Time is ignored
        /// </summary>
        public DateTime DateTimeOfDropOff { get; set; }

    }
}
