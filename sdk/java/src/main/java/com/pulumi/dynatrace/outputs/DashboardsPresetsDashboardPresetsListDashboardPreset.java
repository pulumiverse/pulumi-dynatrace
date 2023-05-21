// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.String;
import java.util.Objects;

@CustomType
public final class DashboardsPresetsDashboardPresetsListDashboardPreset {
    private String dashboardPreset;
    private String userGroup;

    private DashboardsPresetsDashboardPresetsListDashboardPreset() {}
    public String dashboardPreset() {
        return this.dashboardPreset;
    }
    public String userGroup() {
        return this.userGroup;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(DashboardsPresetsDashboardPresetsListDashboardPreset defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private String dashboardPreset;
        private String userGroup;
        public Builder() {}
        public Builder(DashboardsPresetsDashboardPresetsListDashboardPreset defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.dashboardPreset = defaults.dashboardPreset;
    	      this.userGroup = defaults.userGroup;
        }

        @CustomType.Setter
        public Builder dashboardPreset(String dashboardPreset) {
            this.dashboardPreset = Objects.requireNonNull(dashboardPreset);
            return this;
        }
        @CustomType.Setter
        public Builder userGroup(String userGroup) {
            this.userGroup = Objects.requireNonNull(userGroup);
            return this;
        }
        public DashboardsPresetsDashboardPresetsListDashboardPreset build() {
            final var o = new DashboardsPresetsDashboardPresetsListDashboardPreset();
            o.dashboardPreset = dashboardPreset;
            o.userGroup = userGroup;
            return o;
        }
    }
}