using System.ComponentModel.DataAnnotations;

namespace DataAccess.Interfaces
{
    public interface IHasKey<TK> where TK : struct
    {
        [Key]
        public TK ID { get; set; }
    }

}
