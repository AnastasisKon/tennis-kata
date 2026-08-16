# tennis kata

A small C# kata project. This README explains how to build the project and run the tests locally (including from the VS Code terminal).

## Prerequisites

- .NET SDK installed (use the version that matches the project's TargetFramework in the .csproj). Check with:
  ```
  dotnet --version
  ```
- Git (to clone the repo)
- (Optional) Visual Studio Code with the C# extension (ms-dotnettools.csharp). For a test UI, install a Test Explorer extension such as ".NET Test Explorer".

## Quick start (terminal)

1. Clone the repository
   ```
   git clone https://github.com/AnastasisKon/tennis-kata.git
   cd tennis-kata
   ```

2. Restore dependencies
   ```
   dotnet restore
   ```

3. Build
   ```
   dotnet build
   ```

4. Run all tests
   ```
   dotnet test
   ```

Notes:
- If there are multiple test projects, `dotnet test` run from the repo root will discover and run them all. To run a specific test project:
  ```
  dotnet test path/to/Project.Tests/Project.Tests.csproj
  ```

## Running tests from VS Code

1. Open the project folder in VS Code:
   - File → Open Folder → select the repo folder.

2. Install recommended extensions:
   - C# (ms-dotnettools.csharp)
   - .NET Test Explorer (optional) to get a graphical Test Explorer (or use the built-in Test view if available).

3. Use the VS Code Terminal
   - Open Terminal → run the same commands: `dotnet test` (or run a single test from Test Explorer).

4. Use Test Explorer
   - If you installed a Test Explorer extension, tests will appear in the Test Explorer; click Run / Debug for individual tests.

## Running a single test (examples)

- Filter by display name (partial match):
  ```
  dotnet test --filter "DisplayName~MyTestName"
  ```

- Filter by fully qualified name:
  ```
  dotnet test --filter "FullyQualifiedName~Namespace.ClassName.TestMethod"
  ```

- Run a single test project:
  ```
  dotnet test path/to/Project.Tests/Project.Tests.csproj --filter "DisplayName~MyTestName"
  ```

## More detailed output / logging

- Increase console verbosity:
  ```
  dotnet test --logger "console;verbosity=detailed"
  ```

## Troubleshooting

- "SDK not found" or "The .NET SDK required to build this project was not found":
  - Install the correct .NET SDK version (or check the project's TargetFramework in the .csproj).
  - Use `dotnet --info` to inspect installed SDKs.

- "No test is available" / tests not discovered:
  - Ensure the test project references a test framework (xUnit, NUnit, MSTest).
  - Ensure the test project has a supported test SDK package (e.g., Microsoft.NET.Test.Sdk).
  - Run `dotnet test -v n` to see discovery logs.

- Permission or network issues on restore:
  - Check your network/proxy settings and NuGet feeds.

## (Optional) GitHub Actions workflow example

Create `.github/workflows/dotnet.yml` to run tests on push:

```yaml
name: .NET Tests

on: [push, pull_request]

jobs:
  build-and-test:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - name: Setup .NET
        uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '8.x' # change to project SDK if needed
      - name: Restore
        run: dotnet restore
      - name: Build
        run: dotnet build --no-restore --configuration Release
      - name: Test
        run: dotnet test --no-build --configuration Release --logger "trx"
```

## Need this committed?

This README has been added to the repository. If you'd like, I can also add the GitHub Actions workflow file or tailor the README to a specific test framework your project uses — tell me which option.
