// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Sql.Fluent.Models;
    using System.Collections.Generic;
    using System;

    internal partial class SqlSyncFullSchemaPropertyImpl 
    {
        /// <summary>
        /// Gets the list of tables in the database full schema.
        /// </summary>
        System.Collections.Generic.IReadOnlyList<Models.SyncFullSchemaTable> Microsoft.Azure.Management.Sql.Fluent.ISqlSyncFullSchemaProperty.Tables
        {
            get
            {
                return this.Tables() as System.Collections.Generic.IReadOnlyList<Models.SyncFullSchemaTable>;
            }
        }

        /// <summary>
        /// Gets last update time of the database schema.
        /// </summary>
        System.DateTime? Microsoft.Azure.Management.Sql.Fluent.ISqlSyncFullSchemaProperty.LastUpdateTime
        {
            get
            {
                return this.LastUpdateTime();
            }
        }
    }
}