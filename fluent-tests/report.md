# Java Codegen Report
Generated at 2021-06-24T19:15:32.357462
## Success
<details>
<summary>RP count: 176</summary>

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
- streamanalytics
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
- policyinsights
- reservations
- security

## Failure at Build
- automation
- iotspaces
- monitor
- purview
- softwareplan
- visualstudio

## Logs
<details>
<summary>adhybridhealthservice</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
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
[INFO] Total time:  4.911 s
[INFO] Finished at: 2021-06-24T18:09:36Z
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
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
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
INFORMATION (FluentMapper): Add Inner to response types: [Application, IOsmamPolicy, GroupItem, FlaggedUser, Location, Device, OperationResult, WipeDeviceOperationResult, AndroidMamPolicy, FlaggedEnrolledApp]

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
[INFO] Total time:  2.016 s
[INFO] Finished at: 2021-06-24T18:34:21Z
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
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
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
[INFO] Total time:  4.295 s
[INFO] Finished at: 2021-06-24T18:42:19Z
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
<summary>policyinsights</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyTrackedResourcesQueryResults' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QueryFailure' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QueryFailure-error' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RemediationListResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RemediationDeploymentsListResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RemediationDeployment' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Remediation' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RemediationProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RemediationFilters' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RemediationDeploymentSummary' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorResponse' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorDefinition' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'TypedErrorInfo' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyEventsQueryResults' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QueryFailure' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QueryFailure-error' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyStatesQueryResults' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'SummarizeResults' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Summary' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'SummaryResults' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ComplianceDetail' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyAssignmentSummary' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyDefinitionSummary' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyGroupSummary' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QueryFailure' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'QueryFailure-error' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'OperationsListResults' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Operation' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Operation-display' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyMetadata' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyMetadataSlimProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyMetadataProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'SlimPolicyMetadata' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyMetadataCollection' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorResponse' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorDefinition' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'TypedErrorInfo' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'CheckRestrictionsRequest' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'CheckRestrictionsResourceDetails' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PendingField' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'CheckRestrictionsResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'CheckRestrictionsResult-contentEvaluationResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FieldRestrictions' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'FieldRestriction' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyEvaluationResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PolicyReference' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AttestationListResult' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Attestation' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AttestationProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AttestationEvidence' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorResponse' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorDefinition' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'TypedErrorInfo' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.

WARNING (PreCheck/DuplicateSchema): Duplicate Schema named ErrorResponse -- properties.error.$ref: undefined => "#/components/schemas/schemas:283" 

WARNING (PreCheck/DuplicateSchema): Duplicate Schema named ErrorDefinition -- properties.details.$ref: undefined => "#/components/schemas/schemas:287" 

WARNING (Modeler/MissingType): The schema 'TypedErrorInfo-info' has no type or format information whatsoever. Location:
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-07-01/remediations.json#/components/schemas/TypedErrorInfo-info
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/policyMetadata.json#/components/schemas/TypedErrorInfo-info
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2021-01-01/attestations.json#/components/schemas/TypedErrorInfo-info

WARNING (Modeler/MissingType): The schema 'components·1twbxlw·schemas·policyevent·additionalproperties' has no type or format information whatsoever. Location:
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/policyEvents.json#/components/schemas/components·1twbxlw·schemas·policyevent·additionalproperties

WARNING (Modeler/MissingType): The schema 'components·nwpyyh·schemas·componenteventdetails·additionalproperties' has no type or format information whatsoever. Location:
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/policyEvents.json#/components/schemas/components·nwpyyh·schemas·componenteventdetails·additionalproperties

WARNING (Modeler/MissingType): The schema 'components·1yhb3ub·schemas·policystate·additionalproperties' has no type or format information whatsoever. Location:
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/policyStates.json#/components/schemas/components·1yhb3ub·schemas·policystate·additionalproperties

WARNING (Modeler/MissingType): The schema 'components·hezmy5·schemas·componentstatedetails·additionalproperties' has no type or format information whatsoever. Location:
   file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/policyStates.json#/components/schemas/components·hezmy5·schemas·componentstatedetails·additionalproperties

