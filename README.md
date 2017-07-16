![icon](Artwork/RegexToolbox-icon-100.png)

# Regex Toolbox

[![NuGet Version and Downloads count](https://buildstats.info/nuget/RegexToolbox)](https://www.nuget.org/packages/RegexToolbox/)

Regular expression tools for C# developers.


## RegexBuilder

Class to build regular expressions in a more human-readable way using a fluent API.

To use, chain method calls representing the elements you want to match, and finish with
`.BuildRegex()` to build the [`Regex`](https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx).

##### Example

```c#
Regex regex = new RegexBuilder()
                  .Text("cat")
                  .Digit(RegexQuantifier.ZeroOrMore)
                  .EndOfString()
              .BuildRegex(RegexOptions.IgnoreCase);
```

Now you can be a [hero](https://xkcd.com/208/) without even knowing regular expressions.
