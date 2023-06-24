# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

## [3.0.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v2.1.0...v3.0.0) (2023-06-24)


### ⚠ BREAKING CHANGES

* **kernel:** All IWriters must return an IExecutionResult to better indicate conventional errors from actual exceptions

### Features

* **kernel:** Enforce IExecutionResult on IWriter ([a0f54e3](https://github.com/myprysm/myprysm-dotnet-commons/commit/a0f54e330ceb5aab3a31a1d951d5c3f2fe140553))

## [2.1.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v2.0.0...v2.1.0) (2023-06-24)


### Features

* **kernel:** Add more specific failed execution results ([b77d2b3](https://github.com/myprysm/myprysm-dotnet-commons/commit/b77d2b3c489e616294b30af6cb6e4dc3975d14d4))

## [2.0.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.5.0...v2.0.0) (2023-06-24)


### ⚠ BREAKING CHANGES

* **kernel:** IReader implementations must explicitly expose whether the result can be null.
It means that any code using nullable reference type may break because the reader interface doesn't declare anymore that the result may be null

### Bug Fixes

* **build:** Adjust Github Publish action for nuget api key injection ([5973938](https://github.com/myprysm/myprysm-dotnet-commons/commit/597393814d8cf955fb331f436a9c558aa09f65f9))
* **kernel:** Remove optional constraint on IReader ([2e6359d](https://github.com/myprysm/myprysm-dotnet-commons/commit/2e6359d9d1d1045880e5a3047abc7695556ab7aa))

## [1.5.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.4.1...v1.5.0) (2022-12-03)


### Features

* Upgrade to net7.0 with centrally managed versions ([7fd72b4](https://github.com/myprysm/myprysm-dotnet-commons/commit/7fd72b417832d992995643b3428789c1e7d2ccca))

### [1.4.1](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.4.0...v1.4.1) (2022-03-15)


### Bug Fixes

* **image:** Pass cancellation token when detecting format or loading image ([b822ffe](https://github.com/myprysm/myprysm-dotnet-commons/commit/b822ffe7c5a5baaf995c67f6259e19afdcfbb30c))

## [1.4.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.3.0...v1.4.0) (2022-03-14)


### Features

* **image:** Upgrade ImageSharp to 2.0 ([a3d84bc](https://github.com/myprysm/myprysm-dotnet-commons/commit/a3d84bcffc1823746f09af8f6bb7a1df7c7d8725))

## [1.3.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.2.0...v1.3.0) (2022-01-05)


### Features

* **converter:** Add System.Text.Json implementation ([9fb9a64](https://github.com/myprysm/myprysm-dotnet-commons/commit/9fb9a64eb3de45e7adeebf03fe8647f5b783a822))

## [1.2.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.1.0...v1.2.0) (2021-12-22)


### Features

* **pubsub:** Handle publication headers ([a63de43](https://github.com/myprysm/myprysm-dotnet-commons/commit/a63de439f7b9417506d4d45fbeaba29d27b9c717))

## [1.1.0](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.0.2...v1.1.0) (2021-12-10)


### Features

* **testing:** Add `Myprysm.AspNetCore.Testing` for easier API testing ([9661885](https://github.com/myprysm/myprysm-dotnet-commons/commit/9661885f32cd428b29adf3ebe8de69b606215ed1))

### [1.0.2](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.0.1...v1.0.2) (2021-12-04)


### Bug Fixes

* **sk:** Reader may return a null result. ([e85adc5](https://github.com/myprysm/myprysm-dotnet-commons/commit/e85adc5f757f6e87c52b3247ead395eb90dbba9f))

### [1.0.1](https://github.com/myprysm/myprysm-dotnet-commons/compare/v1.0.0...v1.0.1) (2021-12-03)

## 1.0.0 (2021-11-27)


### Features

* **tracing:** Add tests for tracer implementations ([1a29b02](https://github.com/myprysm/myprysm-dotnet-commons/commit/1a29b0259783c8fc0e16cf9fac9113c5d5112be6))
* **tracing:** Trace all utilities ([d02c11b](https://github.com/myprysm/myprysm-dotnet-commons/commit/d02c11b89a5df7d12cc53473c9e421625966e25c))
