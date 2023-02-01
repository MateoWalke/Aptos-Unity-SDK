using Newtonsoft.Json;

namespace Aptos.Unity.Rest.Model
{
    /// <summary>
    /// Represents Gas Estimate response
    /// </summary>
    [JsonObject]
    public class GasEstimation
    {
        [JsonConstructor]
        private GasEstimation() { }

        [JsonProperty("deprioritized_gas_estimate", Required = Required.Always)]
        public int DeprioritizedGasEstimate { get; private set; }

        [JsonProperty("gas_estimate", Required = Required.Always)]
        public int GasEstimate { get; private set; }

        [JsonProperty("prioritized_gas_estimate", Required = Required.Default)]
        public int PrioritizedGasEstimate { get; private set; }
    }
}