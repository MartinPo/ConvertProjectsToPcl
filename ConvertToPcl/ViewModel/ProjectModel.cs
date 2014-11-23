using System.ComponentModel;
using System.Runtime.CompilerServices;
using EnvDTE;
using MLabs.ConvertToPcl.Annotations;
using MLabs.ConvertToPcl.DataContracts;

namespace MLabs.ConvertToPcl.ViewModel
{
    public class ProjectModel:INotifyPropertyChanged
    {
        private bool isSelected;
        private string name;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public NetFramework NetFrameworkInUse { get; set; }

        public bool HasFramework
        {
            get { return NetFrameworkInUse != null; }
        }

        public Project DteProject { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}