# Java Codegen Report
Generated at 2021-07-22T19:33:22.991795
## Success
<details>
<summary>RP count: 178</summary>

- EnterpriseKnowledgeGraph
- addons
- adp
- advisor
- agrifood
- alertsmanagement
- analysisservices
- apimanagement
- appconfiguration
- applicationinsights
- appplatform
- attestation
- authorization
- automanage
- azure-kusto
- azureactivedirectory
- azurearcdata
- azuredata
- azurestack
- azurestackhci
- baremetalinfrastructure
- batch
- billing
- blockchain
- blueprint
- botservice
- cdn
- changeanalysis
- cloudshell
- cognitiveservices
- commerce
- communication
- compute
- confidentialledger
- confluent
- consumption
- containerinstance
- containerregistry
- containerservice
- cosmos-db
- cost-management
- cpim
- customer-insights
- customerlockbox
- customproviders
- databox
- databoxedge
- databricks
- datacatalog
- datadog
- datafactory
- datalake-analytics
- datalake-store
- datamigration
- dataprotection
- datashare
- deploymentmanager
- desktopvirtualization
- deviceprovisioningservices
- deviceupdate
- devops
- devspaces
- devtestlabs
- dfp
- digitaltwins
- dnc
- dns
- domainservices
- edgeorder
- edgeorderpartner
- elastic
- engagementfabric
- eventgrid
- eventhub
- extendedlocation
- fluidrelay
- frontdoor
- guestconfiguration
- hanaonazure
- hardwaresecuritymodules
- hdinsight
- healthbot
- healthcareapis
- hybridcompute
- hybriddatamanager
- hybridkubernetes
- hybridnetwork
- imagebuilder
- iotcentral
- iothub
- iotsecurity
- keyvault
- kubernetesconfiguration
- labservices
- logic
- logz
- m365securityandcompliance
- machinelearningcompute
- machinelearningexperimentation
- machinelearningservices
- maintenance
- managednetwork
- managedservices
- managementgroups
- managementpartner
- maps
- mariadb
- marketplace
- marketplacenotifications
- marketplaceordering
- mediaservices
- migrate
- migrateprojects
- mixedreality
- msi
- mysql
- netapp
- network
- notificationhubs
- operationalinsights
- operationsmanagement
- peering
- policyinsights
- portal
- postgresql
- postgresqlhsc
- powerbidedicated
- powerbiembedded
- powerplatform
- privatedns
- providerhub
- quantum
- quota
- recoveryservices
- recoveryservicesbackup
- recoveryservicessiterecovery
- redhatopenshift
- redis
- redisenterprise
- relay
- resourcegraph
- resourcehealth
- resourcemover
- saas
- scheduler
- search
- security
- securityandcompliance
- securityinsights
- serialconsole
- servicebus
- servicefabric
- servicefabricmanagedclusters
- servicefabricmesh
- signalr
- sql
- sqlvirtualmachine
- storSimple1200Series
- storage
- storagecache
- storageimportexport
- storagepool
- storagesync
- storsimple8000series
- subscription
- support
- synapse
- testbase
- timeseriesinsights
- trafficmanager
- videoanalyzer
- vmware
- vmwarecloudsimple
- web
- webpubsub
- windowsesu
- windowsiot
- workloadmonitor
</details>

## Failure at Codegen
- reservations

## Failure at Build
- automation
- iotspaces
- monitor
- purview
- softwareplan
- streamanalytics
- visualstudio

## Logs
<details>
<summary>adhybridhealthservice</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.3.2; node: v14.17.3]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
NOTE: AutoRest core version selected from configuration: 3.1.3.
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)

WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.

```
**stderr**
```
FATAL: Error: Name is empty!
  Error: Plugin pre-namer reported failure.

