using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Entity
{
    public class Orders:IEntity
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int OrderAmount { get; set; }
        public DateTime OderderTime { get; set; }
    }
}
