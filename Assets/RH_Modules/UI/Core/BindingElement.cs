using UnityEngine;

namespace RH_Modules.UI.Core
{
    public abstract class BindingElement<T> : MonoBehaviour, IBindingElement
    {
        public abstract string Id { get; }
        
        private IBinding _target;
        
        public void Setup(IBinding target)
        {
            _target = target;
            _target.Updated += SetValue;
            
            SetValue();
        }

        private void SetValue()
        {
            if (_target is not Binding<T> genericTarget)
                throw new($"Type of binding with id {Id} doesn't match with binding element type");
            
            SetValue(genericTarget.Value);
        }

        protected abstract void SetValue(T value);
    }
}