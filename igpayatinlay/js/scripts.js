
$(document).ready(function() {
  $("form#piglatin").submit(function(event) {
    event.preventDefault();

    var inputWord = $("input#input1").val();
    var wordString = inputWord.split("");
    var vowelList = ["a", "e", "i", "o", "u"];
    console.log("This is the input word:" + inputWord);
    //
    var firstLetter = $("input#input1").val().charAt(0);
    var toAppend = []; // array of consonants
    var numberToStart = toAppend.length;     // this is the number to start the slice
    var startingWithVowel = inputWord.slice(numberToStart); // will contain inputWord minus beginning consecutive consonants
    var appendedWord = startingWithVowel.append(toAppend);  // will add consecutive consonants to end of word!
    var output = appendedWord.append("ay");
    var result = [];
    console.log("This is the first letter of the word:" + firstLetter);

    if (vowelList.includes(firstLetter) && wordString.length === 0) { // meaning word is single letter vowel (ie. i)
      result.append(inputWord.concat("way"));     // iway
    } else if (vowelList.includes(firstLetter)) { // eg. egg
      result.append(inputWord.concat("ay"));       // eggay
    }

    for(i = 0; i < inputWord.length(); i++) {

      var currentChar = inputWord[i]         // to-do: set currentCharacter as the character at index

      if (vowelList.includes(currentChar)) { //apple
        break;          // does nothing; words beginning w/vowel have been taken care of in branching above
      } else {
        toAppend.append(currentChar); // adds consonants to an array eg. tree --> tr moves to toAppend
      } // to do: tell loop to break when it hits a vowel following consonants
    }

    $(".output1").text(output);
    $(".output2").text(result);
    $("#results").show();
  });
});







//       if (currentCharacter is "u") {
//         if (previous character is "q") {
//           console.log("qu case");
//         } else {
//           break;
//         }
//       } else if (vowelList.includes(inputWord[i])) {
//         console.log("Character is a vowel");
//
//       } else {
//         console.log("Character is a consonant");
//       }
//     }
//
//     // drop the first characters from the input word e.g. "atypus"
//
//     // add the identified consonants to the previous result e.g. "atypus" + "pl"
// }
