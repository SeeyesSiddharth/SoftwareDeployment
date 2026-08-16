# SWE40006 Software Deployment and Evolution - Task 1

**Student:** Shanmukha Siddharth Changalwala

**Student ID:** 104346012

**Unit:** SWE40006 Software Deployment and Evolution

**Declared Target Level:** Task 1.3 (Distinction)

## Overview

Windows Installer (.msi) packaging using WiX Toolset v7, built on native x64 Windows 10 with Visual Studio Community 2026 and the .NET 10 SDK.

Task 1.1 packages a sample console application. Task 1.2 extends this to a custom-built WinForms desktop application. Task 1.3 bundles that application with its external DLL dependencies, authored via WiX v7 automatic file harvesting.

## Contents

| Path | Description |
|---|---|
| `Task1.1-HelloWiX/` | Sample console application and its WiX package |
| `Task1.2-MyApp/` | Custom WinForms application, class library and dependencies |

## Build

    dotnet publish DesktopApp -c Release -o app
    cd Setup
    dotnet build -c Release -p:Platform=x64

## Environment

| Component | Version |
|---|---|
| OS | Windows 10 Home (x64) |
| Visual Studio | Community 2026 (18.9.0) |
| .NET SDK | 10.0.400 |
| WiX Toolset | 7.0.0 |
