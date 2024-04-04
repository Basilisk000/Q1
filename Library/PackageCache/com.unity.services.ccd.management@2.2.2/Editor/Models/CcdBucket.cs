//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Ccd.Management.Http;



namespace Unity.Services.Ccd.Management.Models
{
    /// <summary>
    /// CcdBucket model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.bucket")]
    public class CcdBucket
    {
        /// <summary>
        /// Creates an instance of CcdBucket.
        /// </summary>
        /// <param name="attributes">attributes param</param>
        /// <param name="changes">changes param</param>
        /// <param name="created">created param</param>
        /// <param name="description">description param</param>
        /// <param name="environmentId">environmentId param</param>
        /// <param name="environmentName">environmentName param</param>
        /// <param name="id">id param</param>
        /// <param name="lastRelease">lastRelease param</param>
        /// <param name="name">name param</param>
        /// <param name="permissions">permissions param</param>
        /// <param name="@private">@private param</param>
        /// <param name="projectguid">projectguid param</param>
        [Preserve]
        public CcdBucket(CcdBucketAttributes attributes = default, CcdReleaseChangeVersion changes = default, DateTime created = default, string description = default, System.Guid environmentId = default, string environmentName = default, System.Guid id = default, CcdRelease lastRelease = default, string name = default, CcdBucketPermissions permissions = default, bool @private = default, System.Guid projectguid = default)
        {
            Attributes = attributes;
            Changes = changes;
            Created = created;
            Description = description;
            EnvironmentId = environmentId;
            EnvironmentName = environmentName;
            Id = id;
            LastRelease = lastRelease;
            Name = name;
            Permissions = permissions;
            Private = @private;
            Projectguid = projectguid;
        }

        /// <summary>
        /// Parameter attributes of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public CcdBucketAttributes Attributes{ get; }
        
        /// <summary>
        /// Parameter changes of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "changes", EmitDefaultValue = false)]
        public CcdReleaseChangeVersion Changes{ get; }
        
        /// <summary>
        /// Parameter created of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created{ get; }
        
        /// <summary>
        /// Parameter description of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description{ get; }
        
        /// <summary>
        /// Parameter environment_id of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "environment_id", EmitDefaultValue = false)]
        public System.Guid EnvironmentId{ get; }
        
        /// <summary>
        /// Parameter environment_name of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "environment_name", EmitDefaultValue = false)]
        public string EnvironmentName{ get; }
        
        /// <summary>
        /// Parameter id of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public System.Guid Id{ get; }
        
        /// <summary>
        /// Parameter last_release of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "last_release", EmitDefaultValue = false)]
        public CcdRelease LastRelease{ get; }
        
        /// <summary>
        /// Parameter name of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name{ get; }
        
        /// <summary>
        /// Parameter permissions of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public CcdBucketPermissions Permissions{ get; }
        
        /// <summary>
        /// Parameter private of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private{ get; }
        
        /// <summary>
        /// Parameter projectguid of CcdBucket
        /// </summary>
        [Preserve]
        [DataMember(Name = "projectguid", EmitDefaultValue = false)]
        public System.Guid Projectguid{ get; }
    
        /// <summary>
        /// Formats a CcdBucket into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Attributes != null)
            {
                serializedModel += "attributes," + Attributes.ToString() + ",";
            }
            if (Changes != null)
            {
                serializedModel += "changes," + Changes.ToString() + ",";
            }
            if (Created != null)
            {
                serializedModel += "created," + Created.ToString() + ",";
            }
            if (Description != null)
            {
                serializedModel += "description," + Description + ",";
            }
            if (EnvironmentId != null)
            {
                serializedModel += "environment_id," + EnvironmentId + ",";
            }
            if (EnvironmentName != null)
            {
                serializedModel += "environment_name," + EnvironmentName + ",";
            }
            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (LastRelease != null)
            {
                serializedModel += "last_release," + LastRelease.ToString() + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (Permissions != null)
            {
                serializedModel += "permissions," + Permissions.ToString() + ",";
            }
            serializedModel += "private," + Private.ToString() + ",";
            if (Projectguid != null)
            {
                serializedModel += "projectguid," + Projectguid;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdBucket as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Created != null)
            {
                var createdStringValue = Created.ToString();
                dictionary.Add("created", createdStringValue);
            }
            
            if (Description != null)
            {
                var descriptionStringValue = Description.ToString();
                dictionary.Add("description", descriptionStringValue);
            }
            
            if (EnvironmentId != null)
            {
                var environment_idStringValue = EnvironmentId.ToString();
                dictionary.Add("environment_id", environment_idStringValue);
            }
            
            if (EnvironmentName != null)
            {
                var environment_nameStringValue = EnvironmentName.ToString();
                dictionary.Add("environment_name", environment_nameStringValue);
            }
            
            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }
            
            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            var privateStringValue = Private.ToString();
            dictionary.Add("private", privateStringValue);
            
            if (Projectguid != null)
            {
                var projectguidStringValue = Projectguid.ToString();
                dictionary.Add("projectguid", projectguidStringValue);
            }
            
            return dictionary;
        }
    }
}
