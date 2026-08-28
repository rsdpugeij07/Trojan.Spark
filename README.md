# Trojan.Spark

> ⚠️ **WARNING: MALWARE / DESTRUCTIVE SOFTWARE — DO NOT RUN ON A PRODUCTION SYSTEM**

Trojan.Spark is a malware research project containing code that demonstrates destructive Windows system capabilities.

## ⚠️ Safety Warning

This repository contains code that may:

* Modify Windows Registry data
* Interact with Windows drivers and IOCTLs
* Attempt to trigger system crashes
* Modify or corrupt critical system components
* Interact with the Master Boot Record (MBR)
* Create or modify scheduled tasks and persistence mechanisms

**Do not compile, execute, or deploy this software on a personal, production, or otherwise important computer.**

## Purpose

This repository is intended for **malware analysis, reverse engineering, and security research**.

Researchers should only examine or execute potentially malicious components inside an isolated environment such as:

* An offline virtual machine
* A disposable Windows installation
* A dedicated malware-analysis laboratory
* A sandbox with no access to sensitive data

## Repository Structure

```text
Chris@Spark/
├── Destructive.cs
├── Driver.cs
├── Files.cs
├── RegistryEdits.cs
├── Start.cs
├── TaskScheduling.cs
├── Threads.cs
└── Watchdog.cs
```

The source files implement different components of the malware, including destructive operations, driver interaction, registry manipulation, file operations, task scheduling, and watchdog functionality.

## Disclaimer

This repository is provided for **security research and educational purposes only**.

The authors and contributors are not responsible for damage, data loss, system compromise, or other consequences resulting from the use or execution of this software.

**Never execute unknown malware outside a controlled analysis environment.**
