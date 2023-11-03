using RH_Modules.UI.Core;
using UnityEngine;

namespace RH_Modules.UI.Sample
{
    public class TestController : MonoBehaviour
    {
        [SerializeField] private View _view;

        private void Start()
        {
            IModel model = new ModelBuilder()
                .With("Name", "Michael")
                .With("Health", "50%")
                .With("Armor", "51%")
                .Build();
            
            _view.Setup(model);
        }
    }
}
