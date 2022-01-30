namespace Abstraindo_um_RPG_com_POO.Source.Entities
{
    public abstract class Hero
    {
        public Hero(String Name, int Level, String HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){

        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou";
        }

    }
}