WARNING (PreNamer/DeduplicateName): Deduplicating schema name: 'ErrorResponse' -> 'ErrorResponseAutoGenerated'

WARNING (PreNamer/DeduplicateName): Deduplicating schema name: 'ErrorDefinition' -> 'ErrorDefinitionAutoGenerated'

WARNING (PreNamer/DeduplicateName): Deduplicating schema name: 'ErrorResponse' -> 'ErrorResponseAutoGenerated2'

WARNING (PreNamer/DeduplicateName): Deduplicating schema name: 'ErrorDefinition' -> 'ErrorDefinitionAutoGenerated2'
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

```
**stderr**
```

ERROR (FluentNamer): Failed to successfully run fluentnamer plugin.
java.lang.NullPointerException
	at com.azure.autorest.preprocessor.tranformer.Transformer.addPagingNextOperation(Transformer.java:293)
	at com.azure.autorest.preprocessor.tranformer.Transformer.transformOperationGroups(Transformer.java:123)
	at com.azure.autorest.preprocessor.tranformer.Transformer.transform(Transformer.java:43)
	at com.azure.autorest.fluentnamer.FluentNamer.transform(FluentNamer.java:125)
	at com.azure.autorest.fluentnamer.FluentNamer.processInternal(FluentNamer.java:62)
	at com.azure.autorest.extension.base.plugin.NewPlugin.process(NewPlugin.java:202)
	at com.azure.autorest.fluentnamer.Main.lambda$main$1(Main.java:19)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$dispatch$2(Connection.java:151)
	at com.azure.autorest.extension.base.jsonrpc.Connection.lambda$process$3(Connection.java:270)
	at java.base/java.util.concurrent.Executors$RunnableAdapter.call(Executors.java:515)
	at java.base/java.util.concurrent.FutureTask.run(FutureTask.java:264)
	at java.base/java.util.concurrent.ThreadPoolExecutor.runWorker(ThreadPoolExecutor.java:1128)
	at java.base/java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:628)
	at java.base/java.lang.Thread.run(Thread.java:829)

  Error: Plugin fluentnamer reported failure.

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
[INFO] Compiling 83 source files to /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/target/classes
[INFO] -------------------------------------------------------------
[ERROR] COMPILATION ERROR : 
[INFO] -------------------------------------------------------------
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/AccountPropertiesSystemData.java:[14,56] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/AccountPropertiesSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/AccountPropertiesSystemData.java:[24,14] cannot find symbol
  symbol: method validate()
[INFO] 3 errors 
[INFO] -------------------------------------------------------------
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  2.815 s
[INFO] Finished at: 2021-06-24T18:50:19Z
[INFO] ------------------------------------------------------------------------
[ERROR] Failed to execute goal org.apache.maven.plugins:maven-compiler-plugin:3.8.1:compile (default-compile) on project azure-resourcemanager-purview: Compilation failure: Compilation failure: 
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/AccountPropertiesSystemData.java:[14,56] cannot inherit from final com.azure.core.management.SystemData
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/AccountPropertiesSystemData.java:[22,5] method does not override or implement a method from a supertype
[ERROR] /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-purview/src/main/java/com/azure/resourcemanager/purview/models/AccountPropertiesSystemData.java:[24,14] cannot find symbol
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
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
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
INFORMATION (FluentMapper): Add Inner to response types: [AvailableScopeProperties, QuotaRequestSubmitResponse201, ReservationOrderResponse, CurrentQuotaLimitBase, QuotaRequestDetails, Catalog, ReservationResponse, CalculatePriceResponse, QuotaRequestOneResourceSubmitResponse, AppliedReservations, ExchangeOperationResultResponse, CalculateExchangeOperationResultResponse, OperationResponse]

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
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
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
<summary>security</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluent' (/home/runner/work/autorest.java/autorest.java/fluentgen)
INFORMATION: > Loading local AutoRest extension '@autorest/java.fluentnamer' (/home/runner/work/autorest.java/autorest.java/fluentgen/../fluentnamer)
INFORMATION: > Loading AutoRest extension '@autorest/modelerfour' (4.18.1->4.18.1)

