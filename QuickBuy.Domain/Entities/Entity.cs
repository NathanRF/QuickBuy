using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _validationMessages { get; set; }
        private List<string> validationMessage
        {
            get { return _validationMessages ?? (_validationMessages = new List<string>()); }
        }
        protected void ClearMessages()
        {
            validationMessage.Clear();
        }
        protected void AddCritical(string message)
        {
            validationMessage.Add("Critical - " + message);
        }
        public abstract void Validate();
        protected bool IsValid
        {
            get { return !(validationMessage.Any()); }
        }
    }
}
