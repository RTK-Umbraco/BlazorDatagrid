using System.ComponentModel;

namespace BlazorDatagridDomain
{
    public class File : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public string Type { get; set; }
        public double Size { get; set; }
        public string Image { get; set; }
        public File(string name, string type, double size, string image)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Type = type;
            this.Size = size;
            this.Image = image;
        }
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
