using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes1.Models
{
    public class SuperHero
    {
        [Key]
        public int SuperHeroID { get; set; }
        [Display(Name = "Hero Name")]
        public string SuperHeroName { get; set; }
        [Display(Name = "Alter Ego")]
        public string AlterEgo { get; set; }
        [Display(Name = "Primary SuperHero Ability")]
        public string PrimarySuperHeroAbility { get; set; }
        [Display(Name = "Secondary SuperHero Ability")]
        public string SecondarySuperHeroAbility { get; set; }
        [Display(Name = "Catch phrase")]
        public string Catchphrase { get; set; }
    }
}