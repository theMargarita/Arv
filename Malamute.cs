namespace Arv
{
    internal class Malamute : Dog
    {
        public string Fluffy { get; set; } = "Very fluffy";
        public Malamute(int mass, string species, string name, int age, bool ppp, string sleep, string fluffy) : base(mass, species, name, age, ppp, sleep)
        {
            Fluffy = fluffy;
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }
        public override void VeryDangous(bool dangerous)
        {
            base.VeryDangous(dangerous);
        }
        public override void Eating()
        {
            base.Eating();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
