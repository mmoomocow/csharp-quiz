# C# quiz
The quiz app and game that is being used for my internals, AS91883 and AS91884.


# Develop a Computer Program using Iterative Processes
[AS91883 - Develop a computer program](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91883.pdf)
[AS91884 - Use basic iterative processes to develop a digital outcome](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91884.pdf)

## Purpose of the program
The purpose of the program is to **train our St John youth team** for regional comps by having a fun and competitive game (tic tac toe) that requires them to correctly answer questions before they can make a move in the game.

## Target audience
My target audience is my St John youth team, a group of 13 - 17 year olds who have an understanding of basic first aid, and are learning more complex first aid.

## Describing Relevant Implications (A)

### Social
**The social implications of my program include:**
* Ensuring the final quiz is suitable to the target audience
* Ensuring the final quiz is what the client wants

**I will do this by:**
* Using language that can be understood by my target audience
* Making the questions are relevant to our training
* Fulfilling the purpose of the program

**To ensure I am doing this I will**
* Refer to the purpose of the program whenever adding new features, to ensure it fits with the purpose
* Taking to the other members of my team to ensure the understand the questions

### Usability
**The usability implications of my program include:**
* Ensuring the program is intuitive and easy to use
* Not making it to simple or complex for my target audience
* Using a readable font in my GUI
* Following the usability heuristics

**I will do this by:**
* Designing a simple interface that is easy to use
* Not making an interface that is very simple/complex
* Using a readable font

**To ensure I am doing this I will**
* Test my program with my target audience and collecting feedback
* Ensuring text can be read
* Checking my program against the usability heuristics

### Functionality
**The functionality implications of my program include:**
* Making sure the program fulfills the purpose of the program
* Making sure all inputs work as expected
* Testing input fields to ensure they are client-proof
* Ensuring the program is what the client/target audience want

**I will do this by:**
* Fulfilling the purpose of the program
* Checking the functionality of inputs
* Implementing "sanity checks" in all inputs to ensure errors cannot be caused
* Making the program relevant to the purpose and target audience

**To ensure I am doing this I will**
* Refer to the purpose of the program whenever adding new features, to ensure it fits with the purpose
* Repeated and frequent testing of new and existing features to ensure their functionality
* Testing the inputs with unusual values to ensure the sanity checks are working
* Show the target audience the program and get their feedback on it's relevancy

### Sustainability and future proofing 


## List the components of your program (A)
* Quiz
    * Question struct
	* Ask questions
	* Check user input
	* track correct/incorrect questions
* Tic-Tac-Toe
	* game board
	* validate moves
	* place moves
	* detect winner
* Integration
	* Combine together
	* require correct answer before move
	* GUI
## Planning – show evidence of how you plan to create you program. (A)
* Quiz
    * [Question structure](https://www.w3schools.com/cs/cs_constructors.php)
	* Put questions into arrays
	* Ask questions using random item and Console.Writeline
	* Get and validate user input using Console.ReadLine
	* track correct/incorrect questions
* Tic-Tac-Toe
	* Game board saved as char array
		* '?' for not used
		* 'X' for player 1
		* 'O' for player 2
	* game board using 9 buttons on GUI
	* validate moves with function that checks array
	* place moves
	* detect winner
* Integration
	* Combine together
	* require correct answer before move
	* GUI

## Evidence of Trialing your components (A, M, E)

## Evidence of Testing your components/program (A, M, E)
[Tracking of issues is done on the github repo click here](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue)
## Evidence of addressing relevant implications (M)

