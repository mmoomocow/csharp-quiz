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

### Usability

The usability implications of my program include

* Ensuring the program is intuitive and easy to use
* Not making it to simple or complex for my target audience
* Using a readable font in my GUI
* Following the usability heuristics

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

## List the components of your program (A)

* Console Quiz
  * Question struct
  * Ask questions
  * Check user input
  * track correct/incorrect questions

* Quiz GUI
  * Question classes from console app
  * Form design
  * Getting user input
  * Swapping between players
  * Asking questions
  * Handling answer
  * User Score

## Planning ??? show evidence of how you plan to create you program. (A)

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
  * [x] Mass testing

## Evidence of Trialing your components (A, M, E)

[Storage of questions - Class vs Lists](https://github.com/mmoomocow/csharp-quiz/issues/36)
[Struct vs class](https://github.com/mmoomocow/csharp-quiz/issues/9)
[alternative way to measure score](https://github.com/mmoomocow/csharp-quiz/issues/38)

## Evidence of Testing your components/program (A, M, E)

* [All issues that cause an error](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue+label%3A%22causes+error%22)
* [All issues that are labeled as bugs](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue+label%3Abug)
* [All issues](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue)

### User Feedback from testing

| Person  | Relevance              | Feedback on front-end                                                                  | Feedback on back-end                                                                                                                                                                                  | Version tested | Changes made as a result                                                                                                                                               |
| ------- | ---------------------- | -------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Josh    | Relevant age group     | Very good error prevention, disabling buttons helps to stop lots of issues             | More code comments could help, some of the information around the classes is a bit confusing                                                                                                          | GUI app        |
| Max     | Relevant age group     | Adding information about what answer is correct and why would be very helpful          | --                                                                                                                                                                                                    | Console App    | Add answer explanation variable to each question and tell the user the correct answer                                                                                  |
| Zoe     | Member of St John team | All the questions are helpful and relevant, more would be good                         | --                                                                                                                                                                                                    | Console App    | Additional questions are a future project, 21 is enough for testing and more would be added before a full release to                                                   |
| Cameron | Relevant age group     | The simple design makes it easy to use, the text buttons are hard to read at times     | --                                                                                                                                                                                                    | GUI app        | Make font size on buttons larger                                                                                                                                       |
| Tremain | Relevant age group     | The score text could be improved, "...1 question**s**..." is not grammatically correct | The use of classes for each player is very good, improves the scalability of the program and makes it more readable. The name should be updated from "Questions" to "Player" to make it more readable | GUI app        | Rename questions class to player for readability, the purpose of the class has changed over time to include scores etc so calling it the questions class was incorrect |

## Evidence of addressing relevant implications (M)

### Addressing Functionality

* Frequently testing my program
  1. Testing it myself
  2. Testing it with other people in my class
  3. Testing it with other members of the team
  4. Preventing errors by disabling buttons when they shouldn't be presses
* Designing a simple interface
  * The interface is simple and intuitive to use
  * All buttons are labeled to make them easier to use
  * A GUI application was chosen because it is easier to use than a console app
* Using a font that is readable

#### Error Prevention

* <https://github.com/mmoomocow/csharp-quiz/commit/5a23976c564e0fb2e3acda3da1aec63243c05458>
* <https://github.com/mmoomocow/csharp-quiz/issues/1>
* <https://github.com/mmoomocow/csharp-quiz/commit/5bbd237791e0a6a81c67edd6e18fb934d60a956d>
* <https://github.com/mmoomocow/csharp-quiz/issues/33>

### Addressing Sustainability and future proofing

* Repeatedly testing the program to make sure all features work as intended
* Testing areas where the user can make inputs to ensure they are robust
* Implementing all the features of the program so it can be used fully
* Checking user inputs are valid before attempting to use them
* Using classes to allow for scalability

#### Code Comments

* <https://github.com/mmoomocow/csharp-quiz/pull/12/commits/6318ac1fd46986daa77bc5551e36163036145f14>
* <https://github.com/mmoomocow/csharp-quiz/commit/b15dde324d6f2e0425e82456e79c2984f9099800>

### Addressing Usability

* All features function as intended
* The user can play the quiz without causing errors
* The program fits the purpose of the program

### Addressing Social

* Using language that is simple and appropriate, [Example here](https://github.com/mmoomocow/csharp-quiz/commit/7ec36bb8d1ad7cfcb5634f41c338924c52e6336a)
* Creating questions that are relevant to the purpose of the training
  * There are 3 question types, First aid, patient vital signs and St John history. The first aid and vital signs are relevant for our first aid tests, and the St John history questions are relevant to the written test
* Following the purpose of the program
