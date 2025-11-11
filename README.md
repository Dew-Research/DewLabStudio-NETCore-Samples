<a href="https://www.dewresearch.com/products/mtxvec/mtxvec-for-delphi-c-builder">
<img align="right" src="https://www.dewresearch.com/images/Dew.png" width="128">
</a>

# Dew Lab Studio .NET Core — WinForms Sample Projects (net8.0-windows7.0 / net9.0-windows7.0)

This repository provides WinForms-based sample applications demonstrating how to use Dew Lab Studio under modern .NET runtimes. The samples cover numerical computing, real-time signal processing, statistical modeling, and high-performance visualization.

These sample applications use:

- Dew.Math — vector and matrix computation, dense & sparse linear algebra, solvers, special functions, distributions.
- Dew.Signal — DSP processing workflows, FFT analysis, filtering, sample-rate conversion, streaming, time-frequency displays.
- Dew.Stats — statistical inference, regression, probability modeling, stochastic simulation, hypothesis testing.

Visualization uses:

- Dew.Math.TeePro
- Dew.Signal.Tee
- Dew.Stats.Tee

Since these visualization components extend TeeChart, **all sample projects in this repository are WinForms applications**.

---

## Target Frameworks and UI Requirements

These samples target:

- net8.0-windows7.0
- net9.0-windows7.0

Each project includes:

<TargetFramework>net8.0-windows7.0</TargetFramework> or <TargetFramework>net9.0-windows7.0</TargetFramework>  
<UseWindowsForms>true</UseWindowsForms>

The core libraries (Dew.Math, Dew.Signal, Dew.Stats) are UI-agnostic and can also be used in WPF, Avalonia, MAUI, services, or console applications. Only the visualization samples require WinForms hosting.

---

## Trial NuGet Packages and Debugger Requirement

These samples reference the **trial versions** of Dew Lab Studio available from the public NuGet feed.

Trial mode behavior:

- Full functionality runs **when a debugger is attached** (for example, inside Visual Studio).
- When run **without** a debugger, trial restrictions activate (reduced speed + evaluation messages).
- To run applications normally outside debugging, a **registered license** is required.

---

## Editions and Platform Model

| Edition | Native Acceleration | Platforms | Use Case |
|--------|---------------------|-----------|----------|
| Dew Lab Studio (Windows) | Yes — **AVX2 / AVX-512** optimized native kernels | Windows x64 | Maximum performance with real-time visualization |
| Dew Lab Studio Core | No native acceleration (managed-only) | Windows / Linux / macOS | Portable analytics, cloud, CI/CD builds, shared code |
| Dew Lab Studio Linux | Yes — **AVX2 / AVX-512** optimized native kernels | Linux x64 | HPC compute nodes, cluster workloads, scientific pipelines |

The same user code works across editions. Switching only requires changing the NuGet package reference.

---

## Installing Evaluation or Full Version

Install via NuGet:

Dew.Lab.Studio  
Dew.Lab.Studio.Core  
Dew.Lab.Studio.Linux

Native runtimes are resolved automatically during build — **no manual DLL copying is required**.

---

## Repository Structure

Each sample application contains multiple focused demonstrations:

- Dense & sparse matrix factorizations and solvers
- Interpolation, splines, Chebyshev and polynomial approximation
- Regression and inference, distribution modeling, Monte-Carlo simulation
- Real-time DSP processing, FFT visualization, filtering, multirate processing
- High-speed signal and matrix visualization using TeeChart extensions

All code examples are concise and ready to copy into production applications.

---

## Relationship to .NET Framework Samples

The .NET Framework WinForms samples are located in a different repository:

https://github.com/Dew-Research/DewLabStudio-NET-Samples

The separation is required because TeeChart serialization formats differ between .NET Framework and .NET (Core).

---

## Line Ending Note

Enable CRLF when cloning. Some test datasets rely on Windows line endings.

---

## Contributing / Feedback

If reporting performance or behavior issues, include:

- Dew edition used (Windows / Core / Linux)
- Runtime target (net8.0-windows7.0 or net9.0-windows7.0)
- OS version
- CPU model (relevant for AVX2 / AVX-512 dispatch behavior)

Pull requests for new demonstrations are welcome.
