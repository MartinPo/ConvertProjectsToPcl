namespace MLabs.ConvertToPcl.DataContracts
{
    public class PortableFramework
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Description);
        }
    }
}