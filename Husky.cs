namespace Arv
{
    internal class Husky : Dog
    {

        public int Loudness { get; set; } = 8;
        public Husky(int mass, string species, string name, int age, bool ppp, string sleep, int loudness) : base(mass, species, name, age, ppp, sleep)
        {
            Loudness = loudness;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public override void Eating()
        {
            base.Eating();
        }
        public override void VeryDangous(bool dangerous)
        {
            base.VeryDangous(dangerous);
        }
        public override void MakeSound()
        {
            base.MakeSound();
        }
    }
}
