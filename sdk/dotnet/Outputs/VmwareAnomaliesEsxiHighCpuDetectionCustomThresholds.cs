// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class VmwareAnomaliesEsxiHighCpuDetectionCustomThresholds
    {
        /// <summary>
        /// At least one peak occurred when Hypervisor CPU usage was higher than
        /// </summary>
        public readonly int CpuPeakPercentage;
        /// <summary>
        /// CPU usage is higher than
        /// </summary>
        public readonly int CpuUsagePercentage;
        /// <summary>
        /// VM CPU ready is higher than
        /// </summary>
        public readonly int VmCpuReadyPercentage;

        [OutputConstructor]
        private VmwareAnomaliesEsxiHighCpuDetectionCustomThresholds(
            int cpuPeakPercentage,

            int cpuUsagePercentage,

            int vmCpuReadyPercentage)
        {
            CpuPeakPercentage = cpuPeakPercentage;
            CpuUsagePercentage = cpuUsagePercentage;
            VmCpuReadyPercentage = vmCpuReadyPercentage;
        }
    }
}