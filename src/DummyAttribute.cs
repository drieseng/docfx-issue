using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DocFxCustomAttributeProblem
{
    [DataContract(Namespace = "http://www.infrabel.be/A572/Infrastructure")]
    public class DummyAttribute
    {
        /// <summary>
        /// Gets or sets  the user defined identifier.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Attribute { get; set; }

    }
}
