# Azure Communication Service User Token Configuration client library for Java

> see https://aka.ms/autorest

## Getting Started

To build the SDK for User Token Management Service Client, simply [Install AutoRest](https://aka.ms/autorest/install) and in this folder, run:

### Setup
```ps
Fork and clone https://github.com/Azure/autorest.java
git checkout v4
git submodule update --init --recursive
mvn package -Dlocal
npm install
npm install -g autorest
```

### Generation

There is one swagger for User Token management APIs.

```ps
cd <swagger-folder>
autorest ChatSwervice_README.md --java --v4 --use=@autorest/java@4.0.0
```

## Update generated files for user token configuration service
To update generated files for user token configuration service, run the following command

> autorest ChatService_README.md --java --v4 --use=@autorest/java@4.0.0

To update generated files for user token configuration service using local build, run the following command

> autorest ChatService_README.md --java --v4 --use=C:\Users\jiach\GitRepos\JPAutoRestJava

The generated code contains some minor issues that need to be fixed manually.

### Code generation settings
``` yaml
input-file: ./chatSwagger.json
java: true
output-folder: ./Chat
license-header: MICROSOFT_MIT_SMALL
override-client-name: ChatServiceClient
namespace: com.azure.communication.chat
custom-types-subpackage: models
generate-client-interfaces: false
generate-client-as-impl: false
generate-sync-async-clients: true
sync-methods: all
add-context-parameter: false
context-client-method-parameter: false
enable-xml: false
```
