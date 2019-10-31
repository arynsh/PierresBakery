Specifications

1. The program does nothing to non-alphabetical characters, since they do not contain consonants or vowels.
  Example input: 3
  Example output: 3
2. The program adds "ay" to single-letter words beginning with a vowel.
  Example input: i
  Example output: iay
3. For words beginning with a vowel, the program will add "way" to the end.
   Example input: excited
   Example output: excitedway
4. For words beginning with one or more consonants, the program moves the all first consecutive consonants to the end,
  and adds "ay".
  Example input: three
  Example output: eethray
5. For words beginning with a "y", the program will treat "y" as a consonant.
   Example input: you
   Example output: ouyay
6. For words beginning with "qu", the program will move "qu" to the end and add "ay".
   Example input: question
   Example output: estionquay
7. For words beginning with a consonant and "qu" appears as the second and third character, the program will move the first
   characters to the end, and add "ay".
   Example input: squeal
   Example output: ealsquay
