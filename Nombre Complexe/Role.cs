using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_Complexe
{
    class Role
    {
        private int v1;
        private string v2;

        public Role(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public static implicit operator int(Role role)
        {
            return role.Id;
        }
        public static implicit operator string(Role role)
        {
            return role.Title;
        }
        public static implicit operator Role(int id)
        {
            return new Role(id,"");
        }
    }
}