```
</details>

<details>
<summary>automation</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] -----< com.azure.resourcemanager:azure-resourcemanager-automation >-----
[INFO] Building Microsoft Azure SDK for Automation Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-automation ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-automation ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 480 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/java/com/azure/resourcemanager/automation/fluent/DscConfigurationsClient.java:[201,27] method update(java.lang.String,java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.automation.fluent.DscConfigurationsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/java/com/azure/resourcemanager/automation/implementation/DscConfigurationsClientImpl.java:[1322,41] method updateAsync(java.lang.String,java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.automation.implementation.DscConfigurationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/java/com/azure/resourcemanager/automation/implementation/DscConfigurationsClientImpl.java:[1348,34] method update(java.lang.String,java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.automation.implementation.DscConfigurationsClientImpl
[INFO] 3 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  5.950 s
[INFO] Finished at: 2021-07-22T18:12:41Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-automation: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/java/com/azure/resourcemanager/automation/fluent/DscConfigurationsClient.java:[201,27] method update(java.lang.String,java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.automation.fluent.DscConfigurationsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/java/com/azure/resourcemanager/automation/implementation/DscConfigurationsClientImpl.java:[1322,41] method updateAsync(java.lang.String,java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.automation.implementation.DscConfigurationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-automation/src/main/java/com/azure/resourcemanager/automation/implementation/DscConfigurationsClientImpl.java:[1348,34] method update(java.lang.String,java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.automation.implementation.DscConfigurationsClientImpl
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>

<details>
<summary>intune</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.3.2; node: v14.17.3]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
NOTE: AutoRest core version selected from configuration: 3.1.3.
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)

WARNING (PreCheck/SchemaMissingType): The schema 'Resource' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Location' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'LocationProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Error' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'LocationCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'GroupsCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'GroupItem' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'GroupProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ApplicationCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Application' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ApplicationProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IOSMAMPolicyCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AndroidMAMPolicyCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'iOSMAMPolicy' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AndroidMAMPolicy' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MAMPolicyAppIdOrGroupIdPayload' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MAMPolicyAppOrGroupIdProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MAMPolicyProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'iOSMAMPolicyProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AndroidMAMPolicyProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'DeviceCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Device' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'DeviceProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'WipeDeviceOperationResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'WipeDeviceOperationResultProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'OperationResultCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'OperationResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'OperationResultProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'operationMetadataProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'StatusesDefault' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'StatusesProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedUserCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedUser' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedUserProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedEnrolledAppCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedEnrolledApp' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedEnrolledAppProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FlaggedEnrolledAppError' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.
INFORMATION (FluentNamer): Load fluent settings
INFORMATION (FluentJavaSettings): Option, string, add-inner : null
INFORMATION (FluentJavaSettings): Option, string, remove-inner : null
INFORMATION (FluentJavaSettings): Option, string, rename-model : null
INFORMATION (FluentJavaSettings): Option, string, remove-model : null
INFORMATION (FluentJavaSettings): Option, string, name-for-ungrouped-operations : null
INFORMATION (FluentJavaSettings): Option, string, pom-file : null
INFORMATION (FluentJavaSettings): Option, string, package-version : null
INFORMATION (FluentJavaSettings): Option, boolean, sdk-integration : null
INFORMATION (FluentNamer): Transform code model
INFORMATION (FluentTransformer): Rename ungrouped operation group to 'ResourceProvider'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'GetLocationByHostName' to 'GetLocationByHostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'userName' to 'username'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'userName' to 'username'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'userName' to 'username'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'userName' to 'username'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'userName' to 'username'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (SchemaNameNormalization): Override default name, from 'hostName' to 'hostname'
INFORMATION (ErrorTypeNormalization): Rename error from 'Error' to 'ManagementError'
INFORMATION (FluentGen): Read YAML
INFORMATION (FluentJavaSettings): Option, string, add-inner : null
INFORMATION (FluentJavaSettings): Option, string, remove-inner : null
INFORMATION (FluentJavaSettings): Option, string, rename-model : null
INFORMATION (FluentJavaSettings): Option, string, remove-model : null
INFORMATION (FluentJavaSettings): Option, string, name-for-ungrouped-operations : null
INFORMATION (FluentJavaSettings): Option, string, pom-file : null
INFORMATION (FluentJavaSettings): Option, string, package-version : null
INFORMATION (FluentJavaSettings): Option, boolean, sdk-integration : null
INFORMATION (FluentGen): Map code model to client model
INFORMATION (FluentMapper): Add Inner to response types: [Location, AndroidMamPolicy, WipeDeviceOperationResult, OperationResult, FlaggedEnrolledApp, FlaggedUser, GroupItem, Device, Application, IOsmamPolicy]

```
**stderr**
```

ERROR (FluentGen): Failed to successfully run fluentgen plugin java.lang.IllegalArgumentException: [JavaCheck/SchemaError] item name value not found among properties of client model StatusesDefault
java.lang.IllegalArgumentException: [JavaCheck/SchemaError] item name value not found among properties of client model StatusesDefault
	at com.azure.autorest.mapper.ClientMethodMapper.map(ClientMethodMapper.java:87)
	at com.azure.autorest.mapper.MethodGroupMapper.map(MethodGroupMapper.java:115)
	at com.azure.autorest.mapper.ServiceClientMapper.map(ServiceClientMapper.java:93)
	at com.azure.autorest.mapper.ClientMapper.map(ClientMapper.java:119)
	at com.azure.autorest.fluent.FluentGen.handleMap(FluentGen.java:145)
	at com.azure.autorest.fluent.FluentGen.processInternal(FluentGen.java:86)
	at com.azure.autorest.extension.base.plugin.NewPlugin.process(NewPlugin.java:202)
	at com.azure.autorest.fluent.Main.lambda$main$1(Main.java:18)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$dispatch$2(Connection.java:151)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$process$3(Connection.java:270)
	at java.base/java.util.concurrent.Executors$RunnableAdapter.call(Executors.java:515)
	at java.base/java.util.concurrent.FutureTask.run(FutureTask.java:264)
	at java.base/java.util.concurrent.ThreadPoolExecutor.runWorker(ThreadPoolExecutor.java:1128)
	at java.base/java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:628)
	at java.base/java.lang.Thread.run(Thread.java:829)

FATAL (FluentGen): Unhandled error: [JavaCheck/SchemaError] item name value not found among properties of client model StatusesDefault
java.lang.IllegalArgumentException: [JavaCheck/SchemaError] item name value not found among properties of client model StatusesDefault
	at com.azure.autorest.mapper.ClientMethodMapper.map(ClientMethodMapper.java:87)
	at com.azure.autorest.mapper.MethodGroupMapper.map(MethodGroupMapper.java:115)
	at com.azure.autorest.mapper.ServiceClientMapper.map(ServiceClientMapper.java:93)
	at com.azure.autorest.mapper.ClientMapper.map(ClientMapper.java:119)
	at com.azure.autorest.fluent.FluentGen.handleMap(FluentGen.java:145)
	at com.azure.autorest.fluent.FluentGen.processInternal(FluentGen.java:86)
	at com.azure.autorest.extension.base.plugin.NewPlugin.process(NewPlugin.java:202)
	at com.azure.autorest.fluent.Main.lambda$main$1(Main.java:18)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$dispatch$2(Connection.java:151)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$process$3(Connection.java:270)
	at java.base/java.util.concurrent.Executors$RunnableAdapter.call(Executors.java:515)
	at java.base/java.util.concurrent.FutureTask.run(FutureTask.java:264)
	at java.base/java.util.concurrent.ThreadPoolExecutor.runWorker(ThreadPoolExecutor.java:1128)
	at java.base/java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:628)
	at java.base/java.lang.Thread.run(Thread.java:829)

  Error: Plugin fluentgen reported failure.

```
</details>

