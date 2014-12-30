﻿namespace uLocate.WebApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Http;

    using uLocate.Data;
    using uLocate.Models;
    using uLocate.Persistance;

    using Umbraco.Core;
    using Umbraco.Web.WebApi;

    /// <summary>
    /// The location type api controller for use by the umbraco back-office
    /// </summary>
    [Umbraco.Web.Mvc.PluginController("uLocate")]
    public class LocationTypeApiController : UmbracoAuthorizedApiController
    {
        ///// /umbraco/backoffice/uLocate/LocationTypeApi/Test
        //[System.Web.Http.AcceptVerbs("GET")]
        //public bool Test()
        //{
        //    return true;
        //}

        /// <summary>
        /// Create a new Location Type
        /// /umbraco/backoffice/uLocate/LocationTypeApi/Create?LocationTypeName="xxx"
        /// </summary>
        /// <param name="LocationTypeName">
        /// The location type name.
        /// </param>
        /// <returns>
        /// The <see cref="Guid"/> of the newly created LocationType
        /// </returns>
        [System.Web.Http.AcceptVerbs("GET")]
        public Guid Create(string LocationTypeName)
        {
            LocationType newLocType = new LocationType();
            newLocType.Name = LocationTypeName;
            Repositories.LocationTypeRepo.Insert(newLocType);

            //var Result = Repositories.LocationTypeRepo.GetByKey(newLocType.Key);
            var Result = newLocType.Key;
            
            return Result;
        }

        /// <summary>
        /// Update a location type
        /// /umbraco/backoffice/uLocate/LocationTypeApi/Update
        /// </summary>
        /// <param name="UpdatedLocationType">
        /// The updated location type object
        /// </param>
        /// <returns>
        /// The <see cref="LocationType"/>.
        /// </returns>
        [System.Web.Http.AcceptVerbs("GET")]
        public LocationType Update(LocationType UpdatedLocationType)
        {
            Repositories.LocationTypeRepo.Update(UpdatedLocationType);

            var Result = Repositories.LocationTypeRepo.GetByKey(UpdatedLocationType.Key);

            return Result;
        }

        /// <summary>
        /// Get a location type by its Key
        /// /umbraco/backoffice/uLocate/LocationTypeApi/GetByKey
        /// </summary>
        /// <param name="Key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="LocationType"/>.
        /// </returns>
        [System.Web.Http.AcceptVerbs("GET")]
        public LocationType GetByKey(Guid Key)
        {
            var Result = Repositories.LocationTypeRepo.GetByKey(Key);

            return Result;
        }

        /// <summary>
        /// Delete a location type
        /// /umbraco/backoffice/uLocate/LocationTypeApi/Delete
        /// </summary>
        /// <param name="Key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="StatusMessage"/>.
        /// </returns>
        [System.Web.Http.AcceptVerbs("GET")]
        public StatusMessage Delete(Guid Key)
        {
            var Result = Repositories.LocationTypeRepo.Delete(Key, true);

            return Result;
        }


    }
}

