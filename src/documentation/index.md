---
title: .NET suite for Android
_description: Main page of .NET suite for Android
---

# Netdroid: .NET suite for Android

Netdroid is a comprehensive suite of libraries and tools to use Android and .NET side-by-side.

### Project disclaimer

Netdroid is an .NET suite for Android, curated by MASES Group, can be supported by the open-source community.

Its primary scope is to support other, public or internal, MASES Group projects: open-source community and commercial entities can use it for their needs and support this project, moreover there are dedicated community and commercial subscription plans.

The repository code and releases may contain bugs, the release cycle depends from Android SDK release cycle, critical discovered issues and/or enhancement requested from this or other projects.

Looking for the help of Android experts? MASES Group can help you design, build, deploy, and manage Android based applications.

---

## Scope of the project

This project aims to create a set of libraries and tools to direct access, from .NET, all the features available in the [Android SDK](https://developer.android.com/). 

### Community and Contribution

Do you like the project? 
- Request your free [community subscription](https://www.jcobridge.com/pricing-25/).

Do you want to help us?
- put a :star: on this project
- open [issues](https://github.com/masesgroup/netdroid/issues) to request features or report bugs :bug:
- improves the project with Pull Requests

This project adheres to the Contributor [Covenant code of conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to coc_reporting@masesgroup.com.

## Summary

* [Roadmap](articles/roadmap.md)
* [Current state](articles/currentstate.md)
* [Usage](articles/usage.md)
* [APIs extensibility](articles/API_extensibility.md)
* [JVM callbacks](articles/jvm_callbacks.md)

---

## Runtime engine

netdroid uses [JCOBridge](https://www.jcobridge.com/), and its [features](https://www.jcobridge.com/features/), to obtain many benefits:
* **Cyber-security**: 
  * [JVM](https://en.wikipedia.org/wiki/Java_virtual_machine) and [CLR, or CoreCLR,](https://en.wikipedia.org/wiki/Common_Language_Runtime) runs in the same process, but are insulated from each other;
  * JCOBridge does not make any code injection into JVM;
  * JCOBridge does not use any other communication mechanism than JNI;
  * .NET (CLR) inherently inherits the cyber-security levels of running JVM and Android SDK; 
* **Direct access the JVM from any .NET application**: 
  * Any JVM class behind Android SDK can be directly managed;
  * No need to learn new APIs: we try to expose the same APIs in C# style;
  * No extra validation cycle on protocol and functionality: bug fix, improvements, new features are immediately available;
  * Documentation is shared;
* **Dynamic code**: it helps to write a Java/Scala/Kotlin/etc seamless language code directly inside a standard .NET application written in C#/VB.NET: look at this [simple example](https://www.jcobridge.com/net-examples/dotnet-examples/) and [APIs extensibility](src/documentation/articles/API_extensibility.md).

### JCOBridge resources

Have a look at the following JCOBridge resources:
- [Release notes](https://www.jcobridge.com/release-notes/)
- [Community Edition](https://www.jcobridge.com/pricing-25/)
- [Commercial Edition](https://www.jcobridge.com/pricing-25/)
- Latest release: [![JCOBridge nuget](https://img.shields.io/nuget/v/MASES.JCOBridge)](https://www.nuget.org/packages/MASES.JCOBridge)
