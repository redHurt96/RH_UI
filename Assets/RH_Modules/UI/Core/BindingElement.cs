using System;
using UnityEngine;

namespace RH_Modules.UI.Core
{
    public abstract class BindingElement<T> : MonoBehaviour, IBindingElement
    {
        public abstract string Id { get; }
        
        public void Setup(IBinding target)
        {
            Binding<T> genericTarget = target as Binding<T>;

            if (genericTarget == null)
                throw new Exception($"Type of binding with id {Id} doesn't match with binding element type");
            
            SetValue(genericTarget.Value);
        }

        protected abstract void SetValue(T value);
    }
}