WARNING (PreCheck/SchemaMissingType): The schema 'ComplianceResultList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'PricingList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AdvancedThreatProtectionProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'TagsResource' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecuritySolutionsList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecuritySolutionAnalyticsModelProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecuritySolutionAnalyticsModelProperties-devicesMetricsItem' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecuritySolutionAnalyticsModelList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecurityAggregatedAlertList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecurityAggregatedRecommendationList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IoTSecurityAggregatedAlertProperties-topDevicesListItem' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'TagsResource' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'WorkspaceSettingList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RegulatoryComplianceStandardList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RegulatoryComplianceControlList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'RegulatoryComplianceAssessmentList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AutomationList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'Rule' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'EffectiveNetworkSecurityGroups' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AdaptiveNetworkHardeningProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AdaptiveNetworkHardening' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'AdaptiveNetworkHardeningsList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ExternalSecuritySolutionList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'DeviceList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'IngestionSettingList' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ConnectionStrings' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'SoftwareProperties' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/SchemaMissingType): The schema 'ErrorAdditionalInfo' with an undefined type and declared properties is a bit ambigious. This has been auto-corrected to 'type:object'

WARNING (PreCheck/CheckDuplicateSchemas): Checking for duplicate schemas, this could take a (long) while.  Run with --verbose for more detail.

WARNING (PreCheck/DuplicateSchema): Duplicate Schema named ExternalSecuritySolutionKind -- type: undefined => "string",properties: {"kind":{"description":"The kind of the external solution","$ref":"#/components/schemas/ExternalSecuritySolutionKind"}} => <none>,enum: undefined => ["CEF","ATA","AAD"],x-ms-enum: undefined => {"name":"ExternalSecuritySolutionKind","modelAsString":true,"values":[{"value":"CEF"},{"value":"ATA"},{"value":"AAD"}]} 

WARNING (PreCheck/DuplicateSchema): Duplicate Schema named AadConnectivityState -- type: undefined => "string",properties: {"connectivityState":{"$ref":"#/components/schemas/AadConnectivityState"}} => <none>,title: undefined => "The connectivity state of the external AAD solution ",enum: undefined => ["Discovered","NotLicensed","Connected"],x-ms-enum: undefined => {"name":"AadConnectivityState","modelAsString":true,"values":[{"value":"Discovered"},{"value":"NotLicensed"},{"value":"Connected"}]} 
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

WARNING (FluentTransformer): Modify parameter 'ascLocation' implementation from CLIENT to METHOD
INFORMATION (SchemaNameNormalization): Override default name, from 'ETag' to 'Etag'

WARNING (SchemaNameNormalization): Rename schema from 'Enum13' to 'TasksTaskUpdateActionType', based on operation group 'Tasks'

WARNING (SchemaNameNormalization): Rename schema from 'Enum15' to 'InformationProtectionPoliciesInformationProtectionPolicyName', based on operation group 'InformationProtectionPolicies'

WARNING (SchemaNameNormalization): Rename schema from 'Enum85' to 'SettingsSettingName', based on operation group 'Settings'

WARNING (NamingConflictResolver): Name conflict of choice with object 'Protocol'
INFORMATION (NamingConflictResolver): Rename choice from 'Protocol' to 'ProtocolValue'

WARNING (NamingConflictResolver): Name conflict of choice with object 'ExternalSecuritySolutionKind'
INFORMATION (NamingConflictResolver): Rename choice from 'ExternalSecuritySolutionKind' to 'ExternalSecuritySolutionKindValue'

WARNING (NamingConflictResolver): Name conflict of choice with object 'Kind'
INFORMATION (NamingConflictResolver): Rename choice from 'Kind' to 'KindValue'

