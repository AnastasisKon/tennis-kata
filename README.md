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
