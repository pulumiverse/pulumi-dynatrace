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
    'GetDqlResult',
    'AwaitableGetDqlResult',
    'get_dql',
    'get_dql_output',
]

@pulumi.output_type
class GetDqlResult:
    """
    A collection of values returned by getDql.
    """
    def __init__(__self__, default_sampling_ratio=None, default_scan_limit_gbytes=None, default_timeframe_end=None, default_timeframe_start=None, fetch_timeout_seconds=None, id=None, locale=None, max_result_bytes=None, max_result_records=None, query=None, records=None, timezone=None):
        if default_sampling_ratio and not isinstance(default_sampling_ratio, float):
            raise TypeError("Expected argument 'default_sampling_ratio' to be a float")
        pulumi.set(__self__, "default_sampling_ratio", default_sampling_ratio)
        if default_scan_limit_gbytes and not isinstance(default_scan_limit_gbytes, int):
            raise TypeError("Expected argument 'default_scan_limit_gbytes' to be a int")
        pulumi.set(__self__, "default_scan_limit_gbytes", default_scan_limit_gbytes)
        if default_timeframe_end and not isinstance(default_timeframe_end, str):
            raise TypeError("Expected argument 'default_timeframe_end' to be a str")
        pulumi.set(__self__, "default_timeframe_end", default_timeframe_end)
        if default_timeframe_start and not isinstance(default_timeframe_start, str):
            raise TypeError("Expected argument 'default_timeframe_start' to be a str")
        pulumi.set(__self__, "default_timeframe_start", default_timeframe_start)
        if fetch_timeout_seconds and not isinstance(fetch_timeout_seconds, int):
            raise TypeError("Expected argument 'fetch_timeout_seconds' to be a int")
        pulumi.set(__self__, "fetch_timeout_seconds", fetch_timeout_seconds)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if locale and not isinstance(locale, str):
            raise TypeError("Expected argument 'locale' to be a str")
        pulumi.set(__self__, "locale", locale)
        if max_result_bytes and not isinstance(max_result_bytes, int):
            raise TypeError("Expected argument 'max_result_bytes' to be a int")
        pulumi.set(__self__, "max_result_bytes", max_result_bytes)
        if max_result_records and not isinstance(max_result_records, int):
            raise TypeError("Expected argument 'max_result_records' to be a int")
        pulumi.set(__self__, "max_result_records", max_result_records)
        if query and not isinstance(query, str):
            raise TypeError("Expected argument 'query' to be a str")
        pulumi.set(__self__, "query", query)
        if records and not isinstance(records, str):
            raise TypeError("Expected argument 'records' to be a str")
        pulumi.set(__self__, "records", records)
        if timezone and not isinstance(timezone, str):
            raise TypeError("Expected argument 'timezone' to be a str")
        pulumi.set(__self__, "timezone", timezone)

    @property
    @pulumi.getter(name="defaultSamplingRatio")
    def default_sampling_ratio(self) -> Optional[builtins.float]:
        """
        In case not specified in the DQL string, the sampling ratio defined here is applied. Note that this is only applicable to log queries
        """
        return pulumi.get(self, "default_sampling_ratio")

    @property
    @pulumi.getter(name="defaultScanLimitGbytes")
    def default_scan_limit_gbytes(self) -> Optional[builtins.int]:
        """
        Limit in gigabytes for the amount data that will be scanned during read
        """
        return pulumi.get(self, "default_scan_limit_gbytes")

    @property
    @pulumi.getter(name="defaultTimeframeEnd")
    def default_timeframe_end(self) -> Optional[builtins.str]:
        """
        The query timeframe 'end' timestamp in ISO-8601 or RFC3339 format. If the timeframe 'start' parameter is missing, the whole timeframe is ignored. Note that if a timeframe is specified within the query string (query) then it has precedence over this query request parameter
        """
        return pulumi.get(self, "default_timeframe_end")

    @property
    @pulumi.getter(name="defaultTimeframeStart")
    def default_timeframe_start(self) -> Optional[builtins.str]:
        """
        The query timeframe 'start' timestamp in ISO-8601 or RFC3339 format. If the timeframe 'end' parameter is missing, the whole timeframe is ignored. Note that if a timeframe is specified within the query string (query) then it has precedence over this query request parameter
        """
        return pulumi.get(self, "default_timeframe_start")

    @property
    @pulumi.getter(name="fetchTimeoutSeconds")
    def fetch_timeout_seconds(self) -> Optional[builtins.int]:
        """
        The query will stop reading data after reaching the fetch-timeout. The query execution will continue, providing a partial result based on the read data
        """
        return pulumi.get(self, "fetch_timeout_seconds")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def locale(self) -> Optional[builtins.str]:
        """
        The query locale. If none specified, then a language/country neutral locale is chosen. The input values take the ISO-639 Language code with an optional ISO-3166 country code appended to it with an underscore. For instance, both values are valid 'en' or 'en_US'
        """
        return pulumi.get(self, "locale")

    @property
    @pulumi.getter(name="maxResultBytes")
    def max_result_bytes(self) -> Optional[builtins.int]:
        """
        The maximum number of result bytes that this query will return
        """
        return pulumi.get(self, "max_result_bytes")

    @property
    @pulumi.getter(name="maxResultRecords")
    def max_result_records(self) -> Optional[builtins.int]:
        """
        The maximum number of result records that this query will return
        """
        return pulumi.get(self, "max_result_records")

    @property
    @pulumi.getter
    def query(self) -> builtins.str:
        """
        example: fetch events | filter event.type == "davis" AND davis.status != "CLOSED" | fields timestamp, davis.title, davis.underMaintenance, davis.status | sort timestamp | limit 10
        """
        return pulumi.get(self, "query")

    @property
    @pulumi.getter
    def records(self) -> builtins.str:
        return pulumi.get(self, "records")

    @property
    @pulumi.getter
    def timezone(self) -> Optional[builtins.str]:
        """
        The query timezone. If none is specified, UTC is used as fallback. The list of valid input values matches that of the IANA Time Zone Database (TZDB). It accepts values in their canonical names like 'Europe/Paris', the abbreviated version like CET or the UTC offset format like '+01:00'
        """
        return pulumi.get(self, "timezone")


