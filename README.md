
The **core libraries** (`Dew.Math`, `Dew.Signal`, `Dew.Stats`) do *not* require WinForms and may be used in WPF, Avalonia, MAUI, console, or services.  
However, the visualization components shown here are WinForms-hosted.

---

## Trial NuGet Packages and Debugger Requirement

These sample projects reference the **trial editions** of Dew Lab Studio from the public NuGet feed.

Trial mode behavior:
- **Full functionality is available when a debugger is attached** (running inside Visual Studio).
- When run **without** a debugger, trial restrictions apply (reduced performance and evaluation banners).
- To run applications normally outside debugging, a **registered license** is required.

This applies equally to `net8.0-windows7.0` and `net9.0-windows7.0`.

---

## Editions and Platform Model

| Edition | Native Acceleration | Platforms | Use Case |
|--------|---------------------|-----------|----------|
| Dew Lab Studio (Windows) | Yes (AVX/AVX2/AVX-512 accelerated kernels) | Windows x64 | Maximum performance + real-time visualization |
| Dew Lab Studio Core | No native acceleration (managed-only) | Windows / Linux / macOS | Portable analytics, cloud, CI/CD, cross-platform code |
| Dew Lab Studio Linux | Yes (native Linux-optimized runtime) | Linux x64 | HPC compute clusters, scientific pipelines, server workloads |

Switch editions simply by changing the NuGet package reference — user code remains the same.

---

## Installing Evaluation or Full Version

Evaluation packages install via NuGet:

Dew.Lab.Studio  
Dew.Lab.Studio.Core  
Dew.Lab.Studio.Linux

All required native runtimes are resolved automatically at build time; **no manual DLL copying is needed**.

---

## Repository Structure

Each sample application contains multiple focused demonstrations:

- Dense/sparse matrix workflows, solvers, decompositions
- Interpolation, splines, Chebyshev and polynomial approximation
- Regression and inference, probability distributions, Monte-Carlo simulation
- Real-time DSP signal chains, FFT and time-frequency spectrum visualization
- High-speed charting and matrix/statistics visualization using TeeChart extensions

Code samples are concise and directly reusable.

---

## Relationship to .NET Framework Samples

The **.NET Framework** WinForms samples are in a separate repository:

https://github.com/Dew-Research/DewLabStudio-NET-Samples

The separation exists because **TeeChart serialization formats differ** between `.NET Framework` and `.NET (Core)`.

---

## Line Ending Note

Enable **CRLF** when cloning.  
Some sample datasets rely on Windows line endings.

---

## Contributing / Feedback

When reporting issues, include:

- Dew edition (Windows/Core/Linux)
- Runtime t
