﻿namespace Tests
{
  using NUnit.Framework;


  [TestFixture]
  public class FSharpLexerTest : FSharpLexerTestBase
  {
    [Test, TestCaseSource("files")]
    public void TestLexer(string file)
    {
      DoTestFile(file);
    }

    // ReSharper disable StringLiteralTypo
    private readonly string[] files = new[]
    {
      "let-arith-1",
      "let-array-1",
      "let-array-2",
      "let-list-1",
      "let-list-2",
      "let-list-3",
      "let-list-4",
      "let-list-5",
      "let-list-6",
      "let-list-7",
      "let-list-8",
      "let-list-9",
      "let-mutable",
      "let-tuple-1",
      "let-tuple-2",
      "let-tuple-3",
      "let-tuple-4",
      "module-decl-1",
      "module-decl-2",
      "namespace-decl-1",
      "namespace-decl-2",
      "open-directive-1",
      "open-directive-2",
      "open-directive-3",
      "raise",
      "test1",
      "union-type-1",
      "union-type-2-generic-recursive",
      "union-type-3-generic-recursive",
      "active-patterns-multi-case", 
      "active-patterns-one-case", 
      "active-patterns-parameterized", 
      "active-patterns-partial", 
      "identifier-double-backstick-1", 
      "identifier-double-backstick-2", 
      "identifier-double-backstick-3", 
      "verbatim-string-escape-double-quote", 
      "verbatim-string-escape", 
      "verbatim-string-simple", 
    };
    // ReSharper restore StringLiteralTypo
  }
}