using System.ComponentModel;

namespace DataAccess.Interfaces
{
    public interface IActivEntity
    {
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }

}
