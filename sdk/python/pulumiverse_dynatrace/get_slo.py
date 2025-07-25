# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities

__all__ = [
    'GetSloResult',
    'AwaitableGetSloResult',
    'get_slo',
    'get_slo_output',
]

@pulumi.output_type
class GetSloResult:
    """
    A collection of values returned by getSlo.
    """
    def __init__(__self__, burn_rate_visualization_enabled=None, description=None, enabled=None, evaluation_type=None, evaluation_window=None, fast_burn_threshold=None, filter=None, id=None, legacy_id=None, metric_expression=None, metric_name=None, name=None, target_success=None, target_warning=None):
        if burn_rate_visualization_enabled and not isinstance(burn_rate_visualization_enabled, bool):
            raise TypeError("Expected argument 'burn_rate_visualization_enabled' to be a bool")
        pulumi.set(__self__, "burn_rate_visualization_enabled", burn_rate_visualization_enabled)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if enabled and not isinstance(enabled, bool):
            raise TypeError("Expected argument 'enabled' to be a bool")
        pulumi.set(__self__, "enabled", enabled)
        if evaluation_type and not isinstance(evaluation_type, str):
            raise TypeError("Expected argument 'evaluation_type' to be a str")
        pulumi.set(__self__, "evaluation_type", evaluation_type)
        if evaluation_window and not isinstance(evaluation_window, str):
            raise TypeError("Expected argument 'evaluation_window' to be a str")
        pulumi.set(__self__, "evaluation_window", evaluation_window)
        if fast_burn_threshold and not isinstance(fast_burn_threshold, float):
            raise TypeError("Expected argument 'fast_burn_threshold' to be a float")
        pulumi.set(__self__, "fast_burn_threshold", fast_burn_threshold)
        if filter and not isinstance(filter, str):
            raise TypeError("Expected argument 'filter' to be a str")
        pulumi.set(__self__, "filter", filter)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if legacy_id and not isinstance(legacy_id, str):
            raise TypeError("Expected argument 'legacy_id' to be a str")
        pulumi.set(__self__, "legacy_id", legacy_id)
        if metric_expression and not isinstance(metric_expression, str):
            raise TypeError("Expected argument 'metric_expression' to be a str")
        pulumi.set(__self__, "metric_expression", metric_expression)
        if metric_name and not isinstance(metric_name, str):
            raise TypeError("Expected argument 'metric_name' to be a str")
        pulumi.set(__self__, "metric_name", metric_name)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if target_success and not isinstance(target_success, float):
            raise TypeError("Expected argument 'target_success' to be a float")
        pulumi.set(__self__, "target_success", target_success)
        if target_warning and not isinstance(target_warning, float):
            raise TypeError("Expected argument 'target_warning' to be a float")
        pulumi.set(__self__, "target_warning", target_warning)

    @property
    @pulumi.getter(name="burnRateVisualizationEnabled")
    def burn_rate_visualization_enabled(self) -> builtins.bool:
        """
        Burn rate visualization is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "burn_rate_visualization_enabled")

    @property
    @pulumi.getter
    def description(self) -> builtins.str:
        """
        The custom description of the SLO
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> builtins.bool:
        """
        The SLO is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="evaluationType")
    def evaluation_type(self) -> builtins.str:
        """
        The evaluation type of the SLO. Currently only `AGGREGATE` is supported
        """
        return pulumi.get(self, "evaluation_type")

    @property
    @pulumi.getter(name="evaluationWindow")
    def evaluation_window(self) -> builtins.str:
        """
        The timeframe during which the SLO is to be evaluated. For the timeframe you can enter expressions like -1h (last hour), -1w (last week) or complex expressions like -2d to now (last two days), -1d/d to now/d (beginning of yesterday to beginning of today).
        """
        return pulumi.get(self, "evaluation_window")

    @property
    @pulumi.getter(name="fastBurnThreshold")
    def fast_burn_threshold(self) -> builtins.float:
        """
        The threshold defines when a burn rate is marked as fast-burning (high-emergency). Burn rates lower than this threshold (and greater than 1) are highlighted as slow-burn (low-emergency)
        """
        return pulumi.get(self, "fast_burn_threshold")

    @property
    @pulumi.getter
    def filter(self) -> builtins.str:
        """
        The entity filter for the SLO evaluation. See [syntax of entity selector](https://dt-url.net/entityselector) for details
        """
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="legacyId")
    def legacy_id(self) -> builtins.str:
        """
        The ID of this setting when referred to by the Config REST API V1
        """
        return pulumi.get(self, "legacy_id")

    @property
    @pulumi.getter(name="metricExpression")
    def metric_expression(self) -> builtins.str:
        """
        The percentage-based metric expression for the calculation of the SLO
        """
        return pulumi.get(self, "metric_expression")

    @property
    @pulumi.getter(name="metricName")
    def metric_name(self) -> builtins.str:
        """
        No documentation available
        """
        return pulumi.get(self, "metric_name")

    @property
    @pulumi.getter
    def name(self) -> builtins.str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="targetSuccess")
    def target_success(self) -> builtins.float:
        """
        The target value of the SLO
        """
        return pulumi.get(self, "target_success")

    @property
    @pulumi.getter(name="targetWarning")
    def target_warning(self) -> builtins.float:
        """
        The warning value of the SLO. At warning state the SLO is still fulfilled but is getting close to failure
        """
        return pulumi.get(self, "target_warning")


class AwaitableGetSloResult(GetSloResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSloResult(
            burn_rate_visualization_enabled=self.burn_rate_visualization_enabled,
            description=self.description,
            enabled=self.enabled,
            evaluation_type=self.evaluation_type,
            evaluation_window=self.evaluation_window,
            fast_burn_threshold=self.fast_burn_threshold,
            filter=self.filter,
            id=self.id,
            legacy_id=self.legacy_id,
            metric_expression=self.metric_expression,
            metric_name=self.metric_name,
            name=self.name,
            target_success=self.target_success,
            target_warning=self.target_warning)


def get_slo(name: Optional[builtins.str] = None,
            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSloResult:
    """
    The `Slo` data source allows the SLO ID to be retrieved by its name.

    - `name` (String) - The name of the SLO

    If multiple services match the given criteria, the first result will be retrieved.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    example = dynatrace.get_slo(name="Terraform")
    pulumi.export("id", example.id)
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getSlo:getSlo', __args__, opts=opts, typ=GetSloResult).value

    return AwaitableGetSloResult(
        burn_rate_visualization_enabled=pulumi.get(__ret__, 'burn_rate_visualization_enabled'),
        description=pulumi.get(__ret__, 'description'),
        enabled=pulumi.get(__ret__, 'enabled'),
        evaluation_type=pulumi.get(__ret__, 'evaluation_type'),
        evaluation_window=pulumi.get(__ret__, 'evaluation_window'),
        fast_burn_threshold=pulumi.get(__ret__, 'fast_burn_threshold'),
        filter=pulumi.get(__ret__, 'filter'),
        id=pulumi.get(__ret__, 'id'),
        legacy_id=pulumi.get(__ret__, 'legacy_id'),
        metric_expression=pulumi.get(__ret__, 'metric_expression'),
        metric_name=pulumi.get(__ret__, 'metric_name'),
        name=pulumi.get(__ret__, 'name'),
        target_success=pulumi.get(__ret__, 'target_success'),
        target_warning=pulumi.get(__ret__, 'target_warning'))
def get_slo_output(name: Optional[pulumi.Input[builtins.str]] = None,
                   opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetSloResult]:
    """
    The `Slo` data source allows the SLO ID to be retrieved by its name.

    - `name` (String) - The name of the SLO

    If multiple services match the given criteria, the first result will be retrieved.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    example = dynatrace.get_slo(name="Terraform")
    pulumi.export("id", example.id)
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getSlo:getSlo', __args__, opts=opts, typ=GetSloResult)
    return __ret__.apply(lambda __response__: GetSloResult(
        burn_rate_visualization_enabled=pulumi.get(__response__, 'burn_rate_visualization_enabled'),
        description=pulumi.get(__response__, 'description'),
        enabled=pulumi.get(__response__, 'enabled'),
        evaluation_type=pulumi.get(__response__, 'evaluation_type'),
        evaluation_window=pulumi.get(__response__, 'evaluation_window'),
        fast_burn_threshold=pulumi.get(__response__, 'fast_burn_threshold'),
        filter=pulumi.get(__response__, 'filter'),
        id=pulumi.get(__response__, 'id'),
        legacy_id=pulumi.get(__response__, 'legacy_id'),
        metric_expression=pulumi.get(__response__, 'metric_expression'),
        metric_name=pulumi.get(__response__, 'metric_name'),
        name=pulumi.get(__response__, 'name'),
        target_success=pulumi.get(__response__, 'target_success'),
        target_warning=pulumi.get(__response__, 'target_warning')))
