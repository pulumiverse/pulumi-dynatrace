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

__all__ = ['RumIpLocationsArgs', 'RumIpLocations']

@pulumi.input_type
class RumIpLocationsArgs:
    def __init__(__self__, *,
                 country_code: pulumi.Input[builtins.str],
                 ip: pulumi.Input[builtins.str],
                 city: Optional[pulumi.Input[builtins.str]] = None,
                 ip_to: Optional[pulumi.Input[builtins.str]] = None,
                 latitude: Optional[pulumi.Input[builtins.float]] = None,
                 longitude: Optional[pulumi.Input[builtins.float]] = None,
                 region_code: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a RumIpLocations resource.
        :param pulumi.Input[builtins.str] country_code: The country code of the location.
        :param pulumi.Input[builtins.str] ip: Single IP or IP range start address
        :param pulumi.Input[builtins.str] city: The city name of the location.
        :param pulumi.Input[builtins.str] ip_to: IP range end
        :param pulumi.Input[builtins.float] latitude: Latitude
        :param pulumi.Input[builtins.float] longitude: Longitude
        :param pulumi.Input[builtins.str] region_code: The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
               use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
               codes](https://dt-url.net/fipscodes) without country prefix.
        """
        pulumi.set(__self__, "country_code", country_code)
        pulumi.set(__self__, "ip", ip)
        if city is not None:
            pulumi.set(__self__, "city", city)
        if ip_to is not None:
            pulumi.set(__self__, "ip_to", ip_to)
        if latitude is not None:
            pulumi.set(__self__, "latitude", latitude)
        if longitude is not None:
            pulumi.set(__self__, "longitude", longitude)
        if region_code is not None:
            pulumi.set(__self__, "region_code", region_code)

    @property
    @pulumi.getter(name="countryCode")
    def country_code(self) -> pulumi.Input[builtins.str]:
        """
        The country code of the location.
        """
        return pulumi.get(self, "country_code")

    @country_code.setter
    def country_code(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "country_code", value)

    @property
    @pulumi.getter
    def ip(self) -> pulumi.Input[builtins.str]:
        """
        Single IP or IP range start address
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "ip", value)

    @property
    @pulumi.getter
    def city(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The city name of the location.
        """
        return pulumi.get(self, "city")

    @city.setter
    def city(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "city", value)

    @property
    @pulumi.getter(name="ipTo")
    def ip_to(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        IP range end
        """
        return pulumi.get(self, "ip_to")

    @ip_to.setter
    def ip_to(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "ip_to", value)

    @property
    @pulumi.getter
    def latitude(self) -> Optional[pulumi.Input[builtins.float]]:
        """
        Latitude
        """
        return pulumi.get(self, "latitude")

    @latitude.setter
    def latitude(self, value: Optional[pulumi.Input[builtins.float]]):
        pulumi.set(self, "latitude", value)

    @property
    @pulumi.getter
    def longitude(self) -> Optional[pulumi.Input[builtins.float]]:
        """
        Longitude
        """
        return pulumi.get(self, "longitude")

    @longitude.setter
    def longitude(self, value: Optional[pulumi.Input[builtins.float]]):
        pulumi.set(self, "longitude", value)

    @property
    @pulumi.getter(name="regionCode")
    def region_code(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
        use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
        codes](https://dt-url.net/fipscodes) without country prefix.
        """
        return pulumi.get(self, "region_code")

    @region_code.setter
    def region_code(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "region_code", value)


@pulumi.input_type
class _RumIpLocationsState:
    def __init__(__self__, *,
                 city: Optional[pulumi.Input[builtins.str]] = None,
                 country_code: Optional[pulumi.Input[builtins.str]] = None,
                 ip: Optional[pulumi.Input[builtins.str]] = None,
                 ip_to: Optional[pulumi.Input[builtins.str]] = None,
                 latitude: Optional[pulumi.Input[builtins.float]] = None,
                 longitude: Optional[pulumi.Input[builtins.float]] = None,
                 region_code: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering RumIpLocations resources.
        :param pulumi.Input[builtins.str] city: The city name of the location.
        :param pulumi.Input[builtins.str] country_code: The country code of the location.
        :param pulumi.Input[builtins.str] ip: Single IP or IP range start address
        :param pulumi.Input[builtins.str] ip_to: IP range end
        :param pulumi.Input[builtins.float] latitude: Latitude
        :param pulumi.Input[builtins.float] longitude: Longitude
        :param pulumi.Input[builtins.str] region_code: The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
               use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
               codes](https://dt-url.net/fipscodes) without country prefix.
        """
        if city is not None:
            pulumi.set(__self__, "city", city)
        if country_code is not None:
            pulumi.set(__self__, "country_code", country_code)
        if ip is not None:
            pulumi.set(__self__, "ip", ip)
        if ip_to is not None:
            pulumi.set(__self__, "ip_to", ip_to)
        if latitude is not None:
            pulumi.set(__self__, "latitude", latitude)
        if longitude is not None:
            pulumi.set(__self__, "longitude", longitude)
        if region_code is not None:
            pulumi.set(__self__, "region_code", region_code)

    @property
    @pulumi.getter
    def city(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The city name of the location.
        """
        return pulumi.get(self, "city")

    @city.setter
    def city(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "city", value)

    @property
    @pulumi.getter(name="countryCode")
    def country_code(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The country code of the location.
        """
        return pulumi.get(self, "country_code")

    @country_code.setter
    def country_code(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "country_code", value)

    @property
    @pulumi.getter
    def ip(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Single IP or IP range start address
        """
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "ip", value)

    @property
    @pulumi.getter(name="ipTo")
    def ip_to(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        IP range end
        """
        return pulumi.get(self, "ip_to")

    @ip_to.setter
    def ip_to(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "ip_to", value)

    @property
    @pulumi.getter
    def latitude(self) -> Optional[pulumi.Input[builtins.float]]:
        """
        Latitude
        """
        return pulumi.get(self, "latitude")

    @latitude.setter
    def latitude(self, value: Optional[pulumi.Input[builtins.float]]):
        pulumi.set(self, "latitude", value)

    @property
    @pulumi.getter
    def longitude(self) -> Optional[pulumi.Input[builtins.float]]:
        """
        Longitude
        """
        return pulumi.get(self, "longitude")

    @longitude.setter
    def longitude(self, value: Optional[pulumi.Input[builtins.float]]):
        pulumi.set(self, "longitude", value)

    @property
    @pulumi.getter(name="regionCode")
    def region_code(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
        use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
        codes](https://dt-url.net/fipscodes) without country prefix.
        """
        return pulumi.get(self, "region_code")

    @region_code.setter
    def region_code(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "region_code", value)


@pulumi.type_token("dynatrace:index/rumIpLocations:RumIpLocations")
class RumIpLocations(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 city: Optional[pulumi.Input[builtins.str]] = None,
                 country_code: Optional[pulumi.Input[builtins.str]] = None,
                 ip: Optional[pulumi.Input[builtins.str]] = None,
                 ip_to: Optional[pulumi.Input[builtins.str]] = None,
                 latitude: Optional[pulumi.Input[builtins.float]] = None,
                 longitude: Optional[pulumi.Input[builtins.float]] = None,
                 region_code: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        Create a RumIpLocations resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] city: The city name of the location.
        :param pulumi.Input[builtins.str] country_code: The country code of the location.
        :param pulumi.Input[builtins.str] ip: Single IP or IP range start address
        :param pulumi.Input[builtins.str] ip_to: IP range end
        :param pulumi.Input[builtins.float] latitude: Latitude
        :param pulumi.Input[builtins.float] longitude: Longitude
        :param pulumi.Input[builtins.str] region_code: The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
               use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
               codes](https://dt-url.net/fipscodes) without country prefix.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RumIpLocationsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a RumIpLocations resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param RumIpLocationsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RumIpLocationsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 city: Optional[pulumi.Input[builtins.str]] = None,
                 country_code: Optional[pulumi.Input[builtins.str]] = None,
                 ip: Optional[pulumi.Input[builtins.str]] = None,
                 ip_to: Optional[pulumi.Input[builtins.str]] = None,
                 latitude: Optional[pulumi.Input[builtins.float]] = None,
                 longitude: Optional[pulumi.Input[builtins.float]] = None,
                 region_code: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RumIpLocationsArgs.__new__(RumIpLocationsArgs)

            __props__.__dict__["city"] = city
            if country_code is None and not opts.urn:
                raise TypeError("Missing required property 'country_code'")
            __props__.__dict__["country_code"] = country_code
            if ip is None and not opts.urn:
                raise TypeError("Missing required property 'ip'")
            __props__.__dict__["ip"] = ip
            __props__.__dict__["ip_to"] = ip_to
            __props__.__dict__["latitude"] = latitude
            __props__.__dict__["longitude"] = longitude
            __props__.__dict__["region_code"] = region_code
        super(RumIpLocations, __self__).__init__(
            'dynatrace:index/rumIpLocations:RumIpLocations',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            city: Optional[pulumi.Input[builtins.str]] = None,
            country_code: Optional[pulumi.Input[builtins.str]] = None,
            ip: Optional[pulumi.Input[builtins.str]] = None,
            ip_to: Optional[pulumi.Input[builtins.str]] = None,
            latitude: Optional[pulumi.Input[builtins.float]] = None,
            longitude: Optional[pulumi.Input[builtins.float]] = None,
            region_code: Optional[pulumi.Input[builtins.str]] = None) -> 'RumIpLocations':
        """
        Get an existing RumIpLocations resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] city: The city name of the location.
        :param pulumi.Input[builtins.str] country_code: The country code of the location.
        :param pulumi.Input[builtins.str] ip: Single IP or IP range start address
        :param pulumi.Input[builtins.str] ip_to: IP range end
        :param pulumi.Input[builtins.float] latitude: Latitude
        :param pulumi.Input[builtins.float] longitude: Longitude
        :param pulumi.Input[builtins.str] region_code: The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
               use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
               codes](https://dt-url.net/fipscodes) without country prefix.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RumIpLocationsState.__new__(_RumIpLocationsState)

        __props__.__dict__["city"] = city
        __props__.__dict__["country_code"] = country_code
        __props__.__dict__["ip"] = ip
        __props__.__dict__["ip_to"] = ip_to
        __props__.__dict__["latitude"] = latitude
        __props__.__dict__["longitude"] = longitude
        __props__.__dict__["region_code"] = region_code
        return RumIpLocations(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def city(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The city name of the location.
        """
        return pulumi.get(self, "city")

    @property
    @pulumi.getter(name="countryCode")
    def country_code(self) -> pulumi.Output[builtins.str]:
        """
        The country code of the location.
        """
        return pulumi.get(self, "country_code")

    @property
    @pulumi.getter
    def ip(self) -> pulumi.Output[builtins.str]:
        """
        Single IP or IP range start address
        """
        return pulumi.get(self, "ip")

    @property
    @pulumi.getter(name="ipTo")
    def ip_to(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        IP range end
        """
        return pulumi.get(self, "ip_to")

    @property
    @pulumi.getter
    def latitude(self) -> pulumi.Output[Optional[builtins.float]]:
        """
        Latitude
        """
        return pulumi.get(self, "latitude")

    @property
    @pulumi.getter
    def longitude(self) -> pulumi.Output[Optional[builtins.float]]:
        """
        Longitude
        """
        return pulumi.get(self, "longitude")

    @property
    @pulumi.getter(name="regionCode")
    def region_code(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
        use ISO 3166-2 state codes without `US-` or `CA-` prefix. For the rest of the world use [FIPS 10-4
        codes](https://dt-url.net/fipscodes) without country prefix.
        """
        return pulumi.get(self, "region_code")

