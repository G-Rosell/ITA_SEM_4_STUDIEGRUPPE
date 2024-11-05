// <auto-generated />
#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603
using System.Text.Json.Serialization;

namespace Model.User
{
    public class User
    {
        /// <summary>
        /// Unique identifier for the user (MongoDB ObjectId)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// First name of the user
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Last name of the user
        /// </summary>
        [JsonPropertyName("familyName")]
        public string FamilyName { get; set; }

        /// <summary>
        /// User's password (with minimum length validation)
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// User's email address
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
