// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.dynatrace.SyntheticLocationArgs;
import com.pulumi.dynatrace.Utilities;
import com.pulumi.dynatrace.inputs.SyntheticLocationState;
import java.lang.Boolean;
import java.lang.Double;
import java.lang.Integer;
import java.lang.String;
import java.util.List;
import java.util.Optional;
import javax.annotation.Nullable;

@ResourceType(type="dynatrace:index/syntheticLocation:SyntheticLocation")
public class SyntheticLocation extends com.pulumi.resources.CustomResource {
    /**
     * Auto upgrade of Chromium is enabled (`true`) or disabled (`false`)
     * 
     */
    @Export(name="autoUpdateChromium", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> autoUpdateChromium;

    /**
     * @return Auto upgrade of Chromium is enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Optional<Boolean>> autoUpdateChromium() {
        return Codegen.optional(this.autoUpdateChromium);
    }
    /**
     * The alerting of location outage is enabled (`true`) or disabled (`false`)
     * 
     */
    @Export(name="availabilityLocationOutage", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> availabilityLocationOutage;

    /**
     * @return The alerting of location outage is enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Optional<Boolean>> availabilityLocationOutage() {
        return Codegen.optional(this.availabilityLocationOutage);
    }
    /**
     * The alerting of node outage is enabled (`true`) or disabled (`false`).
     * 
     */
    @Export(name="availabilityNodeOutage", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> availabilityNodeOutage;

    /**
     * @return The alerting of node outage is enabled (`true`) or disabled (`false`).
     * 
     */
    public Output<Optional<Boolean>> availabilityNodeOutage() {
        return Codegen.optional(this.availabilityNodeOutage);
    }
    /**
     * The notifications of location and node outage is enabled (`true`) or disabled (`false`)
     * 
     */
    @Export(name="availabilityNotificationsEnabled", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> availabilityNotificationsEnabled;

    /**
     * @return The notifications of location and node outage is enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Optional<Boolean>> availabilityNotificationsEnabled() {
        return Codegen.optional(this.availabilityNotificationsEnabled);
    }
    /**
     * The city of the location
     * 
     */
    @Export(name="city", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> city;

    /**
     * @return The city of the location
     * 
     */
    public Output<Optional<String>> city() {
        return Codegen.optional(this.city);
    }
    /**
     * The country code of the location. Use the alpha-2 code of the [ISO 3166-2 standard](https://dt-url.net/iso3166-2), (for
     * example, `AT` for Austria or `PL` for Poland)
     * 
     */
    @Export(name="countryCode", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> countryCode;

    /**
     * @return The country code of the location. Use the alpha-2 code of the [ISO 3166-2 standard](https://dt-url.net/iso3166-2), (for
     * example, `AT` for Austria or `PL` for Poland)
     * 
     */
    public Output<Optional<String>> countryCode() {
        return Codegen.optional(this.countryCode);
    }
    /**
     * The deployment type of the location: * `STANDARD`: The location is deployed on Windows or Linux. * `KUBERNETES`: The
     * location is deployed on Kubernetes
     * 
     */
    @Export(name="deploymentType", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> deploymentType;

    /**
     * @return The deployment type of the location: * `STANDARD`: The location is deployed on Windows or Linux. * `KUBERNETES`: The
     * location is deployed on Kubernetes
     * 
     */
    public Output<Optional<String>> deploymentType() {
        return Codegen.optional(this.deploymentType);
    }
    /**
     * The latitude of the location in `DDD.dddd` format
     * 
     */
    @Export(name="latitude", refs={Double.class}, tree="[0]")
    private Output<Double> latitude;

    /**
     * @return The latitude of the location in `DDD.dddd` format
     * 
     */
    public Output<Double> latitude() {
        return this.latitude;
    }
    /**
     * Alert if the location or node outage lasts longer than *X* minutes. Only applicable when
     * **availability_location_outage** or **availability_node_outage** is set to `true`
     * 
     */
    @Export(name="locationNodeOutageDelayInMinutes", refs={Integer.class}, tree="[0]")
    private Output</* @Nullable */ Integer> locationNodeOutageDelayInMinutes;

    /**
     * @return Alert if the location or node outage lasts longer than *X* minutes. Only applicable when
     * **availability_location_outage** or **availability_node_outage** is set to `true`
     * 
     */
    public Output<Optional<Integer>> locationNodeOutageDelayInMinutes() {
        return Codegen.optional(this.locationNodeOutageDelayInMinutes);
    }
    /**
     * The longitude of the location in `DDD.dddd` format
     * 
     */
    @Export(name="longitude", refs={Double.class}, tree="[0]")
    private Output<Double> longitude;

    /**
     * @return The longitude of the location in `DDD.dddd` format
     * 
     */
    public Output<Double> longitude() {
        return this.longitude;
    }
    /**
     * The name of the location
     * 
     */
    @Export(name="name", refs={String.class}, tree="[0]")
    private Output<String> name;

    /**
     * @return The name of the location
     * 
     */
    public Output<String> name() {
        return this.name;
    }
    /**
     * A list of synthetic nodes belonging to the location. You can retrieve the list of available nodes with the [GET all
     * nodes](https://dt-url.net/miy3rpl) call
     * 
     */
    @Export(name="nodes", refs={List.class,String.class}, tree="[0,1]")
    private Output</* @Nullable */ List<String>> nodes;

    /**
     * @return A list of synthetic nodes belonging to the location. You can retrieve the list of available nodes with the [GET all
     * nodes](https://dt-url.net/miy3rpl) call
     * 
     */
    public Output<Optional<List<String>>> nodes() {
        return Codegen.optional(this.nodes);
    }
    /**
     * The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
     * use ISO 3166-2 state codes (without `US-` or `CA-` prefix), for example, `VA` for Virginia or `OR` for Oregon. For the
     * rest of the world use [FIPS 10-4 codes](https://dt-url.net/fipscodes)
     * 
     */
    @Export(name="regionCode", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> regionCode;

    /**
     * @return The region code of the location. For the [USA](https://dt-url.net/iso3166us) or [Canada](https://dt-url.net/iso3166ca)
     * use ISO 3166-2 state codes (without `US-` or `CA-` prefix), for example, `VA` for Virginia or `OR` for Oregon. For the
     * rest of the world use [FIPS 10-4 codes](https://dt-url.net/fipscodes)
     * 
     */
    public Output<Optional<String>> regionCode() {
        return Codegen.optional(this.regionCode);
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public SyntheticLocation(String name) {
        this(name, SyntheticLocationArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public SyntheticLocation(String name, SyntheticLocationArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public SyntheticLocation(String name, SyntheticLocationArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/syntheticLocation:SyntheticLocation", name, args == null ? SyntheticLocationArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private SyntheticLocation(String name, Output<String> id, @Nullable SyntheticLocationState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/syntheticLocation:SyntheticLocation", name, state, makeResourceOptions(options, id));
    }

    private static com.pulumi.resources.CustomResourceOptions makeResourceOptions(@Nullable com.pulumi.resources.CustomResourceOptions options, @Nullable Output<String> id) {
        var defaultOptions = com.pulumi.resources.CustomResourceOptions.builder()
            .version(Utilities.getVersion())
            .build();
        return com.pulumi.resources.CustomResourceOptions.merge(defaultOptions, options, id);
    }

    /**
     * Get an existing Host resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state
     * @param options Optional settings to control the behavior of the CustomResource.
     */
    public static SyntheticLocation get(String name, Output<String> id, @Nullable SyntheticLocationState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new SyntheticLocation(name, id, state, options);
    }
}