class AwaitableGetDqlResult(GetDqlResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDqlResult(
            default_sampling_ratio=self.default_sampling_ratio,
            default_scan_limit_gbytes=self.default_scan_limit_gbytes,
            default_timeframe_end=self.default_timeframe_end,
            default_timeframe_start=self.default_timeframe_start,
            fetch_timeout_seconds=self.fetch_timeout_seconds,
            id=self.id,
            locale=self.locale,
            max_result_bytes=self.max_result_bytes,
            max_result_records=self.max_result_records,
            query=self.query,
            records=self.records,
            timezone=self.timezone)


def get_dql(default_sampling_ratio: Optional[builtins.float] = None,
            default_scan_limit_gbytes: Optional[builtins.int] = None,
            default_timeframe_end: Optional[builtins.str] = None,
            default_timeframe_start: Optional[builtins.str] = None,
            fetch_timeout_seconds: Optional[builtins.int] = None,
            locale: Optional[builtins.str] = None,
            max_result_bytes: Optional[builtins.int] = None,
            max_result_records: Optional[builtins.int] = None,
            query: Optional[builtins.str] = None,
            timezone: Optional[builtins.str] = None,
            opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDqlResult:
    """
    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    this = dynatrace.get_dql(query="fetch events")
    ```
    will produce content for the `results` attribute like this:

    You can also use Heredoc syntax for better readability of complex DQL queries.

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    this = dynatrace.get_dql(query=\"\"\"    fetch events |
        filter event.type == "davis" AND davis.status != "CLOSED" |
        fields timestamp, davis.title, davis.underMaintenance, davis.status |
        sort timestamp |
        limit 10  

    \"\"\")
    ```


    :param builtins.float default_sampling_ratio: In case not specified in the DQL string, the sampling ratio defined here is applied. Note that this is only applicable to log queries
    :param builtins.int default_scan_limit_gbytes: Limit in gigabytes for the amount data that will be scanned during read
    :param builtins.str default_timeframe_end: The query timeframe 'end' timestamp in ISO-8601 or RFC3339 format. If the timeframe 'start' parameter is missing, the whole timeframe is ignored. Note that if a timeframe is specified within the query string (query) then it has precedence over this query request parameter
    :param builtins.str default_timeframe_start: The query timeframe 'start' timestamp in ISO-8601 or RFC3339 format. If the timeframe 'end' parameter is missing, the whole timeframe is ignored. Note that if a timeframe is specified within the query string (query) then it has precedence over this query request parameter
    :param builtins.int fetch_timeout_seconds: The query will stop reading data after reaching the fetch-timeout. The query execution will continue, providing a partial result based on the read data
    :param builtins.str locale: The query locale. If none specified, then a language/country neutral locale is chosen. The input values take the ISO-639 Language code with an optional ISO-3166 country code appended to it with an underscore. For instance, both values are valid 'en' or 'en_US'
    :param builtins.int max_result_bytes: The maximum number of result bytes that this query will return
    :param builtins.int max_result_records: The maximum number of result records that this query will return
    :param builtins.str query: example: fetch events | filter event.type == "davis" AND davis.status != "CLOSED" | fields timestamp, davis.title, davis.underMaintenance, davis.status | sort timestamp | limit 10
    :param builtins.str timezone: The query timezone. If none is specified, UTC is used as fallback. The list of valid input values matches that of the IANA Time Zone Database (TZDB). It accepts values in their canonical names like 'Europe/Paris', the abbreviated version like CET or the UTC offset format like '+01:00'
    """
    __args__ = dict()
    __args__['defaultSamplingRatio'] = default_sampling_ratio
    __args__['defaultScanLimitGbytes'] = default_scan_limit_gbytes
    __args__['defaultTimeframeEnd'] = default_timeframe_end
    __args__['defaultTimeframeStart'] = default_timeframe_start
    __args__['fetchTimeoutSeconds'] = fetch_timeout_seconds
    __args__['locale'] = locale
    __args__['maxResultBytes'] = max_result_bytes
    __args__['maxResultRecords'] = max_result_records
    __args__['query'] = query
    __args__['timezone'] = timezone
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getDql:getDql', __args__, opts=opts, typ=GetDqlResult).value

    return AwaitableGetDqlResult(
        default_sampling_ratio=pulumi.get(__ret__, 'default_sampling_ratio'),
        default_scan_limit_gbytes=pulumi.get(__ret__, 'default_scan_limit_gbytes'),
        default_timeframe_end=pulumi.get(__ret__, 'default_timeframe_end'),
        default_timeframe_start=pulumi.get(__ret__, 'default_timeframe_start'),
        fetch_timeout_seconds=pulumi.get(__ret__, 'fetch_timeout_seconds'),
        id=pulumi.get(__ret__, 'id'),
        locale=pulumi.get(__ret__, 'locale'),
        max_result_bytes=pulumi.get(__ret__, 'max_result_bytes'),
        max_result_records=pulumi.get(__ret__, 'max_result_records'),
        query=pulumi.get(__ret__, 'query'),
        records=pulumi.get(__ret__, 'records'),
        timezone=pulumi.get(__ret__, 'timezone'))
def get_dql_output(default_sampling_ratio: Optional[pulumi.Input[Optional[builtins.float]]] = None,
                   default_scan_limit_gbytes: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                   default_timeframe_end: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                   default_timeframe_start: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                   fetch_timeout_seconds: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                   locale: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                   max_result_bytes: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                   max_result_records: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                   query: Optional[pulumi.Input[builtins.str]] = None,
                   timezone: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                   opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetDqlResult]:
    """
    ## Example Usage

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    this = dynatrace.get_dql(query="fetch events")
    ```
    will produce content for the `results` attribute like this:

    You can also use Heredoc syntax for better readability of complex DQL queries.

    ```python
    import pulumi
    import pulumi_dynatrace as dynatrace

    this = dynatrace.get_dql(query=\"\"\"    fetch events |
        filter event.type == "davis" AND davis.status != "CLOSED" |
        fields timestamp, davis.title, davis.underMaintenance, davis.status |
        sort timestamp |
        limit 10  

    \"\"\")
    ```


    :param builtins.float default_sampling_ratio: In case not specified in the DQL string, the sampling ratio defined here is applied. Note that this is only applicable to log queries
    :param builtins.int default_scan_limit_gbytes: Limit in gigabytes for the amount data that will be scanned during read
    :param builtins.str default_timeframe_end: The query timeframe 'end' timestamp in ISO-8601 or RFC3339 format. If the timeframe 'start' parameter is missing, the whole timeframe is ignored. Note that if a timeframe is specified within the query string (query) then it has precedence over this query request parameter
    :param builtins.str default_timeframe_start: The query timeframe 'start' timestamp in ISO-8601 or RFC3339 format. If the timeframe 'end' parameter is missing, the whole timeframe is ignored. Note that if a timeframe is specified within the query string (query) then it has precedence over this query request parameter
    :param builtins.int fetch_timeout_seconds: The query will stop reading data after reaching the fetch-timeout. The query execution will continue, providing a partial result based on the read data
    :param builtins.str locale: The query locale. If none specified, then a language/country neutral locale is chosen. The input values take the ISO-639 Language code with an optional ISO-3166 country code appended to it with an underscore. For instance, both values are valid 'en' or 'en_US'
    :param builtins.int max_result_bytes: The maximum number of result bytes that this query will return
    :param builtins.int max_result_records: The maximum number of result records that this query will return
    :param builtins.str query: example: fetch events | filter event.type == "davis" AND davis.status != "CLOSED" | fields timestamp, davis.title, davis.underMaintenance, davis.status | sort timestamp | limit 10
    :param builtins.str timezone: The query timezone. If none is specified, UTC is used as fallback. The list of valid input values matches that of the IANA Time Zone Database (TZDB). It accepts values in their canonical names like 'Europe/Paris', the abbreviated version like CET or the UTC offset format like '+01:00'
    """
    __args__ = dict()
    __args__['defaultSamplingRatio'] = default_sampling_ratio
    __args__['defaultScanLimitGbytes'] = default_scan_limit_gbytes
    __args__['defaultTimeframeEnd'] = default_timeframe_end
    __args__['defaultTimeframeStart'] = default_timeframe_start
    __args__['fetchTimeoutSeconds'] = fetch_timeout_seconds
    __args__['locale'] = locale
    __args__['maxResultBytes'] = max_result_bytes
    __args__['maxResultRecords'] = max_result_records
    __args__['query'] = query
    __args__['timezone'] = timezone
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('dynatrace:index/getDql:getDql', __args__, opts=opts, typ=GetDqlResult)
    return __ret__.apply(lambda __response__: GetDqlResult(
        default_sampling_ratio=pulumi.get(__response__, 'default_sampling_ratio'),
        default_scan_limit_gbytes=pulumi.get(__response__, 'default_scan_limit_gbytes'),
        default_timeframe_end=pulumi.get(__response__, 'default_timeframe_end'),
        default_timeframe_start=pulumi.get(__response__, 'default_timeframe_start'),
        fetch_timeout_seconds=pulumi.get(__response__, 'fetch_timeout_seconds'),
        id=pulumi.get(__response__, 'id'),
        locale=pulumi.get(__response__, 'locale'),
        max_result_bytes=pulumi.get(__response__, 'max_result_bytes'),
        max_result_records=pulumi.get(__response__, 'max_result_records'),
        query=pulumi.get(__response__, 'query'),
        records=pulumi.get(__response__, 'records'),
        timezone=pulumi.get(__response__, 'timezone')))
