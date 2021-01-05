# Checker
 Checks on Input (c#)
 
# How to use
 (for VisualStudio)
 1. Goto Depenencies -> add reference 
 2. Then add InputChecker.dll
 (Visual Studio)
 1. 参照 -> 追加
 2. クローンしたフォルダ内にあるDebugフォルダからInputChecker.dllを追加
 
 # Classes and Methods
 
 ### Class LoopNumChecker
 Loops strings s message till user inputs correctly
 Returns converted input
 * CheckIfSByte(string s)
 * CheckIfShort(string s)
 * CheskIfUShort(string s)
 * CheckIfByte(string s)
 * CheckIfInt(string s)
 * CheckIfUInt(string s)
 * CheckIfLong(string s)
 * CheckIfULong(string s)
 * CheckIfFloat(string s)
 * CheckIfDouble(string s)
 * CheckIfDecimal(string s)
 
 ### Class LoopStrChecker
 Loops strings s message while there are no input
 Returns input
 * CheckforString(string s)
 * CheckforChar(string s)
 
 ### Class NumChecker
 Returns bool
 * evenChecker(int inputNum)
 * evenChecker(double inputNum)
 * numRangeChecker<T>(T item, T minRange, T maxRange) where T : IComparable
 
 ### Class StringChecker
 Returns bool
 * startsWithChar(string InputStr, char start)
 * contains(string InputStr, string str)
 * strLengthChecker(string inputStr, int minLength = 0, int maxLength = 30)
 
#### Test Result

```console
LoopNumChecker
Int: hello
Int: 9
Integer is : 9
Double: hi
Double: 8.9
double num is : 8.9

LoopStrChecker
String: hello
String is : hello
Char: hello
h
e
l
l
o

NumChecker
10 is in range between 0 and 20: True
10 is in range between 0 and 9: False
10 is even: True
9.0 is even: False

StringChecker
"Hello"'s length is in between 0 and 5: True
"Hello World"'s length is in between 2 and 5: False
"hi"'s length is in between 3 and 5: False
"Cat" starts with char c: True
"Dog" starts with char c: False
"Hello world hahaha" contains dhaha: False
"Hello world hahaha" contains cat: False
```
