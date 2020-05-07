using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerce.NET.WooCommerce.v3
{
    [DataContract]
    public class Brand : JsonObject
    {
        public static string Endpoint { get { return "brands"; } }

        /// <summary>
        /// term ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// term ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? term_id { get; set; }

        /// <summary>
        /// Brand name. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// Category slug. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string slug { get; set; }

    }
}