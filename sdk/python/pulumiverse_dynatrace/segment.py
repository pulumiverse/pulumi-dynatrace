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
from . import outputs
from ._inputs import *

__all__ = ['SegmentArgs', 'Segment']

@pulumi.input_type
class SegmentArgs:
    def __init__(__self__, *,
                 is_public: pulumi.Input[builtins.bool],
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 includes: Optional[pulumi.Input['SegmentIncludesArgs']] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 variables: Optional[pulumi.Input['SegmentVariablesArgs']] = None):
        """
        The set of arguments for constructing a Segment resource.
        :param pulumi.Input[builtins.bool] is_public: Indicates if the filter-segment is publicly accessible within the tenant
        :param pulumi.Input[builtins.str] description: Description of the filter-segment
        :param pulumi.Input['SegmentIncludesArgs'] includes: List of includes of the filter-segment
        :param pulumi.Input[builtins.str] name: Name of the filter-segment
        :param pulumi.Input['SegmentVariablesArgs'] variables: Variables of the filter-segment
        """
        pulumi.set(__self__, "is_public", is_public)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if includes is not None:
            pulumi.set(__self__, "includes", includes)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if variables is not None:
            pulumi.set(__self__, "variables", variables)

    @property
    @pulumi.getter(name="isPublic")
    def is_public(self) -> pulumi.Input[builtins.bool]:
        """
        Indicates if the filter-segment is publicly accessible within the tenant
        """
        return pulumi.get(self, "is_public")

    @is_public.setter
    def is_public(self, value: pulumi.Input[builtins.bool]):
        pulumi.set(self, "is_public", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Description of the filter-segment
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def includes(self) -> Optional[pulumi.Input['SegmentIncludesArgs']]:
        """
        List of includes of the filter-segment
        """
        return pulumi.get(self, "includes")

    @includes.setter
    def includes(self, value: Optional[pulumi.Input['SegmentIncludesArgs']]):
        pulumi.set(self, "includes", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Name of the filter-segment
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def variables(self) -> Optional[pulumi.Input['SegmentVariablesArgs']]:
        """
        Variables of the filter-segment
        """
        return pulumi.get(self, "variables")

    @variables.setter
    def variables(self, value: Optional[pulumi.Input['SegmentVariablesArgs']]):
        pulumi.set(self, "variables", value)


@pulumi.input_type
class _SegmentState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 includes: Optional[pulumi.Input['SegmentIncludesArgs']] = None,
                 is_public: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 variables: Optional[pulumi.Input['SegmentVariablesArgs']] = None):
        """
        Input properties used for looking up and filtering Segment resources.
        :param pulumi.Input[builtins.str] description: Description of the filter-segment
        :param pulumi.Input['SegmentIncludesArgs'] includes: List of includes of the filter-segment
        :param pulumi.Input[builtins.bool] is_public: Indicates if the filter-segment is publicly accessible within the tenant
        :param pulumi.Input[builtins.str] name: Name of the filter-segment
        :param pulumi.Input['SegmentVariablesArgs'] variables: Variables of the filter-segment
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if includes is not None:
            pulumi.set(__self__, "includes", includes)
        if is_public is not None:
            pulumi.set(__self__, "is_public", is_public)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if variables is not None:
            pulumi.set(__self__, "variables", variables)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Description of the filter-segment
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def includes(self) -> Optional[pulumi.Input['SegmentIncludesArgs']]:
        """
        List of includes of the filter-segment
        """
        return pulumi.get(self, "includes")

    @includes.setter
    def includes(self, value: Optional[pulumi.Input['SegmentIncludesArgs']]):
        pulumi.set(self, "includes", value)

    @property
    @pulumi.getter(name="isPublic")
    def is_public(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Indicates if the filter-segment is publicly accessible within the tenant
        """
        return pulumi.get(self, "is_public")

    @is_public.setter
    def is_public(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "is_public", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Name of the filter-segment
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def variables(self) -> Optional[pulumi.Input['SegmentVariablesArgs']]:
        """
        Variables of the filter-segment
        """
        return pulumi.get(self, "variables")

    @variables.setter
    def variables(self, value: Optional[pulumi.Input['SegmentVariablesArgs']]):
        pulumi.set(self, "variables", value)


@pulumi.type_token("dynatrace:index/segment:Segment")
class Segment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 includes: Optional[pulumi.Input[Union['SegmentIncludesArgs', 'SegmentIncludesArgsDict']]] = None,
                 is_public: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 variables: Optional[pulumi.Input[Union['SegmentVariablesArgs', 'SegmentVariablesArgsDict']]] = None,
                 __props__=None):
        """
        > **Dynatrace SaaS only**

        > To utilize this resource with access to all segments, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **View Filter-Segments** (`storage:filter-segments:read`), **Create and Update Filter-Segments** (`storage:filter-segments:write`), **Share Filter-Segments** (`storage:filter-segments:share`), **Delete Filter-Segments** (`storage:filter-segments:delete`) and **Maintain all Filter-Segments on the environment** (`storage:filter-segments:admin`).

        > This resource is excluded by default in the export utility, please explicitly specify the resource to retrieve existing configuration.

        > The `includes.items[X].filter` attribute, which is a JSON string, is unfriendly for configuration as code. The structure of that attribute is not publicly documented and therefore subject to change without warning. The resource schema has been created to match our REST API, but we will be reaching out to product management on further enhancement of this endpoint. In the meantime, please use the export utility to create configurations more efficiently.

        ## Dynatrace Documentation

        - Segments - https://docs.dynatrace.com/docs/manage/segments

        - Grail Storage Filter-Segments (API) - https://########.apps.dynatrace.com/platform/swagger-ui/index.html?urls.primaryName=Grail+-+Filter+Segments

        ## Resource Example Usage

        ```python
        import pulumi
        import json
        import pulumiverse_dynatrace as dynatrace

        # ID GQ7NqJGPV1N
        _name_ = dynatrace.Segment("#name#",
            description="Example description",
            is_public=True,
            includes={
                "items": [
                    {
                        "data_object": "_all_data_object",
                        "filter": json.dumps({
                            "children": [{
                                "key": {
                                    "range": {
                                        "from": 0,
                                        "to": 16,
                                    },
                                    "textValue": "k8s.cluster.name",
                                    "type": "Key",
                                    "value": "k8s.cluster.name",
                                },
                                "operator": {
                                    "range": {
                                        "from": 17,
                                        "to": 18,
                                    },
                                    "textValue": "=",
                                    "type": "ComparisonOperator",
                                    "value": "=",
                                },
                                "range": {
                                    "from": 0,
                                    "to": 27,
                                },
                                "type": "Statement",
                                "value": {
                                    "range": {
                                        "from": 19,
                                        "to": 27,
                                    },
                                    "textValue": "$cluster",
                                    "type": "String",
                                    "value": "$cluster",
                                },
                            }],
                            "explicit": False,
                            "logicalOperator": "AND",
                            "range": {
                                "from": 0,
                                "to": 27,
                            },
                            "type": "Group",
                        }),
                    },
                    {
                        "data_object": "dt.entity.cloud_application",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.cloud_application_instance",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.cloud_application_namespace",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.container_group_instance",
                        "filter": "",
                        "relationship": {
                            "name": "belongs_to",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.host",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.kubernetes_cluster",
                        "filter": json.dumps({
                            "children": [{
                                "key": {
                                    "range": {
                                        "from": 0,
                                        "to": 11,
                                    },
                                    "textValue": "entity.name",
                                    "type": "Key",
                                    "value": "entity.name",
                                },
                                "operator": {
                                    "range": {
                                        "from": 12,
                                        "to": 13,
                                    },
                                    "textValue": "=",
                                    "type": "ComparisonOperator",
                                    "value": "=",
                                },
                                "range": {
                                    "from": 0,
                                    "to": 22,
                                },
                                "type": "Statement",
                                "value": {
                                    "range": {
                                        "from": 14,
                                        "to": 22,
                                    },
                                    "textValue": "$cluster",
                                    "type": "String",
                                    "value": "$cluster",
                                },
                            }],
                            "explicit": False,
                            "logicalOperator": "AND",
                            "range": {
                                "from": 0,
                                "to": 22,
                            },
                            "type": "Group",
                        }),
                    },
                    {
                        "data_object": "dt.entity.kubernetes_node",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.kubernetes_service",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.service",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                ],
            },
            variables={
                "type": "query",
                "value": \"\"\"fetch dt.entity.kubernetes_cluster
        | fields cluster = entity.name
        | sort cluster
        \"\"\",
            })
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Description of the filter-segment
        :param pulumi.Input[Union['SegmentIncludesArgs', 'SegmentIncludesArgsDict']] includes: List of includes of the filter-segment
        :param pulumi.Input[builtins.bool] is_public: Indicates if the filter-segment is publicly accessible within the tenant
        :param pulumi.Input[builtins.str] name: Name of the filter-segment
        :param pulumi.Input[Union['SegmentVariablesArgs', 'SegmentVariablesArgsDict']] variables: Variables of the filter-segment
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SegmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        > **Dynatrace SaaS only**

        > To utilize this resource with access to all segments, please define the environment variables `DT_CLIENT_ID`, `DT_CLIENT_SECRET`, `DT_ACCOUNT_ID` with an OAuth client including the following permissions: **View Filter-Segments** (`storage:filter-segments:read`), **Create and Update Filter-Segments** (`storage:filter-segments:write`), **Share Filter-Segments** (`storage:filter-segments:share`), **Delete Filter-Segments** (`storage:filter-segments:delete`) and **Maintain all Filter-Segments on the environment** (`storage:filter-segments:admin`).

        > This resource is excluded by default in the export utility, please explicitly specify the resource to retrieve existing configuration.

        > The `includes.items[X].filter` attribute, which is a JSON string, is unfriendly for configuration as code. The structure of that attribute is not publicly documented and therefore subject to change without warning. The resource schema has been created to match our REST API, but we will be reaching out to product management on further enhancement of this endpoint. In the meantime, please use the export utility to create configurations more efficiently.

        ## Dynatrace Documentation

        - Segments - https://docs.dynatrace.com/docs/manage/segments

        - Grail Storage Filter-Segments (API) - https://########.apps.dynatrace.com/platform/swagger-ui/index.html?urls.primaryName=Grail+-+Filter+Segments

        ## Resource Example Usage

        ```python
        import pulumi
        import json
        import pulumiverse_dynatrace as dynatrace

        # ID GQ7NqJGPV1N
        _name_ = dynatrace.Segment("#name#",
            description="Example description",
            is_public=True,
            includes={
                "items": [
                    {
                        "data_object": "_all_data_object",
                        "filter": json.dumps({
                            "children": [{
                                "key": {
                                    "range": {
                                        "from": 0,
                                        "to": 16,
                                    },
                                    "textValue": "k8s.cluster.name",
                                    "type": "Key",
                                    "value": "k8s.cluster.name",
                                },
                                "operator": {
                                    "range": {
                                        "from": 17,
                                        "to": 18,
                                    },
                                    "textValue": "=",
                                    "type": "ComparisonOperator",
                                    "value": "=",
                                },
                                "range": {
                                    "from": 0,
                                    "to": 27,
                                },
                                "type": "Statement",
                                "value": {
                                    "range": {
                                        "from": 19,
                                        "to": 27,
                                    },
                                    "textValue": "$cluster",
                                    "type": "String",
                                    "value": "$cluster",
                                },
                            }],
                            "explicit": False,
                            "logicalOperator": "AND",
                            "range": {
                                "from": 0,
                                "to": 27,
                            },
                            "type": "Group",
                        }),
                    },
                    {
                        "data_object": "dt.entity.cloud_application",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.cloud_application_instance",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.cloud_application_namespace",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.container_group_instance",
                        "filter": "",
                        "relationship": {
                            "name": "belongs_to",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.host",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.kubernetes_cluster",
                        "filter": json.dumps({
                            "children": [{
                                "key": {
                                    "range": {
                                        "from": 0,
                                        "to": 11,
                                    },
                                    "textValue": "entity.name",
                                    "type": "Key",
                                    "value": "entity.name",
                                },
                                "operator": {
                                    "range": {
                                        "from": 12,
                                        "to": 13,
                                    },
                                    "textValue": "=",
                                    "type": "ComparisonOperator",
                                    "value": "=",
                                },
                                "range": {
                                    "from": 0,
                                    "to": 22,
                                },
                                "type": "Statement",
                                "value": {
                                    "range": {
                                        "from": 14,
                                        "to": 22,
                                    },
                                    "textValue": "$cluster",
                                    "type": "String",
                                    "value": "$cluster",
                                },
                            }],
                            "explicit": False,
                            "logicalOperator": "AND",
                            "range": {
                                "from": 0,
                                "to": 22,
                            },
                            "type": "Group",
                        }),
                    },
                    {
                        "data_object": "dt.entity.kubernetes_node",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.kubernetes_service",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                    {
                        "data_object": "dt.entity.service",
                        "filter": "",
                        "relationship": {
                            "name": "clustered_by",
                            "target": "dt.entity.kubernetes_cluster",
                        },
                    },
                ],
            },
            variables={
                "type": "query",
                "value": \"\"\"fetch dt.entity.kubernetes_cluster
        | fields cluster = entity.name
        | sort cluster
        \"\"\",
            })
        ```

        :param str resource_name: The name of the resource.
        :param SegmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SegmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 includes: Optional[pulumi.Input[Union['SegmentIncludesArgs', 'SegmentIncludesArgsDict']]] = None,
                 is_public: Optional[pulumi.Input[builtins.bool]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 variables: Optional[pulumi.Input[Union['SegmentVariablesArgs', 'SegmentVariablesArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SegmentArgs.__new__(SegmentArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["includes"] = includes
            if is_public is None and not opts.urn:
                raise TypeError("Missing required property 'is_public'")
            __props__.__dict__["is_public"] = is_public
            __props__.__dict__["name"] = name
            __props__.__dict__["variables"] = variables
        super(Segment, __self__).__init__(
            'dynatrace:index/segment:Segment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            includes: Optional[pulumi.Input[Union['SegmentIncludesArgs', 'SegmentIncludesArgsDict']]] = None,
            is_public: Optional[pulumi.Input[builtins.bool]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            variables: Optional[pulumi.Input[Union['SegmentVariablesArgs', 'SegmentVariablesArgsDict']]] = None) -> 'Segment':
        """
        Get an existing Segment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] description: Description of the filter-segment
        :param pulumi.Input[Union['SegmentIncludesArgs', 'SegmentIncludesArgsDict']] includes: List of includes of the filter-segment
        :param pulumi.Input[builtins.bool] is_public: Indicates if the filter-segment is publicly accessible within the tenant
        :param pulumi.Input[builtins.str] name: Name of the filter-segment
        :param pulumi.Input[Union['SegmentVariablesArgs', 'SegmentVariablesArgsDict']] variables: Variables of the filter-segment
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SegmentState.__new__(_SegmentState)

        __props__.__dict__["description"] = description
        __props__.__dict__["includes"] = includes
        __props__.__dict__["is_public"] = is_public
        __props__.__dict__["name"] = name
        __props__.__dict__["variables"] = variables
        return Segment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Description of the filter-segment
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def includes(self) -> pulumi.Output[Optional['outputs.SegmentIncludes']]:
        """
        List of includes of the filter-segment
        """
        return pulumi.get(self, "includes")

    @property
    @pulumi.getter(name="isPublic")
    def is_public(self) -> pulumi.Output[builtins.bool]:
        """
        Indicates if the filter-segment is publicly accessible within the tenant
        """
        return pulumi.get(self, "is_public")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        Name of the filter-segment
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def variables(self) -> pulumi.Output[Optional['outputs.SegmentVariables']]:
        """
        Variables of the filter-segment
        """
        return pulumi.get(self, "variables")

