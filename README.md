# Glitched Out Website Manager

A Windows desktop application for managing content on the [Glitched Out](https://glitchedoutchicago.com) band website without manually editing the site's data files.

> **Status: In development.** The application structure and initial WPF views are being built. The features described below are project goals unless explicitly marked as implemented.

## Overview

Glitched Out Website Manager is a personal project built with **C#**, **Windows Presentation Foundation (WPF)**, and the **Model–View–ViewModel (MVVM)** pattern.

The goal is to provide a straightforward desktop interface for updating the band's website content—particularly upcoming shows, music releases, and photo albums. The website uses static content and JSON data files, so this application is intended to simplify editing that data while keeping the website itself lightweight.

## Planned Features

- **Shows:** Add, edit, and remove upcoming show listings.
- **Releases:** Manage music releases and their associated information.
- **Photo albums:** Organize and update photo album entries.
- **JSON management:** Load and save the data files used by the website.
- **Website deployment (future goal):** Explore a way to redeploy the website after content changes.

These features are **not all implemented yet**.

## Technology

- **Language:** C#
- **Desktop UI:** WPF and XAML
- **Architecture:** MVVM
- **Data format:** JSON (planned content-management workflow)
- **Development environment:** Visual Studio

## Project Structure

The project is organized around MVVM, separating UI layout, application behavior, and content data.

```text
Glitched Out Website Manager/
├── Models/                 # Content models (e.g., shows, releases, albums)
├── ViewModels/             # Presentation logic and UI state
├── Views/                  # WPF/XAML screens
│   ├── Shows/              # Show-management screens, including AddShowView
│   ├── ShowsView.xaml
│   ├── ReleasesView.xaml
│   └── PhotoAlbumsView.xaml
├── Commands/               # Command helpers (e.g., RelayCommand)
├── MainWindow.xaml         # Main application window
└── App.xaml                # Application entry point and resources
```

*Illustrative layout; exact folders and filenames may change as development continues.*

## Development Progress

Initial work includes:

- Establishing the project's overall structure.
- Beginning the XAML layouts for the website-management interface.
- Starting the MVVM setup, including `MainWindowViewModel`.
- Starting a reusable `RelayCommand` implementation for UI commands.

Current development is focused on completing the application's UI, navigation, commands, and data-management functionality.

## Getting Started

The application is currently intended to be built and run from source on **Windows**.

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Open the solution (`.sln`) or project (`.csproj`) in **Visual Studio** with the **.NET desktop development** workload installed.
3. Restore any required dependencies when prompted.
4. Build and run the WPF project using **Start** (`F5`).

> The app is still under development. A complete end-user installation and configuration process has not been established.

## Relationship to the Website

This manager is being developed for the [Glitched Out website](https://glitchedoutchicago.com), a separate static website project. The long-term workflow is to update website content through this desktop app, save the relevant data, and publish those changes to the hosted site.

The website is hosted using **Cloudflare Pages**. Automated deployment from within this manager is a possible future enhancement, not a current capability.

## Roadmap

- [x] Establish initial WPF project structure
- [x] Begin core XAML views
- [x] Begin `MainWindowViewModel` and `RelayCommand`
- [ ] Complete MVVM navigation and command handling
- [ ] Implement show management
- [ ] Implement release management
- [ ] Implement photo album management
- [ ] Implement JSON loading, validation, and saving
- [ ] Add error handling and user feedback
- [ ] Investigate an optional website deployment workflow

## About

This project is being built to support **Glitched Out**, a Chicago punk band, while providing hands-on experience with desktop application development, C#, WPF, and MVVM architecture.

---

*This README will be updated as features are implemented.*
