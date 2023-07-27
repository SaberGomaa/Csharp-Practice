namespace Practise
{
    internal class Sample
    {
        public string Name { get; set; }
        public string Img { get; set; }

        public static Sample operator+ (Sample s2, Sample s1)
        {
            Sample result = new Sample();
            result.Name = s2.Name + s1.Name;
            result.Img = s1.Img + s2.Img;

            return result;
        }

        public static bool operator== (Sample s1, Sample s2)
        {
            return s1.Img == s2.Img && s1.Name == s2.Name;
        }

        public static bool operator!=(Sample s1, Sample s2)
        {
            if(s1.Img == s2.Img && s1.Name == s2.Name) return false;
            return true;
        }

        public override string ToString()
        {
            return $"Name : {Name} , Image : {Img}";
        }
    }
}