WARNING (NamingConflictResolver): Name conflict of choice with object 'AadConnectivityState'
INFORMATION (NamingConflictResolver): Rename choice from 'AadConnectivityState' to 'AadConnectivityStateValue'
INFORMATION (OperationNameNormalization): Rename operation from 'listBySubscription' to 'list', in operation group 'IotSecuritySolution'
INFORMATION (OperationNameNormalization): Rename operation from 'get' to 'getByResourceGroup', in operation group 'IotSecuritySolution'
INFORMATION (OperationNameNormalization): Rename operation from 'get' to 'getByResourceGroup', in operation group 'Automations'

WARNING (OperationNameNormalization): Conflict operation name found after attempted rename '[list]', in operation group 'AssessmentsMetadata'

WARNING (OperationNameNormalization): Conflict operation name found after attempted rename '[list]', in operation group 'SecureScoreControlDefinitions'
INFORMATION (OperationNameNormalization): Rename operation from 'listBySubscription' to 'list', in operation group 'SoftwareInventories'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'ComplianceResult'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Pricing'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AdvancedThreatProtectionSetting'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'DeviceSecurityGroup'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IoTSecuritySolutionModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IoTSecuritySolutionAnalyticsModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IoTSecurityAggregatedAlert'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IoTSecurityAggregatedRecommendation'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AscLocation'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecurityTask'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AutoProvisioningSetting'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Compliance'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'InformationProtectionPolicy'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecurityContact'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'WorkspaceSetting'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'RegulatoryComplianceStandard'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'RegulatoryComplianceControl'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'RegulatoryComplianceAssessment'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecuritySubAssessment'
INFORMATION (ResourceTypeNormalization): Change parent from 'TrackedResource' to 'Resource', for 'Automation'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'TrackedResource'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AlertsSuppressionRule'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'ServerVulnerabilityAssessment'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecurityAssessmentMetadata'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecurityAssessment'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AdaptiveApplicationControlGroup'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AdaptiveNetworkHardening'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'AllowedConnectionsResource'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'TopologyResource'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'JitNetworkAccessPolicy'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'DiscoveredSecuritySolution'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecuritySolutionsReferenceData'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'ExternalSecuritySolution'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecureScoreItem'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecureScoreControlDetails'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecureScoreControlDefinitionItem'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'SecuritySolution'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'ConnectorSetting'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Scan'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'ScanResult'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'RuleResults'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotDefenderSettingsModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotSensorsModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Device'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'OnPremiseIotSensor'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotSitesModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotAlertModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotAlertType'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotRecommendationModel'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IotRecommendationType'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Alert'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Setting'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'IngestionSetting'
INFORMATION (ResourceTypeNormalization): Change parent from 'Resource' to 'ProxyResource', for 'Software'
INFORMATION (ErrorTypeNormalization): Rename error from 'CloudError' to 'ManagementError'
INFORMATION (SchemaCleanup): Remove unused object schema 'Resource'
INFORMATION (SchemaCleanup): Remove unused object schema 'SecureScoreControlScore'
INFORMATION (SchemaCleanup): Remove unused choice schema 'CreatedByType'
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
INFORMATION (FluentMapper): Add Inner to response types: [AutoProvisioningSetting, ServerVulnerabilityAssessment, IotRecommendationType, ConnectorSetting, Pricing, SecuritySubAssessment, SecureScoreControlDefinitionItem, RegulatoryComplianceAssessment, ScanResult, Automation, SecuritySolution, IngestionSetting, JitNetworkAccessPolicy, IotSitesList, ComplianceResult, RegulatoryComplianceStandard, IoTSecuritySolutionAnalyticsModel, IngestionSettingToken, IotDefenderSettingsModel, IotSensorsModel, AdaptiveNetworkHardening, ServerVulnerabilityAssessmentsList, AdaptiveApplicationControlGroups, IotRecommendationTypeList, DeviceSecurityGroup, Compliance, IotAlertTypeList, IoTSecuritySolutionAnalyticsModelList, IotDefenderSettingsList, Alert, Operation, SecurityAssessment, AdaptiveApplicationControlGroup, ExternalSecuritySolution, PackageDownloads, OnPremiseIotSensorsList, OnPremiseIotSensor, AllowedConnectionsResource, Scans, AutomationValidationStatus, SecuritySolutionsReferenceDataList, Setting, SecurityAssessmentMetadata, DiscoveredSecuritySolution, ConnectionStrings, JitNetworkAccessRequest, RulesResults, RuleResults, IotSensorsList, IoTSecurityAggregatedAlert, PricingList, IoTSecurityAggregatedRecommendation, AlertsSuppressionRule, Device, IotSitesModel, Software, SecurityContact, Scan, SecurityTask, IotRecommendationModel, SecureScoreControlDetails, InformationProtectionPolicy, WorkspaceSetting, AscLocation, IotAlertModel, TopologyResource, IotAlertType, RegulatoryComplianceControl, AdvancedThreatProtectionSetting, IoTSecuritySolutionModel, SecureScoreItem, ScanResults]
INFORMATION (FluentMapper): Add Inner for type 'SecureScoreControlDefinitionItem': []

