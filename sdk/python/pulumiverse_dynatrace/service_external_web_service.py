# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ServiceExternalWebServiceArgs', 'ServiceExternalWebService']

@pulumi.input_type
class ServiceExternalWebServiceArgs:
    def __init__(__self__, *,
                 enabled: pulumi.Input[bool],
                 id_contributors: pulumi.Input['ServiceExternalWebServiceIdContributorsArgs'],
                 conditions: Optional[pulumi.Input['ServiceExternalWebServiceConditionsArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ServiceExternalWebService resource.
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input['ServiceExternalWebServiceIdContributorsArgs'] id_contributors: Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        :param pulumi.Input['ServiceExternalWebServiceConditionsArgs'] conditions: A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        :param pulumi.Input[str] description: Description
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        :param pulumi.Input[str] name: Rule name
        """
        pulumi.set(__self__, "enabled", enabled)
        pulumi.set(__self__, "id_contributors", id_contributors)
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if management_zones is not None:
            pulumi.set(__self__, "management_zones", management_zones)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Input[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: pulumi.Input[bool]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="idContributors")
    def id_contributors(self) -> pulumi.Input['ServiceExternalWebServiceIdContributorsArgs']:
        """
        Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        """
        return pulumi.get(self, "id_contributors")

    @id_contributors.setter
    def id_contributors(self, value: pulumi.Input['ServiceExternalWebServiceIdContributorsArgs']):
        pulumi.set(self, "id_contributors", value)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[pulumi.Input['ServiceExternalWebServiceConditionsArgs']]:
        """
        A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: Optional[pulumi.Input['ServiceExternalWebServiceConditionsArgs']]):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter(name="managementZones")
    def management_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        """
        return pulumi.get(self, "management_zones")

    @management_zones.setter
    def management_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "management_zones", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Rule name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _ServiceExternalWebServiceState:
    def __init__(__self__, *,
                 conditions: Optional[pulumi.Input['ServiceExternalWebServiceConditionsArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 id_contributors: Optional[pulumi.Input['ServiceExternalWebServiceIdContributorsArgs']] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ServiceExternalWebService resources.
        :param pulumi.Input['ServiceExternalWebServiceConditionsArgs'] conditions: A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        :param pulumi.Input[str] description: Description
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input['ServiceExternalWebServiceIdContributorsArgs'] id_contributors: Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        :param pulumi.Input[str] name: Rule name
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if id_contributors is not None:
            pulumi.set(__self__, "id_contributors", id_contributors)
        if insert_after is not None:
            pulumi.set(__self__, "insert_after", insert_after)
        if management_zones is not None:
            pulumi.set(__self__, "management_zones", management_zones)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[pulumi.Input['ServiceExternalWebServiceConditionsArgs']]:
        """
        A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: Optional[pulumi.Input['ServiceExternalWebServiceConditionsArgs']]):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="idContributors")
    def id_contributors(self) -> Optional[pulumi.Input['ServiceExternalWebServiceIdContributorsArgs']]:
        """
        Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        """
        return pulumi.get(self, "id_contributors")

    @id_contributors.setter
    def id_contributors(self, value: Optional[pulumi.Input['ServiceExternalWebServiceIdContributorsArgs']]):
        pulumi.set(self, "id_contributors", value)

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> Optional[pulumi.Input[str]]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @insert_after.setter
    def insert_after(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "insert_after", value)

    @property
    @pulumi.getter(name="managementZones")
    def management_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        """
        return pulumi.get(self, "management_zones")

    @management_zones.setter
    def management_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "management_zones", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Rule name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class ServiceExternalWebService(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 conditions: Optional[pulumi.Input[pulumi.InputType['ServiceExternalWebServiceConditionsArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 id_contributors: Optional[pulumi.Input[pulumi.InputType['ServiceExternalWebServiceIdContributorsArgs']]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ServiceExternalWebService resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ServiceExternalWebServiceConditionsArgs']] conditions: A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        :param pulumi.Input[str] description: Description
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[pulumi.InputType['ServiceExternalWebServiceIdContributorsArgs']] id_contributors: Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        :param pulumi.Input[str] name: Rule name
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ServiceExternalWebServiceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ServiceExternalWebService resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ServiceExternalWebServiceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ServiceExternalWebServiceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 conditions: Optional[pulumi.Input[pulumi.InputType['ServiceExternalWebServiceConditionsArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 id_contributors: Optional[pulumi.Input[pulumi.InputType['ServiceExternalWebServiceIdContributorsArgs']]] = None,
                 insert_after: Optional[pulumi.Input[str]] = None,
                 management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ServiceExternalWebServiceArgs.__new__(ServiceExternalWebServiceArgs)

            __props__.__dict__["conditions"] = conditions
            __props__.__dict__["description"] = description
            if enabled is None and not opts.urn:
                raise TypeError("Missing required property 'enabled'")
            __props__.__dict__["enabled"] = enabled
            if id_contributors is None and not opts.urn:
                raise TypeError("Missing required property 'id_contributors'")
            __props__.__dict__["id_contributors"] = id_contributors
            __props__.__dict__["insert_after"] = insert_after
            __props__.__dict__["management_zones"] = management_zones
            __props__.__dict__["name"] = name
        super(ServiceExternalWebService, __self__).__init__(
            'dynatrace:index/serviceExternalWebService:ServiceExternalWebService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            conditions: Optional[pulumi.Input[pulumi.InputType['ServiceExternalWebServiceConditionsArgs']]] = None,
            description: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            id_contributors: Optional[pulumi.Input[pulumi.InputType['ServiceExternalWebServiceIdContributorsArgs']]] = None,
            insert_after: Optional[pulumi.Input[str]] = None,
            management_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'ServiceExternalWebService':
        """
        Get an existing ServiceExternalWebService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ServiceExternalWebServiceConditionsArgs']] conditions: A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        :param pulumi.Input[str] description: Description
        :param pulumi.Input[bool] enabled: This setting is enabled (`true`) or disabled (`false`)
        :param pulumi.Input[pulumi.InputType['ServiceExternalWebServiceIdContributorsArgs']] id_contributors: Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        :param pulumi.Input[str] insert_after: Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        :param pulumi.Input[Sequence[pulumi.Input[str]]] management_zones: Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        :param pulumi.Input[str] name: Rule name
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ServiceExternalWebServiceState.__new__(_ServiceExternalWebServiceState)

        __props__.__dict__["conditions"] = conditions
        __props__.__dict__["description"] = description
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["id_contributors"] = id_contributors
        __props__.__dict__["insert_after"] = insert_after
        __props__.__dict__["management_zones"] = management_zones
        __props__.__dict__["name"] = name
        return ServiceExternalWebService(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def conditions(self) -> pulumi.Output[Optional['outputs.ServiceExternalWebServiceConditions']]:
        """
        A list of conditions necessary for the rule to take effect. If multiple conditions are specified, they must **all** match a Request for the rule to apply. If there is no condition at all, the rule is always applied. Conditions are evaluated against attributes, but do not modify them.
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        This setting is enabled (`true`) or disabled (`false`)
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="idContributors")
    def id_contributors(self) -> pulumi.Output['outputs.ServiceExternalWebServiceIdContributors']:
        """
        Contributors to the Service Identifier calculation. URL path is always applied as an Id Contributor. You can exclude the port contribution by disabling the switch.
        """
        return pulumi.get(self, "id_contributors")

    @property
    @pulumi.getter(name="insertAfter")
    def insert_after(self) -> pulumi.Output[str]:
        """
        Because this resource allows for ordering you may specify the ID of the resource instance that comes before this instance regarding order. If not specified when creating the setting will be added to the end of the list. If not specified during update the order will remain untouched
        """
        return pulumi.get(self, "insert_after")

    @property
    @pulumi.getter(name="managementZones")
    def management_zones(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Define a management zone of the process group for which this service detection rule should be created.  Note: in case of external requests/services the PG might not always be known. See [here](https://dt-url.net/9i03b79)
        """
        return pulumi.get(self, "management_zones")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Rule name
        """
        return pulumi.get(self, "name")
