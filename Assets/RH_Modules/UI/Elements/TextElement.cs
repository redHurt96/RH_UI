using RH_Modules.UI.Core;
using UnityEngine;
using UnityEngine.UI;

namespace RH_Modules.UI.Elements
{
    [RequireComponent(typeof(Text))]
    public class TextElement : BindingElement<string>
    {
        public override string Id => _id;
        
        [SerializeField] private string _id;
        
        private Text _label;

        private void Awake() => 
            _label = GetComponent<Text>();

        protected override void SetValue(string value) => 
            _label.text = value;
    }
}
