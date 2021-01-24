using System;
using Secao_9.Entities.Enums;
namespace Secao_9.Entities
{
    class Department
    {
        public string Name { get; set; }
        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
