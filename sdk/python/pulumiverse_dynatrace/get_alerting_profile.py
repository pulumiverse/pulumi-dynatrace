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
    'GetAlertingProfileResult',
    'AwaitableGetAlertingProfileResult',
    'get_alerting_profile',
    'get_alerting_profile_output',
]

@pulumi.output_type
class GetAlertingProfileResult:
    """
    A collection of values returned by getAlertingProfile.
    """
    def __init__(__self__, id=None, legacy_id=None, name=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if legacy_id and not isinstance(legacy_id, str):
            raise TypeError("Expected argument 'legacy_id' to be a str")
        pulumi.set(__self__, "legacy_id", legacy_id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)

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
        return pulumi.get(self, "legacy_id")

    @property
    @pulumi.getter
    def name(self) -> builtins.str:
        return pulumi.get(self, "name")


class AwaitableGetAlertingProfileResult(GetAlertingProfileResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAlertingProfileResult(
            id=self.id,
            legacy_id=self.legacy_id,
            name=self.name)


def get_alerting_profile(name: Optional[builtins.str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAlertingProfileResult:
    """
    The Alerting Profile queries for an Alerting Profile that has a specified name. In case multiple Alerting Profiles share the same name the first one found will be used.
    The ID of this Data Resource aligns with the IDs used by the Dynatrace Settings 2.0 API.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace
    import pulumiverse_dynatrace as dynatrace

    default = dynatrace.get_alerting_profile(name="Default")
    my_webhook_notification = dynatrace.WebhookNotification("myWebhookNotification",
        active=False,
        profile=default.id,
        url="https://webhook.site/40bf4d43-1a50-4ebd-913d-bf50ce7c3a1e",
        insecure=True,
        notify_event_merges=True,
        notify_closed_problems=True,
        payload="web-hook-payload")
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getAlertingProfile:getAlertingProfile', __args__, opts=opts, typ=GetAlertingProfileResult).value

    return AwaitableGetAlertingProfileResult(
        id=pulumi.get(__ret__, 'id'),
        legacy_id=pulumi.get(__ret__, 'legacy_id'),
        name=pulumi.get(__ret__, 'name'))
def get_alerting_profile_output(name: Optional[pulumi.Input[builtins.str]] = None,
                                opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetAlertingProfileResult]:
    """
    The Alerting Profile queries for an Alerting Profile that has a specified name. In case multiple Alerting Profiles share the same name the first one found will be used.
    The ID of this Data Resource aligns with the IDs used by the Dynatrace Settings 2.0 API.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace
    import pulumiverse_dynatrace as dynatrace

    default = dynatrace.get_alerting_profile(name="Default")
    my_webhook_notification = dynatrace.WebhookNotification("myWebhookNotification",
        active=False,
        profile=default.id,
        url="https://webhook.site/40bf4d43-1a50-4ebd-913d-bf50ce7c3a1e",
        insecure=True,
        notify_event_merges=True,
        notify_closed_problems=True,
        payload="web-hook-payload")
    ```
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getAlertingProfile:getAlertingProfile', __args__, opts=opts, typ=GetAlertingProfileResult)
    return __ret__.apply(lambda __response__: GetAlertingProfileResult(
        id=pulumi.get(__response__, 'id'),
        legacy_id=pulumi.get(__response__, 'legacy_id'),
        name=pulumi.get(__response__, 'name')))
