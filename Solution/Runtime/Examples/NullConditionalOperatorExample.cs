using System.ComponentModel;
using UnityEngine;

namespace Runtime.Examples
{
    public sealed class ExampleObject : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class NullConditionalOperatorExample : MonoBehaviour
    {
        private readonly ExampleObject _exampleObject = new ExampleObject();

        public void Awake()
        {
            _exampleObject.Name = "Before";
            _exampleObject.PropertyChanged += ExampleObjectOnPropertyChanged;
            _exampleObject.Name = "After";
        }

        private void ExampleObjectOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            Debug.Log($"Property Changed To : { _exampleObject.Name }");
        }
    }
}