# Conventions

This section explains several conventions used in the API documentation.

## Symbols

This documentation uses some symbols for illustration purposes. Before you read
on, please make sure you've made yourself familiar with the following list of
conventions:

### <!-- tc:version --> – Version { data-toc-label="Version" }

The tag symbol in conjunction with a version number denotes when a specific
feature or behavior was added. Make sure you're at least on this version
if you want to use it.

### <!-- tc:default --> – Default value { #default data-toc-label="Default value" }

Some API method arguments or configuration properties will have default values when one is not
explicitly defined for them. The default value of the property is always included.

#### <!-- tc:default computed --> – Default value is computed { #default data-toc-label="is computed" }

Some default values are not set to static values but computed from other values,
like the site language, repository provider, or other settings.

#### <!-- tc:default none --> – Default value is empty { #default data-toc-label="is empty" }

Some properties do not contain default values. This means that the functionality
that is associated with them is not available unless explicitly enabled.

### <!-- tc:feature --> – Optional feature { #feature data-toc-label="Optional feature" }

Most of the features are hidden behind feature flags, which means they must
be explicitly enabled via configuration. This allows for the existence of
potentially orthogonal features.

### <!-- tc:flag experimental --> – Experimental { data-toc-label="Experimental" }

Some newer features are still considered experimental, which means they might
(although rarely) change at any time, including their complete removal (which
hasn't happened yet).

### <!-- tc:flag required --> – Required value { #required data-toc-label="Required value" }

Some configuration properties or settings are required, which means they must explicitly be defined.
