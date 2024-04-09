namespace myEnglish_with_Button
{
    public interface IWord
    {
       public string Title { get; set; }
       public string Translation { get; set; }
    }
    public class Word : IWord
    {
        public string Title { get; set; }
        public string Translation { get; set; }
        public Word() { }
        public Word(string title, string translation)
        {
            Title = title;
            Translation = translation;
        }
        public override string ToString()
        {
            return $"{Title} - {Translation}";
        }



    }
}
