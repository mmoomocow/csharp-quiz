# Develop a Computer Program using Iterative Processes

[AS91883 - Develop a computer program](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91883.pdf)

[AS91884 - Use basic iterative processes to develop a digital outcome](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91884.pdf)

## Purpose of the program

The purpose of the program is to **train our St John youth team** for regional comps by having a fun and competitive quiz. The competitive aspect of the quiz will incentivize them to do well, and learn more so they can do better

## Target audience

My target audience is my St John youth team, a group of 13 - 17 year olds who have an understanding of basic first aid, and are learning more complex first aid.

## Describing Relevant Implications (A)

### Social

The social implications of my program include:

* Ensuring the final quiz is suitable to the target audience
* Ensuring the final quiz is what the client wants

I will do this by:

* Using language that can be understood by my target audience
* Making the questions are relevant to our training
* Fulfilling the purpose of the program

I have done this by:

* Using language that is simple and appropriate, [Example here](https://github.com/mmoomocow/csharp-quiz/commit/7ec36bb8d1ad7cfcb5634f41c338924c52e6336a)
* Creating questions that are relevant to the purpose of the training
  * There are 3 question types, First aid, patient vital signs and St John history. The first aid and vital signs are relevant for our first aid tests, and the St John history questions are relevant to the written test
* Following the purpose of the program 

### Usability

The usability implications of my program include

* Ensuring the program is intuitive and easy to use
* Not making it to simple or complex for my target audience
* Using a readable font in my GUI
* Following the usability heuristics

I will do this by

* Designing a simple interface that is easy to use
* Not making an interface that is very simple/complex
* Using a readable font

I have done this by:

* Frequently testing my program
  1. Testing it myself using edge cases
  2. Testing it with other people in my class
  3. Testing it with other members of the team
* Designing a simple interface
  * The interface is simple to use and provides instructions on how to use it.
  * All buttons are labled to make them easier to use
  * A GUI application was chosen because it is easier to use than a console app
* Using a font that is readable 

### Functionality

The functionality implications of my program include:

* Making sure the program fulfills the purpose of the program
* Making sure all inputs work as expected
* Testing input fields to ensure they are client-proof
* Ensuring the program is what the client/target audience want

I will do this by:

* Fulfilling the purpose of the program
* Checking the functionality of inputs
* Implementing "sanity checks" in all inputs to ensure errors cannot be caused
* Making the program relevant to the purpose and target audience

I have done this by:

* Repeatedly testing the program to make sure all features work as intended
* Testing areas where the user can make inputs to ensure they are robust
* Implementing all the features of the program so it can be used fully
* Checking user inputs are valid before attempting to use them

### Sustainability and future proofing

The sustainability and future proofing implications of my program include:

* Considering the file size of my program
* Considering the processing time and resource usage of the program
* Use up to date c#
* Code Comments
* Using common c# conventions

I will do this by:

* Reducing excess file usage
* Minimizing resources required for running the program
* Checking my code against the current microsoft c# documentation
* Adding code comments
* Using common and up-to-date c# conventions

I have done this by:

* Using minimal resources to run the program
* Keeping my code understandable and readable
  * Using code comments
  * Correct indentation
  * Usable variable names
* 

## List the components of your program (A)

* Console Quiz
  * Question struct
  * Ask questions
  * Check user input
  * track correct/incorrect questions

* Quiz GUI
  * [x] Question classes from console app
  * Form design
  * Getting user input
  * Swapping between players
  * Asking questions
  * Handling answer
  * User Score

## Planning – show evidence of how you plan to create you program. (A)

* [x] Console Quiz
  * [X] Question class
  * [X] Put questions into arrays
  * [X] Ask questions using random item and Console.Writeline
  * [X] Get and validate user input using Console.ReadLine
  * [x] track correct/incorrect questions
  * [X] Populate question arrays

* [ ] Quiz GUI
  * [x] Transfer Question and Questions classes from console app
  * [x] Design the form (4 main buttons, 2 main text areas)
  * [x] Code for buttons, relating the button to what the current question is and if it's correct
  * [ ] Managing swapping between players (Player class??)
  * [ ] Mass testing

## Evidence of Trialing your components (A, M, E)
* [All issues that cause an error](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue+label%3A%22causes+error%22)
* [All issues that are labeled as bugs](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue+label%3Abug)
* [All issues](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue)

## Evidence of Testing your components/program (A, M, E)

* [All issues that cause an error](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue+label%3A%22causes+error%22)
* [All issues that are labeled as bugs](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue+label%3Abug)
* [All issues](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue)

## Evidence of addressing relevant implications (M)
[Sustainability and future proofing - Adding code comments](https://github.com/mmoomocow/csharp-quiz/issues/8)
[Error prevention](https://github.com/mmoomocow/csharp-quiz/issues/1)

### Testing to diagnose and fix issues
[Testing question asking and realising answers are incorrect](https://github.com/mmoomocow/csharp-quiz/issues/18)
