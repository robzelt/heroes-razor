using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Shared;

namespace HeroesRazor.Components
{
	public class HeroState
	{
		public event EventHandler StateChanged;
		public List<Hero> Heroes { get; set; }
		public List<Hero> Villains { get; set; }

		private void StateHasChanged()
		{

			StateChanged?.Invoke(this, EventArgs.Empty);
		}

		public HeroState()
		{
			Heroes = new List<Hero>() {
	new Hero(){
	Id= "HeroAslaug",
	Name= "Aslaug",
	Description= "warrior queen",
  },
  new Hero(){
	Id = "HeroBjorn",
	Name = "Bjorn Ironside",
	Description= "king of 9th century Sweden",
  },
  new Hero(){
	Id = "HeroIvar",
	Name= "Ivar the Boneless",
	Description= "commander of the Great Heathen Army",
  },
  new Hero(){
	Id= "HeroLagertha",
	Name= "Lagertha the Shieldmaiden",
	Description = "aka Hlaðgerðr",
  },
  new Hero(){
	Id = "HeroRagnar",
	Name = "Ragnar Lothbrok",
	Description=  "aka Ragnar Sigurdsson",
  },
  new Hero(){
	Id = "HeroThora",
	Name= "Thora Town-hart",
	Description= "daughter of Earl Herrauðr of Götaland",
  } };


			Villains = new List<Hero>() {
	new Hero() {
	Id = "VillainMadelyn",
	Name= "Madelyn",
	Description= "the cat whisperer",
  },
  new Hero(){
	Id = "VillainHaley",
	Name = "Haley",
	Description = "pen wielder",
  },
  new Hero(){
	Id = "VillainElla",
	Name = "Ella",
	Description = "fashionista",
  },
  new Hero(){
	Id= "VillainLandon",
	Name= "Landon",
	Description = "Mandalorian mauler",
  }};
		}
	}
}
