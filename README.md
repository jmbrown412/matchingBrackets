# matchingBrackets

This project contains a method HasMatchingBrackets, 

```csharp
public bool HasMatchingBrackets(string checkMe)
```
which takes a string and checks that every { has a corresponding }. If so, the method returns true. Otherwise, false is returned.

Tech stack:
1. C#
2. .Net Core 3.1
3. MSTest

Project structure:
1. JobNimbusLib - Business logic layer with the class SUT which has HasMatchingBrackets.
2. JobNimbusLib.Tests - Test project for business logic layer