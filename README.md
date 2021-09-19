# C# quiz
The quiz app and game that is being used for my internals, AS91883 and AS91884.


# Develop a Computer Program using Iterative Processes
[AS91883 - Develop a computer program](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91883.pdf)
[AS91884 - Use basic iterative processes to develop a digital outcome](https://www.nzqa.govt.nz/nqfdocs/ncea-resource/achievements/2019/as91884.pdf)

## Purpose of the program
The purpose of the program is to **train our St John youth team** for regional comps by having a fun and competitive quiz. The competitive aspect of the quiz will incentivize them to do well, and learn more so they can do better

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
* Testing input fields to ensure they are client-proof
* Testing the inputs with unusual values to ensure the sanity checks are working
* Show the target audience the program and get their feedback on it's relevancy

### Sustainability and future proofing 
**The sustainability and future proofing implications of my program include:**
* Considering the file size of my program
* Considering the processing time and resource usage of the program
* Use up to date c#
* Code Comments
* Using common c# conventions

**I will do this by:**
* Reducing excess file usage
* Minimizing resources required for running the program
* Checking my code against the current microsoft c# documentation
* Adding code comments
* Using common and up-to-date c# conventions

**To ensure I am doing this I will**
* Use efficient code to reduce storage space and resources required
* Use github CodeQL to check all the code
* Check that there are code comments to explain the code

## List the components of your program (A)
- [x] Console Quiz
    - [X] Question struct
	- [X] Ask questions
	- [X] Check user input
	- [x] track correct/incorrect questions
- [ ] Quiz GUI
    - [ ] Question classes from console app
    - [ ] Form design
    - [ ] Getting user input
    - [ ] Swapping between players
## Planning – show evidence of how you plan to create you program. (A)
- [x] Console Quiz
    - [X] Question class
	- [X] Put questions into arrays
	- [X] Ask questions using random item and Console.Writeline
	- [X] Get and validate user input using Console.ReadLine
	- [x] track correct/incorrect questions
	- [X] Populate question arrays
- [ ] Quiz GUI
    - [ ] Transfer Question and Questions classes from console app
    - [ ] Design the form (4 main buttons, 2 main text areas)
    - [ ] Code for buttons, relating the button to what the current question is and if it's correct
    - [ ] Managing swapping between players (Player class??)
    - [ ] Mass testing

## Evidence of Trialing your components (A, M, E)

## Evidence of Testing your components/program (A, M, E)
[Tracking of issues is done on the github repo click here](https://github.com/mmoomocow/csharp-quiz/issues?q=is%3Aissue)
## Evidence of addressing relevant implications (M)

