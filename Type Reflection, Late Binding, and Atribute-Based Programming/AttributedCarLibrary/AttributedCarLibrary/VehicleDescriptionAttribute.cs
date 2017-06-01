using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace AttributedCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method, Inherited =false)]
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute(string vehicleDescription) {
            Description = vehicleDescription;
        } 
        public VehicleDescriptionAttribute() { }
    }

    [Serializable, VehicleDescription(Description = "My Rocking Harley")]
    public class Motorcycle {

    }

    [Serializable, VehicleDescription("Tehe old gray mare, she ain't what she used to be..."), Obsolete("Use another vehicle!")]
    public class HorseAndBuggy { }

    [VehicleDescription("A very long, slow, but feature-rich auto")]
    public class Winnebago {
        public ulong notCompliant;
        [VehicleDescription("My Rocking CD player")]
        public void PlayMusic(bool on) {
             
        }
    }
}
