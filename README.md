# C# quiz
The quiz app and game that is being used for my internals, AS91883 and AS91884.


# Develop a Computer Program using Iterative Processes
[AS91883 - Develop a computer program](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91883.pdf)
[AS91884 - Use basic iterative processes to develop a digital outcome](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91884.pdf)

## Purpose of the program
The purpose of the program is to **train our St John youth team** for regional comps by having a fun and competitive game (tic tac toe) that requires them to correctly answer questions before they can make a move in the game.

## Describing Relevant Implications (A)


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

## Evidence of addressing relevant implications (M)