```
**stderr**
```

ERROR (FluentGen): Failed to successfully run fluentgen plugin java.lang.IllegalArgumentException: discriminator not found in type ExternalSecuritySolution and its parents
java.lang.IllegalArgumentException: discriminator not found in type ExternalSecuritySolution and its parents
	at com.azure.autorest.util.SchemaUtil.getDiscriminatorSerializedName(SchemaUtil.java:101)
	at com.azure.autorest.mapper.ModelMapper.map(ModelMapper.java:165)
	at com.azure.autorest.mapper.ModelMapper.map(ModelMapper.java:181)
	at com.azure.autorest.mapper.ClientMapper.lambda$map$5(ClientMapper.java:100)
	at java.base/java.util.stream.ReferencePipeline$3$1.accept(ReferencePipeline.java:195)
	at java.base/java.util.stream.DistinctOps$1$2.accept(DistinctOps.java:175)
	at java.base/java.util.ArrayList$ArrayListSpliterator.forEachRemaining(ArrayList.java:1655)
	at java.base/java.util.stream.Streams$ConcatSpliterator.forEachRemaining(Streams.java:734)
	at java.base/java.util.stream.AbstractPipeline.copyInto(AbstractPipeline.java:484)
	at java.base/java.util.stream.AbstractPipeline.wrapAndCopyInto(AbstractPipeline.java:474)
	at java.base/java.util.stream.ReduceOps$ReduceOp.evaluateSequential(ReduceOps.java:913)
	at java.base/java.util.stream.AbstractPipeline.evaluate(AbstractPipeline.java:234)
	at java.base/java.util.stream.ReferencePipeline.collect(ReferencePipeline.java:578)
	at com.azure.autorest.mapper.ClientMapper.map(ClientMapper.java:103)
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

FATAL (FluentGen): Unhandled error: discriminator not found in type ExternalSecuritySolution and its parents
java.lang.IllegalArgumentException: discriminator not found in type ExternalSecuritySolution and its parents
	at com.azure.autorest.util.SchemaUtil.getDiscriminatorSerializedName(SchemaUtil.java:101)
	at com.azure.autorest.mapper.ModelMapper.map(ModelMapper.java:165)
	at com.azure.autorest.mapper.ModelMapper.map(ModelMapper.java:181)
	at com.azure.autorest.mapper.ClientMapper.lambda$map$5(ClientMapper.java:100)
	at java.base/java.util.stream.ReferencePipeline$3$1.accept(ReferencePipeline.java:195)
	at java.base/java.util.stream.DistinctOps$1$2.accept(DistinctOps.java:175)
	at java.base/java.util.ArrayList$ArrayListSpliterator.forEachRemaining(ArrayList.java:1655)
	at java.base/java.util.stream.Streams$ConcatSpliterator.forEachRemaining(Streams.java:734)
	at java.base/java.util.stream.AbstractPipeline.copyInto(AbstractPipeline.java:484)
	at java.base/java.util.stream.AbstractPipeline.wrapAndCopyInto(AbstractPipeline.java:474)
	at java.base/java.util.stream.ReduceOps$ReduceOp.evaluateSequential(ReduceOps.java:913)
	at java.base/java.util.stream.AbstractPipeline.evaluate(AbstractPipeline.java:234)
	at java.base/java.util.stream.ReferencePipeline.collect(ReferencePipeline.java:578)
	at com.azure.autorest.mapper.ClientMapper.map(ClientMapper.java:103)
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
<summary>service-map</summary>

