using System;
using System.Collections.Generic;
using System.Linq;
using RH_Modules.UI.Core;
using UnityEngine;

namespace RH_Modules.UI
{
    public class View : MonoBehaviour, IView
    {
        private IEnumerable<IBindingElement> _bingingElements;
        
        public void Setup(IModel model)
        {
            _bingingElements ??= GetComponents<IBindingElement>()
                .Concat(GetComponentsInChildren<IBindingElement>());
            
            foreach (IBinding binding in model.Bindings)
            {
                IBindingElement target = _bingingElements.FirstOrDefault(x => x.Id == binding.Id);

                if (target == null)
                    throw new Exception($"There is no binding element with id {binding.Id} in view");
                
                target.Setup(binding);
            }
        }
    }
}