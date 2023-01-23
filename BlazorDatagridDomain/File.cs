namespace BlazorDatagridDomain
{
    public class File
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }
        public File(string name, string type, double size)
        {
            this.Name = name;
            this.Type = type;
            this.Size = size;
        }
    }
}
