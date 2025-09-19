
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public int _id { get; set; }
        public string _name { get; set; }

        public string _emailAddress { get; }
        public string _password { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            _id = id;
            _name = name;
            _emailAddress =emailAddress;
            _password=password;
        }
    }
}
