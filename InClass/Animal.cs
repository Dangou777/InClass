using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    public class Animal
    {
        public double? Weight { get; set; }
        public double? Hieght { get; set; }
        public string? Name { get; set; }
        public virtual string sayhello()
        {
            return $"hello i am {Name} i weight {Weight} and mt height is {Hieght}";
        }
    }
    public class Dog : Animal
    {
        public override string sayhello()
        {
            return $"woof i am a dog named {Name}";

        }
    }
    public class cat : Animal
    {
        public override string sayhello()
        {
            return $"meau i am a cat named {Name}";

        }
    }
    public class lion : Animal
    {
        public override string sayhello()
        {
            return $"whaaaa i am a lion named {Name}";

        }
    }
    public class benia : Animal
    {
        public override string sayhello()
        {
            return $"im gay benia named {Name}";
        }
    }

}
