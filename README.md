# FlorAll

FlorAll is a cross-platform mobile app built with Xamarin.Forms that targets Android, iOS, and Windows Mobile (UWP). It shares a single C# codebase for UI, navigation, and data access, and uses platform-specific projects for native bootstrapping and renderers. The project is structured as a social, community-style app centered on flowers, sharing, and events, with Portuguese UI text.

## Why this project stands out
- Cross-platform delivery with a shared Xamarin.Forms UI and platform projects for Android, iOS, and UWP.
- MVVM structure with view models, bindable UI, and service abstractions for navigation and messaging.
- Clean separation of concerns: UI (Views), state/logic (ViewModels), and data transport (ClientHTTP/BLL).
- REST/JSON integration using HttpClient + Newtonsoft.Json with reusable CRUD helpers.
- Custom Android renderers to control native visuals for Entry and Picker controls.

## Product scope and UX flows
The codebase includes a full set of pages and models that outline a social sharing product:
- Onboarding and welcome screen with a data preload step (countries API).
- Login and account creation flows with validation and loading states.
- Share flows for categories/subcategories, share details, and flower color selection.
- Feed, search, profile, and panel creation screens (UI scaffolding in place).
- Domain modeling for activities, feeds, shares, comments, likes, publicities, panels, and more.

## Architecture overview
- **Shared core (PCL)** in `FlorAll/FlorAll` with XAML views, view models, and data services.
- **MVVM pattern** via `NotifyBase`/`ViewModelBase` and Xamarin.Forms data binding.
- **DependencyService** for lightweight service injection (navigation + user messaging).
- **ClientHTTP layer** with reusable `GetAll`, `Add`, `Update`, and `Delete` methods.
- **Platform projects** for Android, iOS, and UWP that host the shared app and provide renderers/assets.

## Tech stack
- C# and .NET (PCL Profile 259)
- Xamarin.Forms 2.3 (shared UI)
- Xamarin.Android Support Libraries 25.x
- Xamarin.iOS 10 target
- UWP 10 (Windows 10 SDK 15063)
- Newtonsoft.Json, ModernHttpClient, Microsoft.Net.Http

## Project layout
- `FlorAll/FlorAll`: shared UI, ViewModels, domain models, and HTTP/BLL services
- `FlorAll/FlorAll.Android`: Android entry point, assets, and custom renderers
- `FlorAll/FlorAll.iOS`: iOS entry point and resources
- `FlorAll/FlorAll.UWP`: UWP entry point and package assets

## Notable implementation details
- `ClientHTTP/DataServices.cs` provides consistent REST calls with token headers and JSON serialization.
- `ViewModels/ViewModelBase.cs` exposes `IsLoading`/`IsNotLoading` for responsive UI state.
- `Views/Services/NavigationService.cs` centralizes navigation changes per flow.
- `MyEntry` and `MyPicker` are custom controls with Android renderers for consistent styling.

## Running the solution
Open `FlorAll.sln` in Visual Studio with Xamarin and UWP workloads installed, restore NuGet packages, and select the desired platform project as startup (Android/iOS/UWP).