# Word Counter App

##### By Andrew Niekamp

## Description

_Allows the user to determine word count from a pair of inputs (input 1 is a single word, input 2 is a sentence to be searched for the frequency of occurrences of input 1)._

## Setup/Installation

_Files can be cloned from https://github.com/aniekamp/word-count.git and run in a browser (requires a server environment)._

_Using Mono in the root directory, type the following at the command prompt:

_To install dependencies:_

\>dnu restore

_To run the local server:_

\>dnx kestrel

_Navigate to http://localhost:5004 in your browser._

## Specifications
| Behavior | Input Example 1 | Input Example 2 |  Output Example  | Simplicity Justification |
| -------- |:---------------:|:---------------:|:----------------:|:------------------------ |
| Detect occurrence of single letter and identical 2nd input | 'a' | 'a' | Frequency: 1 | Smallest available comparison/test of matching behavior - no need to split or loop |
| Detect occurrence of single letter in multiple 2nd input | 'a' | 'a b' | Frequency: 1 | Smallest step once matching 1 for 1 letter/word is to compare 1 to 2+ letters - able to match without need to split string into array of words - now beneficial to use a loop |
| Detect increase frequency of occurrences | 'a' | 'a b a' | Frequency: 2 | Smallest incremental step - ensures loop captures all occurrences of letter |
| Detect occurrence of single word and identical 2nd input | 'and' | 'and' | Frequency: 1 | After single letter is functioning - next step is to compare for multi-letter word - Smallest available comparison/test of matching behavior for word - no need to split or loop |
| Detect occurrence of word with multiple 2nd input | 'and' | 'cat and dog' | Frequency: 1 | Smallest step once matching 1 for 1 letter/word and 1 to 2+ letters is to compare 1 to 2+ words - now beneficial to split into array and loop over each word |
| Detect occurrence of word with multiple 2nd input | 'and' | 'cat and dog and fish' | Frequency: 2 | Smallest incremental step - ensures loop captures all occurrences of word in similar pattern to single letter spec above |
| Detect occurrence of word with case differences | 'hello' | 'Hello there, I say!' | Frequency: 1 | Ensures method catches case difference but doesn't necessarily address special characters or punctuation. |
| Detect occurrence even with punctuation | 'hello' | 'Hello. I say, hello!' | Frequency: 2 | Logical next step -ensures method catches a match when typical punctuation is used, but doesn't necessarily account for other unforeseen special characters. |


## Known Bugs

_None known._

## Technologies Used

_C#, Razor, Nancy, HTML_

### License

Copyright (c) 2016 Andrew Niekamp

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
