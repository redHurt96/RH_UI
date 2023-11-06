using RH_Modules.UI.Core;
using UnityEngine;

namespace RH_Modules.UI.Sample
{
    public class TestController : MonoBehaviour
    {
        [SerializeField] private View _view;
        
        private IModel _model;

        private void Start()
        {
            _model = new ModelBuilder()
                .With("Name", "Michael")
                .With("Health", "50%")
                .With("Armor", "51%")
                .With("Time", $"{(int)Time.time}")
                .Build();
            
            _view.Setup(_model);
        }

        private void Update() => 
            _model.Change("Time", $"{(int)Time.time}");
    }
}