<details>
<summary>iotspaces</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] -----< com.azure.resourcemanager:azure-resourcemanager-iotspaces >------
[INFO] Building Microsoft Azure SDK for IoTSpaces Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-iotspaces ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-iotspaces/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-iotspaces ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 10 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-iotspaces/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-iotspaces/src/main/java/module-info.java:[10,55] package is empty or does not exist: com.azure.resourcemanager.iotspaces.fluent.models
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-iotspaces/src/main/java/module-info.java:[11,48] package is empty or does not exist: com.azure.resourcemanager.iotspaces.models
[INFO] 2 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  2.617 s
[INFO] Finished at: 2021-07-22T18:44:02Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-iotspaces: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-iotspaces/src/main/java/module-info.java:[10,55] package is empty or does not exist: com.azure.resourcemanager.iotspaces.fluent.models
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-iotspaces/src/main/java/module-info.java:[11,48] package is empty or does not exist: com.azure.resourcemanager.iotspaces.models
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>

<details>
<summary>machinelearning</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.3.2; node: v14.17.3]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
NOTE: AutoRest core version selected from configuration: 3.1.3.
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)
[Exception] No input files provided.

Use --help to get help information.

```
**stderr**
```

```
</details>

<details>
<summary>monitor</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] ------< com.azure.resourcemanager:azure-resourcemanager-monitor >-------
[INFO] Building Microsoft Azure SDK for Monitor Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-monitor ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-monitor ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 402 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleResourceSystemData.java:[14,65] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleAssociationProxyOnlyResourceSystemData.java:[14,85] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionEndpointResourceSystemData.java:[14,69] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleResourceSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleResourceSystemData.java:[24,14] cannot find symbol
  symbol: method validate()
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleAssociationProxyOnlyResourceSystemData.java:[24,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleAssociationProxyOnlyResourceSystemData.java:[26,14] cannot find symbol
  symbol: method validate()
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionEndpointResourceSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionEndpointResourceSystemData.java:[24,14] cannot find symbol
  symbol: method validate()
[INFO] 9 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  5.112 s
[INFO] Finished at: 2021-07-22T18:53:42Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-monitor: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleResourceSystemData.java:[14,65] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleAssociationProxyOnlyResourceSystemData.java:[14,85] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionEndpointResourceSystemData.java:[14,69] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleResourceSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleResourceSystemData.java:[24,14] cannot find symbol
[ERROR]   symbol: method validate()
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleAssociationProxyOnlyResourceSystemData.java:[24,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionRuleAssociationProxyOnlyResourceSystemData.java:[26,14] cannot find symbol
[ERROR]   symbol: method validate()
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionEndpointResourceSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-monitor/src/main/java/com/azure/resourcemanager/monitor/models/DataCollectionEndpointResourceSystemData.java:[24,14] cannot find symbol
[ERROR]   symbol: method validate()
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>

<details>
<summary>purview</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] ------< com.azure.resourcemanager:azure-resourcemanager-purview >-------
[INFO] Building Microsoft Azure SDK for Purview Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-purview ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-purview ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 84 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/TrackedResourceSystemData.java:[14,54] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/TrackedResourceSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/TrackedResourceSystemData.java:[24,14] cannot find symbol
  symbol: method validate()
[INFO] 3 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  3.101 s
[INFO] Finished at: 2021-07-22T19:03:18Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-purview: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/TrackedResourceSystemData.java:[14,54] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/TrackedResourceSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/TrackedResourceSystemData.java:[24,14] cannot find symbol
[ERROR]   symbol: method validate()
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>

<details>
<summary>reservations</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.3.2; node: v14.17.3]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
NOTE: AutoRest core version selected from configuration: 3.1.3.
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)

WARNING (PreCheck/SchemaMissingType): The schema 'ResourceName' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QuotaLimits' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QuotaLimitsResponse' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.

WARNING (Modeler/MissingType): The enum schema 'ResourceType' with an undefined type and enum values is ambigious. This has been auto-corrected to 'type:string'

WARNING (Modeler/MissingType): The enum schema 'QuotaRequestState' with an undefined type and enum values is ambigious. This has been auto-corrected to 'type:string'
INFORMATION (FluentNamer): Load fluent settings
INFORMATION (FluentJavaSettings): Option, string, add-inner : null
INFORMATION (FluentJavaSettings): Option, string, remove-inner : null
INFORMATION (FluentJavaSettings): Option, string, rename-model : null
INFORMATION (FluentJavaSettings): Option, string, remove-model : null
INFORMATION (FluentJavaSettings): Option, string, name-for-ungrouped-operations : null
INFORMATION (FluentJavaSettings): Option, string, pom-file : null
INFORMATION (FluentJavaSettings): Option, string, package-version : null
INFORMATION (FluentJavaSettings): Option, boolean, sdk-integration : null
INFORMATION (FluentNamer): Transform code model
INFORMATION (FluentTransformer): Rename ungrouped operation group to 'ResourceProvider'
INFORMATION (SchemaNameNormalization): Override response header, from 'ETag' to 'Etag'
INFORMATION (SchemaNameNormalization): Override response header, from 'ETag' to 'Etag'
INFORMATION (ResourceTypeNormalization): Add parent ProxyResource, for 'ReservationOrderResponse'
INFORMATION (ResourceTypeNormalization): Add parent ProxyResource, for 'ReservationResponse'
INFORMATION (ResourceTypeNormalization): Add parent ProxyResource, for 'QuotaRequestOneResourceSubmitResponse'
INFORMATION (ResourceTypeNormalization): Add parent ProxyResource, for 'QuotaRequestDetails'
INFORMATION (ResourceTypeNormalization): Add parent ProxyResource, for 'QuotaRequestSubmitResponse'
INFORMATION (ErrorTypeNormalization): Rename error from 'Error' to 'ManagementError'
INFORMATION (ErrorTypeNormalization): Rename error from 'ExceptionResponse' to 'ManagementError'
INFORMATION (SchemaCleanup): Remove unused object schema 'ManagementError'
INFORMATION (SchemaCleanup): Remove unused object schema 'ManagementError'
INFORMATION (SchemaCleanup): Remove unused object schema 'ServiceErrorDetail'
INFORMATION (SchemaCleanup): Remove unused object schema 'QuotaLimitsResponse'
INFORMATION (SchemaCleanup): Remove unused object schema 'CreateGenericQuotaRequestParameters'
INFORMATION (SchemaCleanup): Remove unused object schema 'QuotaRequestSubmitResponse'
INFORMATION (SchemaCleanup): Remove unused choice schema 'ErrorResponseCode'
INFORMATION (FluentGen): Read YAML
INFORMATION (FluentJavaSettings): Option, string, add-inner : null
INFORMATION (FluentJavaSettings): Option, string, remove-inner : null
INFORMATION (FluentJavaSettings): Option, string, rename-model : null
INFORMATION (FluentJavaSettings): Option, string, remove-model : null
INFORMATION (FluentJavaSettings): Option, string, name-for-ungrouped-operations : null
INFORMATION (FluentJavaSettings): Option, string, pom-file : null
INFORMATION (FluentJavaSettings): Option, string, package-version : null
INFORMATION (FluentJavaSettings): Option, boolean, sdk-integration : null
INFORMATION (FluentGen): Map code model to client model
INFORMATION (FluentMapper): Add Inner to response types: [CalculatePriceResponse, CalculateExchangeOperationResultResponse, QuotaRequestDetails, CurrentQuotaLimitBase, OperationResponse, Catalog, AvailableScopeProperties, ReservationOrderResponse, AppliedReservations, ExchangeOperationResultResponse, QuotaRequestSubmitResponse201, ReservationResponse, QuotaRequestOneResourceSubmitResponse]

```
**stderr**
```

ERROR (FluentGen): Failed to successfully run fluentgen plugin java.lang.NullPointerException
java.lang.NullPointerException
	at com.azure.autorest.mapper.ChoiceMapper.lambda$map$0(ChoiceMapper.java:64)
	at java.base/java.util.stream.ReferencePipeline$2$1.accept(ReferencePipeline.java:176)
	at java.base/java.util.ArrayList$ArrayListSpliterator.forEachRemaining(ArrayList.java:1655)
	at java.base/java.util.stream.AbstractPipeline.copyInto(AbstractPipeline.java:484)
	at java.base/java.util.stream.AbstractPipeline.wrapAndCopyInto(AbstractPipeline.java:474)
	at java.base/java.util.stream.ReduceOps$ReduceOp.evaluateSequential(ReduceOps.java:913)
	at java.base/java.util.stream.ReduceOps$5.evaluateSequential(ReduceOps.java:257)
	at java.base/java.util.stream.ReduceOps$5.evaluateSequential(ReduceOps.java:248)
	at java.base/java.util.stream.AbstractPipeline.evaluate(AbstractPipeline.java:234)
	at java.base/java.util.stream.ReferencePipeline.count(ReferencePipeline.java:605)
	at com.azure.autorest.mapper.ChoiceMapper.map(ChoiceMapper.java:64)
	at com.azure.autorest.mapper.ClientMapper.map(ClientMapper.java:60)
	at com.azure.autorest.fluent.FluentGen.handleMap(FluentGen.java:145)
	at com.azure.autorest.fluent.FluentGen.processInternal(FluentGen.java:86)
	at com.azure.autorest.extension.base.plugin.NewPlugin.process(NewPlugin.java:202)
	at com.azure.autorest.fluent.Main.lambda$main$1(Main.java:18)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$dispatch$2(Connection.java:151)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$process$3(Connection.java:270)
	at java.base/java.util.concurrent.Executors$RunnableAdapter.call(Executors.java:515)
	at java.base/java.util.concurrent.FutureTask.run(FutureTask.java:264)
	at java.base/java.util.concurrent.ThreadPoolExecutor.runWorker(ThreadPoolExecutor.java:1128)
	at java.base/java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:628)
	at java.base/java.lang.Thread.run(Thread.java:829)

FATAL (FluentGen): Unhandled error: null
java.lang.NullPointerException
	at com.azure.autorest.mapper.ChoiceMapper.lambda$map$0(ChoiceMapper.java:64)
	at java.base/java.util.stream.ReferencePipeline$2$1.accept(ReferencePipeline.java:176)
	at java.base/java.util.ArrayList$ArrayListSpliterator.forEachRemaining(ArrayList.java:1655)
	at java.base/java.util.stream.AbstractPipeline.copyInto(AbstractPipeline.java:484)
	at java.base/java.util.stream.AbstractPipeline.wrapAndCopyInto(AbstractPipeline.java:474)
	at java.base/java.util.stream.ReduceOps$ReduceOp.evaluateSequential(ReduceOps.java:913)
	at java.base/java.util.stream.ReduceOps$5.evaluateSequential(ReduceOps.java:257)
	at java.base/java.util.stream.ReduceOps$5.evaluateSequential(ReduceOps.java:248)
	at java.base/java.util.stream.AbstractPipeline.evaluate(AbstractPipeline.java:234)
	at java.base/java.util.stream.ReferencePipeline.count(ReferencePipeline.java:605)
	at com.azure.autorest.mapper.ChoiceMapper.map(ChoiceMapper.java:64)
	at com.azure.autorest.mapper.ClientMapper.map(ClientMapper.java:60)
	at com.azure.autorest.fluent.FluentGen.handleMap(FluentGen.java:145)
	at com.azure.autorest.fluent.FluentGen.processInternal(FluentGen.java:86)
	at com.azure.autorest.extension.base.plugin.NewPlugin.process(NewPlugin.java:202)
	at com.azure.autorest.fluent.Main.lambda$main$1(Main.java:18)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$dispatch$2(Connection.java:151)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$process$3(Connection.java:270)
	at java.base/java.util.concurrent.Executors$RunnableAdapter.call(Executors.java:515)
	at java.base/java.util.concurrent.FutureTask.run(FutureTask.java:264)
	at java.base/java.util.concurrent.ThreadPoolExecutor.runWorker(ThreadPoolExecutor.java:1128)
	at java.base/java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:628)
	at java.base/java.lang.Thread.run(Thread.java:829)

  Error: Plugin fluentgen reported failure.

```
</details>

