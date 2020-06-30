using System.Collections.Generic;
using System.Linq;

namespace fastBuy.Dominio.Entity
{
    public abstract class Entity
    {
        public List<string> _validationMessage { get; set; }
        private List<string> validationMessage 
        { 
            get { return _validationMessage ?? (_validationMessage = new List<string>()); } 
        }

        protected void ClearValidationMessage()
        {
            validationMessage.Clear();
        }

        protected void AddAlert(string message)
        {
            validationMessage.Add(message);
        }
        public abstract void Validate();
        public bool ItsValid
        {
            get { return !validationMessage.Any(); }
        }
    }
}
