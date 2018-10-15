using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LoyaltyIntegration.Models.LoyaltyRewards
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Rewards : List<Reward>
    {
        ///// <summary>
        ///// Get the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()  {
        //  var sb = new StringBuilder();
        //  sb.Append("class Rewards {\n");
        //  sb.Append("}\n");
        //  return sb.ToString();
        //}

        ///// <summary>
        ///// Get the JSON string presentation of the object
        ///// </summary>
        ///// <returns>JSON string presentation of the object</returns>
        //public  new string ToJson() {
        //  return JsonConvert.SerializeObject(this, Formatting.Indented);
        //}
    }
}