<details>
<summary>resources</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.3.2; node: v14.17.3]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
NOTE: AutoRest core version selected from configuration: 3.1.3.
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)
[Exception] No input files provided.

Use --help to get help information.

```
**stderr**
```

```
</details>

<details>
<summary>service-map</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.3.2; node: v14.17.3]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
NOTE: AutoRest core version selected from configuration: 3.1.3.
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Installing AutoRest extension 'oav' (~0.4.20)
INFORMATION: > Installed AutoRest extension 'oav' (~0.4.20->0.4.70)
INFORMATION: > Installing AutoRest extension '@microsoft.azure/classic-openapi-validator' (~1.1.5)
INFORMATION: > Installed AutoRest extension '@microsoft.azure/classic-openapi-validator' (~1.1.5->1.1.9)
INFORMATION: > Installing AutoRest extension '@microsoft.azure/openapi-validator' (~1.7.0)
INFORMATION: > Installed AutoRest extension '@microsoft.azure/openapi-validator' (~1.7.0->1.7.0)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)

WARNING (PreCheck/SchemaMissingType): The schema 'Resource' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ResourceReference' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachineReference' with an undefined type and 'allOf'/'anyOf'/'oneOf' is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ProcessReference' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PortReference' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachineReferenceWithHints' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ClientGroupReference' with an undefined type and 'allOf'/'anyOf'/'oneOf' is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'CoreResource' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Machine' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Process' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Port' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ClientGroup' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ClientGroupMember' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachineGroup' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Summary' with an undefined type and 'allOf'/'anyOf'/'oneOf' is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachinesSummary' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Relationship' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Connection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Acceptor' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RelationshipProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ConnectionProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AcceptorProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Ipv4NetworkInterface' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Ipv6NetworkInterface' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'NetworkConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AgentConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Timezone' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'OperatingSystemConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachineResourcesConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'VirtualMachineConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'HypervisorConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'HostingConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AzureHostingConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AzureCloudServiceConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AzureVmScaleSetConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AzureServiceFabricClusterConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ImageConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ProcessUser' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ProcessDetails' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ProcessHostedService' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ProcessHostingConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AzureProcessHostingConfiguration' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'SingleMachineDependencyMapRequest' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MultipleMachinesMapRequest' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachineListMapRequest' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'MachineGroupMapRequest' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.

WARNING (PreCheck/PropertyRedeclarationWarning): Schema 'MachineGroup' has a property 'etag' that is already declared the parent schema 'CoreResource' but isn't significantly different. The property has been removed from MachineGroup

WARNING (PostOperationIdContainsUrlVerb/R2066/SDKViolation): OperationId should contain the verb: 'generatemap' in:'Maps_Generate'. Consider updating the operationId
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:4591:4

WARNING (PostOperationIdContainsUrlVerb/R2066/SDKViolation): OperationId should contain the verb: 'machinegroups' in:'MachineGroups_Create'. Consider updating the operationId
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:6557:4

WARNING (EnumInsteadOfBoolean/R3018/ARMViolation): Booleans are not descriptive and make them hard to use. Consider using string enums with allowed set of values defined. Property: live
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:58:6

WARNING (EnumInsteadOfBoolean/R3018/ARMViolation): Booleans are not descriptive and make them hard to use. Consider using string enums with allowed set of values defined. Property: live
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:2097:6

WARNING (OperationIdNounVerb/R1001/SDKViolation): Per the Noun_Verb convention for Operation Ids, the noun 'Machines' should not appear after the underscore. Note: If you have already shipped an SDK on top of this spec, fixing this warning may introduce a breaking change.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:3618:4

WARNING (PutInOperationName/R1006/SDKViolation): 'PUT' operation 'MachineGroups_Update' should use method name 'Create'. Note: If you have already shipped an SDK on top of this spec, fixing this warning may introduce a breaking change.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:6750:4

WARNING (PreviewVersionOverOneYear/R4024/SDKViolation): The API version:2015-11-01-preview having been in a preview state over one year , please move it to GA or retire.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:6:2

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: kind
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:6937:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: kind
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:7070:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: kind
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:7434:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: provider
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8039:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: kind
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8046:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: provider
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8306:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: kind
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8313:4

WARNING (XmsEnumValidation/R2018/SDKViolation): The enum types should have x-ms-enum type extension set with appropriate options. Property name: kind
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8450:4

WARNING (DescriptionAndTitleMissing/R4021/SDKViolation): 'properties' model/property lacks 'description' and 'title' property. Consider adding a 'description'/'title' element. Accurate description/title is essential for maintaining reference documentation.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:7419:4

WARNING (DescriptionAndTitleMissing/R4021/SDKViolation): 'properties' model/property lacks 'description' and 'title' property. Consider adding a 'description'/'title' element. Accurate description/title is essential for maintaining reference documentation.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:7456:4

WARNING (DescriptionAndTitleMissing/R4021/SDKViolation): 'properties' model/property lacks 'description' and 'title' property. Consider adding a 'description'/'title' element. Accurate description/title is essential for maintaining reference documentation.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:7471:4

WARNING (DescriptionAndTitleMissing/R4021/SDKViolation): 'nodes' model/property lacks 'description' and 'title' property. Consider adding a 'description'/'title' element. Accurate description/title is essential for maintaining reference documentation.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8398:4

WARNING (DescriptionAndTitleMissing/R4021/SDKViolation): 'edges' model/property lacks 'description' and 'title' property. Consider adding a 'description'/'title' element. Accurate description/title is essential for maintaining reference documentation.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8401:4

WARNING (EnumInsteadOfBoolean/R3018/ARMViolation): Booleans are not descriptive and make them hard to use. Consider using string enums with allowed set of values defined. Property: live
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8424:4

WARNING (EnumInsteadOfBoolean/R3018/ARMViolation): Booleans are not descriptive and make them hard to use. Consider using string enums with allowed set of values defined. Property: filterProcesses
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:8490:4
INFORMATION (FluentNamer): Load fluent settings
INFORMATION (FluentJavaSettings): Option, string, add-inner : null
INFORMATION (FluentJavaSettings): Option, string, remove-inner : null
INFORMATION (FluentJavaSettings): Option, string, rename-model : null
INFORMATION (FluentJavaSettings): Option, string, remove-model : null
INFORMATION (FluentJavaSettings): Option, string, name-for-ungrouped-operations : null
INFORMATION (FluentJavaSettings): Option, string, pom-file : null
INFORMATION (FluentJavaSettings): Option, string, package-version : null
INFORMATION (FluentJavaSettings): Option, boolean, sdk-integration : null
INFORMATION (FluentNamer): Transform code model
INFORMATION (SchemaNameNormalization): Override default name, from 'userName' to 'username'
INFORMATION (SchemaNameNormalization): Create sealed choice 'HostingConfigurationProvider'
INFORMATION (SchemaNameNormalization): Create sealed choice 'ProcessHostingConfigurationProvider'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'CoreResource'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Relationship'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'ClientGroupMember'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Summary'
INFORMATION (ErrorTypeNormalization): Rename error from 'ErrorResponse' to 'ManagementError'
INFORMATION (SchemaCleanup): Remove unused object schema 'Resource'
INFORMATION (SchemaCleanup): Remove unused object schema 'ManagementError'
INFORMATION (FluentGen): Read YAML
INFORMATION (FluentJavaSettings): Option, string, add-inner : null
INFORMATION (FluentJavaSettings): Option, string, remove-inner : null
INFORMATION (FluentJavaSettings): Option, string, rename-model : null
INFORMATION (FluentJavaSettings): Option, string, remove-model : null
INFORMATION (FluentJavaSettings): Option, string, name-for-ungrouped-operations : null
INFORMATION (FluentJavaSettings): Option, string, pom-file : null
INFORMATION (FluentJavaSettings): Option, string, package-version : null
INFORMATION (FluentJavaSettings): Option, boolean, sdk-integration : null
INFORMATION (FluentGen): Map code model to client model
INFORMATION (FluentMapper): Add Inner to response types: [Port, ClientGroupMember, ClientGroup, MapResponse, MachinesSummary, Process, Connection, ClientGroupMembersCount, Machine, MachineGroup, Liveness]
INFORMATION (FluentGen): Java template for client model
INFORMATION (FluentGen): Process for Fluent Lite, SDK integration disabled
INFORMATION (FluentJavaSettings): Option, string, tag : package-2015-11-preview
INFORMATION (FluentJavaSettings): Option, string, base-folder : .
INFORMATION (FluentJavaSettings): Option, string, output-folder : /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-service-map
INFORMATION (FluentJavaSettings): Option, string, azure-libraries-for-java-folder : null
INFORMATION (FluentJavaSettings): List of input files : [Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json]
INFORMATION (FluentGen): Write Java
INFORMATION (JavaFormatter): Java version: 11.0.12
INFORMATION (JavaFormatter): Java formatter enabled
INFORMATION (FluentGen): Write Xml
INFORMATION (FluentGen): Write Text

```
**stderr**
```
FATAL: [object Object]
(node:25245) UnhandledPromiseRejectionWarning: Error: Plugin model-validator reported failure.
    at /home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist/src_lib_autorest-core_ts.js:3015:19
    at ScheduleNode (/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist/src_lib_autorest-core_ts.js:1809:33)
(Use `node --trace-warnings ...` to show where the warning was created)
(node:25245) UnhandledPromiseRejectionWarning: Unhandled promise rejection. This error originated either by throwing inside of an async function without a catch block, or by rejecting a promise which was not handled with .catch(). To terminate the node process on unhandled promise rejection, use the CLI flag `--unhandled-rejections=strict` (see https://nodejs.org/api/cli.html#cli_unhandled_rejections_mode). (rejection id: 60)
(node:25245) [DEP0018] DeprecationWarning: Unhandled promise rejections are deprecated. In the future, promise rejections that are not handled will terminate the Node.js process with a non-zero exit code.
FATAL: Failed validating: 'file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json', error encountered: TypeError: Cannot read property 'properties' of undefined

ERROR (DeleteOperationResponses/R4011/ARMViolation): The delete operation is defined without a 200 or 204 error response implementation,please add it.'
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:6869:4
  Error: Plugin model-validator reported failure.

```
</details>

