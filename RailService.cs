public class RailService
{
    public List<RailResult> LastResults {get; set;} = new ();

    public class RailResult
    {
        public List<double> Cuts {get; set;} = new();
        public double Remaining {get; set;} 

        public string GetKey() => string.Join("|", Cuts.OrderBy(c => c));
    }
}