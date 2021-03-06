//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;
using PayPal.Util;

namespace PayPal.Api
{
    /// <summary>
    /// Payment web experience profile.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class WebProfile : PayPalResource
    {
        /// <summary>
        /// The ID of the web experience profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// The web experience profile name. Unique for a specified merchant's profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name")]
        public string name { get; set; }

        /// <summary>
        /// Indicates whether the profile persists for three hours or permanently. Set to `false` to persist the profile permanently. Set to `true` to persist the profile for three hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "temporary")]
        public bool? temporary { get; set; }

        /// <summary>
        /// Parameters for flow configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flow_config")]
        public FlowConfig flow_config { get; set; }

        /// <summary>
        /// Parameters for input fields customization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "input_fields")]
        public InputFields input_fields { get; set; }

        /// <summary>
        /// Parameters for style and presentation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "presentation")]
        public Presentation presentation { get; set; }

        /// <summary>
        /// Creates a web experience profile. Pass the profile name and details in the JSON request body.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>CreateProfileResponse</returns>
        public CreateProfileResponse Create(APIContext apiContext)
        {
            return WebProfile.Create(apiContext, this);
        }

        /// <summary>
        /// Create a web experience profile by passing the name of the profile and other profile details in the request JSON to the request URI.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="webProfile">WebProfile object to be created as a PayPal resource.</param>
        /// <returns>CreateProfileResponse</returns>
        public static CreateProfileResponse Create(APIContext apiContext, WebProfile webProfile)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);

            // Configure and send the request
            var resourcePath = "v1/payment-experience/web-profiles";
            return PayPalResource.ConfigureAndExecute<CreateProfileResponse>(apiContext, HttpMethod.POST, resourcePath, webProfile.ConvertToJson());
        }

        /// <summary>
        /// Updates a web experience profile. Pass the ID of the profile to the request URI and pass the profile details in the JSON request body. If your request omits any profile detail fields, the operation removes the previously set values for those fields.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        public void Update(APIContext apiContext)
        {
            WebProfile.Update(apiContext, this);
        }

        /// <summary>
        /// Update a web experience profile by passing the ID of the profile to the request URI. In addition, pass the profile details in the request JSON. If your request does not include values for all profile detail fields, the previously set values for the omitted fields are removed by this operation.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="profile">WebProfile resource to update.</param>
        public static void Update(APIContext apiContext, WebProfile profile)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(profile, "profile");

            // Configure and send the request
            var pattern = "v1/payment-experience/web-profiles/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { profile.id });
            PayPalResource.ConfigureAndExecute(apiContext, HttpMethod.PUT, resourcePath, profile.ConvertToJson());
        }

        /// <summary>
        /// Partially-updates a web experience profile. Pass the profile ID to the request URI. Pass a patch object with the operation, path of the profile location to update, and, if needed, a new value to complete the operation in the JSON request body.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="patchRequest">PatchRequest</param>
        public void PartialUpdate(APIContext apiContext, PatchRequest patchRequest)
        {
            WebProfile.PartialUpdate(apiContext, this.id, patchRequest);
        }

        /// <summary>
        /// Partially update an existing web experience profile by passing the ID of the profile to the request URI. In addition, pass a patch object in the request JSON that specifies the operation to perform, path of the profile location to update, and a new value if needed to complete the operation.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="profileId">ID fo the web profile to partially update.</param>
        /// <param name="patchRequest">PatchRequest</param>
        public static void PartialUpdate(APIContext apiContext, string profileId, PatchRequest patchRequest)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(profileId, "profileId");
            ArgumentValidator.Validate(patchRequest, "patchRequest");

            // Configure and send the request
            var pattern = "v1/payment-experience/web-profiles/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { profileId });
            PayPalResource.ConfigureAndExecute(apiContext, HttpMethod.PATCH, resourcePath, patchRequest.ConvertToJson());
        }

        /// <summary>
        /// Shows details for a web experience profile, by ID.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="profileId">The ID of the profile for which to show details.</param>
        /// <returns>WebProfile</returns>
        public static WebProfile Get(APIContext apiContext, string profileId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(profileId, "profileId");

            // Configure and send the request
            var pattern = "v1/payment-experience/web-profiles/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { profileId });
            return PayPalResource.ConfigureAndExecute<WebProfile>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Lists all web experience profiles for a merchant or subject.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <returns>WebProfileList</returns>
        public static WebProfileList GetList(APIContext apiContext)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);

            // Configure and send the request
            var resourcePath = "v1/payment-experience/web-profiles";
            return PayPalResource.ConfigureAndExecute<WebProfileList>(apiContext, HttpMethod.GET, resourcePath);
        }

        /// <summary>
        /// Deletes a web experience profile, by ID.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        public void Delete(APIContext apiContext)
        {
            WebProfile.Delete(apiContext, this.id);
        }

        /// <summary>
        /// Deletes a web experience profile, by ID.
        /// </summary>
        /// <param name="apiContext">APIContext used for the API call.</param>
        /// <param name="profileId">The ID of the profile to delete.</param>
        public static void Delete(APIContext apiContext, string profileId)
        {
            // Validate the arguments to be used in the request
            ArgumentValidator.ValidateAndSetupAPIContext(apiContext);
            ArgumentValidator.Validate(profileId, "profileId");

            // Configure and send the request
            apiContext.MaskRequestId = true;
            var pattern = "v1/payment-experience/web-profiles/{0}";
            var resourcePath = SDKUtil.FormatURIPath(pattern, new object[] { profileId });
            PayPalResource.ConfigureAndExecute(apiContext, HttpMethod.DELETE, resourcePath);
        }
    }
}
