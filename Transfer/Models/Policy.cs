namespace Transfer.Models
{
    public interface IPolicy
    {

    }

    public class Policy : IPolicy
    {
        private Func<double> _action;
        private string _name;
        public Policy(string name, Func<double> action) {
            _name = name;
            _action = action;
        }
    }
}
