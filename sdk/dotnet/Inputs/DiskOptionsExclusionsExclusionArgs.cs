// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class DiskOptionsExclusionsExclusionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// **File system type field:** the type of the file system to be excluded from monitoring. Examples:
        /// 
        /// * ext4
        /// * ext3
        /// * btrfs
        /// * ext*
        /// 
        /// ⚠️ Starting from **OneAgent 1.299+** file system types are not case sensitive! 
        /// 
        /// The wildcard in the last example means to exclude matching file systems such as types ext4 and ext3
        /// </summary>
        [Input("filesystem")]
        public Input<string>? Filesystem { get; set; }

        /// <summary>
        /// **Disk or mount point path field:** the path to where the disk to be excluded from monitoring is mounted. Examples:
        /// 
        /// * /mnt/my_disk
        /// * /staff/emp1
        /// * C:\
        /// * /staff/*
        /// * /disk*
        /// 
        ///  ⚠️ Mount point paths are case sensitive! 
        /// 
        /// The wildcard in **/staff/*** means to exclude every child folder of /staff.
        /// 
        /// The wildcard in **/disk*** means to exclude every mount point starting with /disk, for example /disk1, /disk99,  /diskabc
        /// </summary>
        [Input("mountpoint")]
        public Input<string>? Mountpoint { get; set; }

        /// <summary>
        /// Possible Values: `OS_TYPE_AIX`, `OS_TYPE_DARWIN`, `OS_TYPE_HPUX`, `OS_TYPE_LINUX`, `OS_TYPE_SOLARIS`, `OS_TYPE_UNKNOWN`, `OS_TYPE_WINDOWS`, `OS_TYPE_ZOS`
        /// </summary>
        [Input("os", required: true)]
        public Input<string> Os { get; set; } = null!;

        public DiskOptionsExclusionsExclusionArgs()
        {
        }
        public static new DiskOptionsExclusionsExclusionArgs Empty => new DiskOptionsExclusionsExclusionArgs();
    }
}
