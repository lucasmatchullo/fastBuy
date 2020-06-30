using System.Collections.Generic;

namespace fastBuy.Dominio.Entity
{
    public class Username : Entity
    {   
        public int Id{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // A user can have One or Many orders
        public ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddAlert("Email not informed!!");

            if (string.IsNullOrEmpty(Password))
                AddAlert("Password not informed!!");

        }
    }
}
