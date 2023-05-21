// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class TrelloNotificationState extends com.pulumi.resources.ResourceArgs {

    public static final TrelloNotificationState Empty = new TrelloNotificationState();

    /**
     * The configuration is enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="active")
    private @Nullable Output<Boolean> active;

    /**
     * @return The configuration is enabled (`true`) or disabled (`false`)
     * 
     */
    public Optional<Output<Boolean>> active() {
        return Optional.ofNullable(this.active);
    }

    /**
     * The application key for the Trello account
     * 
     */
    @Import(name="applicationKey")
    private @Nullable Output<String> applicationKey;

    /**
     * @return The application key for the Trello account
     * 
     */
    public Optional<Output<String>> applicationKey() {
        return Optional.ofNullable(this.applicationKey);
    }

    /**
     * The application token for the Trello account
     * 
     */
    @Import(name="authorizationToken")
    private @Nullable Output<String> authorizationToken;

    /**
     * @return The application token for the Trello account
     * 
     */
    public Optional<Output<String>> authorizationToken() {
        return Optional.ofNullable(this.authorizationToken);
    }

    /**
     * The Trello board to which the card should be assigned
     * 
     */
    @Import(name="boardId")
    private @Nullable Output<String> boardId;

    /**
     * @return The Trello board to which the card should be assigned
     * 
     */
    public Optional<Output<String>> boardId() {
        return Optional.ofNullable(this.boardId);
    }

    /**
     * The description of the Trello card.   You can use same placeholders as in card text
     * 
     */
    @Import(name="description")
    private @Nullable Output<String> description;

    /**
     * @return The description of the Trello card.   You can use same placeholders as in card text
     * 
     */
    public Optional<Output<String>> description() {
        return Optional.ofNullable(this.description);
    }

    /**
     * The ID of these settings when referred to from resources requiring the REST API V1 keys
     * 
     */
    @Import(name="legacyId")
    private @Nullable Output<String> legacyId;

    /**
     * @return The ID of these settings when referred to from resources requiring the REST API V1 keys
     * 
     */
    public Optional<Output<String>> legacyId() {
        return Optional.ofNullable(this.legacyId);
    }

    /**
     * The Trello list to which the card should be assigned
     * 
     */
    @Import(name="listId")
    private @Nullable Output<String> listId;

    /**
     * @return The Trello list to which the card should be assigned
     * 
     */
    public Optional<Output<String>> listId() {
        return Optional.ofNullable(this.listId);
    }

    /**
     * The name of the notification configuration
     * 
     */
    @Import(name="name")
    private @Nullable Output<String> name;

    /**
     * @return The name of the notification configuration
     * 
     */
    public Optional<Output<String>> name() {
        return Optional.ofNullable(this.name);
    }

    /**
     * The ID of the associated alerting profile
     * 
     */
    @Import(name="profile")
    private @Nullable Output<String> profile;

    /**
     * @return The ID of the associated alerting profile
     * 
     */
    public Optional<Output<String>> profile() {
        return Optional.ofNullable(this.profile);
    }

    /**
     * The Trello list to which the card of the resolved problem should be assigned
     * 
     */
    @Import(name="resolvedListId")
    private @Nullable Output<String> resolvedListId;

    /**
     * @return The Trello list to which the card of the resolved problem should be assigned
     * 
     */
    public Optional<Output<String>> resolvedListId() {
        return Optional.ofNullable(this.resolvedListId);
    }

    /**
     * The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
     * 
     */
    @Import(name="text")
    private @Nullable Output<String> text;

    /**
     * @return The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
     * 
     */
    public Optional<Output<String>> text() {
        return Optional.ofNullable(this.text);
    }

    private TrelloNotificationState() {}

    private TrelloNotificationState(TrelloNotificationState $) {
        this.active = $.active;
        this.applicationKey = $.applicationKey;
        this.authorizationToken = $.authorizationToken;
        this.boardId = $.boardId;
        this.description = $.description;
        this.legacyId = $.legacyId;
        this.listId = $.listId;
        this.name = $.name;
        this.profile = $.profile;
        this.resolvedListId = $.resolvedListId;
        this.text = $.text;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(TrelloNotificationState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private TrelloNotificationState $;

        public Builder() {
            $ = new TrelloNotificationState();
        }

        public Builder(TrelloNotificationState defaults) {
            $ = new TrelloNotificationState(Objects.requireNonNull(defaults));
        }

        /**
         * @param active The configuration is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder active(@Nullable Output<Boolean> active) {
            $.active = active;
            return this;
        }

        /**
         * @param active The configuration is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder active(Boolean active) {
            return active(Output.of(active));
        }

        /**
         * @param applicationKey The application key for the Trello account
         * 
         * @return builder
         * 
         */
        public Builder applicationKey(@Nullable Output<String> applicationKey) {
            $.applicationKey = applicationKey;
            return this;
        }

        /**
         * @param applicationKey The application key for the Trello account
         * 
         * @return builder
         * 
         */
        public Builder applicationKey(String applicationKey) {
            return applicationKey(Output.of(applicationKey));
        }

        /**
         * @param authorizationToken The application token for the Trello account
         * 
         * @return builder
         * 
         */
        public Builder authorizationToken(@Nullable Output<String> authorizationToken) {
            $.authorizationToken = authorizationToken;
            return this;
        }

        /**
         * @param authorizationToken The application token for the Trello account
         * 
         * @return builder
         * 
         */
        public Builder authorizationToken(String authorizationToken) {
            return authorizationToken(Output.of(authorizationToken));
        }

        /**
         * @param boardId The Trello board to which the card should be assigned
         * 
         * @return builder
         * 
         */
        public Builder boardId(@Nullable Output<String> boardId) {
            $.boardId = boardId;
            return this;
        }

        /**
         * @param boardId The Trello board to which the card should be assigned
         * 
         * @return builder
         * 
         */
        public Builder boardId(String boardId) {
            return boardId(Output.of(boardId));
        }

        /**
         * @param description The description of the Trello card.   You can use same placeholders as in card text
         * 
         * @return builder
         * 
         */
        public Builder description(@Nullable Output<String> description) {
            $.description = description;
            return this;
        }

        /**
         * @param description The description of the Trello card.   You can use same placeholders as in card text
         * 
         * @return builder
         * 
         */
        public Builder description(String description) {
            return description(Output.of(description));
        }

        /**
         * @param legacyId The ID of these settings when referred to from resources requiring the REST API V1 keys
         * 
         * @return builder
         * 
         */
        public Builder legacyId(@Nullable Output<String> legacyId) {
            $.legacyId = legacyId;
            return this;
        }

        /**
         * @param legacyId The ID of these settings when referred to from resources requiring the REST API V1 keys
         * 
         * @return builder
         * 
         */
        public Builder legacyId(String legacyId) {
            return legacyId(Output.of(legacyId));
        }

        /**
         * @param listId The Trello list to which the card should be assigned
         * 
         * @return builder
         * 
         */
        public Builder listId(@Nullable Output<String> listId) {
            $.listId = listId;
            return this;
        }

        /**
         * @param listId The Trello list to which the card should be assigned
         * 
         * @return builder
         * 
         */
        public Builder listId(String listId) {
            return listId(Output.of(listId));
        }

        /**
         * @param name The name of the notification configuration
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable Output<String> name) {
            $.name = name;
            return this;
        }

        /**
         * @param name The name of the notification configuration
         * 
         * @return builder
         * 
         */
        public Builder name(String name) {
            return name(Output.of(name));
        }

        /**
         * @param profile The ID of the associated alerting profile
         * 
         * @return builder
         * 
         */
        public Builder profile(@Nullable Output<String> profile) {
            $.profile = profile;
            return this;
        }

        /**
         * @param profile The ID of the associated alerting profile
         * 
         * @return builder
         * 
         */
        public Builder profile(String profile) {
            return profile(Output.of(profile));
        }

        /**
         * @param resolvedListId The Trello list to which the card of the resolved problem should be assigned
         * 
         * @return builder
         * 
         */
        public Builder resolvedListId(@Nullable Output<String> resolvedListId) {
            $.resolvedListId = resolvedListId;
            return this;
        }

        /**
         * @param resolvedListId The Trello list to which the card of the resolved problem should be assigned
         * 
         * @return builder
         * 
         */
        public Builder resolvedListId(String resolvedListId) {
            return resolvedListId(Output.of(resolvedListId));
        }

        /**
         * @param text The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
         * 
         * @return builder
         * 
         */
        public Builder text(@Nullable Output<String> text) {
            $.text = text;
            return this;
        }

        /**
         * @param text The text of the generated Trello card.  You can use the following placeholders:  * `{ImpactedEntity}`: The entity impacted by the problem or *X* impacted entities.  * `{PID}`: The ID of the reported problem.  * `{ProblemDetailsMarkdown}`: All problem event details, including root cause, as a [Markdown-formatted](https://www.markdownguide.org/cheat-sheet/) string.  * `{ProblemID}`: The display number of the reported problem.  * `{ProblemImpact}`: The [impact level](https://www.dynatrace.com/support/help/shortlink/impact-analysis) of the problem. Possible values are `APPLICATION`, `SERVICE`, and `INFRASTRUCTURE`.  * `{ProblemSeverity}`: The [severity level](https://www.dynatrace.com/support/help/shortlink/event-types) of the problem. Possible values are `AVAILABILITY`, `ERROR`, `PERFORMANCE`, `RESOURCE_CONTENTION`, and `CUSTOM_ALERT`.  * `{ProblemTitle}`: A short description of the problem.  * `{ProblemURL}`: The URL of the problem within Dynatrace.  * `{State}`: The state of the problem. Possible values are `OPEN` and `RESOLVED`.  * `{Tags}`: The list of tags that are defined for all impacted entities, separated by commas
         * 
         * @return builder
         * 
         */
        public Builder text(String text) {
            return text(Output.of(text));
        }

        public TrelloNotificationState build() {
            return $;
        }
    }

}