**stdout**
```
AutoRest code generation utility [cli version: 3.2.3; node: v14.17.0, max-memory: 2048 MB]
(C) 2018 Microsoft Corporation.
https://aka.ms/autorest
   Loading AutoRest core      '/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist' (3.1.3)
INFORMATION: > Loading local AutoRest extension '@autorest/java' (/home/runner/work/autorest.java/autorest.java)
INFORMATION: > Installing AutoRest extension 'oav' (~0.4.20)
INFORMATION: > Installed AutoRest extension 'oav' (~0.4.20->0.4.70)
INFORMATION: > Installing AutoRest extension '@microsoft.azure/classic-openapi-validator' (~1.1.5)
INFORMATION: > Installed AutoRest extension '@microsoft.azure/classic-openapi-validator' (~1.1.5->1.1.8)
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

WARNING (PreviewVersionOverOneYear/R4024/SDKViolation): The API version:2015-11-01-preview having been in a preview state over one year , please move it to GA or retire.
    - file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json:6:2

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
INFORMATION (FluentMapper): Add Inner to response types: [Port, ClientGroupMembersCount, MachinesSummary, Process, MachineGroup, MapResponse, ClientGroup, Connection, ClientGroupMember, Machine, Liveness]
INFORMATION (FluentGen): Java template for client model
INFORMATION (FluentGen): Process for Fluent Lite, SDK integration disabled
INFORMATION (FluentJavaSettings): Option, string, tag : package-2015-11-preview
INFORMATION (FluentJavaSettings): Option, string, base-folder : .
INFORMATION (FluentJavaSettings): Option, string, output-folder : /home/runner/work/autorest.java/autorest.java/fluent_generated/azure-resourcemanager-service-map
INFORMATION (FluentJavaSettings): Option, string, azure-libraries-for-java-folder : null
INFORMATION (FluentJavaSettings): List of input files : [Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json]
INFORMATION (FluentGen): Write Java
INFORMATION (JavaFormatter): Java version: 11.0.11
INFORMATION (JavaFormatter): Java formatter enabled
INFORMATION (FluentGen): Write Xml
INFORMATION (FluentGen): Write Text

```
**stderr**
```
FATAL: Failed validating: 'file:///home/runner/work/autorest.java/autorest.java/azure-rest-api-specs/specification/service-map/resource-manager/Microsoft.OperationalInsights/preview/2015-11-01-preview/arm-service-map.json', error encountered: TypeError: Cannot read property 'properties' of undefined
FATAL: [object Object]
(node:24533) UnhandledPromiseRejectionWarning: Error: Plugin model-validator reported failure.
    at /home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist/src_lib_autorest-core_ts.js:3015:19
    at ScheduleNode (/home/runner/.autorest/@autorest_core@3.1.3/node_modules/@autorest/core/dist/src_lib_autorest-core_ts.js:1809:33)
(Use `node --trace-warnings ...` to show where the warning was created)
(node:24533) UnhandledPromiseRejectionWarning: Unhandled promise rejection. This error originated either by throwing inside of an async function without a catch block, or by rejecting a promise which was not handled with .catch(). To terminate the node process on unhandled promise rejection, use the CLI flag `--unhandled-rejections=strict` (see https://nodejs.org/api/cli.html#cli_unhandled_rejections_mode). (rejection id: 60)
(node:24533) [DEP0018] DeprecationWarning: Unhandled promise rejections are deprecated. In the future, promise rejections that are not handled will terminate the Node.js process with a non-zero exit code.

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
[INFO] Total time:  2.606 s
[INFO] Finished at: 2021-06-24T19:00:07Z
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
[INFO] Total time:  1.690 s
[INFO] Finished at: 2021-06-24T19:10:14Z
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
