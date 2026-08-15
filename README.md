# \# SWE40006 Software Deployment and Evolution - Task 1

# 

# \*\*Student:\*\* Siddharth  

# \*\*Student ID:\*\* 104346012  

# \*\*Unit:\*\* SWE40006 Software Deployment and Evolution  

# \*\*Declared Target Level:\*\* Task 1.3 (Distinction)

# 

# \## Overview

# Windows Installer (.msi) packaging using WiX Toolset v7, built on native

# x64 Windows 10 with Visual Studio Community 2026 and the .NET 10 SDK.

# 

# Task 1.1 packages a sample console application. Task 1.2 extends this to a

# custom-built WinForms desktop application. Task 1.3 bundles that application

# together with its external DLL dependencies, authored via WiX v7 automatic

# file harvesting.

# 

# \## Contents

# | Path | Description |

# |---|---|

# | `HelloApp/` | Task 1.1 sample console application source |

# | `Setup/Package.wxs` | WiX package definition (directories, components, feature) |

# | `Setup/Setup.wixproj` | WiX MSBuild SDK project, x64 platform |

# | `screenshots/` | Annotated execution evidence |

# | `TROUBLESHOOTING.md` | Build failures encountered and their resolutions |

# 

# \## Build

# ```

# dotnet publish HelloApp -c Release -o app

# cd Setup

# dotnet build -c Release -p:Platform=x64

# ```

# Output: `Setup/bin/x64/Release/HelloWiX.msi`

# 

# \## Environment

# | Component | Version |

# |---|---|

# | OS | Windows 10 Home (x64) |

# | Visual Studio | Community 2026 (18.9.0) |

# | .NET SDK | 10.0.400 |

# | WiX Toolset | 7.0.0 |

