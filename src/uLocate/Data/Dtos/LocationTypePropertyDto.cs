﻿namespace uLocate.Data
{
    using System;

    using uLocate.Models;

    using Umbraco.Core.Persistence;
    using Umbraco.Core.Persistence.DatabaseAnnotations;

    /// <summary>
    /// Dto representing the "uLocate_LocationTypeProperty" table - used for creating/deleting the table
    /// </summary>
    [TableName("uLocate_LocationTypeProperty")]
    [PrimaryKey("Id")]
    [ExplicitColumns] 
    internal class LocationTypePropertyDto
    {
        /// <summary>
        /// Gets or sets the Primary Key ID for the property
        /// </summary>
        [Column("Id")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Alias for the property
        /// </summary>
        [Column("Alias")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or sets the Display Name for the property
        /// </summary>
        [Column("Name")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the related DataType (from the umbraco DataTypes) for the property
        /// </summary>
        [Column("DataTypeId")]
        [ForeignKey(typeof(cmsDataTypeDto), Name = "FK_uLocateLocationTypeProperty_cmsDataType", Column = "nodeId")]
        public int DataTypeId { get; set; }

        /// <summary>
        /// Gets or sets the related Location Type for the property
        /// </summary>
        [Column("LocationTypeId")]
        [ForeignKey(typeof(LocationType), Name = "FK_uLocateLocationTypeProperty_uLocateLocationType", Column = "Id")]
        public int LocationTypeId { get; set; }

        /// <summary>
        /// Gets or sets the sort order for the property
        /// </summary>
        [Column("sortOrder")]
        public int SortOrder { get; set; } 

                /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        [Column("CreateDate")]
        [Constraint(Default = "getdate()")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        [Column("UpdateDate")]
        [Constraint(Default = "getdate()")]
        public DateTime UpdateDate { get; set; }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="LocationTypePropertyDto"/> class and sets some default values.
        ///// </summary>
        //public LocationTypePropertyDto()
        //{
        //    UpdateDate = DateTime.Now;
        //    CreateDate = DateTime.Now;
        //}
    }
}
