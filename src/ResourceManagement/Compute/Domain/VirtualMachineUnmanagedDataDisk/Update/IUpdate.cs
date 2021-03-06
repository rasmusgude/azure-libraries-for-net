// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update
{
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.Update;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions;

    /// <summary>
    /// The stage of the virtual machine data disk update allowing to set the disk caching type.
    /// </summary>
    public interface IWithDiskCaching
    {
        /// <summary>
        /// Specifies the new caching type for the data disk.
        /// </summary>
        /// <param name="cachingType">The disk caching type. Possible values include: 'None', 'ReadOnly', 'ReadWrite'.</param>
        /// <return>The next stage of data disk update.</return>
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update.IUpdate WithCaching(CachingTypes cachingType);
    }

    /// <summary>
    /// The stage of the virtual machine data disk update allowing to set the disk size.
    /// </summary>
    public interface IWithDiskSize
    {
        /// <summary>
        /// Specifies the new size in GB for data disk.
        /// </summary>
        /// <param name="sizeInGB">The disk size in GB.</param>
        /// <return>The next stage of data disk update.</return>
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update.IUpdate WithSizeInGB(int sizeInGB);
    }

    /// <summary>
    /// The entirety of a data disk update as part of a virtual machine update.
    /// </summary>
    public interface IUpdate :
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update.IWithDiskSize,
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update.IWithDiskLun,
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update.IWithDiskCaching,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResourceActions.ISettable<Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.Update.IUpdate>
    {
    }

    /// <summary>
    /// The stage of the virtual machine data disk update allowing to set the disk LUN.
    /// </summary>
    public interface IWithDiskLun
    {
        /// <summary>
        /// Specifies the new logical unit number for the data disk.
        /// </summary>
        /// <param name="lun">The logical unit number.</param>
        /// <return>The next stage of data disk update.</return>
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineUnmanagedDataDisk.Update.IUpdate WithLun(int lun);
    }
}