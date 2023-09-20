# Find and Replace

This is a console app where a user enters a string, chooses a word in that string and provides a replacement for that word. The method in action looks something like:
```csharp
WordReplacer("Hello world", "world", "universe");
```
The result of which would be `"Hello universe"`.

Following the prompt and implementing **Test Driven Development** in the process, the test sequence followed:

1. Writing a method so that it replaces whole words only, as in the `"hello world"` example above.

2. Adding to the method, so that the method takes into account partial matches. For example:
```csharp
WordReplacer("I am walking my cat to the cathedral", "cat", "dog");
```
Which would return the silly phrase `"I am walking my dog to the doghedral."`

### Setup Instructions

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called `FindAndReplace`.
3. In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
4. Optionally, you can run `dotnet build` to compile this console app without running it.