<details>
<summary>softwareplan</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] ----< com.azure.resourcemanager:azure-resourcemanager-softwareplan >----
[INFO] Building Microsoft Azure SDK for SoftwarePlan Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-softwareplan ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-softwareplan ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 38 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[72,49] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[77,49] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[82,34] method get(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[91,44] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[108,27] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/OperationsClient.java:[53,43] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.OperationsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/OperationsClient.java:[67,43] method list(java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.OperationsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitRevisionsClient.java:[56,47] method list(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitRevisionsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitRevisionsClient.java:[71,47] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitRevisionsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/SoftwarePlansClient.java:[42,10] method register() is already defined in interface com.azure.resourcemanager.softwareplan.fluent.SoftwarePlansClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/SoftwarePlansClient.java:[54,20] method registerWithResponse(com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.SoftwarePlansClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/Operations.java:[47,38] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.Operations
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/Operations.java:[60,38] method list(java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.Operations
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefitRevisions.java:[50,42] method list(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefitRevisions
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefitRevisions.java:[64,42] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefitRevisions
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/SoftwarePlans.java:[37,10] method register() is already defined in interface com.azure.resourcemanager.softwareplan.models.SoftwarePlans
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/SoftwarePlans.java:[48,20] method registerWithResponse(com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.SoftwarePlans
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[176,47] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[191,47] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[206,32] method create(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[222,42] method createWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[238,32] method update(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[254,42] method updateWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[269,32] method get(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[284,42] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[297,10] method delete(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[312,20] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[102,42] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[116,42] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[129,27] method get(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[143,37] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[169,20] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansImpl.java:[35,17] method register() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansImpl.java:[39,27] method registerWithResponse(com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsImpl.java:[40,49] method list(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsImpl.java:[45,49] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsImpl.java:[39,45] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsImpl.java:[44,45] method list(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[262,61] method listSinglePageAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[304,61] method listSinglePageAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[346,51] method listAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[363,51] method listAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[380,54] method list(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[397,54] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[80,52] method list(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl.HybridUseBenefitRevisionsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[186,34] method registerWithResponseAsync() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[220,34] method registerWithResponseAsync(com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[248,24] method registerAsync() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[259,17] method register() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[273,27] method registerWithResponse(com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[71,30] method register(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl.SoftwarePlansService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[244,57] method listSinglePageAsync(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[282,57] method listSinglePageAsync(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[319,47] method listAsync(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[335,47] method listAsync(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[351,50] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[367,50] method list(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[77,39] method list(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl.OperationsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[889,61] method listSinglePageAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[928,61] method listSinglePageAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[967,51] method listAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[982,51] method listAsync(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1000,51] method listAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1016,54] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1034,54] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1051,56] method createWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1092,56] method createWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1130,46] method createAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1155,39] method create(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1173,49] method createWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1191,56] method updateWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1232,56] method updateWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1270,46] method updateAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1295,39] method update(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1313,49] method updateWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1330,56] method getWithResponseAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1363,56] method getWithResponseAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1395,46] method getAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1419,39] method get(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1436,49] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1452,34] method deleteWithResponseAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1486,34] method deleteWithResponseAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1517,24] method deleteAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1532,17] method delete(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1549,27] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[132,52] method list(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[144,52] method create(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[157,52] method update(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[170,52] method get(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[182,30] method delete(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[INFO] 90 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  2.923 s
[INFO] Finished at: 2021-07-22T19:15:18Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-softwareplan: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[72,49] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[77,49] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[82,34] method get(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[91,44] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsImpl.java:[108,27] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/OperationsClient.java:[53,43] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.OperationsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/OperationsClient.java:[67,43] method list(java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.OperationsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitRevisionsClient.java:[56,47] method list(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitRevisionsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitRevisionsClient.java:[71,47] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitRevisionsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/SoftwarePlansClient.java:[42,10] method register() is already defined in interface com.azure.resourcemanager.softwareplan.fluent.SoftwarePlansClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/SoftwarePlansClient.java:[54,20] method registerWithResponse(com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.SoftwarePlansClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/Operations.java:[47,38] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.Operations
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/Operations.java:[60,38] method list(java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.Operations
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefitRevisions.java:[50,42] method list(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefitRevisions
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefitRevisions.java:[64,42] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefitRevisions
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/SoftwarePlans.java:[37,10] method register() is already defined in interface com.azure.resourcemanager.softwareplan.models.SoftwarePlans
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/SoftwarePlans.java:[48,20] method registerWithResponse(com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.SoftwarePlans
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[176,47] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[191,47] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[206,32] method create(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[222,42] method createWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[238,32] method update(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[254,42] method updateWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[269,32] method get(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[284,42] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[297,10] method delete(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/fluent/HybridUseBenefitsClient.java:[312,20] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.fluent.HybridUseBenefitsClient
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[102,42] method list(java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[116,42] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[129,27] method get(java.lang.String,java.lang.String) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[143,37] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/models/HybridUseBenefits.java:[169,20] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.models.HybridUseBenefits
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansImpl.java:[35,17] method register() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansImpl.java:[39,27] method registerWithResponse(com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsImpl.java:[40,49] method list(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsImpl.java:[45,49] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsImpl.java:[39,45] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsImpl.java:[44,45] method list(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[262,61] method listSinglePageAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[304,61] method listSinglePageAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[346,51] method listAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[363,51] method listAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[380,54] method list(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[397,54] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitRevisionsClientImpl.java:[80,52] method list(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitRevisionsClientImpl.HybridUseBenefitRevisionsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[186,34] method registerWithResponseAsync() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[220,34] method registerWithResponseAsync(com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[248,24] method registerAsync() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[259,17] method register() is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[273,27] method registerWithResponse(com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/SoftwarePlansClientImpl.java:[71,30] method register(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.SoftwarePlansClientImpl.SoftwarePlansService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[244,57] method listSinglePageAsync(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[282,57] method listSinglePageAsync(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[319,47] method listAsync(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[335,47] method listAsync(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[351,50] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[367,50] method list(java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/OperationsClientImpl.java:[77,39] method list(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.OperationsClientImpl.OperationsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[889,61] method listSinglePageAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[928,61] method listSinglePageAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[967,51] method listAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[982,51] method listAsync(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1000,51] method listAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1016,54] method list(java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1034,54] method list(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1051,56] method createWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1092,56] method createWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1130,46] method createAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1155,39] method create(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1173,49] method createWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1191,56] method updateWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1232,56] method updateWithResponseAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1270,46] method updateAsync(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1295,39] method update(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1313,49] method updateWithResponse(java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1330,56] method getWithResponseAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1363,56] method getWithResponseAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1395,46] method getAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1419,39] method get(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1436,49] method getWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1452,34] method deleteWithResponseAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1486,34] method deleteWithResponseAsync(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1517,24] method deleteAsync(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1532,17] method delete(java.lang.String,java.lang.String) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[1549,27] method deleteWithResponse(java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in class com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[132,52] method list(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[144,52] method create(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[157,52] method update(java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.resourcemanager.softwareplan.fluent.models.HybridUseBenefitModelInner,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[170,52] method get(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-softwareplan/src/main/java/com/azure/resourcemanager/softwareplan/implementation/HybridUseBenefitsClientImpl.java:[182,30] method delete(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,com.azure.core.util.Context) is already defined in interface com.azure.resourcemanager.softwareplan.implementation.HybridUseBenefitsClientImpl.HybridUseBenefitsService
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>

<details>
<summary>streamanalytics</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] --< com.azure.resourcemanager:azure-resourcemanager-streamanalytics >---
[INFO] Building Microsoft Azure SDK for StreamAnalytics Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-streamanalytics ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-streamanalytics ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 254 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/TestDatasourceResultImpl.java:[24,33] cannot find symbol
  symbol:   method status()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.TestDatasourceResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/QueryTestingResultImpl.java:[24,33] cannot find symbol
  symbol:   method status()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.QueryTestingResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/QueryTestingResultImpl.java:[28,33] cannot find symbol
  symbol:   method outputUri()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.QueryTestingResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[26,33] cannot find symbol
  symbol:   method status()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[30,47] cannot find symbol
  symbol:   method diagnostics()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[39,33] cannot find symbol
  symbol:   method eventsDownloadUrl()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[43,33] cannot find symbol
  symbol:   method lastArrivalTime()
  location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[INFO] 7 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  4.428 s
[INFO] Finished at: 2021-07-22T19:23:33Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-streamanalytics: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/TestDatasourceResultImpl.java:[24,33] cannot find symbol
[ERROR]   symbol:   method status()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.TestDatasourceResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/QueryTestingResultImpl.java:[24,33] cannot find symbol
[ERROR]   symbol:   method status()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.QueryTestingResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/QueryTestingResultImpl.java:[28,33] cannot find symbol
[ERROR]   symbol:   method outputUri()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.QueryTestingResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[26,33] cannot find symbol
[ERROR]   symbol:   method status()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[30,47] cannot find symbol
[ERROR]   symbol:   method diagnostics()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[39,33] cannot find symbol
[ERROR]   symbol:   method eventsDownloadUrl()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-streamanalytics/src/main/java/com/azure/resourcemanager/streamanalytics/implementation/SampleInputResultImpl.java:[43,33] cannot find symbol
[ERROR]   symbol:   method lastArrivalTime()
[ERROR]   location: class com.azure.resourcemanager.streamanalytics.fluent.models.SampleInputResultInner
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>

<details>
<summary>visualstudio</summary>

**stdout**
```
[INFO] Scanning for projects...
[INFO] 
[INFO] ----< com.azure.resourcemanager:azure-resourcemanager-visualstudio >----
[INFO] Building Microsoft Azure SDK for VisualStudio Management 1.0.0-beta.1
[INFO] --------------------------------[ jar ]---------------------------------
[INFO] 
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ azure-resourcemanager-visualstudio ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/resources
[INFO] 
[INFO] --- maven-compiler-plugin:3.8.1:compile (default-compile) @ azure-resourcemanager-visualstudio ---
[INFO] Changes detected - recompiling the module!
[INFO] Compiling 59 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[13,50] <identifier> expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[17,5] ',', '}', or ';' expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[17,9] '}' expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[37,19] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[39,5] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[41,5] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[50,19] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[52,9] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[55,13] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[58,5] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[62,12] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[64,5] class, interface, or enum expected
[INFO] 12 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  1.709 s
[INFO] Finished at: 2021-07-22T19:27:20Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-visualstudio: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[13,50] <identifier> expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[17,5] ',', '}', or ';' expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[17,9] '}' expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[37,19] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[39,5] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[41,5] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[50,19] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[52,9] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[55,13] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[58,5] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[62,12] class, interface, or enum expected
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-visualstudio/src/main/java/com/azure/resourcemanager/visualstudio/models/AccountResourceRequestOperationType.java:[64,5] class, interface, or enum expected
[ERROR] -> [Help 1]
[ERROR] 
[ERROR] To see the full stack trace of the errors, re-run Maven with the -e switch.
[ERROR] Re-run Maven using the -X switch to enable full debug logging.
[ERROR] 
[ERROR] For more information about the errors and possible solutions, please read the following articles:
[ERROR] [Help 1] http://cwiki.apache.org/confluence/display/MAVEN/MojoFailureException

```
**stderr**
```

```
</details>
