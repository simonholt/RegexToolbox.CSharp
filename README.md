# RegexToolbox

Regular expression tools for C# developers.

## RegexBuilder

Class to build regular expressions in a more human-readable way using a fluent API.

To use, chain method calls representing the elements you want to match, and finish with
`.BuildRegex()` to build the [`Regex`](https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx).

##### Example

```c#
Regex regex = new RexexBuilder()
                  .Text("cat")
                  .Digit(RegexQuantifier.ZeroOrMore)
                  .EndOfString()
              .BuildRegex(RegexOptions.IgnoreCase);
```

Now you can be a hero without even knowing regular expressions.

[![Everybody stand back.](https://imgs.xkcd.com/comics/regular_expressions.png)](https://xkcd.com/208/)
