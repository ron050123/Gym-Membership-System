using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem
{
    public class GenericCollection<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public List<T> GetAllItems()
        {
            return items;
        }
    }

}
