namespace ARM.Core.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _title = "ARM Solution";
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
    }
}
